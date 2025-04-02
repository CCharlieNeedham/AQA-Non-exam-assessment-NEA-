namespace Computer_Science_Coursework
{
    public partial class Launch_Info : Form
    {
        //Define private variables for the form:
        private Rocket rocket;
        private SpaceAgency spaceAgency;

        //Define pens for drawing trajectories:
        private Pen trajectoryPen = new Pen(Color.White, 3);
        private Pen targetPen = new Pen(Color.Red, 3);

        internal Launch_Info(Rocket rocket, SpaceAgency spaceAgency)
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Reduce flickering for UI rendering

            //Set the private variables to the values passed in the constructor:
            this.rocket = rocket;
            this.spaceAgency = spaceAgency;
        }

        public int MetresToPixels(double metres)
        {
            return (int)(Math.Round(metres * AstroConstants.GraphicsScalerValue));
        }

        private void LaunchReport()
        {
            double componentY = 0;
            //Check if was mission was a obrital or sub-orbital mission and change labels:
            if (spaceAgency.ActiveMission.Orbital == true)
            {
                trajectoryTypeLabel.Text = trajectoryTypeLabel.Text + " Orbital";
                componentY = Math.Round(rocket.OrbitalComponents["Y"], 2);

            }
            else if (spaceAgency.ActiveMission.Orbital == false)
            {
                trajectoryTypeLabel.Text = trajectoryTypeLabel.Text + " Sub-Orbital";
                componentY = Math.Round(rocket.SubOrbitalComponents["Y"], 2);

            }

            achievedAltitudeLabel.Text = achievedAltitudeLabel.Text + Math.Round(rocket.SubOrbitalComponents["Y"], 2).ToString("N0") + " Metres";

            //Display an error if the rocket trajectory is to high for the UI to display:
            if (componentY > AstroConstants.ClippingHeight)
            {

                MessageBox.Show("Rocket trajectory too high to display on screen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Check if the mission was successful or not and update UI:
            if (rocket.MissionAltitudeSuccess(spaceAgency.ActiveMission.Orbital, spaceAgency.ActiveMission.Altitude) == true && rocket.MissionCrewedSuccess(spaceAgency.ActiveMission.Manned) == true)
            {
                missionStatusLabel.Text = missionStatusLabel.Text + " Mission Success, reward is £" + spaceAgency.ActiveMission.Reward.ToString("N0");
                missionStatusLabel.ForeColor = Color.Green;
                targetPen.Color = Color.Green;
                targetAltitudeLabel.ForeColor = Color.Green;
            }
            else
            {
                //If the mission was a failure, update the UI to reflect this:
                missionStatusLabel.Text = missionStatusLabel.Text + " Mission Failure!";
                missionStatusLabel.ForeColor = Color.Red;
                targetPen.Color = Color.Red;
                targetAltitudeLabel.ForeColor = Color.Red;

            }
            //Update the UI with the rockets final velocity:
            finalVelocityLabel.Text = finalVelocityLabel.Text + "Final Velocity: " + Math.Round(rocket.FinalVelocity, 2).ToString("N0") + " m/s";
            targetAltitudeLabel.Text = targetAltitudeLabel.Text + "Target Altitude: " + spaceAgency.ActiveMission.Altitude.ToString("N0") + " Metres";
            labelKineticEnergy.Text = labelKineticEnergy.Text + "Kinetic Energy: " + Math.Round(rocket.KineticEnergy, 2).ToString("N0") + " Joules";
            labelPotentialEnergy.Text = labelPotentialEnergy.Text + "Potential Energy: " + Math.Round(rocket.PotentialEnergy, 1).ToString("N0") + " Joules";
        }

        private void Launch_Info_Paint(object sender, PaintEventArgs e)
        {
            //Rocket launch location:
            const int launchXLocation = 960;
            const int launchYLocation = 868;

            //Get values for mission state: 
            bool isOrbital = spaceAgency.ActiveMission.Orbital;
            int targetAltitude = (MetresToPixels(spaceAgency.ActiveMission.Altitude));
            int targetArcWidth = ((targetAltitude / 60) * 40); //add to mission class

            //values for the rockets trajectory:
            int rocketXComponentLength = 0;
            int rocketYComponentLength = 0;
            int trajectorySweepAngle = 0;

            int targetStartY = 0;
            int targetEndY = 0;

            //Draw curve to represent the rockets mission target:
            if (isOrbital == false)
            {
                targetStartY = launchYLocation - targetAltitude;
                targetEndY = launchYLocation - targetAltitude;
            }
            else if (isOrbital == true)
            {
                targetStartY = this.Height - targetAltitude;
                targetEndY = this.Height - targetAltitude;
            }
            e.Graphics.DrawCurve(targetPen, new Point[] {
                new Point(-80, targetStartY),
                new Point(launchXLocation - targetArcWidth, launchYLocation - targetAltitude),
                new Point(launchXLocation + targetArcWidth, launchYLocation - targetAltitude),
                new Point(2000,  targetEndY)
                });
            targetAltitudeLabel.Location = new Point(launchXLocation + targetArcWidth, launchYLocation - targetAltitude);

            //Calculate the dimesions of the rockets trajectory & plot rockets final orbit (if obrital):
            if (isOrbital == false)
            {
                rocketXComponentLength = (MetresToPixels(rocket.SubOrbitalComponents["X"]));
                rocketYComponentLength = (MetresToPixels(rocket.SubOrbitalComponents["Y"]));
                trajectorySweepAngle = 180;

            }
            else if (isOrbital == true)
            {
                rocketXComponentLength = (MetresToPixels(rocket.OrbitalComponents[""]));
                rocketYComponentLength = (MetresToPixels(rocket.OrbitalComponents["Y"]));

                if (rocket.OrbitalComponents["Y"] >= AstroConstants.StableOrbit)
                {
                    trajectorySweepAngle = 90;
                    //Draw curve to represent the rockets highest achievable orbit:
                    e.Graphics.DrawCurve(trajectoryPen, new Point[] {
                    new Point(-80, this.Height - rocketYComponentLength ),
                    new Point(launchXLocation - rocketXComponentLength, launchYLocation - rocketYComponentLength),
                    new Point(launchXLocation + rocketXComponentLength, launchYLocation - rocketYComponentLength),
                    new Point(2000,  this.Height - rocketYComponentLength)
                    });
                }
                else
                {
                    trajectorySweepAngle = 180;
                }
            }

            //Draw Arc to represent the rockets trajectory:
            e.Graphics.DrawArc(trajectoryPen,
                launchXLocation,
                launchYLocation - rocketYComponentLength,
                rocketXComponentLength * 2,
                rocketYComponentLength * 2,
                180,
                trajectorySweepAngle);

            achievedAltitudeLabel.Location = new Point(launchXLocation, launchYLocation - rocketYComponentLength - 20);

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //Reward the player if the mission was a success:
            if (rocket.MissionAltitudeSuccess(spaceAgency.ActiveMission.Orbital, spaceAgency.ActiveMission.Altitude) == true && rocket.MissionCrewedSuccess(spaceAgency.ActiveMission.Manned) == true) ;
            {
                spaceAgency.MissionSuccess();
            }

            //Return to main menu:
            MainMenu mainMenu = new MainMenu(spaceAgency);
            mainMenu.Show();
            this.Close();
        }

        private void Launch_Info_Load(object sender, EventArgs e)
        {
            LaunchReport(); //Generate the mission report
        }

        private void informationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
