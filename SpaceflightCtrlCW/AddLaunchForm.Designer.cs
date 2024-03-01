namespace SpaceflightCtrlCW
{
    partial class AddLaunchForm
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
            this.MissionsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LaunchDirectorTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LaunchNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SpacecraftComboBox = new System.Windows.Forms.ComboBox();
            this.LaunchDateTextBox = new System.Windows.Forms.TextBox();
            this.LaunchDateLabel = new System.Windows.Forms.Label();
            this.LaunchSiteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MissionsComboBox
            // 
            this.MissionsComboBox.FormattingEnabled = true;
            this.MissionsComboBox.Location = new System.Drawing.Point(188, 40);
            this.MissionsComboBox.Name = "MissionsComboBox";
            this.MissionsComboBox.Size = new System.Drawing.Size(190, 24);
            this.MissionsComboBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Миссия*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Директор*";
            // 
            // LaunchDirectorTextBox
            // 
            this.LaunchDirectorTextBox.Location = new System.Drawing.Point(188, 100);
            this.LaunchDirectorTextBox.Name = "LaunchDirectorTextBox";
            this.LaunchDirectorTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchDirectorTextBox.TabIndex = 30;
            this.LaunchDirectorTextBox.Text = "Не указано";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(303, 188);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 188);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 23);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Добавить запуск";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Название запуска";
            // 
            // LaunchNameTextBox
            // 
            this.LaunchNameTextBox.Location = new System.Drawing.Point(188, 12);
            this.LaunchNameTextBox.Name = "LaunchNameTextBox";
            this.LaunchNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchNameTextBox.TabIndex = 24;
            this.LaunchNameTextBox.Text = "Новый запуск";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Аппарат*";
            // 
            // SpacecraftComboBox
            // 
            this.SpacecraftComboBox.FormattingEnabled = true;
            this.SpacecraftComboBox.Location = new System.Drawing.Point(188, 70);
            this.SpacecraftComboBox.Name = "SpacecraftComboBox";
            this.SpacecraftComboBox.Size = new System.Drawing.Size(190, 24);
            this.SpacecraftComboBox.TabIndex = 35;
            // 
            // LaunchDateTextBox
            // 
            this.LaunchDateTextBox.Location = new System.Drawing.Point(188, 128);
            this.LaunchDateTextBox.Name = "LaunchDateTextBox";
            this.LaunchDateTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchDateTextBox.TabIndex = 30;
            this.LaunchDateTextBox.Text = "Не указано";
            // 
            // LaunchDateLabel
            // 
            this.LaunchDateLabel.AutoSize = true;
            this.LaunchDateLabel.Location = new System.Drawing.Point(10, 131);
            this.LaunchDateLabel.Name = "LaunchDateLabel";
            this.LaunchDateLabel.Size = new System.Drawing.Size(44, 16);
            this.LaunchDateLabel.TabIndex = 32;
            this.LaunchDateLabel.Text = "Дата*";
            // 
            // LaunchSiteTextBox
            // 
            this.LaunchSiteTextBox.Location = new System.Drawing.Point(188, 156);
            this.LaunchSiteTextBox.Name = "LaunchSiteTextBox";
            this.LaunchSiteTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchSiteTextBox.TabIndex = 30;
            this.LaunchSiteTextBox.Text = "Не указано";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Место*";
            // 
            // AddLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 219);
            this.Controls.Add(this.SpacecraftComboBox);
            this.Controls.Add(this.MissionsComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LaunchDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LaunchSiteTextBox);
            this.Controls.Add(this.LaunchDateTextBox);
            this.Controls.Add(this.LaunchDirectorTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaunchNameTextBox);
            this.Name = "AddLaunchForm";
            this.Text = "Добавить запуск";
            this.Load += new System.EventHandler(this.AddLaunchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MissionsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LaunchDirectorTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LaunchNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SpacecraftComboBox;
        private System.Windows.Forms.TextBox LaunchDateTextBox;
        private System.Windows.Forms.Label LaunchDateLabel;
        private System.Windows.Forms.TextBox LaunchSiteTextBox;
        private System.Windows.Forms.Label label4;
    }
}