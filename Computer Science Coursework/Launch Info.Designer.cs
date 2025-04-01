namespace Computer_Science_Coursework
{
    partial class Launch_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launch_Info));
            reportGroupBox = new GroupBox();
            labelPotentialEnergy = new Label();
            labelKineticEnergy = new Label();
            finalVelocityLabel = new Label();
            trajectoryTypeLabel = new Label();
            missionStatusLabel = new Label();
            targetAltitudeLabel = new Label();
            achievedAltitudeLabel = new Label();
            mainMenuButton = new Button();
            informationButton = new Button();
            reportGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // reportGroupBox
            // 
            reportGroupBox.BackColor = Color.Bisque;
            reportGroupBox.Controls.Add(labelPotentialEnergy);
            reportGroupBox.Controls.Add(labelKineticEnergy);
            reportGroupBox.Controls.Add(finalVelocityLabel);
            reportGroupBox.Controls.Add(trajectoryTypeLabel);
            reportGroupBox.Controls.Add(missionStatusLabel);
            reportGroupBox.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportGroupBox.Location = new Point(12, 12);
            reportGroupBox.Name = "reportGroupBox";
            reportGroupBox.Size = new Size(588, 121);
            reportGroupBox.TabIndex = 1;
            reportGroupBox.TabStop = false;
            reportGroupBox.Text = "Launch Report";
            // 
            // labelPotentialEnergy
            // 
            labelPotentialEnergy.AutoSize = true;
            labelPotentialEnergy.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPotentialEnergy.Location = new Point(6, 95);
            labelPotentialEnergy.Name = "labelPotentialEnergy";
            labelPotentialEnergy.Size = new Size(135, 18);
            labelPotentialEnergy.TabIndex = 25;
            labelPotentialEnergy.Text = "Potential Energy:";
            // 
            // labelKineticEnergy
            // 
            labelKineticEnergy.AutoSize = true;
            labelKineticEnergy.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKineticEnergy.Location = new Point(6, 77);
            labelKineticEnergy.Name = "labelKineticEnergy";
            labelKineticEnergy.Size = new Size(119, 18);
            labelKineticEnergy.TabIndex = 24;
            labelKineticEnergy.Text = "Kinetic Energy:";
            // 
            // finalVelocityLabel
            // 
            finalVelocityLabel.AutoSize = true;
            finalVelocityLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalVelocityLabel.Location = new Point(6, 59);
            finalVelocityLabel.Name = "finalVelocityLabel";
            finalVelocityLabel.Size = new Size(110, 18);
            finalVelocityLabel.TabIndex = 2;
            finalVelocityLabel.Text = "Final Velocity:";
            // 
            // trajectoryTypeLabel
            // 
            trajectoryTypeLabel.AutoSize = true;
            trajectoryTypeLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trajectoryTypeLabel.Location = new Point(6, 23);
            trajectoryTypeLabel.Name = "trajectoryTypeLabel";
            trajectoryTypeLabel.Size = new Size(131, 18);
            trajectoryTypeLabel.TabIndex = 1;
            trajectoryTypeLabel.Text = "Trajectory Type:";
            // 
            // missionStatusLabel
            // 
            missionStatusLabel.AutoSize = true;
            missionStatusLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missionStatusLabel.Location = new Point(6, 41);
            missionStatusLabel.Name = "missionStatusLabel";
            missionStatusLabel.Size = new Size(122, 18);
            missionStatusLabel.TabIndex = 0;
            missionStatusLabel.Text = "Mission Status:";
            // 
            // targetAltitudeLabel
            // 
            targetAltitudeLabel.AutoSize = true;
            targetAltitudeLabel.BackColor = Color.White;
            targetAltitudeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            targetAltitudeLabel.ForeColor = Color.Black;
            targetAltitudeLabel.Location = new Point(630, 742);
            targetAltitudeLabel.Name = "targetAltitudeLabel";
            targetAltitudeLabel.Size = new Size(146, 18);
            targetAltitudeLabel.TabIndex = 2;
            targetAltitudeLabel.Text = "Target Altitude:";
            // 
            // achievedAltitudeLabel
            // 
            achievedAltitudeLabel.AutoSize = true;
            achievedAltitudeLabel.BackColor = Color.White;
            achievedAltitudeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            achievedAltitudeLabel.ForeColor = SystemColors.ActiveCaptionText;
            achievedAltitudeLabel.Location = new Point(77, 500);
            achievedAltitudeLabel.Name = "achievedAltitudeLabel";
            achievedAltitudeLabel.Size = new Size(165, 18);
            achievedAltitudeLabel.TabIndex = 3;
            achievedAltitudeLabel.Text = "Achieved Altitude:";
            // 
            // mainMenuButton
            // 
            mainMenuButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenuButton.Location = new Point(1842, 12);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(50, 50);
            mainMenuButton.TabIndex = 23;
            mainMenuButton.Text = "🏠";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // informationButton
            // 
            informationButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            informationButton.Location = new Point(1842, 68);
            informationButton.Name = "informationButton";
            informationButton.Size = new Size(50, 50);
            informationButton.TabIndex = 24;
            informationButton.Text = "ℹ️";
            informationButton.UseVisualStyleBackColor = true;
            informationButton.Click += informationButton_Click;
            // 
            // Launch_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(informationButton);
            Controls.Add(mainMenuButton);
            Controls.Add(achievedAltitudeLabel);
            Controls.Add(targetAltitudeLabel);
            Controls.Add(reportGroupBox);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1038);
            Name = "Launch_Info";
            Text = "Launch_Info";
            WindowState = FormWindowState.Maximized;
            Load += Launch_Info_Load;
            Paint += Launch_Info_Paint;
            reportGroupBox.ResumeLayout(false);
            reportGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox reportGroupBox;
        private Label missionStatusLabel;
        private Label trajectoryTypeLabel;
        private Label labelKineticEnergy;
        private Label targetAltitudeLabel;
        private Label achievedAltitudeLabel;
        private Button mainMenuButton;
        private Label finalVelocityLabel;
        private Label labelPotentialEnergy;
        private Button button1;
        private Button informationButton;
    }
}