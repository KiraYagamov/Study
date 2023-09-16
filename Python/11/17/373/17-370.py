file = open('17-370.txt', "r")
lines = []
three = []
minThree = 0
minSumSqr = 0
count = 0

for line in file:
    lines.append(int(line))

for num in lines:
    if(len(str(abs(num))) == 3):
        three.append(num)
three.sort()

for num in three:
    if(str(num)[-1] == "3"):
        minThree = num
        break

for i in range(0, len(lines)-1):
    if(len(str(abs(lines[i]))) == 4 and len(str(abs(lines[i+1]))) != 4) or (len(str(abs(lines[i]))) != 4 and len(str(abs(lines[i+1]))) == 4):
        sum = lines[i]**2 + lines[i+1]**2
        if(sum/minThree == int(sum/minThree)):
            if(minSumSqr == 0 or minSumSqr > sum):
                minSumSqr = sum
            count += 1

print(count, minSumSqr)

#Вывод: 10 43133184