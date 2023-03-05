using System.Collections.Generic;
Console.Write("Введите длинну массива: ");
int count = int.Parse(Console.ReadLine());
List<int> randMas = new List<int>();
List<int> trueMas = new List<int>();
Random rnd = new Random();
int del = 0;
for(int i = 0; i<count;i++){
    randMas.Add(rnd.Next(0, 1000000));
}
for(int i = 0; i<randMas.Count; i++){
    for(int b = 1; b<randMas[i]; b++){
        if(randMas[i]%b == 0){
            del++;
        }
    }
    if(del==1){
        trueMas.Add(randMas[i]);
    }
    del = 0;
}
for(int i = 0; i<trueMas.Count; i++){
    Console.WriteLine(trueMas[i]);
}