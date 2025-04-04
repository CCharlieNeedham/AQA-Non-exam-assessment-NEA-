using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    internal class Engine : Component
    {
        //Fields of Engine class:
        private double thrust; //N
        private double massFlow; //kg/s
        private FuelType fuelType; 
        private double fuelRatio; //Oxidizer to fuel ratio (LOX:1)

        //Public accessors for private fields:
        public FuelType FuelType
        {
            get { return fuelType; }
        }
        public double MassFlow
        {
            get { return massFlow; }
        }
        public double FuelRatio
        {
            get { return fuelRatio; }
        }
        public double Thrust
        {
            get { return thrust; }
        }
        public double Cost
        {
            get { return cost; }
        }
        public Engine(double thrust, double massFlow, FuelType fuelType, string name, int height, int diameter, string textureFileName, double mass, double cost, double fuelRatio) : base(name, height, diameter, textureFileName)
        {
            //Initialise engine properties:
            this.thrust = thrust;
            this.massFlow = massFlow;
            this.fuelType = fuelType;
            this.cost = cost;
            this.mass = mass;
            this.textureFileName = textureFileName;
            this.fuelRatio = fuelRatio;
        }

        public override string Description() //Returns a string with the engine's properties
        {
            return ("Size: " + diameter.ToString("N0") + "x" + height.ToString("N0") + "Metres \nMass: " + mass.ToString("N0") + "kg \nCost: £" + cost.ToString("N0") + "\n Fuel Type: " + fuelType + "\n Thrust: " + thrust);
        }
     
    }
}
