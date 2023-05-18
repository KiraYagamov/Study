file = open("17.txt", "r")
text = file.readlines()
count = 0
min = 10000
max = -1
for i in range(len(text)):
    if(int(text[i]) < min and int(text[i])%2 == 1):
        min = int(text[i])
for i in range(len(text)-1):
    if((int(text[i])%3 == 0 or int(text[i+1])%3 == 0) and (int(text[i])%3 != 0 or int(text[i+1])%3 != 0)):
        if(abs(int(text[i]) - int(text[i+1])) < min):
            if(abs(int(text[i]) - int(text[i+1])) > max):
                max = abs(int(text[i]) - int(text[i+1]))
            count+=1
file.close()
print("Ответ 1:", count)
print("Ответ 2:", max)

print("Всего элементов:", len(text))