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
    public partial class EditLaunchForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        public int currentID;

        public EditLaunchForm(int launchID)
        {
            InitializeComponent();
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            cnn.Open();

            currentID = launchID;
            LoadLaunchData();
        }

        private void LoadLaunchData()
        {
            cmd.CommandText = "SELECT * FROM Launches WHERE LaunchID = @LaunchID";
            cmd.Parameters.AddWithValue("@LaunchID", currentID);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                LaunchNameTextBox.Text = reader["LaunchName"].ToString();
                LaunchDateTextBox.Text = reader["LaunchDate"].ToString();
                LaunchSiteTextBox.Text = reader["LaunchSite"].ToString();
                LaunchDirectorTextBox.Text = reader["LaunchDirector"].ToString();
            }
            reader.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LaunchNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LaunchDirectorTextBox.Text))
            {
                MessageBox.Show("Ошибка: Не все обязательные поля заполнены.");
                return;
            }

            cmd.CommandText = @"UPDATE Launches 
                                SET LaunchName = @LaunchName,
                                    LaunchDate = @LaunchDate,
                                    LaunchSite = @LaunchSite,
                                    LaunchDirector = @LaunchDirector
                                WHERE LaunchID = @LaunchID";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@LaunchName", LaunchNameTextBox.Text);
            cmd.Parameters.AddWithValue("@LaunchDate", LaunchDateTextBox.Text);
            cmd.Parameters.AddWithValue("@LaunchSite", LaunchSiteTextBox.Text);
            cmd.Parameters.AddWithValue("@LaunchDirector", LaunchDirectorTextBox.Text);

            cmd.Parameters.AddWithValue("@LaunchID", currentID);

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
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот запуск?",
                "Удаление запуска", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM Launches WHERE LaunchID = @LaunchID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@LaunchID", currentID);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запуск удален успешно!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить запуск.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении запуска: {ex.Message}");
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
