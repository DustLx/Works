namespace SpaceflightCtrlCW
{
    partial class MissionsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.missionsDataGridView = new System.Windows.Forms.DataGridView();
            this.AllMissionsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MissionsBudgetSummaryText = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.activeMissionsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // missionsDataGridView
            // 
            this.missionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missionsDataGridView.Location = new System.Drawing.Point(12, 121);
            this.missionsDataGridView.Name = "missionsDataGridView";
            this.missionsDataGridView.RowHeadersWidth = 51;
            this.missionsDataGridView.RowTemplate.Height = 24;
            this.missionsDataGridView.Size = new System.Drawing.Size(1158, 320);
            this.missionsDataGridView.TabIndex = 0;
            this.missionsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionsDataGridView_CellDoubleClick);
            // 
            // AllMissionsButton
            // 
            this.AllMissionsButton.Location = new System.Drawing.Point(974, 34);
            this.AllMissionsButton.Name = "AllMissionsButton";
            this.AllMissionsButton.Size = new System.Drawing.Size(196, 23);
            this.AllMissionsButton.TabIndex = 1;
            this.AllMissionsButton.Text = "Все миссии";
            this.AllMissionsButton.UseVisualStyleBackColor = false;
            this.AllMissionsButton.Click += new System.EventHandler(this.AllMissionsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Суммарный бюджет всех миссий:";
            // 
            // MissionsBudgetSummaryText
            // 
            this.MissionsBudgetSummaryText.AutoSize = true;
            this.MissionsBudgetSummaryText.Location = new System.Drawing.Point(252, 12);
            this.MissionsBudgetSummaryText.Name = "MissionsBudgetSummaryText";
            this.MissionsBudgetSummaryText.Size = new System.Drawing.Size(40, 16);
            this.MissionsBudgetSummaryText.TabIndex = 3;
            this.MissionsBudgetSummaryText.Text = "None";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1068, 92);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // activeMissionsButton
            // 
            this.activeMissionsButton.Location = new System.Drawing.Point(974, 5);
            this.activeMissionsButton.Name = "activeMissionsButton";
            this.activeMissionsButton.Size = new System.Drawing.Size(196, 23);
            this.activeMissionsButton.TabIndex = 5;
            this.activeMissionsButton.Text = "Все активные миссии";
            this.activeMissionsButton.UseVisualStyleBackColor = false;
            this.activeMissionsButton.Click += new System.EventHandler(this.activeMissionsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дважды щёлкните по записи для редактирования.";
            // 
            // MissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activeMissionsButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MissionsBudgetSummaryText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllMissionsButton);
            this.Controls.Add(this.missionsDataGridView);
            this.Name = "MissionsForm";
            this.Text = "Миссии";
            this.Load += new System.EventHandler(this.Missions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.missionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView missionsDataGridView;
        private System.Windows.Forms.Button AllMissionsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MissionsBudgetSummaryText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button activeMissionsButton;
        private System.Windows.Forms.Label label2;
    }
}

