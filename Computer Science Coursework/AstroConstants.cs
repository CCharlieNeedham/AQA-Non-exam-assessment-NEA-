using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    static class AstroConstants
    {
        //Physical Constants:
        public const double GravitationalConstant = 6.67430e-11; //N m^2 kg^-2
        public const double DragCoefficient = 0.5; //unitless

        //Planet Constants:
        public const double Mass = 6.39e23; //kg
        public const double Radius = 3389500; //m
        public const double Gravity = 3.72; //m s^-2
        public const double StableOrbit = 250000; //m
        public const double GraphicsScalerValue = 0.0008; //Unitless
        public const double SeaLevelAirDensity = 0.02; //kg m^-3
        public const double AtmosphericHeight = 11000; //m

        //UI Constants:
        public const double Scaler = 25; //Unitless
        public const double ClippingHeight  = 1000000; //m
    }
}
