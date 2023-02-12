maxDel = 0
currentDel = 0
delitels = []
for i in range(394441, 394505+1):
	for b in range(1, i+1):
		if(i%b == 0):
			currentDel += 1
	if(currentDel > maxDel):
		maxDel = currentDel
	currentDel = 0
for i in range(394441, 394505+1):
	for b in range(1, i+1):
		if(i%b == 0):
			delitels.append(b)
	if(len(delitels) == maxDel):
		print("Минимальное число:", i, "\n")
		print("Количество делителей:", maxDel)
		print("Два наибольших делителя в порядке убывания:", delitels[-1], ";", delitels[-2])
		break
		delitels.clear()
	else:
		delitels.clear()
input()