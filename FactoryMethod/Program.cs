using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            Creator[] arr = new Creator[5];
            for (int i = 0; i < arr.Length; i++)
            {
                if(random.Next(0,2) == 1)
                {
                    arr[i] = new TruckCreactor();
                }
                else
                {
                    arr[i] = new ShipCreator();
                }
                arr[i].SomeOperation(random.Next(10,30));
                Console.WriteLine();
            }
           
        }
    }
}
