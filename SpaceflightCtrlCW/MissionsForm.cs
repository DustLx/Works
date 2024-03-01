using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace SpaceflightCtrlCW
{
    public partial class MissionsForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        private String calculateBudget() {
            cmd.CommandText = "SELECT SUM(MissionBudget) FROM Missions;";
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value) return result.ToString();
            else return "Нет данных.";
        }
        private void PrintDataGridView(String cmdString)
        {
            missionsDataGridView.DataSource = null;

            cmd.CommandText = cmdString;

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            missionsDataGridView.DataSource = dt;
        }

        public MissionsForm()
        {
            cnn.ConnectionString = "Data Source=(local); Initial Catalog=SpaceflightCtrlCW; Integrated Security=True";
            cmd.Connection = cnn;
            InitializeComponent();
            cnn.Open();

            MissionsBudgetSummaryText.Text = calculateBudget();
        }

        private void Missions_Load(object sender, EventArgs e)
        {

        }

        private void AllMissionsButton_Click(object sender, EventArgs e) {
            PrintDataGridView("SELECT * FROM Missions ORDER BY " +
                "CASE WHEN " +
                "MissionStatus = 'активна' THEN 0 " +
                "ELSE 1 " +
                "END, MissionStatus;");
        }

        private void AddButton_Click(object sender, EventArgs e) {
            AddMissionForm form = new AddMissionForm();

            if (form.ShowDialog() == DialogResult.OK) {
                
            }
        }

        private void activeMissionsButton_Click(object sender, EventArgs e) {
            PrintDataGridView("SELECT * FROM Missions WHERE MissionStatus = 'активен';");
        }

        private void missionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = missionsDataGridView.Rows[e.RowIndex];
                String selectedMissionID = row.Cells["MissionID"].Value.ToString();
                MessageBox.Show("selectedMissionID:" + selectedMissionID);

                EditMissionForm editForm = new EditMissionForm(Convert.ToInt32(selectedMissionID));
                editForm.currentID = Convert.ToInt32(selectedMissionID);
                editForm.ShowDialog();

                PrintDataGridView("SELECT * FROM Missions WHERE MissionID = " + selectedMissionID);
                PrintDataGridView(
                    "SELECT *, S.SpacecraftID, S.SpacecraftName" +
                    "FROM Missions AS M" +
                    "JOIN(" +
                        "SELECT SpacecraftID, SpacecraftName" +
                        "FROM Spacecrafts" +
                    ") AS S " +
                    "ON M.SpacecraftID = S.SpacecraftID" +
                    "WHERE MissionID = " + 
                    selectedMissionID);
            }
        }
    }
}
