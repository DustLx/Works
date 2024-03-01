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
    public partial class EditSpacecraftForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        public int currentID;

        public EditSpacecraftForm(int spacecraftID)
        {
            InitializeComponent();
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            cnn.Open();

            currentID = spacecraftID;
            LoadSpacecraftData();
        }

        private void LoadSpacecraftData()
        {
            cmd.CommandText = "SELECT * FROM Spacecrafts WHERE SpacecraftID = @SpacecraftID";
            cmd.Parameters.AddWithValue("@SpacecraftID", currentID);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                SpacecraftNameTextBox.Text      = reader["SpacecraftName"].ToString();
                SpacecraftStatusTextBox.Text    = reader["SpacecraftStatus"].ToString();
                PayloadTextBox.Text             = reader["Payload"].ToString();
                PayloadWeightTextBox.Text       = reader["PayloadWeight"].ToString();
                PayloadTypeTextBox.Text         = reader["PayloadType"].ToString();
                CommunicationTextBox.Text       = reader["Communication"].ToString();
                CommunicationStatusTextBox.Text = reader["CommunicationStatus"].ToString();
            }
            reader.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SpacecraftNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SpacecraftStatusTextBox.Text) ||
                string.IsNullOrWhiteSpace(CommunicationTextBox.Text) ||
                string.IsNullOrWhiteSpace(CommunicationStatusTextBox.Text))
            {
                MessageBox.Show("Ошибка: Не все обязательные поля заполнены.");
                return;
            }

            cmd.CommandText = @"UPDATE Spacecrafts 
                                SET SpacecraftName = @SpacecraftName,
                                    SpacecraftStatus = @SpacecraftStatus,
                                    Payload = @Payload,
                                    PayloadWeight = @PayloadWeight,
                                    PayloadType = @PayloadType,
                                    Communication = @Communication,
                                    CommunicationStatus = @CommunicationStatus
                                WHERE SpacecraftID = @SpacecraftID";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@SpacecraftName", SpacecraftNameTextBox.Text);
            cmd.Parameters.AddWithValue("@SpacecraftStatus", SpacecraftStatusTextBox.Text);
            cmd.Parameters.AddWithValue("@Payload", PayloadTextBox.Text);
            cmd.Parameters.AddWithValue("@PayloadWeight", float.Parse(PayloadWeightTextBox.Text));
            cmd.Parameters.AddWithValue("@PayloadType", PayloadTypeTextBox.Text);
            cmd.Parameters.AddWithValue("@Communication", CommunicationTextBox.Text);
            cmd.Parameters.AddWithValue("@CommunicationStatus", CommunicationStatusTextBox.Text);
            cmd.Parameters.AddWithValue("@SpacecraftID", currentID);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные обновлены успешно!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
            }
            finally
            {
                cnn.Close();
                this.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот аппарат?",
                "Удаление аппарата", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM Spacecrafts WHERE SpacecraftID = @SpacecraftID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@SpacecraftID", currentID);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Космический аппарат удален успешно!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить аппарат.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении аппарата: {ex.Message}");
                }
                finally
                {
                    cnn.Close();
                    this.Close();
                }
            }
        }
    }
}
