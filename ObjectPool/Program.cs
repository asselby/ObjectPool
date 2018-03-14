using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Pool<Taxi> poolTaxi = new Pool<Taxi>(new Taxi(), 5);
            Console.WriteLine(poolTaxi.objectList.Count);
            var tax = poolTaxi.GetObject();
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.GetObject();
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.GetObject();
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.GetObject();
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.GetObject();
            poolTaxi.ReturnObject(tax);
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.ReturnObject(tax);
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.ReturnObject(tax);
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.ReturnObject(tax);
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.ReturnObject(tax);
            Console.WriteLine(poolTaxi.objectList.Count);
            poolTaxi.ReturnObject(tax);
            Console.WriteLine(poolTaxi.objectList.Count);
            Console.ReadLine();

        }
    }
}
