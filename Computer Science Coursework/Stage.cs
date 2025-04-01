﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    internal class Stage 
    {
        private     const double OxidizerDensity = 1041; //k/m^3

        //Fields of Stage class:
        private int numOfEngines;
        private int stageIndex; 
        private FuelTank fuelTank;
        private Engine engine;

        //Public accessors for private fields:
        public Engine Engine
        {
            get { return engine; }
        }
        public FuelTank FuelTank
        {
            get { return fuelTank; }
        }
        public int NumOfEngines
        {
            get { return numOfEngines; }
        }

        public Stage(FuelTank defaultFuelTank, Engine defaultEngine, int stageIndex, int numOfEngines)
        {
            this.numOfEngines = numOfEngines;
            this.fuelTank = defaultFuelTank;
            this.engine = defaultEngine;
            this.stageIndex = stageIndex;
        }

        public double CombinedEngineDiameter()
        {//Returns the combined diameter of all engines in the stage
            return engine.Diameter * numOfEngines;
        }
        public double GetDiameter()
        {//Returns the diameter of the stage
            return fuelTank.Diameter;
        }
        public double GetHeight()
        {//Returns the height of the stage
            return fuelTank.Height + engine.Height;
        }
        public double BurnTime()
        {//Returns the burn time of the stage
            double time = CalcFuelMass() / TotalMassFlowRate();
            return time;
        }
        public double Cost()
        {//Calculates the cost of the stage
            double enginesCost = engine.Cost * numOfEngines;
            double fuelTankCost = fuelTank.Cost;
            return enginesCost + fuelTankCost;
        }
        public double CalcWetMass()
        {//Calculates the wet mass of the stage
            return CalcDryMass() + CalcFuelMass();

        }
        public double TotalThrust()
        {//Calculates the total thrust of the stage with all engines
            return engine.Thrust * numOfEngines;
        }
        private double TotalMassFlowRate()
        {//Calculates the total mass flow rate of the stage with all engines
            return engine.MassFlow * numOfEngines;
        }
        public double CalcExhaustVelocity() //m/s
        { //Calculates the total exhaust velocity of the stage with all engines
            return TotalThrust() / TotalMassFlowRate();
        }
        private double CalcFuelMass()
        {

            int fuelDensity = (int)engine.FuelType;
            double fuelRatio = engine.FuelRatio;
            double fuelTankVolume = fuelTank.Volume;
            double oxidizerVolume = (fuelRatio / (fuelRatio + 1.0)) * fuelTankVolume;
            double fuelVolume = (1.0/ (fuelRatio + 1.0)) * fuelTankVolume;
            double fuelMass = (fuelVolume * fuelDensity) + (oxidizerVolume * OxidizerDensity);
            return fuelMass;
        }
        public double CalcDryMass()
        {//Calculates the dry mass of the stage
            return fuelTank.Mass + (engine.Mass*numOfEngines);
        }
        public bool UpdateFuelTankConfiguration(FuelTank newFuelTank, double connectingStageDiameter, int selectedStage)
        {//Updates the fuel tank configuration of the stage amd returns a boolean value depending on whether the fuel tank was updated successfully
            bool fuelTankUpdated = false;

            double newFuelTankDiameter = newFuelTank.Diameter;

            if ((selectedStage == 0 && connectingStageDiameter > newFuelTankDiameter) || (selectedStage == 1 && connectingStageDiameter < newFuelTankDiameter))
            {
                    fuelTankUpdated = false;
            } 
            else if (newFuelTankDiameter >= CombinedEngineDiameter())
            {
                fuelTank = newFuelTank;
                fuelTankUpdated = true;
            }
      
            return fuelTankUpdated;
        }
   
        public bool UpdateEngineConfiguration(Engine newEngine)
        {//Updates the engine configuration of the stage and returns a boolean value depending on whether the engine was updated successfully
            bool engineUpdated = false;

            double fuelTankDiameter = FuelTank.Diameter;
            double newEngineDiameter = newEngine.Diameter;

            double newCombinedEngineWidth = newEngineDiameter * numOfEngines;

            if (newCombinedEngineWidth <= fuelTankDiameter)
            {
                engine = newEngine;
                engineUpdated = true;
            }
            else
            {
                engineUpdated = false;
            }
            return engineUpdated;
        }

        public bool UpdateEngineConfiguration(int newNumOfEngines)
        {//Updates the engine configuration of the stage and returns a boolean value depending on whether the engine was updated successfully
            bool engineUpdated = false;

            double newEngineDiameter = Engine.Diameter;
            double fuelTankDiameter = FuelTank.Diameter;

            double newCombinedEngineWidth = newNumOfEngines * newEngineDiameter;

            if (newCombinedEngineWidth <= fuelTankDiameter)
            {
                numOfEngines = newNumOfEngines;
                engineUpdated = true;
            }
            else
            {
                engineUpdated = false;
            }
            return engineUpdated;

        }
        

    }


    
}
