using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceflightCtrlCW
{
    public partial class AddLaunchForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader reader;
        public int LaunchID;
        private int? OuterSpacecraftID = null;
        public int? SpacecraftID {
            get { return OuterSpacecraftID; }
            set { OuterSpacecraftID = value; }
        }

        public AddLaunchForm() {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();

            cmd.CommandText = "SELECT ISNULL(MAX(LaunchID), 0) + 1 FROM Launches;";
            LaunchID = (int)cmd.ExecuteScalar();
            LaunchNameTextBox.Text = "Запуск " + LaunchID;


            // MissionsComboBox setup

            MissionsComboBox.Items.Add("Новая миссия");

            List<string> missions = new List<string>();

            cmd.CommandText = "SELECT MissionID, MissionName FROM Missions";
            reader = cmd.ExecuteReader();

            if (reader.HasRows || reader != null) {
                while (reader.Read()) {
                    string MissionID = reader["MissionID"].ToString();
                    string MissionName = reader["MissionName"].ToString();

                    missions.Add($"#{MissionID}: {MissionName}");
                }

                MissionsComboBox.Items.AddRange(missions.ToArray());
            }
            reader.Close();


            // SpacecraftComboBox setup

            if (OuterSpacecraftID != null) SpacecraftComboBox.Items.Add(OuterSpacecraftID + " (Новый аппарат)");
            else {
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
                    reader.Close();
                }
                reader.Close();
                SpacecraftComboBox.Items.AddRange(spacecrafts.ToArray());
            }
        }

        private void AddLaunchForm_Load(object sender, EventArgs e) {

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

        private void AddParameters(SqlCommand cmd, string[,] parameters) {
            for (int i = 0; i < parameters.GetLength(0); i++)
                cmd.Parameters.AddWithValue(parameters[i, 0], parameters[i, 1]);
        }
        private void finish()
        {
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SpacecraftComboBox.Text) ||
                string.IsNullOrWhiteSpace(MissionsComboBox.Text) ||
                string.IsNullOrWhiteSpace(LaunchDateTextBox.Text) ||
                string.IsNullOrWhiteSpace(LaunchSiteTextBox.Text) ||
                string.IsNullOrWhiteSpace(LaunchDirectorTextBox.Text))
            {
                MessageBox.Show(
                    "Ошибка: Не указаны все обязательные параметры. " +
                    "Убедитесь, что все обязательные параметры указаны, прежде чем добавлять запись. Пон?");
                return;
            }

            if (!DateTime.TryParseExact(LaunchDateTextBox.Text, "yyyy-MM-dd", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime launchDate)) // Какие-то необходимые функции параметры с инета
            {
                MessageBox.Show("Некорректный формат даты. Используйте формат 'yyyy-MM-dd'.");
                return;
            }

            if (string.IsNullOrWhiteSpace(LaunchDateTextBox.Text))
            {
                MessageBox.Show(
                    "Ошибка: Не указаны все обязательные параметры. " +
                    "Убедитесь, что все обязательные параметры указаны, прежде чем добавлять запись. Пон?");
                return;
            }

            cmd.CommandText = @"INSERT INTO Launches (LaunchName, SpacecraftID, MissionID, LaunchDate, LaunchSite, LaunchDirector)
                                VALUES (@LaunchName, @SpacecraftID, @MissionID, @LaunchDate, @LaunchSite, @LaunchDirector);";

            string[,] parameters = new string[,] {
                { "@LaunchName", LaunchNameTextBox.Text },

                { "@LaunchDate", LaunchDateTextBox.Text },
                { "@LaunchSite", LaunchSiteTextBox.Text },
                { "@LaunchDirector", LaunchDirectorTextBox.Text },
            };

            AddParameters(cmd, parameters);

            // MissionID
            if (MissionsComboBox.Text == "Новая миссия") {
                AddMissionForm addMissionForm = new AddMissionForm();
                addMissionForm.ShowDialog();
                if (addMissionForm.DialogResult == DialogResult.OK)
                    cmd.Parameters.AddWithValue("@MissionID", addMissionForm.currentID);
            } else cmd.Parameters.AddWithValue("@MissionID", getComboBoxID(MissionsComboBox.Text));

            // SpacecraftID
            if (SpacecraftComboBox.Text == "Новый аппарат") {
                AddSpacecraftForm addSpacecraftForm = new AddSpacecraftForm();
                addSpacecraftForm.ShowDialog();
                if (addSpacecraftForm.DialogResult == DialogResult.OK)
                    cmd.Parameters.AddWithValue("@SpacecraftID", addSpacecraftForm.currentID);
            } 
            else if (OuterSpacecraftID != null) cmd.Parameters.AddWithValue("@SpacecraftID", OuterSpacecraftID);
            else cmd.Parameters.AddWithValue("@SpacecraftID", getComboBoxID(SpacecraftComboBox.Text));
            
            finish();
        }
    }
}
