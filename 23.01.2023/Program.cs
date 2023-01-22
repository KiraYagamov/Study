﻿using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            MainProgram mp = new MainProgram();
            mp.ChangeProgram();
        }
    }
    public class MainProgram
    {
        private float a, b, h, r;
        public int numOfProgram;
        public void ChangeProgram()
        {
            Console.WriteLine("Выберите программу из списка: ");
            Console.WriteLine("1. Периметр прямоугольника");
            Console.WriteLine("2. Площадь трапеции");
            Console.WriteLine("3. Длина окружности и площадь круга");
            Console.WriteLine("4. Среднее арифметическое и геометрическое");
            Console.WriteLine("5. Закрыть программу");
            numOfProgram = int.Parse(Console.ReadLine());
            if (numOfProgram == 1)
            {
                Program1();
            }
            else if (numOfProgram == 2)
            {
                Program2();
            }
            else if (numOfProgram == 3)
            {
                Program3();
            }
            else if (numOfProgram == 4)
            {
                Program4();
            }
            else if (numOfProgram == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Неверно заданное число!");
                Console.WriteLine();
                ChangeProgram();
            }
        }
        public void Program1()
        {
            Console.Write("Введите первую сторону: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Периметр прямоугольника равен: " + a*b);
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program2()
        {
            Console.Write("Введите первое основание: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Введите второе основание: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Площадь трапеции равна: " + (0.5f * (a + b) * h));
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program3()
        {
            Console.Write("Введите радиус: ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: " + (2 * Math.PI * r));
            Console.WriteLine("Площадь круга равна: " + (Math.Pow(Math.PI*r, 2)));
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program4()
        {
            Console.Write("Введите первое число: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое кубов этих чисел: " + ((Math.Pow(a, 3) + Math.Pow(b, 3))/2));
            if (a < 0)
            {
                a = -a;
            }
            if (b < 0)
            {
                b = -1;
            }
            Console.WriteLine("Среднее геометрическое модулей этих чисел: " + (Math.Pow(a * b, 0.5f)));
            Console.WriteLine();
            ChangeProgram();
        }
    }
}
