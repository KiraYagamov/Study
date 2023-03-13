cep = str(input("Введите цепочку: "))
num = 0
curCount = 0
count = 0
for i in range(len(cep)):
    if(num == 0 and cep[i] == "D"):
        curCount += 1
        num+=1
    elif(num == 1 and cep[i] == "A"):
        curCount += 1
        num+=1
    elif(num == 2 and cep[i] == "F"):
        curCount += 1
        num = 0
    else:
        num = 0
        if(curCount > count):
            count = curCount
        curCount = 0
    if(i == len(cep)-1):
        if(curCount > count):
            count = curCount
print(count)