using System.Collections.Generic;
Console.Write("Введите длинну массива: ");
int count = int.Parse(Console.ReadLine());
List<int> randMas = new List<int>();
List<int> trueMas = new List<int>();
Random rnd = new Random();
int sum = 0;
for(int i = 0; i<count;i++){
    randMas.Add(rnd.Next(0, 1000000000));
}
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
for(int i = 0; i<randMas.Count; i++){
    for(int b = 0; b<(randMas[i].ToString()).Length; b++){
        sum+=int.Parse((randMas[i].ToString())[b].ToString());
    }
    if(sum == n){
        trueMas.Add(randMas[i]);
    }
    sum = 0;
}
for(int i = 0; i<trueMas.Count; i++){
    Console.WriteLine(trueMas[i]);
}