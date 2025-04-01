using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Coursework
{
    internal abstract class Component
    {
        //Fields of every component class:
        public string name;
        protected double height; //m
        protected double diameter; //m 
        protected string textureFileName;
        protected Image textureImage;
        protected double mass; //kg
        protected double cost; //£
        protected bool textureLoaded = false;

        //Public accessors for private fields:
        public double Mass
        {
            get { return mass; }
        }
        public bool TextureLoaded
        {
            get { return textureLoaded; }
        }
        public double Height
        {
            get { return height; }
        }
        public double Diameter
        {
            get { return diameter; }
        }
        public Image TextureImage
        {
            get { return textureImage; }
        }
        public string Name
        {
            get { return name; }
        }

        public Component(string name, double height, double diameter, string textureFileName)
        {
            //Initialise component properties:
            this.name = name;
            this.height = height;
            this.diameter = diameter;
            this.textureFileName = textureFileName;
        }
        public virtual string description() //Returns a string with the component's properties
        {
            return ("Size: " + diameter.ToString("N0") + "x" + height.ToString("N0") + "Metres \nMass: " + mass.ToString("N0") + "kg \nCost: £" + cost.ToString("N0"));
        }
        public void loadTexture() //Trys to load the texture image for the component from the resources
        {
            try 
            {
                textureImage = TextureResources.ResourceManager.GetObject(textureFileName) as Bitmap;
                textureLoaded = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading texture: " + ex.Message);
                textureLoaded = false;
            }
        }
    }
}
