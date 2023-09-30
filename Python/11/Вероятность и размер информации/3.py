import math
all = 96
issilver = 4
igold = 5
psilver = (2**issilver)**(-1)
pgold = (2**igold)**(-1)
silver = psilver * all
gold = pgold * all
copper = all - silver - gold
print("Золотых:", math.ceil(gold), "| Серебряных:", math.ceil(silver), "| Медных:", math.ceil(copper))