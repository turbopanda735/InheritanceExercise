using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public int NumberOfWings = 2;
        public bool CanFly { get; set; }
        public bool LikesFish { get; set; }
        public string Noise { get; set; }
        public void DisplayCharacteristics(Bird bird)
        {
            DisplayCharacteristics();
            string fly;
            if (CanFly == true)
                fly = "can";
            else fly = "cant";
            string fish;
            if (LikesFish == true)
                fish = "loves";
            else fish = "hates";
            Console.WriteLine($"this BIRD has {NumberOfWings} wings. It {fly} fly. It {fish} fish. It goes {Noise}");
        }
    }
}
