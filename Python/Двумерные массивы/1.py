a = int(input("Количество строк в матрице: "))
print("ВВОДИТЕ ЧИСЛА ЧЕРЕЗ ПРОБЕЛ! ПОСЛЕ ПЕРЕНОСА СТРОКИ ВВОДИТСЯ СТЕЛУЮЩАЯ СТРОКА МАТРИЦЫ!")
mas = []
for i in range(a): 
    mas.append(list(map(int, input().split())))
min = mas[0][0]
max = mas[0][0]
miniD1 = 0
miniD2 = 0
maxiD1 = 0
maxiD2 = 0
for i in range(len(mas)):
    for b in range(len(mas[i])):
        if(mas[i][b] > max):
            max = mas[i][b]
            maxiD1 = i
            maxiD2 = b
        if(mas[i][b] < min):
            min = mas[i][b]
            miniD1 = i
            miniD2 = b
print(max, "Индексы:", maxiD1, maxiD2)
print(min, "Индексы:", miniD1, miniD2)