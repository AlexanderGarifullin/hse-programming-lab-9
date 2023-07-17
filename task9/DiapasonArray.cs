using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class DiapasonArray
    {
        static Random rnd = new Random();
        Diapason[] arr = null;
        static int count = 0;
        public int Size
        {
            get
            {
                return arr.Length;
            }
        }
        public Diapason this[int index]
        {
            get
            {
                if (index  >= 1 && index <= arr.Length)
                    return arr[index-1];
                Console.WriteLine("Ошибка! Индекс находится за границами!");
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index  >= 1 && index <= arr.Length)
                {
                    arr[index-1] = value;
                    Console.WriteLine($"Вы поменяли {index } диапазон");
                }                      
                else
                    Console.WriteLine("Ошибка! Индекс за пределами массива! Вы ничего не поменяли!");
            }
        }
        public DiapasonArray()
        {
            arr = null;
            count++;
        }
        public DiapasonArray(int size, int limit)
        {
            arr = new Diapason[size];
            double max, min, temp;
            for (int i = 0; i < arr.Length; i++)
            {
                max = rnd.NextDouble()*limit;
                min = rnd.NextDouble()*limit;
                if (min > max)
                {
                    temp = min;
                    min = max;
                    max = temp; ;
                }  
                Diapason d = new Diapason(min, max);
                arr[i] = d;
            }
            count++;
        }
        public DiapasonArray(int size)
        {
            arr = new Diapason[size];
            double x, y;
            for (int i = 0; i < arr.Length; i++)
            {
                x = UI.Input(double.MinValue, double.MaxValue, $"Введите первую координату {i+1} диапазона");
                y = UI.Input(x, double.MaxValue, $"Введите вторую координату {i + 1} диапазона (не меньше первой координаты)");
                Diapason d = new Diapason(x, y);
                arr[i] = d;
            }
            count++;
        }
        public static int GetCount()
        {
            return count;
        }
        public  void Show()
        {
            if (arr == null)
            {
                Console.WriteLine("Пустой массив");
                return;
            }
            foreach(Diapason d in arr)
            {
                d.Show();
            }
        }
    }
}
