delitels = []
for i in range(190061, 190080+1):
	for b in range(i, 0, -1):
		if(i%b == 0 and b%2 == 1):
			delitels.append(b)
	if(len(delitels) == 4):
		print(i)
		print(delitels, "\n")
		delitels.clear()
	else:
		delitels.clear()

input()