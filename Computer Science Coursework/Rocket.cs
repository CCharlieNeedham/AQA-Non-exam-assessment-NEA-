using System.Linq.Expressions;

namespace Computer_Science_Coursework
{
    internal class Rocket
    {
        private const double DragCoefficient = 0.5; //unitless

        //Fields of Rocket class:
        public string name;
        private Payload payload;
        private double dryMass;
        private double wetMass;
        private double finalVelocity;
        private double maxAltitude;
        private double kineticEnergy;
        private double potentialEnergy;

        Dictionary<string, double> orbitalComponents = new Dictionary<string, double>()
            {
                {"X", 0},
                {"Y", 0}
            };

        Dictionary<string, double> subOrbitalComponents = new Dictionary<string, double>()
            {
                {"X", 0},
                {"Y", 0}
            };

        private List<Stage> stages = new List<Stage>(); 

        //Public accessors for private fields:
        public double DryMass {get { return dryMass; }}
        public double WetMass { get { return wetMass; } }
        public double FinalVelocity {  get { return finalVelocity; } }
        public double MaxAltitude { get { return maxAltitude; } }
        public Dictionary<string,double> SubOrbitalComponents { get { return subOrbitalComponents; } }
        public Dictionary<string, double> OrbitalComponents { get { return orbitalComponents; } }
        public double KineticEnergy { get { return kineticEnergy; } }
        public double PotentialEnergy { get { return potentialEnergy; } }


        public List<Stage> Stages
        {
            get { return stages; }
        }
        public Payload Payload
        {
            get { return payload; }
        }

        public Rocket(Payload defaultPayload, string name)
        { //Constructor for creating a new rocket from scratch

            this.payload = defaultPayload;
            this.name = name;
        }
        public Rocket(string name, Payload payload, List<FuelTank> fuelTanks, List<Engine> engines,  List<int> numOfEngines)
        { //Constructor for creating a pre existing rocket from a text file

            this.name = name;
            this.payload = payload;
            int stageIndex = 0;

            //Add stages to rocket based on provided data:
            while (stageIndex < numOfEngines.Count)
            {
                AddStage(fuelTanks[stageIndex], engines[stageIndex], numOfEngines[stageIndex]);
                stageIndex++; 
            }
        }

        public void LaunchRocketData() //Simulate the launch of the rocket and calculate the final velocity and position for different mission types
        {
            this.wetMass = CalcTotalWetMass();
            this.dryMass = CalcTotalDryMass();
            GetFinalPositionData();
            this.orbitalComponents["X"] = CalcOrbitalXComponent();
            this.orbitalComponents["Y"] = CalcOrbitalYComponent();
            this.subOrbitalComponents["X"] = CalcSuborbitalXComponent();
            this.subOrbitalComponents["Y"] = CalcSuborbitalYComponent();
            this.potentialEnergy = CalcPE(this.maxAltitude, payload.Mass);
            this.kineticEnergy = CalcKE(payload.Mass, this.finalVelocity);

        }

        public string SaveRocket() //Attempt to save the rocket data to a text file in the directory
        {
            string filePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rocket Designs", this.name);
            try
            {
                using (StreamWriter RocketFile = new StreamWriter(filePathName))
                {
                    RocketFile.WriteLine(payload.name); //Write the payload to the file
                    for (int stageIndex = 0; stageIndex < stages.Count; stageIndex = stageIndex + 1) //Write each stage to the file:
                    {
                        RocketFile.WriteLine();
                        RocketFile.WriteLine(stages[stageIndex].FuelTank.name);
                        RocketFile.WriteLine(stages[stageIndex].Engine.name);
                        RocketFile.WriteLine(Stages[stageIndex].NumOfEngines);
                    }
                }
                return "Rocket Saved";

            }
            catch (Exception e)
            {
                return "Error saving rocket: " + e;
            }
        }
        public string DeleteRocket() //Attempt to delete the rocket file from the directory
        {
            string filePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rocket Designs", this.name);
            try
            {
                File.Delete(filePathName);
                return "Rocket Deleted";
            }
            catch (Exception e)
            {
                return "Error deleting rocket: " + e;
            }
        }
        private double CalcTotalDryMass()
        {
            //Calculate the total dry mass of the rocket by adding the dry mass of each stage and the payload
            double totalDryMass = payload.Mass;
            for (int stageIndex = 0; stageIndex < stages.Count; stageIndex = stageIndex + 1)
            {
                totalDryMass = totalDryMass + stages[stageIndex].CalcDryMass();
            }
            return totalDryMass;
        }
        public double CalcTotalCost()
        {
            //Calculate the total cost of the rocket by adding the cost of each stage and the payload
            double totalCost = payload.Cost;
            for (int stageIndex = 0; stageIndex < stages.Count; stageIndex = stageIndex + 1)
            {
                totalCost = totalCost + stages[stageIndex].Cost();
            }
            return totalCost;
        }

        private double CalcTotalWetMass()
        {
            //Calculate the total wet mass of the rocket by adding the wet mass of each stage and the payload
            double totalWetMass = payload.Mass;
            for (int stageIndex = 0; stageIndex < stages.Count; stageIndex = stageIndex + 1)
            {
                totalWetMass = totalWetMass + stages[stageIndex].CalcWetMass();
            }
            return totalWetMass;
        }
        private void GetFinalPositionData() //use to calc if acceleration and see if crew can suv
        {
            double exhaustVelocity;
            double rocketDryMass = this.dryMass;
            double rocketWetMass = this.wetMass;
            double stageIdealVelocity = 0;
            double velocity = 0;
            double avgStageVelocity = 0;
            double avgStageAltitude = 0;
            double stageBurnTime;
            double avgStageMass;
            double stageWetMass;
            double stageDryMass;
            double altitude = 0;
            double stageVelocityGain = 0;
            double stageAltitudeGain = 0;
            double velocityLoss = 0;


            //Iterate through each stage of the rocket and calculate the final velocity and altitude of the rocket
            for (int stageIndex = 0; stageIndex < stages.Count; stageIndex = stageIndex + 1)
            {
                stageDryMass = stages[stageIndex].CalcDryMass();
                stageWetMass = stages[stageIndex].CalcWetMass();
                stageBurnTime = stages[stageIndex].BurnTime();
                exhaustVelocity = stages[stageIndex].CalcExhaustVelocity();

                //Calculate the ideal velocity the stage could achieve with no resistance:
                stageIdealVelocity = CalcIdealVelocity(exhaustVelocity,stageWetMass,stageDryMass);

                //Calculate the average mass, velocity and altitude of the stage:
                avgStageMass = rocketWetMass - (stageWetMass/2);
                avgStageVelocity = velocity + (stageIdealVelocity / 2);
                avgStageAltitude = altitude + ((avgStageVelocity * stageBurnTime) / 2);

                //Calculate the velocity loss due to drag and gravity:
                velocityLoss = CalcDragVelocityLoss(CalcAirDensityAtAltitude(avgStageAltitude), avgStageVelocity, stages[stageIndex].FuelTank.BaseArea, avgStageMass, stageBurnTime) + (CalcGravityVelocityLoss(CalcFieldStrength(avgStageAltitude), stageBurnTime));

                //Calculate the velocity and altitude gain of the stage after accounting for resistance:
                stageVelocityGain = stageIdealVelocity - velocityLoss;
                stageAltitudeGain = CalcDistanceTravelled(velocity, stageVelocityGain, stageBurnTime);

                //Update the velocity and altitude of the total rocket:
                velocity = velocity + stageVelocityGain;
                altitude = altitude + stageAltitudeGain;

                //Update the dry and wet mass of the rocket after the stage has been jettisoned:
                rocketDryMass = rocketDryMass - stages[stageIndex].CalcDryMass();
                rocketWetMass = rocketWetMass - stages[stageIndex].CalcWetMass();

            }
            //Set the final velocity and altitude of the rocket:
            this.finalVelocity = velocity;
            this.maxAltitude = altitude;

        }
        private double CalcAirDensityAtAltitude(double altitude)
        { //Calculate the air density at a given altitude using the exponential model of the atmosphere
            return AstroConstants.SeaLevelAirDensity * Math.Exp(-altitude / AstroConstants.AtmosphericHeight);
        } 
        private double CalcIdealVelocity(double exhaustVelocity, double wetMass, double dryMass)
        { //Calculate the ideal velocity a stage could achieve with no resistance
            return exhaustVelocity * Math.Log(wetMass / dryMass);
        }
        private double CalcFieldStrength(double altitude)
        { //Calculate the gravitational field strength at a given altitude
            return (AstroConstants.GravitationalConstant * AstroConstants.Mass) / ((AstroConstants.Radius + altitude) * (AstroConstants.Radius + altitude));
        }
        private double CalcDragVelocityLoss(double airDensity, double velocity, double baseArea, double mass, double time)
        { //Calculate the velocity loss due to drag over a given time period
            double dragForce = 0.5 * airDensity * velocity * velocity * DragCoefficient * baseArea;
            return (dragForce / mass) * time;
        }
        private double CalcGravityVelocityLoss(double fieldStrength, double time)
        { //Calculate the velocity loss due to gravity over a given time period
            return fieldStrength * time;
        }
        private double CalcKE(double mass, double velocity)
        { //Calculate the kinetic energy at the rockets apogee
            return 0.5*mass*velocity*velocity;
        }
        private double CalcPE(double altitude, double spacecraftMass)
        { //Calculate the potential energy at the rockets apogee
            return -AstroConstants.Mass*spacecraftMass/(AstroConstants.Radius + altitude);
        }
        private double CalcDistanceTravelled(double intialVelocity, double finalVeloity, double time) 
        {
            double distance = (intialVelocity + finalVeloity) / 2 * time; //SUVAT equation (Rocket starts from rest)
            return distance; //Achievable maximum altitude of the rocket when all velocity is going into the vertical component
        }
        private double CalcOrbitalYComponent()
        { //Estimate the maximum Y distance the rocket could achieve in an orbital mission
            double distance = this.maxAltitude * 0.60; 
            return distance;
        }
        private double CalcOrbitalXComponent()
        { //Estimate the maximum X distance the rocket could achieve in an orbital mission
            double distance = this.maxAltitude * 0.40;
            return distance;
        }
        private double CalcSuborbitalYComponent()
        { //Estimate the maximum Y distance the rocket could achieve in a suborbital mission
            double distance = this.maxAltitude * 0.95;
            return distance;
        }
        private double CalcSuborbitalXComponent()
        { //Estimate the maximum X distance the rocket could achieve in a suborbital mission
            double distance = this.maxAltitude * 0.05;
            return distance;
        }
        public bool MissionAltitudeSuccess(bool orbital, double altitude)
        { //Check if the rocket has achieved the required altitude for the mission:
            bool missionSuccess = false;
            if (orbital == true && this.orbitalComponents["Y"] >= altitude)
            {
                missionSuccess = true;
            }
            else if (orbital == false && this.orbitalComponents["Y"] >= altitude)
            {
                missionSuccess = true;
            } 
            return missionSuccess;
        }
        public bool MissionCrewedSuccess(bool crewed)
        { //Check if the rocket has achieved the required crewed status for the mission:
            bool missionSuccess = false;
            if (crewed == true && payload.Crewed == true)
            {
                missionSuccess = true;
            }
            else if (crewed == false && payload.Crewed == false)
            {
                missionSuccess = true;
            } else
            {
                missionSuccess = false;
            }
            return missionSuccess;
        }
        public double ThrustToWeightRatio()
        { //Calculate the thrust to weight ratio of the rocket:
            double thrust = stages[0].TotalThrust();
            double rocketWeight = CalcTotalWetMass() * AstroConstants.Gravity;
            return thrust / rocketWeight;
        }
        public void AddStage(FuelTank defaultFuelTank, Engine defaultEngine, int numOfEngines)
        { //Add a new stage to the rocket:
            stages.Add(new Stage(defaultFuelTank, defaultEngine, stages.Count(), numOfEngines));
        }
        public bool RemoveStage(int selectedStage)
        { //Remove a stage from the rocket and validate that there is a stage to remove :
            if (selectedStage < 0)
            {
               return false;
            }
            else
            {
               stages.RemoveAt(selectedStage);
               return true;
            }
        }
        public double StageSizeRestraint(int selectedStage)
        { //Calculate the size restraint of a stage based on the diameter of the connecting stage:
            double sizeRestraint = 0;
            if (selectedStage == 0 && stages.Count == 1)
            {
                sizeRestraint = 0; //No connected stage, so no size restraint
            }
            else if (selectedStage == 0)
            {
                sizeRestraint = stages[1].FuelTank.Diameter;

            }
            else if (selectedStage == 1)
            {
                sizeRestraint = stages[0].FuelTank.Diameter;

            }
            return sizeRestraint;
        }
        public bool UpdatePayload(Payload newPayload)
        { //Update the payload of the rocket and validate that the payload can fit on the rocket:
            bool payloadUpdated = false;
            int numOfStages = stages.Count();
            double fuelTankDiameter = stages[stages.Count-1].FuelTank.Diameter;

             if (fuelTankDiameter >= newPayload.Diameter)
           {
               payload = newPayload;
               payloadUpdated = true;
           }
            return payloadUpdated;
        }
    }
}
