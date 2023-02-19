int NOK(int f, int s){
    int min;
    if(f<s) min = f;
    else min = s;
    for(int i = min; i < 2147483647; i++){if(i%f == 0 && i%s == 0){return i; break;}}
    return 1;
}
Console.WriteLine("Введите 2 числа: ");
Console.WriteLine("НОК: " + NOK(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));