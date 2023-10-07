def to_bin(num): binary = bin(num)[2:]; return binary
def to_bin_eight(num):
    binary = bin(num)[2:]
    if(len(binary) < 8):
        for i in range(8-len(binary)):
            binary = "0" + binary
    return binary
def bin_reverse(bin):
    strBin = str(bin)
    newBin = ""
    for i in strBin:
        if(i == "0"):
            newBin += "1"
        elif(i == "1"):
            newBin += "0"
    return newBin
def chet_bit(bin):
    stringBin = str(bin)
    if(stringBin.count("1") % 2 == 0):
        return "0"
    else:
        return "1"
def lastNum(num): strNum = str(num); return strNum[-1]
def to_trinary(num):
    thisNum = num
    trinaryNum = ""
    while(thisNum > 0):
        trinaryNum = str(thisNum % 3) + trinaryNum
        thisNum = thisNum // 3
    return trinaryNum
def ex1():
    for i in range(100):
        binary = to_bin(i)
        binary += chet_bit(binary)
        binary += chet_bit(binary)
        if(int(binary, 2) > 150):
            print(int(binary, 2))
            break
def ex2():
    for x in range(99, 9, -1):
        num = ""
        num += str(x%4)
        num += str(x%3)
        num += str(x%2)
        currentNum = int(num)
        if(currentNum == 101):
            print(x)
            break
def ex3():
    for i in range(100):
        ibinary = to_bin(i)
        binary = ibinary
        binary += lastNum(binary)
        binary += chet_bit(ibinary)
        binary += chet_bit(binary)
        if(int(binary, 2) > 130):
            print(int(binary, 2))
            break
def ex4():
    for i in range(256):
        binary = to_bin_eight(i)
        reversedBin = bin_reverse(binary)
        if(int(reversedBin, 2) - i == 99):
            print(i)
            break
def ex5():
    for i in range(200, 3, -1):
        binary = to_bin(i)
        if(i % 5 == 0):
            for b in range(3):
                binary += binary[-3]
        else:
            newNum = i % 5
            newNum *= 5
            newBin = to_bin(newNum)
            binary += newBin
        if(int(binary, 2) < 100):
            print(i)
            break
def ex6():
    for i in range(1, 100):
        trinary = to_trinary(i)
        if(i % 3 == 0):
            for b in range(2):
                trinary += trinary[-2]
        else:
            newTrinary = to_trinary((i % 3) * 5)
            trinary += newTrinary
        if(int(trinary, 3) > 133):
            print(i)
            break
def select_exercise():
    exNum = input("Введите номер задачи: ")
    if(exNum != "-1"):
        print("\nОтвет: ")
        if(exNum == "1"):
            ex1()
        elif(exNum == "2"):
            ex2()
        elif(exNum == "3"):
            ex3()
        elif(exNum == "4"):
            ex4()
        elif(exNum == "5"):
            ex5()
        elif(exNum == "6"):
            ex6()
        else:
            print("Такой задачи нет!")
        select_exercise()
    else:
        print("Программа завершена")
select_exercise()