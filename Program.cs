using System;

namespace Study
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
        private float a, b, h, r, n;
        public int numOfProgram;
        public void ChangeProgram()
        {
            Console.WriteLine("Выберите программу из списка: ");
            Console.WriteLine("1. Периметр прямоугольника");
            Console.WriteLine("2. Площадь трапеции");
            Console.WriteLine("3. Длина окружности и площадь круга");
            Console.WriteLine("4. Среднее арифметическое и геометрическое");
            Console.WriteLine("5. Про цену пироженного");
            Console.WriteLine("6. Разница времени в секундах");
            Console.WriteLine("7. Длины векторов");
            Console.WriteLine("8. Закрыть программу");
            numOfProgram = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(numOfProgram){
                case 1:
                    Program1();
                    break;
                case 2: 
                    Program2();
                    break;
                case 3:
                    Program3();
                    break;
                case 4:
                    Program4();
                    break;
                case 5:
                    Program5();
                    break;
                case 6:
                    Program6();
                    break;
                case 7:
                    Program7();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверно заданное число!");
                    Console.WriteLine();
                    ChangeProgram();
                    break;
            }

        }
        public void Program1()
        {
            Console.Write("Введите первую сторону: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите вторую сторону: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Периметр прямоугольника равен: " + 2*(a+b));
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program2()
        {
            Console.Write("Введите первое основание: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите второе основание: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите высоту: ");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Площадь трапеции равна: " + (0.5f * (a + b) * h));
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program3()
        {
            Console.Write("Введите радиус: ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Длина окружности равна: " + (2 * Math.PI * r));
            Console.WriteLine("Площадь круга равна: " + Math.PI*(Math.Pow(r, 2)));
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program4()
        {
            Console.Write("Введите первое число: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите второе число: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое кубов этих чисел: " + ((Math.Pow(a, 3) + Math.Pow(b, 3))/2));
            if (a < 0)
            {
                a = -a;
            }
            if (b < 0)
            {
                b = -b;
            }
            Console.WriteLine("Среднее геометрическое модулей этих чисел: " + (Math.Pow(a * b, 0.5f)));
            Console.WriteLine();
            ChangeProgram();
        }
        public void Program5(){
            Console.WriteLine("Сколько рублей стоит пироженое?");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Сколько копеек стоит пироженое?");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Сколько пироженных вы хотите купить?");
            n = float.Parse(Console.ReadLine());
            Console.WriteLine();
            a = a*n;
            b = b*n;
            while(b >= 100){
                b -= 100;
                a += 1;
            }

            Console.WriteLine("Для покупки " + n + " пироженных требуется " + a + " рублей и " + b + " копеек. \n");
            ChangeProgram();
        }
        public void Program6(){
            int hour1, min1, sec1; int hour2, min2, sec2;
            Console.WriteLine("Введите значение первого момента времени в одну строку через :");
            Console.WriteLine();
            string time1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите значение второго момента времени в одну строку через :");
            Console.WriteLine();
            string time2 = Console.ReadLine();
            Console.WriteLine();
            string[] words1 = time1.Split(':');
            string[] words2 = time2.Split(':');
            hour1 = int.Parse(words1[0]); hour2 = int.Parse(words2[0]);
            min1 = int.Parse(words1[1]); min2 = int.Parse(words2[1]);
            sec1 = int.Parse(words1[2]); sec2 = int.Parse(words2[2]);

            sec1 = hour1 * 3600 + min1 * 60 + sec1;
            sec2 = hour2 * 3600 + min2 * 60 + sec2;
            Console.WriteLine("Разница составляет " + (sec2 - sec1) + " секунд. \n");
            int resHour = (sec2 - sec1)/3600;
            int resMin = ((sec2-sec1) - resHour*3600)/60;
            int resSec = ((sec2-sec1) - resHour*3600) - resMin * 60;
            Console.WriteLine("Или " + resHour + " часов " + resMin + " минут " + resSec + " секунд. \n");
            ChangeProgram();
        }
        public void Program7(){
            int x1, y1, x2, y2;
            Console.WriteLine("Введите значение координат конца первого вектора в одну строку через :"  + "\n");
            string vector1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите значение координат конца второго вектора в одну строку через :"  + "\n");
            string vector2 = Console.ReadLine();
            Console.WriteLine();
            string[] coord1 = vector1.Split(":");
            string[] coord2 = vector2.Split(":");
            x1 = int.Parse(coord1[0]); y1 = int.Parse(coord1[1]);
            x2 = int.Parse(coord2[0]); y2 = int.Parse(coord2[1]);
            Console.WriteLine("Длина первого вектора равна " + (Math.Pow(Math.Pow(x1, 2) + Math.Pow(y1, 2), 0.5f)) + "\n");
            Console.WriteLine("Длина второго вектора равна " + (Math.Pow(Math.Pow(x2, 2) + Math.Pow(y2, 2), 0.5f)) + "\n");
            ChangeProgram();
        }
    }
}
