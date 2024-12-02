using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductoConsumidor
{
  public class Cola<T>
    {
        private int capacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockOjeto = new object();

        public Cola(int capacidad)
        {
            capacidadMaxima= capacidad;
        }

        public void Agregaar (T item)
        {
            lock (lockOjeto) 
            {
                while (cola.Count >= capacidadMaxima) 
                {
                    Monitor.Wait(lockOjeto);
                }
                cola.Enqueue (item);
                Monitor.Pulse(lockOjeto);
            }
        }

       public T Extraer()
        {
            lock (lockOjeto)
            {
                while (cola.Count == 0) 
                {
                    Monitor.Wait(lockOjeto);
                }
                T item =cola.Dequeue();
                Monitor.Pulse(lockOjeto);
                return item;
            }
          
        }
    }
}
