    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    internal class Mission
    {
        //Fields of Mission class:
        private string name;
        private string description;
        private double altitude;
        private bool orbital;
        private bool manned;
        private double reward;

        //Public accessors for private fields:
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }
        public double Altitude
        {
            get { return altitude; }
        }
        public double Reward
        {
            get { return reward; }
        }
        public bool Orbital
        {
            get { return orbital; }
        }
        public bool Manned
        {
            get { return manned; }
        }
        public Mission(string name, string description, double altitude, bool orbital, bool manned, double reward)
        {
            this.name = name;
            this.description = description;
            this.altitude = altitude;
            this.orbital = orbital;
            this.manned = manned;
            this.reward = reward;
        }

    }
}
