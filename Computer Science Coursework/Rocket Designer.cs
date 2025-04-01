using System.Drawing.Drawing2D;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Computer_Science_Coursework
{
    public enum FuelType //Enum for differant types of rocket fuel types:
    {
        Hydrogen = 71, //Fuel Density for hydrogen (kg/m^3)
        Methane = 423, //Fuel Density for Methane (kg/m^3)
        RP1 = 810, //Fuel Density for RP1 (kg/m^3)
    }

    public partial class Rocket_Designer : Form
    {
        //Define private variables for the form:
        private SpaceAgency spaceAgency;
        private Rocket rocket;
        private List<FuelTank> fuelTanks = new List<FuelTank>();//List of all possible fuel tanks
        private int selectedStage;
        private Brush fairingBrush = new HatchBrush(HatchStyle.Vertical, Color.Gray, Color.LightGray); //Brush for fairing between stages
        
        //Dictionaries to map fuel tank names to their dimensions:
        private Dictionary<string, double> tankHeights = new Dictionary<string, double>()
        {
            {"Short", 4},
            {"Regular", 8},
            {"Tall", 12},
        };
        private Dictionary<string, double> tankWidths = new Dictionary<string, double>()
        {
            {"Extra Thin", 2},
            {"Thin", 4},
            {"Mid", 6},
            {"Wide", 8},
            {"Extra Wide", 10},
        };

        //Engine definitions:
        private Engine rd180 = new Engine(thrust: 4150000, massFlow: 1250, fuelType: FuelType.RP1, name: "RD-180", height: 4, diameter: 3, textureFileName: "RD180", mass: 5480, cost: 12000000, fuelRatio: 2.3);
        private Engine f1 = new Engine(thrust: 7770000, massFlow: 2577, fuelType: FuelType.RP1, name: "F1", height: 5, diameter: 4, textureFileName: "F1", mass: 8400, cost: 15000000, fuelRatio: 14.7);
        private Engine rs25 = new Engine(thrust: 2279000, massFlow: 514, fuelType: FuelType.Hydrogen, name: "RS-25", height: 4, diameter: 3, textureFileName: "RS25", mass: 3200, cost: 6000000, fuelRatio: 6);
        private Engine le7 = new Engine(thrust: 1078000, massFlow: 220, fuelType: FuelType.Hydrogen, name: "LE7", height: 3, diameter: 2, textureFileName: "LE7", mass: 1700, cost: 4000000, fuelRatio: 5.9);
        private Engine raptor = new Engine(thrust: 2530000, massFlow: 650, fuelType: FuelType.Methane, name: "Raptor", height: 3, diameter: 2, textureFileName: "Raptor", mass: 1600, cost: 10000000, fuelRatio: 3.6);

        //Payload definitions
        private Payload extraSmallPayload = new Payload(name: "Extra Small Payload", height: 2, diameter: 2, textureFileName: "UncrewedPayload", mass: 4000, cost: 20000, crewed: false);
        private Payload smallPayload = new Payload(name: "Small Payload", height: 4, diameter: 4, textureFileName: "CrewedPayload", mass: 8000, cost: 40000, crewed: true);
        private Payload mediumPayload = new Payload(name: "Medium Payload", height: 6, diameter: 6, textureFileName: "CrewedPayload", mass: 12000, cost: 60000, crewed: true);
        private Payload largePayload = new Payload(name: "Large Payload", height: 8, diameter: 8, textureFileName: "UncrewedPayload", mass: 16000, cost: 80000, crewed: false);
        private Payload extraLargePayload = new Payload(name: "Extra Large Payload", height: 10, diameter: 10, textureFileName: "UncrewedPayload", mass: 20000, cost: 100000, crewed: false);


        internal Rocket_Designer(SpaceAgency spaceAgency) //Constructor for the creation of a new rocket
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Reduce flickering for UI rendering

            this.spaceAgency = spaceAgency; //Set the space agency for the form

            CreateFuelTanks(); //Call a function to create all the fuel tanks and add them to the list
            RocketVisible(false); //Hide the rocket graphics
            RocketControlsVisible(false); //Hide the rocket controls
            CreateToolTips(); //Create tooltips for all the buttons

            rocket = new Rocket(extraSmallPayload, "Untitled Rocket"); //Create a new rocket with a default payload

        }
        internal Rocket_Designer(SpaceAgency spaceAgency, string rocketFileName) //Constructor for loading of an exsisting rocket
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Reduce flickering for UI rendering

            this.spaceAgency = spaceAgency; //Set the space agency for the form

            CreateFuelTanks(); //Call a function to create all the fuel tanks and add them to the list
            RocketControlsVisible(true); //Show the rocket controls
            CreateToolTips(); //Create tooltips for all the buttons

            LoadRocket(rocketFileName); //load data from the file

            //load rocket graphics:
            payloadPic.Show();
            selectedStage = 0; //Set selected stage to the first stage

            Stage1Visible(true);
            stage1Button.Checked = true;

            ChangeEngineGraphic();
            ChangeFuelTankGraphic();

            if (rocket.Stages.Count > 1)
            {
                selectedStage = 1; //Set the selected stage to the second stage if available
                Stage2Visible(true);
                ChangeEngineGraphic();
                ChangeFuelTankGraphic();
                stage2Button.Checked = true;
            }

            ChangePayloadGraphics();
            UpdateRocketCostLabel();
            numEnginesNumericUpDown.Value = rocket.Stages[selectedStage].NumOfEngines;
        }

        private void LoadRocket(string rocketFileName)
        {
            //Initialize the payload, engines, fuel tanks, and engine counts:
            Payload rocketPayload = extraSmallPayload;
            List<Engine> rocketEngines = new List<Engine>();
            List<FuelTank> rocketFuelTanks = new List<FuelTank>();
            List<int> rocketNumOfEngines = new List<int>();
                      
            string fuelTankName;

            string filePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rocket Designs", rocketFileName);

            using (StreamReader RocketFile = new StreamReader(filePathName))
            {
                //Get payload name and find the corresponding Payload class:
                switch (RocketFile.ReadLine())
                {
                    case "Extra Small Payload":
                        rocketPayload = extraSmallPayload;
                        break;
                    case "Small Payload":
                        rocketPayload = smallPayload;
                        break;
                    case "Medium Payload":
                        rocketPayload = mediumPayload;
                        break;
                    case "Large Payload":
                        rocketPayload = largePayload;
                        break;
                    case "Extra Large Payload":
                        rocketPayload = extraLargePayload;
                        break;
                    default:
                        MessageBox.Show("Error loading file: Missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                //Iterate through the file to get each stage:
                while (RocketFile.ReadLine() != null)
                {
                    //Get fuel tank name and find the corresponding FuelTank class:
                    fuelTankName = RocketFile.ReadLine();
                    rocketFuelTanks.Add(fuelTanks.First(FuelTank => FuelTank.name == fuelTankName));

                    //Get engine name and find the corresponding Engine class:
                    switch (RocketFile.ReadLine())
                    {
                        case "RD-180":
                            rocketEngines.Add(rd180);
                            break;
                        case "F1":
                            rocketEngines.Add(f1);
                            break;
                        case "RS-25":
                            rocketEngines.Add(rs25);
                            break;
                        case "LE7":
                            rocketEngines.Add(le7);
                            break;
                        case "Raptor":
                            rocketEngines.Add(raptor);
                            break;
                        default:
                            MessageBox.Show("Error loading file: Missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    //Get number of engines:
                    rocketNumOfEngines.Add(int.Parse(RocketFile.ReadLine()));
                }
                //load the rocket with the data:
                rocket = new Rocket(rocketFileName, rocketPayload, rocketFuelTanks, rocketEngines, rocketNumOfEngines);
            }

        }
        private void CreateToolTips()
        {
            //Create tooltips for engines:
            descriptionToolTip.SetToolTip(rd180Button, rd180.description());
            descriptionToolTip.SetToolTip(f1Button, f1.description());
            descriptionToolTip.SetToolTip(rs25Button, rs25.description());
            descriptionToolTip.SetToolTip(le7Button, le7.description());
            descriptionToolTip.SetToolTip(raptorButton, raptor.description());

            //Create tooltips for paylaods:
            descriptionToolTip.SetToolTip(extraSmallPayloadButton, extraSmallPayload.description());
            descriptionToolTip.SetToolTip(smallPayloadButton, extraSmallPayload.description());
            descriptionToolTip.SetToolTip(mediumPayloadButton, extraSmallPayload.description());
            descriptionToolTip.SetToolTip(extraSmallPayloadButton, extraSmallPayload.description());
            descriptionToolTip.SetToolTip(extraSmallPayloadButton, extraSmallPayload.description());

            //Create tooltips for fuel tanks:
            descriptionToolTip.SetToolTip(fuelTank0Button, fuelTanks[0].description());
            descriptionToolTip.SetToolTip(fuelTank1Button, fuelTanks[1].description());
            descriptionToolTip.SetToolTip(fuelTank2Button, fuelTanks[2].description());
            descriptionToolTip.SetToolTip(fuelTank3Button, fuelTanks[3].description());
            descriptionToolTip.SetToolTip(fuelTank4Button, fuelTanks[4].description());
            descriptionToolTip.SetToolTip(fuelTank5Button, fuelTanks[5].description());
            descriptionToolTip.SetToolTip(fuelTank6Button, fuelTanks[6].description());
            descriptionToolTip.SetToolTip(fuelTank7Button, fuelTanks[7].description());
            descriptionToolTip.SetToolTip(fuelTank8Button, fuelTanks[8].description());
            descriptionToolTip.SetToolTip(fuelTank9Button, fuelTanks[9].description());
            descriptionToolTip.SetToolTip(fuelTank10Button, fuelTanks[10].description());
            descriptionToolTip.SetToolTip(fuelTank11Button, fuelTanks[11].description());
            descriptionToolTip.SetToolTip(fuelTank12Button, fuelTanks[12].description());
            descriptionToolTip.SetToolTip(fuelTank13Button, fuelTanks[13].description());
            descriptionToolTip.SetToolTip(fuelTank14Button, fuelTanks[14].description());
        }

        private void CreateFuelTanks()
        {
            const string textureFileName = "FuelTankTexture";  //Texture for the fuel tanks

            string tankName;
            double tankHeight;
            double tankWidth;

            //Iterate through the fuel tank dictionaries to create all the fuel tanks:
            for (int widthIndex = 0; widthIndex < tankWidths.Count; widthIndex = widthIndex + 1)
            {
                tankWidth = tankWidths.Values.ElementAt(widthIndex);
                for (int heightIndex = 0; heightIndex < tankHeights.Count; heightIndex = heightIndex + 1)
                {
                    tankHeight = tankHeights.Values.ElementAt(heightIndex);
                    tankName = tankHeights.Keys.ElementAt(heightIndex) + ", " + tankWidths.Keys.ElementAt(widthIndex);

                    //Add the created fuel tank to the list:
                    fuelTanks.Add(new FuelTank(name: tankName, height: tankHeight, diameter: tankWidth, textureFileName: textureFileName));
                }

            }

        }
        private void ControlsVisible(bool visible)
        {
            //Change the visibility of all the controls on the form based on a bool value:
            createStageButton.Visible = visible;
            stagesGroupBox.Visible = visible;
            launchButton.Visible = visible;
            launchPictureBox.Visible = visible;
            budgetLabel.Visible = visible;
            rocketCostLabel.Visible = visible;
            mainMenuButton.Visible = visible;

            RocketControlsVisible(visible);
        }
        private void RocketControlsVisible(bool visible)
        {
            //Change the visibility of all the rocket controls based on a bool value:
            enginesGroupBox.Visible = visible;
            fuelTankGroupbox.Visible = visible;
            payloadGroupBox.Visible = visible;
            saveRocketButton.Visible = visible;
            deleteRocketButton.Visible = visible;
            removeStageButton.Visible = visible;

            //lock the launch button if the rocket controls are not visible
            launchButton.Enabled = visible;
            if (visible == false) 
            {
                launchButton.Text = "🔒";
            }
            else if (visible == true)
            {
                launchButton.Text = "Launch Rocket";
            }
        }
        private void RocketVisible(bool visible)
        {
            //Change the visibility of the rocket based on a bool value:
            Stage1Visible(visible);
            Stage2Visible(visible);
            payloadPic.Visible = visible;
        }
        private void Stage1Visible(bool visible)
        {
            //Change the visibility of stage 1 based on a bool value:
            enginePic1.Visible = visible;
            fuelTankPic1.Visible = visible;
            stage1Button.Visible = visible;
        }
        private void Stage2Visible(bool visible)
        {
            //Change the visibility of stage 2 based on a bool value:
            enginePic2.Visible = visible;
            fuelTankPic2.Visible = visible;
            stage2Button.Visible = visible;

        }
        private void UpdateRocketCostLabel()
        {
            double rocketCost = Math.Round(rocket.calcTotalCost(), 2);//Calculate the total rocket cost and round to two decimal places

            //Update the rocket cost label with the new cost:
            rocketCostLabel.Text = ("Rocket Cost: £" + rocketCost.ToString("N0"));

            //Change the colour of the label based on if the rocket cost is greater than the bank balance:
            if (rocketCost > spaceAgency.BankBalance)
            {
                rocketCostLabel.ForeColor = Color.Red;
            }
            else if (rocketCost < spaceAgency.BankBalance)
            {
                rocketCostLabel.ForeColor = Color.Black;
            }
        }

        private void createStageButton_Click(object sender, EventArgs e)
        {
            int numOfStages = rocket.Stages.Count();

            //Handle depending on the number of exsisting stages:
            if (numOfStages == 0)
            {
                if (fuelTanks.Count == 0) //Validate that the components are available
                {
                    MessageBox.Show("No fuel tanks available, issue loading fuel tanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Add the first stage with a default fuel tank, payload and engine
                rocket.addStage(fuelTanks[6], rd180, 1);                
                selectedStage = 0;
                Stage1Visible(true);
                stage1Button.Checked = true;
                RocketControlsVisible(true);
                rocket.updatePayload(extraSmallPayload);
                extraSmallPayload.loadTexture();

            }
            else if (numOfStages == 1)
            {
                //Add the second stage with the same fuel tank and engine as the first stage
                rocket.addStage(rocket.Stages[0].FuelTank, rocket.Stages[0].Engine, 1);
                selectedStage = 1;
                Stage2Visible(true);
                stage2Button.Checked = true;
            }
            else //handle exception:
            {
                MessageBox.Show("2 stages max ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // create delete stage function
                return;
            }

            //update the form graphics and labels (UI):
            payloadPic.Show();
            ChangeEngineGraphic();
            ChangeFuelTankGraphic();
            ChangePayloadGraphics();
            UpdateRocketCostLabel();
            numEnginesNumericUpDown.Value = rocket.Stages[selectedStage].NumOfEngines;
        }

        private int RocketCenterline()
        {
            return enginePic1.Location.X + enginePic1.Width / 2;
        }

        private int FormCentreLineX()
        {
            return this.Width / 2;
        }

        protected void ChangeEngineGraphic() //improve 
        {
            int rocketCenterline = RocketCenterline();

            //Get new engine dimensions (pixels): 
            int newEngineHeight = MetresToPixels(rocket.Stages[selectedStage].Engine.Height) - 20; //Minus 20 to remove extra spacing  
            int newEngineWidth = MetresToPixels(rocket.Stages[selectedStage].Engine.Diameter) - 4; //Minus 8  to remove extra spacing 

            //Load new texture if not loaded already
            if (rocket.Stages[selectedStage].Engine.TextureLoaded == false)
            {
                rocket.Stages[selectedStage].Engine.loadTexture();
            }

            //Set new texture 
            Image engineImage = rocket.Stages[selectedStage].Engine.TextureImage;

            //Get number of engines and adjust width for them:
            int numOfEngines = rocket.Stages[selectedStage].NumOfEngines;
            newEngineWidth = newEngineWidth * numOfEngines;

            //Set new engine graphics and adjust dimensions:
            if (selectedStage == 0)
            {
                enginePic1.BackgroundImage = engineImage;

                enginePic1.Height = newEngineHeight;
                enginePic1.Width = newEngineWidth;

                //Adjust position of engine so it changes size evenly on both sides:
                enginePic1.Location = new Point(FormCentreLineX() - (enginePic1.Width / 2), 920);


            }
            else if (selectedStage == 1)
            {
                enginePic2.BackgroundImage = engineImage;

                enginePic2.Height = newEngineHeight;
                enginePic2.Width = newEngineWidth;

            }
            //Align second engine with frist engine:
            enginePic2.Location = new Point(rocketCenterline - enginePic2.Width / 2, fuelTankPic1.Location.Y - enginePic2.Height);
        }
        protected void ChangeFuelTankGraphic() //improve 
        {
            int rocketCenterline = RocketCenterline();

            //Get new fueltank dimensions (pixels): 
            int newFuelTankWidth = MetresToPixels(rocket.Stages[selectedStage].FuelTank.Diameter);
            int newFuelTankHeight = MetresToPixels(rocket.Stages[selectedStage].FuelTank.Height);

            //Load new texture if not loaded already
            if (rocket.Stages[selectedStage].FuelTank.TextureLoaded == false)
            {
                rocket.Stages[selectedStage].FuelTank.loadTexture();
            }

            //Set new texture 
            Image fuelTankImage = rocket.Stages[selectedStage].FuelTank.TextureImage;

            //Adjust new fuel tank dimensions:
            if (selectedStage == 0)
            {
                fuelTankPic1.Width = newFuelTankWidth;
                fuelTankPic1.Height = newFuelTankHeight;
                fuelTankPic1.Location = new Point(rocketCenterline - newFuelTankWidth / 2, enginePic1.Location.Y - newFuelTankHeight);

                //If the rocket has more then one stage adjust the second stage:
                if (rocket.Stages.Count() > 1)
                {
                    ChangeEngineGraphic();
                    fuelTankPic2.Location = new Point(rocketCenterline - fuelTankPic2.Width / 2, enginePic2.Location.Y - fuelTankPic2.Height);
                }

            }
            else if (selectedStage == 1)
            {
                fuelTankPic2.Width = newFuelTankWidth;
                fuelTankPic2.Height = newFuelTankHeight;
                fuelTankPic2.Location = new Point(rocketCenterline - newFuelTankWidth / 2, enginePic2.Location.Y - newFuelTankHeight);
            }
        }
        protected void ChangePayloadGraphics()
        {
            int rocketCenterline = RocketCenterline();

            //Get new payload dimensions (pixels): 
            int newPayloadWidth = MetresToPixels(rocket.Payload.Diameter);
            int newPayloadHeight = MetresToPixels(rocket.Payload.Height);

            //Adjust new payload dimensions:
            payloadPic.Width = newPayloadWidth;
            payloadPic.Height = newPayloadHeight;
            payloadPic.Image = rocket.Payload.TextureImage;
            if (rocket.Stages.Count - 1 == 0)
            {
                payloadPic.Location = new Point(rocketCenterline - newPayloadWidth / 2, fuelTankPic1.Location.Y - newPayloadHeight);
            }
            else if (rocket.Stages.Count() - 1 == 1)
            {
                payloadPic.Location = new Point(rocketCenterline - newPayloadWidth / 2, fuelTankPic2.Location.Y - newPayloadHeight);
            }
        }
        private void selectEngine(Engine selectedEngine)
        {
            //Update the engine configuration based on the selected engine:
            bool engineUpdated = rocket.Stages[selectedStage].updateEngineConfiguration(selectedEngine);

            if (engineUpdated == true)
            {
                //Update the form graphics and labels (UI):
                ChangeEngineGraphic();
                ChangeFuelTankGraphic();
                ChangePayloadGraphics();
                UpdateRocketCostLabel();
            }
            else //Handle if the engine does not fit:
            {
                MessageBox.Show("New engine arrangement is too wide. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectFuelTank(int fuelTankTag)
        {
            FuelTank newFuelTank = fuelTanks[fuelTankTag]; //Get the selected fuel tank based on the button clicked

            //Update the fuel tank configuration based on the selected fuel tank:
            bool fuelTankUpdated = rocket.Stages[selectedStage].updateFuelTankConfiguration(newFuelTank, rocket.stageSizeRestraint(selectedStage), selectedStage);

            if (fuelTankUpdated == true)
            {
                //Update the form graphics and labels (UI):
                ChangeFuelTankGraphic();
                ChangePayloadGraphics();
                UpdateRocketCostLabel();
                ChangeEngineGraphic();

            }
            else //Handle if the fuel tank does not fit:
            {
                MessageBox.Show("New fuel tank does not fit. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numEnginesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newNumEngines = (int)numEnginesNumericUpDown.Value; //Get the new number of engines from the numeric up down
            bool enginesUpdated = rocket.Stages[selectedStage].updateEngineConfiguration(newNumEngines); //Update the engine configuration based on the new number of engines

            if (enginesUpdated == true)
            {
                //Update the form graphics and labels (UI):
                ChangeEngineGraphic();
                UpdateRocketCostLabel();
            }
            else
            {
                //Handle if the engine configuration does not fit:
                MessageBox.Show("New engine arrangement is does not fit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numEnginesNumericUpDown.Value = rocket.Stages[selectedStage].NumOfEngines;
            }
        }

        private void SelectPayload(Payload selectedPayload)
        {
            bool payloadUpdated = rocket.updatePayload(selectedPayload); //Update the payload configuration based on the selected payload
            if (payloadUpdated == true)
            {
                //Update the form graphics and labels (UI):
                selectedPayload.loadTexture();
                ChangePayloadGraphics();
                UpdateRocketCostLabel();
            }
            else
            {
                //Handle if the payload does not fit:
                MessageBox.Show("New payload does not fit. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeStageButton_Click(object sender, EventArgs e)
        {
            //Try to remove the stage and if successful update UI depending on selected stage:
            if (rocket.RemoveStage(selectedStage) == true)
            {
                if (selectedStage == 1)
                {
                    Stage2Visible(false);
                    stage1Button.Checked = true;
                }
                else if (selectedStage == 0)
                {
                    RocketVisible(false);
                    RocketControlsVisible(false);
                }

                selectedStage = selectedStage - 1; //Decrease the selected stage index to reflect the removed stage

                UpdateNumOfEnginesNumericUpDown();
                ChangePayloadGraphics();
                UpdateRocketCostLabel();
            }
        }

        private void stage2Button_Click(object sender, EventArgs e)
        {
            //Change the selected stage to stage 2 and update UI:
            selectedStage = 1;
            UpdateNumOfEnginesNumericUpDown();
        }

        private void stage1Button_Click(object sender, EventArgs e)
        {
            //Change the selected stage to stage 1 and update UI:
            selectedStage = 0;
            UpdateNumOfEnginesNumericUpDown();
        }
        private void UpdateNumOfEnginesNumericUpDown() //Update number of engines numeric up down based on selected stage
        {
            if (rocket.Stages.Count > 0)
            {
                numEnginesNumericUpDown.Value = rocket.Stages[selectedStage].NumOfEngines;

            }

        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            double thrustToWeightRatio = rocket.thrustToWeightRatio(); //Calculate the thrust to weight ratio of the rocket
           
            rocket.launchRocketData();

            MessageBox.Show(rocketCostLabel.Text +" \nThrust-To-Weight Ratio = " + Math.Round(thrustToWeightRatio,2) + "\nDry Mass = " + Math.Round(rocket.DryMass,2) + "\nWet Mass = " + Math.Round(rocket.WetMass,2), "Rocket Data", MessageBoxButtons.OK);

            //Check if the rocket is too heavy to launch:
            if (thrustToWeightRatio > 1)
            {
                rocket.launchRocketData();

                //Deduct the cost of the rocket from the space agency bank balance:
                spaceAgency.RemoveFunds(rocket.calcTotalCost());

                //Update the form graphics and labels (UI), to show launch animation:
                ControlsVisible(false);
                launchPictureBox.Show();
                launchPictureBox.Location = new Point(0, 0);
                launchPictureBox.Size = new Size(this.Width, this.Height);
                PictureBox[] rocketParts = { enginePic1, fuelTankPic1, fuelTankPic2, payloadPic };
                enginePic2.Hide();
                launchPictureBox.Controls.AddRange(rocketParts);
                launchTimer.Start();
            }
            else
            {
                MessageBox.Show("Rocket is too heavy to launch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int MetresToPixels(double metres)
        {
            return (int)(Math.Round(metres * AstroConstants.Scaler)); //Convert metres to pixels using a factor of 25 for rocket graphics 
        }

        private void launchTimer_Tick(object sender, EventArgs e) //Timer for launch animation
        { 
            launchTimer.Stop();
            Launch_Info Launch_Info = new Launch_Info(rocket, spaceAgency); //Create a new launch info form
            Launch_Info.Show();
            this.Hide();
        }

        private void Rocket_Designer_Load(object sender, EventArgs e)
        {
            //Update the budget label with the space agency bank balance:
            double budget = Math.Round(spaceAgency.BankBalance, 2);
            budgetLabel.Text = "Budget: £" + budget.ToString("N0");
        }


        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu();
        }
        private void MainMenu() //Return to the main menu
        {
            MainMenu mainMenu = new MainMenu(spaceAgency);
            mainMenu.Show();
            this.Close();
        }

        private void launchPictureBox_Paint(object sender, PaintEventArgs e)
        { 
            //Draw fairing between stages for launch animation if there are multiple stages:
            if (rocket.Stages.Count > 1)
            {
                e.Graphics.FillPolygon(fairingBrush, new Point[] {
                    new Point(fuelTankPic1.Location.X, fuelTankPic1.Location.Y),
                    new Point(fuelTankPic1.Location.X + fuelTankPic1.Width, fuelTankPic1.Location.Y),
                    new Point(fuelTankPic2.Location.X + fuelTankPic2.Width, fuelTankPic1.Location.Y - enginePic2.Height),
                    new Point(fuelTankPic2.Location.X, fuelTankPic1.Location.Y - enginePic2.Height),
                });


            }
        }

        private void saveRocketButton_Click(object sender, EventArgs e)
        {
            string inputRocketName = Interaction.InputBox("Enter a name for the rocket you wish to save", "Save Rocket", rocket.name);
            if (string.IsNullOrWhiteSpace(inputRocketName) == false)
            {
                rocket.name = inputRocketName;
            }
            MessageBox.Show(rocket.SaveRocket(), "Info");
        }

        private void deleteRocketButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            if (Interaction.MsgBox("Are you sure you want to delete this rocket file?", MsgBoxStyle.YesNo, "Delete Rocket") == MsgBoxResult.Yes)
            {
                MessageBox.Show(rocket.DeleteRocket(), "Info");
            }
        }

        //Fuel tank buttons:
        private void fuelTank0Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 0;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank1Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 1;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank2Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 2;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank3Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 3;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank4Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 4;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank5Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 5;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank6Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 6;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank7Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 7;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank8Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 8;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank9Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 9;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank10Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 10;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank11Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 11;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank12Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 12;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank13Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 13;
            SelectFuelTank(fuelTankIndex);
        }
        private void fuelTank14Button_Click(object sender, EventArgs e)
        {
            const int fuelTankIndex = 14;
            SelectFuelTank(fuelTankIndex);
        }

        //Engine buttons:
        private void rs25Button_Click(object sender, EventArgs e)
        {
            selectEngine(rs25);
        }
        private void le7Button_Click(object sender, EventArgs e)
        {
            selectEngine(le7);
        }
        private void raptorButton_Click(object sender, EventArgs e)
        {
            selectEngine(raptor);
        }
        private void rd180Button_Click(object sender, EventArgs e)
        {
            selectEngine(rd180); 
        }
        private void f1Button_Click(object sender, EventArgs e)
        {
            selectEngine(f1); 
        }

        //Payload buttons:
        private void extraSmallPayloadButton_Click(object sender, EventArgs e)
        {
            SelectPayload(extraSmallPayload);
        }
        private void mediumPayloadButton_Click(object sender, EventArgs e)
        {
            SelectPayload(mediumPayload);
        }
        private void smallPayloadButton_Click(object sender, EventArgs e)
        {
            SelectPayload(smallPayload);
        }
        private void largePayloadButton_Click(object sender, EventArgs e)
        {
            SelectPayload(largePayload);
        }
        private void extraSmallPayloadButton_Click_1(object sender, EventArgs e)
        {
            SelectPayload(extraSmallPayload);
        }
        private void mediumPayloadButton_Click_1(object sender, EventArgs e)
        {
            SelectPayload(mediumPayload);
        }
        private void extraLargePayloadButton_Click(object sender, EventArgs e)
        {
            SelectPayload(extraLargePayload);
        }
        private void smallPayloadButton_Click_1(object sender, EventArgs e)
        {
            SelectPayload(smallPayload);
        }
        private void largePayloadButton_Click_1(object sender, EventArgs e)
        {
            SelectPayload(largePayload);
        }
    }
}