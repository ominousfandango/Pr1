using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_4
{
    class Car
    {
        public double maxSpeed;

        public Car()
        {

        }

        public string Name { get; set; }
        public Car(String name)
        {
            Name = name;

        }

        public Car(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }

        static void Main()
        {
            Car car_1 = new Car
            {
                Name = "Rimac Concept Two ",
                maxSpeed = 415
            };


            Console.WriteLine(car_1.Name + " пройдет 100км за " + car_1.maxSpeed);
            Car car_2 = new Car
            {
                Name = "Hennessey Venom F5",
                maxSpeed = 484
            };
            Console.WriteLine(car_2.Name + " пройдет 100км за " + car_2.maxSpeed);
            Car car_3 = new Car
            {
                Name = "Koenigsegg Agera RS",
                maxSpeed = 445
            };

            Console.WriteLine(car_3.Name + " пройдет 100км за " + car_3.maxSpeed);
            Car car_4 = new Car
            {
                Name = "SSC Tuatara",
                maxSpeed = 443
            };
            Console.WriteLine(car_4.Name + " пройдет 100км за " + car_4.maxSpeed);

            Console.ReadKey(true);
        }
    }
}
