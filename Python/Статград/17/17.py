file = open("17.txt", "r")
strLines = file.readlines()
countDoubles = 0
minToNeed = 10001
maxSum = 0
for i in range(len(strLines)):
    if(strLines[i][-2] == strLines[i][-3]):
        if(minToNeed > int(strLines[i])):
            minToNeed = int(strLines[i])

for i in range(len(strLines)-1):
    if(strLines[i][-2] == strLines[i+1][-3]) or (strLines[i][-3] == strLines[i+1][-2]):
        if((int(strLines[i])%7 == 0) or (int(strLines[i+1])%7 == 0)) and not((int(strLines[i])%7 == 0) and (int(strLines[i+1])%7 == 0)):
            if((int(strLines[i])**2 + int(strLines[i+1])**2) < minToNeed**2):
                countDoubles += 1
                if((int(strLines[i])**2 + int(strLines[i+1])**2) > maxSum):
                    maxSum = (int(strLines[i])**2 + int(strLines[i+1])**2)
print("Ответ 1:", countDoubles)
print("Ответ 2:", maxSum)