namespace SpaceflightCtrlCW
{
    partial class LaunchesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.AllLaunchesButton = new System.Windows.Forms.Button();
            this.launchesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.launchesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(653, 89);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(135, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AllLaunchesButton
            // 
            this.AllLaunchesButton.Location = new System.Drawing.Point(559, 12);
            this.AllLaunchesButton.Name = "AllLaunchesButton";
            this.AllLaunchesButton.Size = new System.Drawing.Size(229, 23);
            this.AllLaunchesButton.TabIndex = 9;
            this.AllLaunchesButton.Text = "Все запуски";
            this.AllLaunchesButton.UseVisualStyleBackColor = false;
            this.AllLaunchesButton.Click += new System.EventHandler(this.AllLaunchesButton_Click);
            // 
            // launchesDataGridView
            // 
            this.launchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.launchesDataGridView.Location = new System.Drawing.Point(12, 118);
            this.launchesDataGridView.Name = "launchesDataGridView";
            this.launchesDataGridView.RowHeadersWidth = 51;
            this.launchesDataGridView.RowTemplate.Height = 24;
            this.launchesDataGridView.Size = new System.Drawing.Size(776, 320);
            this.launchesDataGridView.TabIndex = 8;
            this.launchesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.launchesDataGridView_CellDoubleClick);
            // 
            // LaunchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AllLaunchesButton);
            this.Controls.Add(this.launchesDataGridView);
            this.Name = "LaunchesForm";
            this.Text = "Запуски";
            ((System.ComponentModel.ISupportInitialize)(this.launchesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AllLaunchesButton;
        private System.Windows.Forms.DataGridView launchesDataGridView;
    }
}