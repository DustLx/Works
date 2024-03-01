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
    public partial class SpacecraftsForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader reader;

        private void PrintDataGridView(String cmdString)
        {
            spacecraftsDataGridView.DataSource = null;

            cmd.CommandText = cmdString;

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            spacecraftsDataGridView.DataSource = dt;
        }

        public SpacecraftsForm()
        {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();

            // SpacecraftComboBox setup

            List<string> spacecrafts = new List<string>();

            cmd.CommandText = "SELECT SpacecraftID, SpacecraftName FROM Spacecrafts";
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string spacecraftID = reader["SpacecraftID"].ToString();
                    string spacecraftName = reader["SpacecraftName"].ToString();

                    spacecrafts.Add($"#{spacecraftID}: {spacecraftName}");
                }
                SearchComboBox.Items.AddRange(spacecrafts.ToArray());
            }
            reader.Close();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            AddSpacecraftForm form = new AddSpacecraftForm();
            form.ShowDialog();
        }

        private void AllSpacecraftsButton_Click(object sender, EventArgs e) {
            cmd.CommandText = "SELECT * FROM Spacecrafts";

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            spacecraftsDataGridView.DataSource = dt;
        }

        private void spacecraftsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = spacecraftsDataGridView.Rows[e.RowIndex];
                String selectedID = row.Cells["SpacecraftID"].Value.ToString();

                EditSpacecraftForm editForm = new EditSpacecraftForm(Convert.ToInt32(selectedID));
                editForm.currentID = Convert.ToInt32(selectedID);
                editForm.ShowDialog();

                PrintDataGridView("SELECT * FROM Spacecrafts WHERE SpacecraftID = " + selectedID);
            }
        }

        private int? getComboBoxID(String text) {
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

        private void SearchButton_Click(object sender, EventArgs e) {
            PrintDataGridView("SELECT * FROM Missions WHERE SpacecraftID = " + getComboBoxID(SearchComboBox.Text));
        }
    }
}
