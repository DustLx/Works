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
    public partial class LaunchesForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        private void PrintDataGridView(String cmdString)
        {
            launchesDataGridView.DataSource = null;

            cmd.CommandText = cmdString;

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            launchesDataGridView.DataSource = dt;
        }

        public LaunchesForm() {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            AddLaunchForm form = new AddLaunchForm();
            form.ShowDialog();
            PrintDataGridView("SELECT * FROM Launches");
        }

        private void AllLaunchesButton_Click(object sender, EventArgs e)
        {
            PrintDataGridView("SELECT * FROM Launches");
        }

        private void launchesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = launchesDataGridView.Rows[e.RowIndex];
                String selectedID = row.Cells["LaunchID"].Value.ToString();

                EditLaunchForm editForm = new EditLaunchForm(Convert.ToInt32(selectedID));
                editForm.currentID = Convert.ToInt32(selectedID);
                editForm.ShowDialog();

                PrintDataGridView("SELECT * FROM Launches WHERE LaunchID = " + selectedID);
            }
        }
    }
}
