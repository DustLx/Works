namespace SpaceflightCtrlCW
{
    partial class SpacecraftsForm
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
            this.AllSpacecraftsButton = new System.Windows.Forms.Button();
            this.spacecraftsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spacecraftsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(653, 89);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(135, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AllSpacecraftsButton
            // 
            this.AllSpacecraftsButton.Location = new System.Drawing.Point(559, 12);
            this.AllSpacecraftsButton.Name = "AllSpacecraftsButton";
            this.AllSpacecraftsButton.Size = new System.Drawing.Size(229, 23);
            this.AllSpacecraftsButton.TabIndex = 6;
            this.AllSpacecraftsButton.Text = "Все аппараты";
            this.AllSpacecraftsButton.UseVisualStyleBackColor = false;
            this.AllSpacecraftsButton.Click += new System.EventHandler(this.AllSpacecraftsButton_Click);
            // 
            // spacecraftsDataGridView
            // 
            this.spacecraftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spacecraftsDataGridView.Location = new System.Drawing.Point(12, 118);
            this.spacecraftsDataGridView.Name = "spacecraftsDataGridView";
            this.spacecraftsDataGridView.RowHeadersWidth = 51;
            this.spacecraftsDataGridView.RowTemplate.Height = 24;
            this.spacecraftsDataGridView.Size = new System.Drawing.Size(776, 320);
            this.spacecraftsDataGridView.TabIndex = 5;
            this.spacecraftsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spacecraftsDataGridView_CellDoubleClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(298, 70);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Найти, в каких миссиях используется космический аппарат";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(12, 69);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(280, 24);
            this.SearchComboBox.TabIndex = 10;
            // 
            // SpacecraftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AllSpacecraftsButton);
            this.Controls.Add(this.spacecraftsDataGridView);
            this.Name = "SpacecraftsForm";
            this.Text = "Космические аппараты";
            ((System.ComponentModel.ISupportInitialize)(this.spacecraftsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AllSpacecraftsButton;
        private System.Windows.Forms.DataGridView spacecraftsDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchComboBox;
    }
}