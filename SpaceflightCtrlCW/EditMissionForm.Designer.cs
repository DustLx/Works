namespace SpaceflightCtrlCW
{
    partial class EditMissionForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackingStationTextBox = new System.Windows.Forms.TextBox();
            this.TelemetryTextBox = new System.Windows.Forms.TextBox();
            this.MissionRevenueTextBox = new System.Windows.Forms.TextBox();
            this.FlightControllerTextBox = new System.Windows.Forms.TextBox();
            this.GroundStationTextBox = new System.Windows.Forms.TextBox();
            this.MissionDirectorTextBox = new System.Windows.Forms.TextBox();
            this.MissionCommentsTextBox = new System.Windows.Forms.TextBox();
            this.MissionControlTextBox = new System.Windows.Forms.TextBox();
            this.MissionExpenditureTextBox = new System.Windows.Forms.TextBox();
            this.MissionBudgetTextBox = new System.Windows.Forms.TextBox();
            this.SpacecraftComboBox = new System.Windows.Forms.ComboBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.MissionNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(691, 292);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 34;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(285, 292);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(211, 23);
            this.EditButton.TabIndex = 33;
            this.EditButton.Text = "Применить изменения";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Космический аппарат*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Контроллер полёта*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(405, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Земная станция связи*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Доход";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(405, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Станция слежения*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Телеметрия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Расходы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Бюджет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Директор*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Центр управления*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Комментарии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Место назначения*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название миссии*";
            // 
            // TrackingStationTextBox
            // 
            this.TrackingStationTextBox.Location = new System.Drawing.Point(576, 36);
            this.TrackingStationTextBox.Name = "TrackingStationTextBox";
            this.TrackingStationTextBox.Size = new System.Drawing.Size(190, 22);
            this.TrackingStationTextBox.TabIndex = 19;
            // 
            // TelemetryTextBox
            // 
            this.TelemetryTextBox.Location = new System.Drawing.Point(185, 192);
            this.TelemetryTextBox.Name = "TelemetryTextBox";
            this.TelemetryTextBox.Size = new System.Drawing.Size(190, 22);
            this.TelemetryTextBox.TabIndex = 18;
            // 
            // MissionRevenueTextBox
            // 
            this.MissionRevenueTextBox.Location = new System.Drawing.Point(576, 192);
            this.MissionRevenueTextBox.Name = "MissionRevenueTextBox";
            this.MissionRevenueTextBox.Size = new System.Drawing.Size(190, 22);
            this.MissionRevenueTextBox.TabIndex = 17;
            // 
            // FlightControllerTextBox
            // 
            this.FlightControllerTextBox.Location = new System.Drawing.Point(185, 130);
            this.FlightControllerTextBox.Name = "FlightControllerTextBox";
            this.FlightControllerTextBox.Size = new System.Drawing.Size(190, 22);
            this.FlightControllerTextBox.TabIndex = 16;
            // 
            // GroundStationTextBox
            // 
            this.GroundStationTextBox.Location = new System.Drawing.Point(576, 8);
            this.GroundStationTextBox.Name = "GroundStationTextBox";
            this.GroundStationTextBox.Size = new System.Drawing.Size(190, 22);
            this.GroundStationTextBox.TabIndex = 15;
            // 
            // MissionDirectorTextBox
            // 
            this.MissionDirectorTextBox.Location = new System.Drawing.Point(185, 99);
            this.MissionDirectorTextBox.Name = "MissionDirectorTextBox";
            this.MissionDirectorTextBox.Size = new System.Drawing.Size(190, 22);
            this.MissionDirectorTextBox.TabIndex = 14;
            // 
            // MissionCommentsTextBox
            // 
            this.MissionCommentsTextBox.Location = new System.Drawing.Point(185, 223);
            this.MissionCommentsTextBox.Multiline = true;
            this.MissionCommentsTextBox.Name = "MissionCommentsTextBox";
            this.MissionCommentsTextBox.Size = new System.Drawing.Size(581, 63);
            this.MissionCommentsTextBox.TabIndex = 13;
            // 
            // MissionControlTextBox
            // 
            this.MissionControlTextBox.Location = new System.Drawing.Point(576, 66);
            this.MissionControlTextBox.Name = "MissionControlTextBox";
            this.MissionControlTextBox.Size = new System.Drawing.Size(190, 22);
            this.MissionControlTextBox.TabIndex = 12;
            // 
            // MissionExpenditureTextBox
            // 
            this.MissionExpenditureTextBox.Location = new System.Drawing.Point(576, 161);
            this.MissionExpenditureTextBox.Name = "MissionExpenditureTextBox";
            this.MissionExpenditureTextBox.Size = new System.Drawing.Size(190, 22);
            this.MissionExpenditureTextBox.TabIndex = 11;
            // 
            // MissionBudgetTextBox
            // 
            this.MissionBudgetTextBox.Location = new System.Drawing.Point(576, 130);
            this.MissionBudgetTextBox.Name = "MissionBudgetTextBox";
            this.MissionBudgetTextBox.Size = new System.Drawing.Size(190, 22);
            this.MissionBudgetTextBox.TabIndex = 8;
            // 
            // SpacecraftComboBox
            // 
            this.SpacecraftComboBox.FormattingEnabled = true;
            this.SpacecraftComboBox.Location = new System.Drawing.Point(185, 36);
            this.SpacecraftComboBox.Name = "SpacecraftComboBox";
            this.SpacecraftComboBox.Size = new System.Drawing.Size(190, 24);
            this.SpacecraftComboBox.TabIndex = 10;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(185, 68);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(190, 22);
            this.DestinationTextBox.TabIndex = 9;
            // 
            // MissionNameTextBox
            // 
            this.MissionNameTextBox.Location = new System.Drawing.Point(185, 8);
            this.MissionNameTextBox.Name = "MissionNameTextBox";
            this.MissionNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.MissionNameTextBox.TabIndex = 7;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(7, 292);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(177, 23);
            this.DeleteButton.TabIndex = 35;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditMissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 323);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackingStationTextBox);
            this.Controls.Add(this.TelemetryTextBox);
            this.Controls.Add(this.MissionRevenueTextBox);
            this.Controls.Add(this.FlightControllerTextBox);
            this.Controls.Add(this.GroundStationTextBox);
            this.Controls.Add(this.MissionDirectorTextBox);
            this.Controls.Add(this.MissionCommentsTextBox);
            this.Controls.Add(this.MissionControlTextBox);
            this.Controls.Add(this.MissionExpenditureTextBox);
            this.Controls.Add(this.MissionBudgetTextBox);
            this.Controls.Add(this.SpacecraftComboBox);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.MissionNameTextBox);
            this.Name = "EditMissionForm";
            this.Text = "Редактировать миссию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrackingStationTextBox;
        private System.Windows.Forms.TextBox TelemetryTextBox;
        private System.Windows.Forms.TextBox MissionRevenueTextBox;
        private System.Windows.Forms.TextBox FlightControllerTextBox;
        private System.Windows.Forms.TextBox GroundStationTextBox;
        private System.Windows.Forms.TextBox MissionDirectorTextBox;
        private System.Windows.Forms.TextBox MissionCommentsTextBox;
        private System.Windows.Forms.TextBox MissionControlTextBox;
        private System.Windows.Forms.TextBox MissionExpenditureTextBox;
        private System.Windows.Forms.TextBox MissionBudgetTextBox;
        private System.Windows.Forms.ComboBox SpacecraftComboBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.TextBox MissionNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}