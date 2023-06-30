using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}

	public Car(int year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
		{
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
			IsDriveable = isDriveable;
        }
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public string IsDriveable { get; set; }

		public void MakeEngineNoise(string EngineNoise)
		{
			Console.WriteLine($"The {Year} {Make} {Model} engine makes a {EngineNoise} noise.");
		}

		public void MakeHonkNoise(string HonkNoise)
		{
			Console.WriteLine($"The {Year} { Make} {Model} horn makes a {HonkNoise} noise.");
		}
	}
}