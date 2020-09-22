using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Flyingbike : IFlyable, IRunnable
    {
        public void Fly()
            => Console.WriteLine("Bike Fly");

        public void Run()
            => Console.WriteLine("Bike Run");
    }

    class FlyingCar : IFlyable, IRunnable
    {
        public void Fly()
        {
            Console.WriteLine("Car Fly");
        }

        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }

    class Class5
    {
        static void Main()
        {
            FlyingCar car =  new FlyingCar();
            car.Fly();
            car.Run();

            Flyingbike bike = new Flyingbike();
            bike.Fly();
            bike.Run();

            Flying(car);
            Flying(bike);
            
        }
        static void Flying(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Runing(IRunnable flyable)
        {
            flyable.Run();
        }
    }
}
