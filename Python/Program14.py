num = str(input())
last = ""
yes = False
for i in range(len(num)):
    if(last != ""):
        if(last == num[i]):
            yes = True
            break
    last = num[i]
if(yes):
    print("Yes")
else:
    print("False")