using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Now that the Car class is created we can instanciate 3 new cars
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            //Set the properties for each of the cars
            car1.Year = 1993;
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.EngineNoise = "Soft";
            car1.HonkNoise = "Noraml";
            car1.IsDriveable = "Yes";

            car2.Year = 2005;
            car2.Make = "Toyota";
            car2.Model = "Tundra";
            car2.EngineNoise = "Loud";
            car2.HonkNoise = "Loud";
            car2.IsDriveable = "Yes";

            car3.Year = 1995;
            car3.Make = "Buick";
            car3.Model = "Lesabre";
            car3.EngineNoise = "Average";
            car3.HonkNoise = "Squeaky";
            car3.IsDriveable = "No";

            //Call each of the methods for each car
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

                // Set the properties utilizing the 3 different ways we learned about, one way for each car
                //dot notation
                car1.Year = 1993;
                car1.Make = "Honda";
                car1.Model = "Civic";
                car1.EngineNoise = "Soft";
                car1.HonkNoise = "Normal";
                car1.IsDriveable = "Yes";

                //Object Initializer Syntax
                Car car4 = new Car()
                {
                 Year = 2005,
                 Make = "Toyota",
                 Model = "Tundra",
                 EngineNoise = "Loud",
                 HonkNoise = "Loud",
                 IsDriveable = "Yes",

                };

            //Custom Constructor
            Car car5 = new Car(2019, "Ford", "Explorer", "Loud", "Normal", "No");
                //*************BONUS X 2*************//

                //Create a CarLot class
                //It should have at least one property: a List of cars
                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
