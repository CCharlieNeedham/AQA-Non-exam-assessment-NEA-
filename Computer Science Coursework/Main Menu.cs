using System.Net.Sockets;
using Microsoft.VisualBasic;

namespace Computer_Science_Coursework
{
    public partial class MainMenu : Form
    {
        private SpaceAgency spaceAgency;
        public MainMenu()
        {
            this.DoubleBuffered = true; //Reduce flickering for UI rendering
            InitializeComponent();
            spaceAgency = new SpaceAgency();
            bankBalanceLabel.Text = "Bank Balance: £" + Math.Round(spaceAgency.BankBalance, 2).ToString();
            UpdateMissionPanel();


        }
        internal MainMenu(SpaceAgency spaceAgency) //Consttructor for loading exsisting spaceAgency data
        {
            this.DoubleBuffered = true; //Reduce flickering for UI rendering
            InitializeComponent();
            this.spaceAgency = spaceAgency;

            //Create UI elements with exsisting spaceAgency data:
            spaceAgencyTextbox.Text = spaceAgency.name;
            bankBalanceLabel.Text = "Bank Balance: £" + Math.Round(spaceAgency.BankBalance, 2).ToString();
            UpdateMissionPanel();
        }

        private void NewRocketButton_Click(object sender, EventArgs e)
        {
            //Open Rocket Designer form and hide current menu:
            Rocket_Designer rocket_Designer = new Rocket_Designer(spaceAgency);
            rocket_Designer.Show();
            this.Hide();
        }

        private void LoadRocketButton_Click(object sender, EventArgs e)
        {
            //Attempt to load the rocket designer form with exsisting rocket data from a text file:
            string inputRocketName = Interaction.InputBox("Enter a name for the rocket you wish to load", "Load Rocket");
            string filePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rocket Designs", inputRocketName);
            if (File.Exists(filePathName) == true)
            {
                try
                {
                    Rocket_Designer rocket_Designer = new Rocket_Designer(spaceAgency, inputRocketName);
                    rocket_Designer.Show();
                    this.Hide();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error loading file: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rocket design not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ViewMissionsButton_Click(object sender, EventArgs e)
        {
            //Open the mission panel to show mission data:
            missionPanel.Show();
        }
        private void UpdateMissionPanel()
        {
            //Update the mission panel with the current mission data:
            if (spaceAgency.ActiveMission != null)
            {
                missionTitleLabel.Text = spaceAgency.ActiveMission.Name;
                MissionDescriptionLabel.Text = spaceAgency.ActiveMission.Description;
                rewardLabel.Text = ("Reward: £" + spaceAgency.ActiveMission.Reward.ToString());
                altitudeLabel.Text = ("Altitude: " + spaceAgency.ActiveMission.Altitude.ToString() + " Metres");
            }
            else
            {
                missionTitleLabel.Text = "No Active Missions";
                MissionDescriptionLabel.Text = "No Active Missions";
                rewardLabel.Text = "No Active Missions";
                altitudeLabel.Text = "No Active Missions";
            }
        }

        private void closeMissionWindow_Click(object sender, EventArgs e)
        {
            missionPanel.Hide();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            spaceAgency.NextMission();
            UpdateMissionPanel();
        }

        private void spaceAgencyTextbox_TextChanged(object sender, EventArgs e)
        {
            spaceAgency.name = spaceAgencyTextbox.Text; //Update space agency name whenever the text field is modified

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
