using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Player {0}: What The Hello World?", i + 1);
            }

            SportsCar car = new SportsCar();
            var carName = car.GetPetName();
            Console.WriteLine("My car's name is {0}.", carName);
        }
    }
}
