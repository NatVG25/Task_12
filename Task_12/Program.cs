using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{

    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных данных с консоли
            Console.WriteLine("Введите значение радиуса окружности:R");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату центра окружности X0:");
            double x0 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату центра окружности Y0:");
            double y0 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату точки X:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату точки Y:");
            double y = Double.Parse(Console.ReadLine());

            if (r > 0) //проверка условия, что значение радиуса положительное
            {
                Circle.Length(r); //обращение к методу вычисления длины окружности
                Circle.Area(r);  //обращение к методу вычисления площади круга
                Circle.Point(r, x, x0, y, y0); //обращение к методу проверки точки
            }
            else
            {
                Console.WriteLine("Радиус не может быть отрицательным");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
    public static class Circle //статический класс окружность
    {
        public static double Length(double r) //метод вычисления длины окружности
        {
            // Вычисление длины окруности
            double P = 2 * Math.PI * r;
            return P;
        }

        public static double Area(double r) //метод вычисления площади круга
        {
            // Вычисление площади круга
            double S = Math.PI * r * r;
            return S;
        }

        private static bool point;
        public static bool Point(double r, double x, double x0, double y, double y0) //метод для проверки точки внутри круга
        {
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= r * r)
            {
                Console.WriteLine("Точка A с координатами x = {0:f2} и y = {1:f2} принадлежит кругу с радиусом {2}", x, y, r);
            }

            else
            {
                Console.WriteLine("Точка A с координатами x = {0:f2} и y = {1:f2}  НЕ принадлежит кругу с радиусом {2}", x, y, r);
            }
            return point;
        }
    }
}
