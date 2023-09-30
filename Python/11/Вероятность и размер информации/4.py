import math
isnottwo = 7 - math.log2(24)
isnotone = 7 - math.log2(120)
pnottwo = (2**isnottwo)**(-1)
pnotone = (2**isnotone)**(-1)
pone = 1 - pnotone
ptwo = 1 - pnottwo
pthree = 1 - pone - ptwo
i = math.log2(1/pthree)
print("Ответ:", math.ceil(i))