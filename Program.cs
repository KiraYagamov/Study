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
            Console.WriteLine("0. Закрыть программу");
            Console.WriteLine("1. Периметр прямоугольника");
            Console.WriteLine("2. Площадь трапеции");
            Console.WriteLine("3. Длина окружности и площадь круга");
            Console.WriteLine("4. Среднее арифметическое и геометрическое");
            Console.WriteLine("5. Про цену пироженного");
            Console.WriteLine("6. Разница времени в секундах");
            Console.WriteLine("7. Длины векторов");
            Console.WriteLine("8. Квадратное уравнение");
            Console.WriteLine("9. Периметр и площадь треугольника");
            Console.WriteLine("10. Математические операции с числами");
            Console.WriteLine("11. Определение вида треугольника");
            numOfProgram = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(numOfProgram){
                case 0:
                    Environment.Exit(0);
                    break;
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
                    Program8();
                    break;
                case 9:
                    Program9();
                    break;
                case 10:
                    Program10();
                    break;
                case 11:
                    Program11();
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
        public void Program8()
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("Введите значения a, b и с через пробел: ");
            string text = Console.ReadLine();
            string[] phrases = text.Split(" ");
            a = double.Parse(phrases[0]);
            b = double.Parse(phrases[1]);
            c = double.Parse(phrases[2]);
            Console.WriteLine("Уравнение: " + a + "x^2 + " + b + "x + " + c + " = 0");

            d = Math.Pow(b, 2) - 4 * a * c;
            if(a != 0 && b != 0){
                if(d > 0){
                    x1 = (-b - Math.Pow(d, 0.5))/(2*a);
                    x2 = (-b + Math.Pow(d, 0.5))/(2*a);
                    Console.WriteLine("Корни: " + x1 + ", " + x2);
                }
                else if(d == 0){
                    x1 = -b/(2*a);
                    Console.WriteLine("Корень: " + x1);
                }
                else if(d < 0){
                    Console.WriteLine("Корней нет!");
                }
            }
            else if(a == 0 && b != 0){
                x1 = (-c/b);
                Console.WriteLine("Корень: " + x1);
            }
            else if(a != 0 && b == 0){
                if(c > 0){
                	if(a < 0){
                		x1 = Math.Pow(-(c/a), 0.5);
                		Console.WriteLine("Корни: ±" + x1);
                	}
                	else{
                		 Console.WriteLine("Корней нет");
                	}
                }
                else if(c < 0){
                    if (a > 0){
                		x1 = Math.Pow(-(c/a), 0.5);
                		Console.WriteLine("Корни: ±" + x1);
                	}
                	else{
                		 Console.WriteLine("Корней нет");
                	}
                }
            }
            else if(a == 0 && b == 0){
                Console.WriteLine("Уравнение не имеет смысла");
            }
            Console.WriteLine();
            ChangeProgram();
        }
        void Program9(){
            double a, b, c, p, s, max, min, middle;
            Console.WriteLine("Введите значения сторон через пробел: ");
            string text = Console.ReadLine();
            string[] phrases = text.Split(" ");
            bool canToBe;
            a = double.Parse(phrases[0]);
            b = double.Parse(phrases[1]);
            c = double.Parse(phrases[2]);
            middle = 0;
            max = Math.Max(a, Math.Max(b, c));
            min = Math.Min(a, Math.Min(b, c));
            if(a > min && a < max){middle = a;}
            else if(b > min && b < max){middle = b;}
            else if(c > min && c < max){middle = c;}
            else{
                if(a == max && b == max || b == max && c == max || a == max && c == max){
                    middle = max;
                }
                else if(a == min && b == min || b == min && c == min || a == min && c == min){

                }
            }
            if((min + middle) > max){canToBe = true;}
            else{canToBe = false;}
            if(canToBe){
                p = a+b+c;
                s = Math.Pow(((p/2) * ((p/2)-a) * ((p/2)-b) * ((p/2)-b)), 0.5f);
                Console.WriteLine("Периметр: " + p + " Площадь: " + s);
            }
            else{
                Console.WriteLine("Такого треугольника не существует!");
            }
            Console.WriteLine();
            ChangeProgram();
        }
        void Program10(){
            double x, y, z;
            Console.WriteLine("Введите 3 числа через пробел: ");
            string text = Console.ReadLine();
            string[] phrases = text.Split(" ");
            x = double.Parse(phrases[0]);
            y = double.Parse(phrases[1]);
            z = double.Parse(phrases[2]);
            Console.WriteLine("а) " + (Math.Max((x+y+z), x*y*z)+3) + " б) " + ((Math.Min((Math.Pow(x, 2) + Math.Pow(y, 2)), (Math.Pow(y, 2) + Math.Pow(z, 2))))-4));
            Console.WriteLine();
            ChangeProgram();
        }
        void Program11(){
            double a, b, c, p, s, max, min, middle;
            Console.WriteLine("Введите значения сторон через пробел: ");
            string text = Console.ReadLine();
            string[] phrases = text.Split(" ");
            bool canToBe;
            a = double.Parse(phrases[0]);
            b = double.Parse(phrases[1]);
            c = double.Parse(phrases[2]);
            middle = 0;
            max = Math.Max(a, Math.Max(b, c));
            min = Math.Min(a, Math.Min(b, c));
            if(a > min && a < max){middle = a;}
            else if(b > min && b < max){middle = b;}
            else if(c > min && c < max){middle = c;}
            else{
                if(a == max && b == max || b == max && c == max || a == max && c == max){
                    middle = max;
                }
                else if(a == min && b == min || b == min && c == min || a == min && c == min){

                }
            }
            if((min + middle) > max){canToBe = true;}
            else{canToBe = false;}
            if(canToBe){
                if(Math.Pow(min, 2) + Math.Pow(middle, 2) == Math.Pow(max, 2)){Console.WriteLine("Прямоугольный треугольник!");}
                else if(Math.Pow(min, 2) + Math.Pow(middle, 2) < Math.Pow(max, 2)){Console.WriteLine("Тупоугольный треугольник!");}
                else if(Math.Pow(min, 2) + Math.Pow(middle, 2) > Math.Pow(max, 2)){Console.WriteLine("Остроугольный треугольник!");}
            }
            else{
                Console.WriteLine("Такого треугольника не существует!");
            }
            Console.WriteLine();
            ChangeProgram();
        }
    }
}
