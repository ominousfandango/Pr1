using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        public double maxSpeed;

        public Car( double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        
        static void Main()
        {
            double distance = 100;
            Car camaro = new Car( 250 );
            double camaroTime = camaro.CalculateTime(distance);
            Console.WriteLine($"Шевроле Камаро пройдет 100 км за { camaroTime }");
            Car granta = new Car( 184 );
            double grantaTime = granta.CalculateTime(distance);
            Console.WriteLine($"Лада Гранта пройдет 100 км за { grantaTime }");

            Console.ReadKey( true );
        }

    }
}
