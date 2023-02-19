int Max(int f, int s, int t){
    int max = f;
    if(s>max) max = s;
    if(t>max) max = t;
    return max;
}
Console.WriteLine("Введите 3 числа: ");
Console.WriteLine("Максимальное из них: " + Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));