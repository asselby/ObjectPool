using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class Pool<T> where T : class, new()
    {
        public List<T> objectList = new List<T>();
        public Pool( T obj, int maxValue)
        {
            for (int i = 0; i < maxValue; i++)
            {
                objectList.Add(Create());
            }
        }

        public T GetObject()
        {
            if (objectList.Count == 0)
            {
                Console.WriteLine("Объектов в пуле нет");
                return null;               
            }
                var obj = objectList.First();
                objectList.Remove(obj);
                return obj;
        }

        public void ReturnObject(T obj)
        {
            if (objectList.Count < 5)
            {
                objectList.Add(obj);
            }
            else  Console.WriteLine("Невозможно добавить объект в пул"); 
        }

        public T Create()
        {
            return new T();            
        }


    }
}
