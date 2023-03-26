using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_2
{
    class Car
    {

        public Car( )
        {
            
        }

        public string Name { get; set; }
        public Car(String name)
        {
            Name = name;

        }

        static void Main()
        {
            Car car_1 = new Car { 
            Name = "Шевроле Камаро",
        };

            Console.WriteLine( car_1.Name) ;
            
            Car car_2 = new Car {
            Name = "Лада Гранта"
            };
            Console.Write(car_2.Name);

            Console.ReadKey(true);
        }
    }
}