n = int(input("Количество футболистов: "))
count = 0
for i in range(n):
    footballer = str(input())
    footmas = footballer.split(" ")
    if(int(footmas[2]) >= 1998 and int(footmas[2]) <= 2000):
        if(int(footmas[3]) == 0):
            count+=1
    footmas.clear()
print(count)