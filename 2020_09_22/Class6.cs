using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    interface IRunnable2
    {
        void Run();
    }

    interface IFlyable2
    {
        void Fly();
    }

    abstract class Fly
    {
        public abstract void CFly();
    }

    class Flyingbike2 : Fly, IRunnable2
    {
        public override void CFly()
        {
            Console.WriteLine("Bike Fly");
        }

        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }

    class FlyingCar2 : Fly, IRunnable2
    {
        public override void CFly()
        {
            Console.WriteLine("Car Fly");
        }

        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Class6
    {
        static void Main()
        {
            Flyingbike2 bike = new Flyingbike2();
            FlyingCar2 car = new FlyingCar2();

            car.CFly();
            car.Run();

            bike.CFly();
            bike.Run();

            Flying(car);
            Flying(bike);

            Fly[] arr = new Fly[3];

            arr[0] = new FlyingCar2();
            arr[1] = new Flyingbike2();
            arr[2] = new Flyingbike2();

            foreach(Fly temp in arr)
            {
                temp.CFly();
            }
        }

        static void Flying(Fly fly)
        {
            fly.CFly();
        }
    }
}
