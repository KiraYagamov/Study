num = str(input())
last = ""
yes = True
for i in range(len(num)):
    if(last != ""):
        if(num[i] != last):
            yes = False
            break
    last = num[i]
if(yes):
    print("Yes")
else:
    print("No")