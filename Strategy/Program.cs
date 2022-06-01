using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
        }
    }

    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
    class Car
    {
        public IMovable Movable { private get; set; }

        public Car(IMovable mov)
        {
            Movable = mov;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
