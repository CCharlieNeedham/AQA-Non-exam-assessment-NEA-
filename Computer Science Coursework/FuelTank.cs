using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    internal class FuelTank : Component
    {
        const double costPerMetreSquared = 150; //£
        const double materialDensity = 7850; //kg/m^2

        //Fields of FuelTank class:
        private double radius; //m
        private double volume; //m^3
        private double surfaceArea; //m^2
        private double baseArea; //m^2
        private double circumference; //m

        //Public accessors for private fields:
        public double Volume
        {
             get {return volume;} 
        }
        public double Cost
        {
            get { return cost; }
        }
        public double BaseArea
        {
            get { return baseArea; }
        }

        public FuelTank(string name, double height, double diameter, string textureFileName) : base(name, height, diameter, textureFileName)
        {
            //Initialise fuel tank properties:
            this.radius = CalcRadius(diameter);
            this.circumference = CalcCircumference();
            this.baseArea = CalcBaseArea();
            this.volume = CalcVolume();
            this.surfaceArea = CalcSurfaceArea();
            this.cost = CalcCost();
            this.mass = CalcMass();
        }
        //Calculate fuel tank properties:
        private double CalcRadius(double diameter)
        {
            return diameter / 2;
        }
        private double CalcCircumference()
        {
            return diameter * Math.PI;
        }
        private double CalcBaseArea()
        {
            return radius * radius * Math.PI;
        }
        private double CalcVolume()
        {
            return baseArea * height;
        }
        private double CalcSurfaceArea()
        {
            return (baseArea * 2) + (circumference * height);
        }
        private double CalcCost()
        {
            return surfaceArea * costPerMetreSquared;
        }
        private double CalcMass()
        {
            return surfaceArea * materialDensity * 0.005;
        }

        public override string description() //Returns a string with the engine's properties
        {
            return ("Size: " + diameter.ToString("N0") + "x" + height.ToString("N0") + "Metres \nMass: " + mass.ToString("N0") + "kg \nCost: £" + cost.ToString("N0") + "\n Volume: " + volume.ToString("N0") + "m^3");
        }
    }


}
