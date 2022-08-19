using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird = new Bird()
            {
                Name = "Larry Bird",
                Age = 4,
                NumberOfEyes = 2,
                IsMale = true,
                CanFly = true,
                LikesFish = false,
                Noise = "CAW CAW"
            };
            bird.DisplayCharacteristics(bird);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reptile = new Reptile()
            {
                Name = "Godzilla",
                Age = 8000000,
                NumberOfEyes = 12,
                IsMale = false,
                NumberOfLegs = 1,
                IsScaly = true,
                NeedsHeatLamp = true,
                NoiseYouMakeWhenYouSeeIt = "agh help its godzilla"
            };
            reptile.DisplayCharacteristics(reptile);

            var animal = new Animal()
            {
                Name = "Joel",
                Age = 24,
                NumberOfEyes = 2,
                IsMale = true,
            };
            animal.DisplayCharacteristics(animal);
        }
    }
}
