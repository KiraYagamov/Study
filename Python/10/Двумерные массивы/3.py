a = int(input("Количество строк в матрице: "))
print("ВВОДИТЕ ЧИСЛА ЧЕРЕЗ ПРОБЕЛ! ПОСЛЕ ПЕРЕНОСА СТРОКИ ВВОДИТСЯ СЛЕДУЮЩАЯ СТРОКА МАТРИЦЫ!")
mas = []
for i in range(a): 
    mas.append(list(map(int, input().split())))
sum = 0
maxSum = 0
id = 0
for i in range(len(mas)):
    sum = 0
    for b in range(len(mas[i])):
        sum += mas[i][b]
    if(i == 0):
        maxSum = sum
        id = 0
    if(sum > maxSum):
        maxSum = sum
        id = i
print(mas[id])