def to_trinary(num):
    trinary = ""
    while(num > 0):
        trinary += str(num%3)
        num = num//3
    return trinary[::-1]

file = open('17-370.txt', "r")
lines = []
three = []
maxThree = 0
minSumSqr = 0
count = 0

for line in file:
    lines.append(int(line))
for num in lines:
    if(len(str(abs(num))) == 3):
        three.append(num)
three.sort()

for i in range(len(three)-1, -1, -1):
    trinary = to_trinary(three[i])
    if(trinary == trinary[::-1]):
        maxThree = three[i]
        break

for i in range(0, len(lines)-1):
    if(len(str(abs(lines[i]))) == 4 and len(str(abs(lines[i+1]))) != 4) or (len(str(abs(lines[i]))) != 4 and len(str(abs(lines[i+1]))) == 4):
        sum = lines[i]**2 + lines[i+1]**2
        if(sum/maxThree == int(sum/maxThree)):
            if(minSumSqr == 0 or minSumSqr > sum):
                minSumSqr = sum
            count += 1

print(count, minSumSqr)

#Вывод: 12 19025168