int NOD(int f, int s){
    int max;
    if(f>s) max = f;
    else max = s;
    for(int i = max; i > 0; i--){if(f%i == 0 && s%i == 0){return i;}}
    return 1;
}
Console.WriteLine("Введите 2 числа: ");
Console.WriteLine("НОД: " + NOD(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));