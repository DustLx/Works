using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SpaceflightCtrlCW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MissionsButton_Click(object sender, EventArgs e)
        {
            MissionsForm form = new MissionsForm();
            form.ShowDialog();
        }

        private void LaunchesButton_Click(object sender, EventArgs e)
        {
            LaunchesForm form = new LaunchesForm();
            form.ShowDialog();
        }

        private void SpacecraftsButton_Click(object sender, EventArgs e)
        {
            SpacecraftsForm form = new SpacecraftsForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UselessQueries form = new UselessQueries();
            form.ShowDialog();
        }
    }
}
