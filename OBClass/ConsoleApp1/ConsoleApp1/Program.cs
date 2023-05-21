using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OBClass
{
    class Mass<T>
    {
        T[] mas;
        public Mass()
        {
            mas = new T[0];
        }
        public void Add(T it)
        {
            T[] newMas = new T[mas.Length + 1];
            for (int i = 0; i < mas.Length; i++)
            {
                newMas[i] = mas[i];
            }
            newMas[mas.Length] = it;
            mas = newMas;
        }
        public void Remove(T it)
        {
            int ind = -1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Equals(it))
                {
                    ind = i;
                    break;
                }

            }
            if (ind > -1)
            {
                T[] newMas = new T[mas.Length + 1];
                for (int i = 0, j = 0; i < mas.Length; i++)
                {
                    if (i == ind) continue;
                    newMas[j] = mas[i];
                    j++;
                }
                mas = newMas;
            }
        }
        public T GetItem(int ind)
        {
            if (ind > -1 && ind < mas.Length)
            {
                return mas[ind];
            }
            else
                throw new IndexOutOfRangeException();
        }
        public int Count()
        {
            return mas.Length;
        }
    }
    public class Run
    {
        static void Main()
        {
            Mass<string> n = new Mass<string>();
            n.Add("aa");
            n.Add("bb");
            n.Add("cc");

            n.Remove("qq");
            n.Remove("aa");



            for (int i = 0; i < n.Count(); i++)
            {
                Console.WriteLine(n.GetItem(i));
            }
        }
    }
}
