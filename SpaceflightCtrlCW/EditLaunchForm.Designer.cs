namespace SpaceflightCtrlCW
{
    partial class EditLaunchForm
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
            this.SpacecraftComboBox = new System.Windows.Forms.ComboBox();
            this.MissionsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LaunchDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LaunchSiteTextBox = new System.Windows.Forms.TextBox();
            this.LaunchDateTextBox = new System.Windows.Forms.TextBox();
            this.LaunchDirectorTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LaunchNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpacecraftComboBox
            // 
            this.SpacecraftComboBox.FormattingEnabled = true;
            this.SpacecraftComboBox.Location = new System.Drawing.Point(187, 65);
            this.SpacecraftComboBox.Name = "SpacecraftComboBox";
            this.SpacecraftComboBox.Size = new System.Drawing.Size(190, 24);
            this.SpacecraftComboBox.TabIndex = 48;
            // 
            // MissionsComboBox
            // 
            this.MissionsComboBox.FormattingEnabled = true;
            this.MissionsComboBox.Location = new System.Drawing.Point(187, 35);
            this.MissionsComboBox.Name = "MissionsComboBox";
            this.MissionsComboBox.Size = new System.Drawing.Size(190, 24);
            this.MissionsComboBox.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Аппарат*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Миссия*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Место*";
            // 
            // LaunchDateLabel
            // 
            this.LaunchDateLabel.AutoSize = true;
            this.LaunchDateLabel.Location = new System.Drawing.Point(9, 126);
            this.LaunchDateLabel.Name = "LaunchDateLabel";
            this.LaunchDateLabel.Size = new System.Drawing.Size(44, 16);
            this.LaunchDateLabel.TabIndex = 44;
            this.LaunchDateLabel.Text = "Дата*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Директор*";
            // 
            // LaunchSiteTextBox
            // 
            this.LaunchSiteTextBox.Location = new System.Drawing.Point(187, 151);
            this.LaunchSiteTextBox.Name = "LaunchSiteTextBox";
            this.LaunchSiteTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchSiteTextBox.TabIndex = 40;
            this.LaunchSiteTextBox.Text = "Не указано";
            // 
            // LaunchDateTextBox
            // 
            this.LaunchDateTextBox.Location = new System.Drawing.Point(187, 123);
            this.LaunchDateTextBox.Name = "LaunchDateTextBox";
            this.LaunchDateTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchDateTextBox.TabIndex = 41;
            this.LaunchDateTextBox.Text = "Не указано";
            // 
            // LaunchDirectorTextBox
            // 
            this.LaunchDirectorTextBox.Location = new System.Drawing.Point(187, 95);
            this.LaunchDirectorTextBox.Name = "LaunchDirectorTextBox";
            this.LaunchDirectorTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchDirectorTextBox.TabIndex = 42;
            this.LaunchDirectorTextBox.Text = "Не указано";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(302, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 39;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(11, 183);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(219, 23);
            this.EditButton.TabIndex = 38;
            this.EditButton.Text = "Редактировать запуск";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Название запуска";
            // 
            // LaunchNameTextBox
            // 
            this.LaunchNameTextBox.Location = new System.Drawing.Point(187, 7);
            this.LaunchNameTextBox.Name = "LaunchNameTextBox";
            this.LaunchNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.LaunchNameTextBox.TabIndex = 36;
            this.LaunchNameTextBox.Text = "Новый запуск";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(11, 212);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(219, 23);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Удалить запуск";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 245);
            this.Controls.Add(this.DeleteButton);
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
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaunchNameTextBox);
            this.Name = "EditLaunchForm";
            this.Text = "Редактировать запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SpacecraftComboBox;
        private System.Windows.Forms.ComboBox MissionsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LaunchDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LaunchSiteTextBox;
        private System.Windows.Forms.TextBox LaunchDateTextBox;
        private System.Windows.Forms.TextBox LaunchDirectorTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LaunchNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}