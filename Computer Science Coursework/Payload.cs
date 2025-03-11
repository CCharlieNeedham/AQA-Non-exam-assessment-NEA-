using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    internal class Payload : Component
    {
        private bool crewed;

        public double Cost
        {
            get { return cost; }
        }
        public double Mass
        {
            get { return mass; }
        }
        public bool Crewed
        {
            get { return crewed; }
        }
        public Payload(string name, int height, int diameter, string textureFileName, double mass, double cost, bool crewed) : base(name, height, diameter, textureFileName)
        {
            this.mass = mass;
            this.cost = cost;
            this.crewed = crewed;
        }

    }
    
    
}
