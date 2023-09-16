num = str(input())
first = num[0]
last = num[-1]
result = ""
for i in range(len(num)-1):
    if(i==0):
        result = result + last
    else:
        result = result + num[i]
result = result + first
print(result)