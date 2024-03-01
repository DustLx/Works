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
    public partial class AddMissionForm : Form {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader reader;
        public int currentID;

        public AddMissionForm() {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();

            cmd.CommandText = "SELECT ISNULL(MAX(MissionID), 0) + 1 FROM Missions;";
            int currentID = (int)cmd.ExecuteScalar();
            MissionNameTextBox.Text = "Миссия " + currentID;

            // SpacecraftComboBox setup

            SpacecraftComboBox.Items.Add("Новый аппарат");

            List<string> spacecrafts = new List<string>();

            cmd.CommandText = "SELECT SpacecraftID, SpacecraftName FROM Spacecrafts";
            reader = cmd.ExecuteReader();

            if (reader.HasRows) {
                while (reader.Read()) {
                    string spacecraftID = reader["SpacecraftID"].ToString();
                    string spacecraftName = reader["SpacecraftName"].ToString();

                    spacecrafts.Add($"#{spacecraftID}: {spacecraftName}");
                }
                SpacecraftComboBox.Items.AddRange(spacecrafts.ToArray());
            }
            reader.Close();
        }

        private int? getComboBoxID(String text) {
            if (text != null) {
                string[] parts = text.Split(':');
                if (parts.Length >= 2)  {
                    string ID = parts[0].Substring(1);
                    return int.Parse(ID);
                }
                else return null;
            }
            else return null;
        }

        public void AddParameters(SqlCommand cmd, string[,] parameters) {
            for (int i = 0; i < parameters.GetLength(0); i++)
                cmd.Parameters.AddWithValue(parameters[i, 0], parameters[i, 1]);
        }

        private void finish() {
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(MissionNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SpacecraftComboBox.Text) ||
                string.IsNullOrWhiteSpace(DestinationTextBox.Text) ||
                string.IsNullOrWhiteSpace(MissionControlTextBox.Text) ||
                string.IsNullOrWhiteSpace(MissionDirectorTextBox.Text) ||
                string.IsNullOrWhiteSpace(TrackingStationTextBox.Text) ||
                string.IsNullOrWhiteSpace(GroundStationTextBox.Text) ||
                string.IsNullOrWhiteSpace(FlightControllerTextBox.Text)) {
                MessageBox.Show("Ошибка: Не указаны все обязательные параметры. " +
                    "Убедитесь, что все обязательные параметры указаны, прежде чем добавлять запись. Пон?");
                return;
            }

            if (SpacecraftComboBox.Text == null) {
                MessageBox.Show("Ошибка: Выбранный элемент SpacecraftComboBox равен null. (Ты как это сделал?)");
                return;
            }

            cmd.CommandText = @"INSERT INTO Missions 
                        (MissionName, SpacecraftID, Destination, MissionStatus, MissionControl, 
                        MissionDirector, MissionBudget, MissionExpenditure, MissionRevenue, MissionComments, 
                        Telemetry, TelemetryStatus, GroundStation, 
                        TrackingStation, FlightController) 
                        VALUES 
                        (@MissionName, @SpacecraftID, @Destination, @MissionStatus, @MissionControl, 
                        @MissionDirector, @MissionBudget, @MissionExpenditure, @MissionRevenue, @MissionComments, 
                        @Telemetry, @TelemetryStatus, @GroundStation, 
                        @TrackingStation, @FlightController)";

            string[,] parameters = new string[,] {
                { "@MissionName", MissionNameTextBox.Text },
                { "@Destination", DestinationTextBox.Text },

                { "@MissionControl", MissionControlTextBox.Text },
                { "@MissionDirector", MissionDirectorTextBox.Text },

                { "@MissionComments", MissionCommentsTextBox.Text },

                { "@Telemetry", TelemetryTextBox.Text },

                { "@GroundStation", GroundStationTextBox.Text },
                { "@TrackingStation", TrackingStationTextBox.Text },
                { "@FlightController", FlightControllerTextBox.Text },

                { "@MissionBudget", MissionBudgetTextBox.Text },
                { "@MissionExpenditure", MissionExpenditureTextBox.Text },
                { "@MissionRevenue", MissionRevenueTextBox.Text },

                { "@MissionStatus", "Подготовка" },
                { "@TelemetryStatus", "Не получена" }
            };

            AddParameters(cmd, parameters);

            if (SpacecraftComboBox.Text == "Новый аппарат") {
                AddSpacecraftForm addSpacecraftForm = new AddSpacecraftForm();
                addSpacecraftForm.ShowDialog();
                if (addSpacecraftForm.DialogResult == DialogResult.OK)
                    cmd.Parameters.AddWithValue("@SpacecraftID", addSpacecraftForm.currentID);
            }
            else cmd.Parameters.AddWithValue("@SpacecraftID", getComboBoxID(SpacecraftComboBox.Text).ToString());

            finish();
        }
    }
}
