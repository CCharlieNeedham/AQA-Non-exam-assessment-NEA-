namespace Computer_Science_Coursework
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            NewRocketButton = new Button();
            ViewMissionsButton = new Button();
            LoadRocketButton = new Button();
            missionPanel = new Panel();
            skipButton = new Button();
            rewardLabel = new Label();
            altitudeLabel = new Label();
            closeMissionWindow = new Button();
            MissionDescriptionLabel = new Label();
            missionTitleLabel = new Label();
            bankBalanceLabel = new Label();
            logoPanel = new Panel();
            spaceAgencyTextbox = new TextBox();
            missionPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewRocketButton
            // 
            NewRocketButton.Anchor = AnchorStyles.Bottom;
            NewRocketButton.BackColor = SystemColors.Control;
            NewRocketButton.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewRocketButton.Location = new Point(711, 907);
            NewRocketButton.Margin = new Padding(1);
            NewRocketButton.Name = "NewRocketButton";
            NewRocketButton.Size = new Size(500, 100);
            NewRocketButton.TabIndex = 0;
            NewRocketButton.Text = "New Rocket";
            NewRocketButton.UseVisualStyleBackColor = false;
            NewRocketButton.Click += NewRocketButton_Click;
            // 
            // ViewMissionsButton
            // 
            ViewMissionsButton.Anchor = AnchorStyles.Bottom;
            ViewMissionsButton.BackColor = SystemColors.Control;
            ViewMissionsButton.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewMissionsButton.Location = new Point(711, 753);
            ViewMissionsButton.Margin = new Padding(1);
            ViewMissionsButton.Name = "ViewMissionsButton";
            ViewMissionsButton.Size = new Size(500, 75);
            ViewMissionsButton.TabIndex = 2;
            ViewMissionsButton.Text = "View Missions";
            ViewMissionsButton.UseVisualStyleBackColor = false;
            ViewMissionsButton.Click += ViewMissionsButton_Click;
            // 
            // LoadRocketButton
            // 
            LoadRocketButton.Anchor = AnchorStyles.Bottom;
            LoadRocketButton.BackColor = SystemColors.Control;
            LoadRocketButton.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadRocketButton.Location = new Point(711, 830);
            LoadRocketButton.Margin = new Padding(1);
            LoadRocketButton.Name = "LoadRocketButton";
            LoadRocketButton.Size = new Size(500, 75);
            LoadRocketButton.TabIndex = 1;
            LoadRocketButton.Text = "Load Rocket";
            LoadRocketButton.UseVisualStyleBackColor = false;
            LoadRocketButton.Click += LoadRocketButton_Click;
            // 
            // missionPanel
            // 
            missionPanel.Anchor = AnchorStyles.Bottom;
            missionPanel.BackColor = Color.LightGray;
            missionPanel.Controls.Add(skipButton);
            missionPanel.Controls.Add(rewardLabel);
            missionPanel.Controls.Add(altitudeLabel);
            missionPanel.Controls.Add(closeMissionWindow);
            missionPanel.Controls.Add(MissionDescriptionLabel);
            missionPanel.Controls.Add(missionTitleLabel);
            missionPanel.Location = new Point(711, 605);
            missionPanel.Name = "missionPanel";
            missionPanel.Size = new Size(500, 129);
            missionPanel.TabIndex = 6;
            missionPanel.Visible = false;
            // 
            // skipButton
            // 
            skipButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skipButton.Location = new Point(433, 91);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(64, 35);
            skipButton.TabIndex = 5;
            skipButton.Text = "Skip";
            skipButton.UseVisualStyleBackColor = true;
            skipButton.Click += skipButton_Click;
            // 
            // rewardLabel
            // 
            rewardLabel.AutoSize = true;
            rewardLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rewardLabel.Location = new Point(20, 93);
            rewardLabel.Name = "rewardLabel";
            rewardLabel.Size = new Size(86, 14);
            rewardLabel.TabIndex = 4;
            rewardLabel.Text = "rewardLabel";
            // 
            // altitudeLabel
            // 
            altitudeLabel.AutoSize = true;
            altitudeLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            altitudeLabel.Location = new Point(20, 74);
            altitudeLabel.Name = "altitudeLabel";
            altitudeLabel.Size = new Size(89, 14);
            altitudeLabel.TabIndex = 3;
            altitudeLabel.Text = "altitudeLabel";
            // 
            // closeMissionWindow
            // 
            closeMissionWindow.Location = new Point(465, 3);
            closeMissionWindow.Name = "closeMissionWindow";
            closeMissionWindow.Size = new Size(32, 35);
            closeMissionWindow.TabIndex = 2;
            closeMissionWindow.Text = "X";
            closeMissionWindow.UseVisualStyleBackColor = true;
            closeMissionWindow.Click += closeMissionWindow_Click;
            // 
            // MissionDescriptionLabel
            // 
            MissionDescriptionLabel.AutoSize = true;
            MissionDescriptionLabel.Font = new Font("Verdana", 9F);
            MissionDescriptionLabel.Location = new Point(20, 52);
            MissionDescriptionLabel.Name = "MissionDescriptionLabel";
            MissionDescriptionLabel.Size = new Size(123, 14);
            MissionDescriptionLabel.TabIndex = 1;
            MissionDescriptionLabel.Text = "MissionDescription";
            // 
            // missionTitleLabel
            // 
            missionTitleLabel.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missionTitleLabel.Location = new Point(15, 16);
            missionTitleLabel.Name = "missionTitleLabel";
            missionTitleLabel.Size = new Size(415, 37);
            missionTitleLabel.TabIndex = 0;
            missionTitleLabel.Text = "Mission Name";
            // 
            // bankBalanceLabel
            // 
            bankBalanceLabel.AutoSize = true;
            bankBalanceLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankBalanceLabel.Location = new Point(10, 50);
            bankBalanceLabel.Name = "bankBalanceLabel";
            bankBalanceLabel.Size = new Size(178, 23);
            bankBalanceLabel.TabIndex = 21;
            bankBalanceLabel.Text = "Bank Balance: £0";
            // 
            // logoPanel
            // 
            logoPanel.BackColor = SystemColors.ButtonFace;
            logoPanel.BackgroundImageLayout = ImageLayout.Stretch;
            logoPanel.Controls.Add(spaceAgencyTextbox);
            logoPanel.Controls.Add(bankBalanceLabel);
            logoPanel.Location = new Point(12, 12);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(359, 85);
            logoPanel.TabIndex = 5;
            // 
            // spaceAgencyTextbox
            // 
            spaceAgencyTextbox.BackColor = SystemColors.MenuBar;
            spaceAgencyTextbox.BorderStyle = BorderStyle.None;
            spaceAgencyTextbox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spaceAgencyTextbox.ForeColor = Color.Black;
            spaceAgencyTextbox.Location = new Point(7, 3);
            spaceAgencyTextbox.MaxLength = 22;
            spaceAgencyTextbox.Name = "spaceAgencyTextbox";
            spaceAgencyTextbox.Size = new Size(343, 43);
            spaceAgencyTextbox.TabIndex = 7;
            spaceAgencyTextbox.Text = "Untitled Space Agency";
            spaceAgencyTextbox.TextChanged += spaceAgencyTextbox_TextChanged;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(missionPanel);
            Controls.Add(logoPanel);
            Controls.Add(ViewMissionsButton);
            Controls.Add(LoadRocketButton);
            Controls.Add(NewRocketButton);
            Margin = new Padding(1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "MainMenu";
            Text = "-";
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            missionPanel.ResumeLayout(false);
            missionPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button NewRocketButton;
        private Button ViewMissionsButton;
        private Button LoadRocketButton;
        private Panel missionPanel;
        private Label missionTitleLabel;
        private Label MissionDescriptionLabel;
        private Button closeMissionWindow;
        private Label altitudeLabel;
        private Label rewardLabel;
        private Label bankBalanceLabel;
        private Button skipButton;
        private Panel logoPanel;
        private TextBox spaceAgencyTextbox;
    }
}
