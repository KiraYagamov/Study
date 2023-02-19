int Count(string f){
    return f.Length;
}
Console.WriteLine("Введите число: ");
Console.WriteLine("Цифр в нем: " + Count(Console.ReadLine()));