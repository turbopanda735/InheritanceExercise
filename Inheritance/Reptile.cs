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
            DisplayCharacteristics();
            string scaly;
            if (IsScaly == true)
                scaly = "it is";
            else scaly = "it is not";
            string heat;
            if (NeedsHeatLamp == true)
                heat = "loves";
            else heat = "hates";
            Console.WriteLine($"this REPTILE has {NumberOfLegs} legs. {scaly} scaly. It {heat} heat lamps. when you see it you go '{NoiseYouMakeWhenYouSeeIt}!'");
        }
    }
}
