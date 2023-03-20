using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Creator
    {
        public abstract ITransport FactoryMethod();
        public void SomeOperation(double distance)
        {
            var product = FactoryMethod();

            product.deliver(distance);
        }
    }
    class ShipCreator : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }
    class TruckCreactor : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new Truck();
        }
    }
    interface ITransport
    {
        void deliver(double distrance);
        double calculateFuel(double distance);
        double calculateShip();
        double calculateDistance(double distance);
    }
    class Ship : ITransport
    {
        public double calculateDistance(double distance)
        {
            return distance * calculateShip();
        }

        public double calculateFuel(double distance)
        {
            return calculateDistance(distance) * 1.5;
        }

        public double calculateShip()
        {
            return 3.5;
        }

        public void deliver(double distrance)
        {
            Console.WriteLine("Ship delivery wiil be:");
            Console.WriteLine("Distance price - " + calculateDistance(distrance));
            Console.WriteLine("Fuel price - " + calculateFuel(distrance));
            Console.WriteLine("Ship price - " + calculateShip() * distrance);
        }
    }
    class Truck : ITransport
    {
        public double calculateDistance(double distance)
        {
            return distance * calculateShip();
        }

        public double calculateFuel(double distance)
        {
            return calculateDistance(distance) * 1.1;
        }

        public double calculateShip()
        {
            return 1.3;
        }

        public void deliver(double distrance)
        {
            Console.WriteLine("Truck delivery wiil be:");
            Console.WriteLine("Distance price - " + calculateDistance(distrance));
            Console.WriteLine("Fuel price - " + calculateFuel(distrance));
            Console.WriteLine("Ship price - " + calculateShip() * distrance);
        }
    }
}
