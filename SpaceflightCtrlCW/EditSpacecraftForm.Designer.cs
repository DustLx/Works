namespace SpaceflightCtrlCW
{
    partial class EditSpacecraftForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.CommunicationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpacecraftStatusTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CommunicationStatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpacecraftNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PayloadTextBox = new System.Windows.Forms.TextBox();
            this.PayloadTypeTextBox = new System.Windows.Forms.TextBox();
            this.PayloadWeightTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Коммуникация";
            // 
            // CommunicationTextBox
            // 
            this.CommunicationTextBox.Location = new System.Drawing.Point(186, 67);
            this.CommunicationTextBox.Name = "CommunicationTextBox";
            this.CommunicationTextBox.Size = new System.Drawing.Size(190, 22);
            this.CommunicationTextBox.TabIndex = 29;
            this.CommunicationTextBox.Text = "Не указано";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Статус*";
            // 
            // SpacecraftStatusTextBox
            // 
            this.SpacecraftStatusTextBox.Location = new System.Drawing.Point(186, 35);
            this.SpacecraftStatusTextBox.Name = "SpacecraftStatusTextBox";
            this.SpacecraftStatusTextBox.Size = new System.Drawing.Size(190, 22);
            this.SpacecraftStatusTextBox.TabIndex = 30;
            this.SpacecraftStatusTextBox.Text = "Спроектирован";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(301, 261);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Статус коммуникации";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(8, 232);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(227, 23);
            this.EditButton.TabIndex = 27;
            this.EditButton.Text = "Редактировать аппарат";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CommunicationStatusTextBox
            // 
            this.CommunicationStatusTextBox.Location = new System.Drawing.Point(186, 98);
            this.CommunicationStatusTextBox.Name = "CommunicationStatusTextBox";
            this.CommunicationStatusTextBox.Size = new System.Drawing.Size(190, 22);
            this.CommunicationStatusTextBox.TabIndex = 23;
            this.CommunicationStatusTextBox.Text = "Неактивна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Название аппарата*";
            // 
            // SpacecraftNameTextBox
            // 
            this.SpacecraftNameTextBox.Location = new System.Drawing.Point(186, 5);
            this.SpacecraftNameTextBox.Name = "SpacecraftNameTextBox";
            this.SpacecraftNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.SpacecraftNameTextBox.TabIndex = 24;
            this.SpacecraftNameTextBox.Text = "Новый аппарат";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Тип нагрузки*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Масса нагрузки*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Полезная нагрузка*";
            // 
            // PayloadTextBox
            // 
            this.PayloadTextBox.Location = new System.Drawing.Point(186, 130);
            this.PayloadTextBox.Name = "PayloadTextBox";
            this.PayloadTextBox.Size = new System.Drawing.Size(190, 22);
            this.PayloadTextBox.TabIndex = 18;
            this.PayloadTextBox.Text = "Не указано";
            // 
            // PayloadTypeTextBox
            // 
            this.PayloadTypeTextBox.Location = new System.Drawing.Point(186, 188);
            this.PayloadTypeTextBox.Name = "PayloadTypeTextBox";
            this.PayloadTypeTextBox.Size = new System.Drawing.Size(190, 22);
            this.PayloadTypeTextBox.TabIndex = 19;
            this.PayloadTypeTextBox.Text = "0";
            // 
            // PayloadWeightTextBox
            // 
            this.PayloadWeightTextBox.Location = new System.Drawing.Point(186, 160);
            this.PayloadWeightTextBox.Name = "PayloadWeightTextBox";
            this.PayloadWeightTextBox.Size = new System.Drawing.Size(190, 22);
            this.PayloadWeightTextBox.TabIndex = 17;
            this.PayloadWeightTextBox.Text = "0";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(8, 261);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(227, 23);
            this.DeleteButton.TabIndex = 33;
            this.DeleteButton.Text = "Удалить аппарат";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditSpacecraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CommunicationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpacecraftStatusTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CommunicationStatusTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpacecraftNameTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PayloadTextBox);
            this.Controls.Add(this.PayloadTypeTextBox);
            this.Controls.Add(this.PayloadWeightTextBox);
            this.Name = "EditSpacecraftForm";
            this.Text = "Редактировать космический аппарат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CommunicationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpacecraftStatusTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox CommunicationStatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpacecraftNameTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PayloadTextBox;
        private System.Windows.Forms.TextBox PayloadTypeTextBox;
        private System.Windows.Forms.TextBox PayloadWeightTextBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}