using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>(); 

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                int speed = int.Parse(carData[1]);
                int power = int.Parse(carData[2]);
                int weight = int.Parse(carData[3]);
                string cargoType = carData[4];

                double tire1Pressure = double.Parse(carData[5]);
                int tire1Age = int.Parse(carData[6]);

                double tire2Pressure = double.Parse(carData[7]);
                int tire2Age = int.Parse(carData[8]);

                double tire3Pressure = double.Parse(carData[9]);
                int tire3Age = int.Parse(carData[10]);

                double tire4Pressure = double.Parse(carData[11]);
                int tire4Age = int.Parse(carData[12]);

                Tire[] currTires = new Tire[4]
                {
                     new Tire( tire1Age,tire1Pressure ),
                     new Tire(tire2Age, tire2Pressure ),
                     new Tire(tire3Age, tire3Pressure),
                     new Tire(tire4Age,tire4Pressure )
                };

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(cargoType, weight);

                Car car = new Car(model, engine, cargo, currTires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var fragileCars = cars
                    .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.TirePressure < 1) )
                    .ToList();

                foreach (Car car in fragileCars)
                {
                    Console.WriteLine($"{car.Model}");
                }

            }
            else if (command == "flamable" )
            {
                var flammableCars = cars.Where(c => c.Cargo.CargoType == "flamable" &&                                                                             c.Engine.EnginePower > 250)
                                        .ToList();


                foreach (Car car in flammableCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
