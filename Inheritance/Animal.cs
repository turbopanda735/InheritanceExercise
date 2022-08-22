using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfEyes { get; set; }
        public bool IsMale { get; set; }
        public void DisplayCharacteristics()
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
        }
    }
}
