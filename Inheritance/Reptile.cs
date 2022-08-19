using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public int NumberOfLegs { get; set; }
        public bool IsScaly { get; set; }
        public bool NeedsHeatLamp { get; set; }
        public string NoiseYouMakeWhenYouSeeIt { get; set; }
        public void DisplayCharacteristics(Reptile reptile)
        {

            string maleMessage;
            string maleMessage2;
            if (IsMale == true)
            {
                maleMessage = "yes";
                maleMessage2 = "is";
            }
            else
            {
                maleMessage = "no";
                maleMessage2 = "is not";
            }
            Console.WriteLine($"this animal is called {Name}. They are {Age} years old and they have {NumberOfEyes} eyes. {maleMessage}, this animal {maleMessage2} a male.");
            string scaly;
            if (IsScaly == true)
                scaly = "it is";
            else scaly = "it is not";
            string heat;
            if (NeedsHeatLamp == true)
                heat = "loves";
            else heat = "hates";
            Console.WriteLine($"this REPTILE has {NumberOfLegs} legs. It {scaly} fly. {scaly} scaly. It {heat} heat lamps. when you see it you go '{NoiseYouMakeWhenYouSeeIt}!'");
        }
    }
}
