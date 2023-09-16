delitels = []
for i in range(164700, 164752+1):
	for b in range(1, i+1):
		if(i%b == 0):
			delitels.append(b)
	if(len(delitels) == 6):
		print(i)
		print(sorted(delitels), "\n")
		delitels.clear()
	else:
		delitels.clear()

input()