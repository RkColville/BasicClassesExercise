using System;

namespace BasicClasses_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Tesla";
            car1.Model = "CyberTruck";
            car1.Year = 2021;
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);
        }
    }
}
