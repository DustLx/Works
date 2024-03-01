using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceflightCtrlCW
{
    public partial class EditMissionForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader reader;
        public int currentID = 0;

        private void LoadMissionData()
        {
            cmd.CommandText = "SELECT * FROM Missions WHERE MissionID = @MissionID";
            cmd.Parameters.AddWithValue("@MissionID", currentID);

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MissionNameTextBox.Text         = reader["MissionName"].ToString();

                SpacecraftComboBox.Text         = reader["SpacecraftID"].ToString();

                DestinationTextBox.Text         = reader["Destination"].ToString();
                MissionControlTextBox.Text      = reader["MissionControl"].ToString();
                MissionDirectorTextBox.Text     = reader["MissionDirector"].ToString();

                TelemetryTextBox.Text           = reader["Telemetry"].ToString();

                GroundStationTextBox.Text       = reader["GroundStation"].ToString();
                TrackingStationTextBox.Text     = reader["TrackingStation"].ToString();
                FlightControllerTextBox.Text    = reader["FlightController"].ToString();

                MissionBudgetTextBox.Text       = reader["MissionBudget"].ToString();
                MissionExpenditureTextBox.Text  = reader["MissionExpenditure"].ToString();
                MissionRevenueTextBox.Text      = reader["MissionRevenue"].ToString();

                MissionCommentsTextBox.Text     = reader["MissionComments"].ToString();
            }
            else MessageBox.Show("Произошла ошибка в отображении данных. Закройте форму.");
            reader.Close();
        }


        public EditMissionForm(int missionID) {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();

            currentID = missionID;

            // SpacecraftComboBox setup

            SpacecraftComboBox.Items.Add("Новый аппарат");

            List<string> spacecrafts = new List<string>();

            cmd.CommandText = "SELECT SpacecraftID, SpacecraftName FROM Spacecrafts WHERE SpacecraftID = " + currentID;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string spacecraftID = reader["SpacecraftID"].ToString();
                    string spacecraftName = reader["SpacecraftName"].ToString();

                    spacecrafts.Add($"#{spacecraftID}: {spacecraftName}");
                }
                SpacecraftComboBox.Items.AddRange(spacecrafts.ToArray());
            }
            reader.Close();

            LoadMissionData();
        }

        private int? getComboBoxID(String text)
        {
            if (text != null)
            {
                string[] parts = text.Split(':');
                if (parts.Length >= 2)
                {
                    string ID = parts[0].Substring(1);
                    return int.Parse(ID);
                }
                else return null;
            }
            else return null;
        }

        public void AddParameters(SqlCommand cmd, string[,] parameters)
        {
            for (int i = 0; i < parameters.GetLength(0); i++)
                cmd.Parameters.AddWithValue(parameters[i, 0], parameters[i, 1]);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MissionNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SpacecraftComboBox.Text) ||
                string.IsNullOrWhiteSpace(DestinationTextBox.Text) ||
                string.IsNullOrWhiteSpace(MissionControlTextBox.Text) ||
                string.IsNullOrWhiteSpace(MissionDirectorTextBox.Text) ||
                string.IsNullOrWhiteSpace(TrackingStationTextBox.Text) ||
                string.IsNullOrWhiteSpace(GroundStationTextBox.Text) ||
                string.IsNullOrWhiteSpace(FlightControllerTextBox.Text))
            {
                MessageBox.Show("Ошибка: Не указаны все обязательные параметры. " +
                    "Убедитесь, что все обязательные параметры указаны, прежде чем добавлять запись. Пон?");
                return;
            }

            if (getComboBoxID(SpacecraftComboBox.Text) == null)
            {
                MessageBox.Show("Ошибка: Выбранный элемент SpacecraftComboBox равен null. (Ты как это сделал?)");
                return;
            }

            cmd.CommandText = @"UPDATE Missions 
                    SET MissionName = @MissionName, 
                        SpacecraftID = @SpacecraftID,
                        Destination = @Destination
                    WHERE MissionID = @MissionID";

            string[,] parameters = new string[,] {
                { "@MissionName", MissionNameTextBox.Text },
                { "@Destination", DestinationTextBox.Text },
            };

            cmd.Parameters.AddWithValue("@MissionID", currentID);

            AddParameters(cmd, parameters);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DeleteButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись БЕЗ возможности восстановления?", 
                "Удаление записи", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                cmd.CommandText = "DELETE FROM Missions WHERE MissionID = @MissionID";
                if (cmd.ExecuteNonQuery() > 0) {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else MessageBox.Show("Не удалось удалить запись.");
            }
        }
    }
}
