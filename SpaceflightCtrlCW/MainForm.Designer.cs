namespace SpaceflightCtrlCW
{
    partial class MainForm
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
            this.MissionsButton = new System.Windows.Forms.Button();
            this.SpacecraftsButton = new System.Windows.Forms.Button();
            this.LaunchesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MissionsButton
            // 
            this.MissionsButton.Location = new System.Drawing.Point(96, 169);
            this.MissionsButton.Name = "MissionsButton";
            this.MissionsButton.Size = new System.Drawing.Size(150, 40);
            this.MissionsButton.TabIndex = 0;
            this.MissionsButton.Text = "Місії";
            this.MissionsButton.UseVisualStyleBackColor = true;
            this.MissionsButton.Click += new System.EventHandler(this.MissionsButton_Click);
            // 
            // SpacecraftsButton
            // 
            this.SpacecraftsButton.Location = new System.Drawing.Point(96, 215);
            this.SpacecraftsButton.Name = "SpacecraftsButton";
            this.SpacecraftsButton.Size = new System.Drawing.Size(306, 40);
            this.SpacecraftsButton.TabIndex = 0;
            this.SpacecraftsButton.Text = "Космічні апарати";
            this.SpacecraftsButton.UseVisualStyleBackColor = true;
            this.SpacecraftsButton.Click += new System.EventHandler(this.SpacecraftsButton_Click);
            // 
            // LaunchesButton
            // 
            this.LaunchesButton.Location = new System.Drawing.Point(252, 169);
            this.LaunchesButton.Name = "LaunchesButton";
            this.LaunchesButton.Size = new System.Drawing.Size(150, 40);
            this.LaunchesButton.TabIndex = 0;
            this.LaunchesButton.Text = "Запуски";
            this.LaunchesButton.UseVisualStyleBackColor = true;
            this.LaunchesButton.Click += new System.EventHandler(this.LaunchesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обділені запити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Центр керування польотами";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "*фронтендера не найняли, викручуємось як можемо";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(96, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тут могла б бути ваша красива картинка, але бюджету не вистачило";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LaunchesButton);
            this.Controls.Add(this.SpacecraftsButton);
            this.Controls.Add(this.MissionsButton);
            this.Name = "MainForm";
            this.Text = "Spaceflight Control CW";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MissionsButton;
        private System.Windows.Forms.Button SpacecraftsButton;
        private System.Windows.Forms.Button LaunchesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}