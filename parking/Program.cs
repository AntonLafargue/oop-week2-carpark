using System;
using System.Threading;

namespace parking
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            double charge = 0;
            Car car = new Car() {Time = rnd.Next(1, 24) };
            if (car.Time < 4)
            {
                charge = 2.0f;
            }
            else
            {
                charge = (2.0 + (0.5 * (car.Time - 3)));
            }

            if (charge > 10.0)
            {
                charge = 10.0;
            }
            
            Console.Write("Car stayed " + car.Time + " hour(s) and paid " + charge + " euros.");
        }
    }
}