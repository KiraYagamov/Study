# Создание массива
y = int(input("Количество строк: "))
x = int(input("Количество столбцов: "))
mas = []
for i in range(y):
    mas.append([0] * x)
# Значения для перемещения точки
posX = 0
posY = 0
horizontal = 0
vertical = 0
num = 1
mas[0][0] = 1
# Перемещение точки
# По спирали
def Spiral():
    global mas, posX, posY, horizontal, vertical, num, y, x
    horizontal = 1
    vertical = 0
    while(num <= x*y-1):
        # Вправо
        while(horizontal == 1 and vertical == 0):
            posX += 1
            if(posX <= x-1):
                if(mas[posY][posX] == 0):
                    num += 1
                    mas[posY][posX] = num
                else:
                    posX -= 1
                    horizontal = 0
                    vertical = 1
            else:
                posX -= 1
                horizontal = 0
                vertical = 1
        # Вниз
        while(horizontal == 0 and vertical == 1):
            posY += 1
            if(posY <= y-1):
                if(mas[posY][posX] == 0):
                    num += 1
                    mas[posY][posX] = num
                else:
                    posY -= 1
                    horizontal = -1
                    vertical = 0
            else:
                posY -= 1
                horizontal = -1
                vertical = 0
        # Влево
        while(horizontal == -1 and vertical == 0):
            posX += -1
            if(posX >= 0):
                if(mas[posY][posX] == 0):
                    num += 1
                    mas[posY][posX] = num
                else:
                    posX -= -1
                    horizontal = 0
                    vertical = -1
            else:
                posX -= -1
                horizontal = 0
                vertical = -1
        # Вверх
        while(horizontal == 0 and vertical == -1):
            posY += -1
            if(posY >= 0):
                if(mas[posY][posX] == 0):
                    num += 1
                    mas[posY][posX] = num
                else:
                    posY -= -1
                    horizontal = 1
                    vertical = 0
            else:
                posY -= -1
                horizontal = 1
                vertical = 0
# По кривой
def Curve():
    global mas, posX, posY, horizontal, vertical, num, y, x
    horizontal = 0
    vertical = 1
    while(num <= x*y-1):
        # Вниз
        while(vertical == 1):
            posY += 1
            if(posY <= y-1):
                if(posX <= x-1):
                    num += 1
                    mas[posY][posX] = num
            else:
                posY -= 1
                posX += 1
                if(posX <= x-1):
                    num += 1
                    mas[posY][posX] = num
                vertical = -1
        # Вверх
        while(vertical == -1):
            posY += -1
            if(posY >= 0):
                if(posX <= x-1):
                    num += 1
                    mas[posY][posX] = num
            else:
                posY -= -1
                posX += 1
                if(posX <= x-1):
                    num += 1
                    mas[posY][posX] = num
                vertical = 1
# По кривой боком
def SideCurve():
    global mas, posX, posY, horizontal, vertical, num, y, x
    posX = 0
    posY = 0
    horizontal = -1
    vertical = 1
    num = 1
    while(num <= x*y-1):
        # Вниз влево
        while(vertical == 1 and horizontal == -1):
            posX -= 1
            posY += 1
            # Если удачная клетка
            if(posY <= y-1 and posX >= 0):
                num += 1
                mas[posY][posX] = num
            # Иначе сдвигаемся вниз или вправо
            else:
                posX -= -1
                posY += -1
                posY += 1
                if(posY <= y-1):
                    num += 1
                    mas[posY][posX] = num
                else:
                    posY -= 1
                    posX += 1
                    if(posX <= x-1):
                        num += 1
                        mas[posY][posX] = num
                vertical = -1
                horizontal = 1
        # Вверх вправо
        while(vertical == -1 and horizontal == 1):
            posX -= -1
            posY += -1
            # Если удачная клетка
            if(posY >= 0 and posX <= x-1):
                num += 1
                mas[posY][posX] = num
            # Иначе сдвигаемся вправо или вниз
            else:
                posX -= 1
                posY += 1
                posX += 1
                if(posX <= x-1):
                    num += 1
                    mas[posY][posX] = num
                else:
                    posX -= 1
                    posY += 1
                    if(posY <= y-1):
                        num += 1
                        mas[posY][posX] = num
                vertical = 1
                horizontal = -1
print("Виды узоров: \n1: Спираль \n2: Кривая \n3: Боковая кривая")
type = input("Выберите вид узора: ")
# Выбираем тип узора
if(type == "1" or type == "Спираль"):
    Spiral()
elif(type == "2" or type == "Кривая"):
    Curve()
elif(type == "3" or type == "Боковая кривая"):
    SideCurve()
# Вывод массива
for i in range(y):
    print(mas[i])