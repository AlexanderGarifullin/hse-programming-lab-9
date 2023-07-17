using System;

namespace task9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Diapason diapason = new Diapason(10.32, 42.24); // Создание демонстрационного объекта типа Diapason
            diapason.ShowDiapason(); // Вывод данных о начале и конце диапазона
            Console.WriteLine((int)diapason); // Демонстрация явного приведения типа 
            Console.WriteLine(diapason); // Демонстрация неявного приведения типа 
            Console.WriteLine(diapason++); // Демонстрация увеличения координат дипапазна на 1
            diapason.ShowDiapason(); // Вывод данных о начале и конце диапазона
            Console.WriteLine(diapason+4); // Демонстрация увеличения координат дипапазна на целое число
            diapason.ShowDiapason(); // Вывод данных о начале и конце диапазона
            Console.WriteLine(!diapason); // Демонстрация счета длины диапазона
            Console.WriteLine(diapason.GetInRange(15)); // Демонстрация проверки попадания числа в диапазон
        }
    }
}
