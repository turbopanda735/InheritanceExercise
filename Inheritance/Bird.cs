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
