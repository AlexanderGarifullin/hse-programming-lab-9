using System;

namespace task9
{
    public class Diapason
    {
        static int count = 0; //  переменная для счета количества созданных объектов
        double _endRange;   //  конец диапазона

        public double StartRange { get; set; } // свойства для начала диапазона
        public double EndRange // свойствао для конца диапзаона
        {
            get => _endRange;
            set
            {
                if (value < StartRange)
                {
                    _endRange = StartRange;
                    StartRange = value;
                }
                else
                    _endRange = value;
            }
        }
        /// <summary>
        /// Конструктор класса Diapason 
        /// </summary>
        /// <param name="StartRange">Начало диапзаона</param>
        /// <param name="EndRange">Конец диапазона</param>
        public Diapason(double StartRange, double EndRange)
        {
            this.StartRange = StartRange;
            this.EndRange = EndRange;
            count++;
        }

        /// <summary>
        /// Перегруженная операция !, возвращает длину диапазона
        /// </summary>
        /// <param name="diapason">Диапазон</param>
        /// <returns></returns>
        public static double operator !(Diapason diapason)
        {
            return diapason.EndRange - diapason.StartRange;
        }

        /// <summary>
        /// Перегруженная операция ++, увеличивает координаты диапазона на 1
        /// </summary>
        /// <param name="diapason">Диапазон</param>
        /// <returns></returns>
        public static Diapason operator ++(Diapason diapason)
        {
            diapason.StartRange++;
            diapason.EndRange++;
            return diapason;
        }

        /// <summary>
        /// Перегруженная операция +, увеличивает координаты диапазона на введенное число
        /// </summary>
        /// <param name="number">Целое число, на которое увеличатся координаты диапазона</param>
        /// <param name="diapason">Диапазон</param>
        /// <returns></returns>
        public static Diapason operator +(int number, Diapason diapason)
        {
            Diapason newDiapason = new Diapason(0, 0)
            {
                StartRange = diapason.StartRange + number,
                EndRange = diapason.EndRange + number
            };
            return newDiapason;
        }

        /// <summary>
        /// Перегруженная операция +, увеличивает координаты диапазона на введенное число
        /// </summary>
        /// <param name="diapason">Диапазон</param>
        /// <param name="number">Целое число, на которое увеличатся координаты диапазона</param>
        /// <returns></returns>
        public static Diapason operator +(Diapason diapason, int number)
        {
            Diapason newDiapason = new Diapason(0, 0)
            {
                StartRange = diapason.StartRange + number,
                EndRange = diapason.EndRange + number
            };
            return newDiapason;
        }

        /// <summary>
        /// Перегруженная операция явного приведения типа int, возвращает целую часть координаты начала диапзаона
        /// </summary>
        /// <param name="diapason">Диапазон</param>
        public static explicit operator int(Diapason diapason)
        {
            return (int)diapason.StartRange;
        }

        /// <summary>
        /// Перегруженная операция неявного приведения типа double, возвращает координату конца диапазона
        /// </summary>
        /// <param name="diapason">Диапазон</param>
        public static implicit operator double(Diapason diapason)
        {
            return diapason.EndRange;
        }

        /// <summary>
        /// Метод, который определяет, попадает ли указанное число в диапазон
        /// </summary>
        /// <param name="number">Вещественное число, которое проверяют на попадание в диапазон</param>
        /// <returns></returns>
        public bool GetInRange(double number)
        {
            return (number >= StartRange && number <= EndRange);
        }

        /// <summary>
        /// Статический метод, который возвращает количество созданных объектов типа Diapason
        /// </summary>
        /// <returns></returns>
        public static int GetCount()
        {
            return count;
        }

        /// <summary>
        /// Метод, который выводит данные о диапазоне
        /// </summary>
        public void ShowDiapason()
        {
            Console.WriteLine($"Начало диапазона: {StartRange}; Конец диапазона: {EndRange}");
        }

        /// <summary>
        /// Переопределенный метод для сравнения объектов типа Diapason
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Diapason diapason = (Diapason)obj;
            return StartRange == diapason.StartRange && EndRange == diapason.EndRange;
        }
    }
}
