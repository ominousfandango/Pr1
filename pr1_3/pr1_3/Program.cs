using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_3
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
                Name = "Шевроле Камаро",
                maxSpeed = 180
            };

            Console.WriteLine(car_1.Name + " пройдет 100км за " + car_1.maxSpeed);
            Car car_2 = new Car
            {
                Name = "Лада Гранта",
                maxSpeed = 200
            };
            Console.WriteLine(car_2.Name + " пройдет 100км за " + car_2.maxSpeed);

            Console.ReadKey(true);
        }
    }
}
