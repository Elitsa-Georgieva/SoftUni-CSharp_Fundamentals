using System;
using System.Collections.Generic;

namespace _06.VehicleCatalogue
{
    public class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        public  int HorsePower { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] vehicleParts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = vehicleParts[0];
                string model = vehicleParts[1];
                string color = vehicleParts[2];
                int horsePower = int.Parse(vehicleParts[3]);

                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };

                vehicles.Add(vehicle);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Close the Catalogue")
                {
                    break;
                }

                //line всъщност е нашия модел, затова във функцията взимаме модел и превозни средства
                Vehicle vehicle = GetVehicleByModel(vehicles, line);

                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }

                //след като сме си открили превозното средство:
                
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.HorsePower}");


            }


            double carsHPavg = CalcAvgHorsePowerByType(vehicles, "car");
            double truckHPavg = CalcAvgHorsePowerByType(vehicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsHPavg:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckHPavg:F2}.");

        }

        private static double CalcAvgHorsePowerByType(List<Vehicle> vehicles, string type)
        {
            int typeCount = 0;
            int typeHorsePowerTotal = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    typeCount += 1;
                    typeHorsePowerTotal += vehicle.HorsePower;
                }
            }

            if (typeCount == 0)
            {
                return 0;
            }

            return (double)typeHorsePowerTotal / typeCount;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> vehicles, string model)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == model)
                {
                    return vehicle;
                }
            }
            //ако сме минали всички итерации и не сме отйрили такъв vehicle, връщаме null
            return null;
        }
    }
}
