#Открытие файла в формате *.csv для того, чтобы между символами стояла не табуляция, а ";"
file = open("09.csv", "r")
fileStrs = file.readlines()
strMas = []



#Занесение в двумерный массив всех чисел в виде строк
for i in range(len(fileStrs)):
    strMas.append(fileStrs[i].split(";"))



#Перевод всего массива в целочисленное значение, чтобы избавиться от \n в конце каждого 6 элемента массива
intMas = []
for i in range(len(strMas)):
    intLine = []
    for b in range(len(strMas[i])):
        intLine.append(int(strMas[i][b]))
    intMas.append(intLine)



#Сбор всех возможных видов чисел и их количества
numsMas = []
countOfNumsMas = []
for i in range(len(intMas)):
    for b in range(len(intMas[i])):
        num = intMas[i][b]
        have = False
        for c in range(len(numsMas)):
            if(num == numsMas[c]):
                countOfNumsMas[c]+=1
                have = True
                break
        if(not have):
            numsMas.append(num)
            countOfNumsMas.append(1)



#Поиск хороших ячеек в строках по условию задачи
countGoodStr = 0
for i in range(len(intMas)):
    goodPlace = 0
    for b in range(len(intMas[i])):
        copy = False
        for c in range(len(intMas[i])):
            if(b != c):
                if(intMas[i][b] == intMas[i][c]):
                    copy = True
                    break
        if(not copy):
            for c in range(len(numsMas)):
                if(intMas[i][b] == numsMas[c]):
                    count = countOfNumsMas[c]
                    break
            if(count == 45):
                goodPlace += 1
                break
    if(goodPlace == 1):
        countGoodStr+=1



#Вывод количества этих строк
print(countGoodStr)