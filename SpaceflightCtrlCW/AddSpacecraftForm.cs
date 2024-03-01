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
    public partial class AddSpacecraftForm : Form {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader reader;
        public int currentID;

        public AddSpacecraftForm() {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();

            cmd.CommandText = "SELECT ISNULL(MAX(SpacecraftID), 0) + 1 FROM Spacecrafts;";
            currentID = (int)cmd.ExecuteScalar();
            SpacecraftNameTextBox.Text = "Аппарат " + currentID;
            // reader.Close();
        }

        private void AddParameters(SqlCommand cmd, string[,] parameters)
        {
            for (int i = 0; i < parameters.GetLength(0); i++)
                cmd.Parameters.AddWithValue(parameters[i, 0], parameters[i, 1]);
        }

        private void finish()
        {
            try
            {
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception) { this.DialogResult = DialogResult.None; }
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(SpacecraftNameTextBox.Text)   ||
                string.IsNullOrWhiteSpace(SpacecraftStatusTextBox.Text) ||
                string.IsNullOrWhiteSpace(CommunicationTextBox.Text)    ||
                string.IsNullOrWhiteSpace(CommunicationStatusTextBox.Text)) {
                MessageBox.Show(
                    "Ошибка: Не указаны все обязательные параметры. " +
                    "Убедитесь, что все обязательные параметры указаны, прежде чем добавлять запись. Пон?");
                return;
            }

            cmd.CommandText = @"INSERT INTO Spacecrafts 
                        (SpacecraftName, SpacecraftStatus, Payload, PayloadWeight, PayloadType, 
                        Communication, CommunicationStatus)
                        VALUES
                        (@SpacecraftName, @SpacecraftStatus, @Payload, @PayloadWeight, @PayloadType, 
                        @Communication, @CommunicationStatus);";

            string[,] parameters = new string[,] {
                { "@SpacecraftName", SpacecraftNameTextBox.Text },

                { "@SpacecraftStatus", SpacecraftStatusTextBox.Text },

                { "@Payload", PayloadTextBox.Text },
                { "@PayloadType", PayloadTypeTextBox.Text },

                { "@Communication", CommunicationTextBox.Text },
                { "@CommunicationStatus", CommunicationStatusTextBox.Text }
            };

            cmd.Parameters.AddWithValue("@PayloadWeight", float.Parse(PayloadWeightTextBox.Text));
            AddParameters(cmd, parameters);

            finish();
        }
    }
}
