import math
red = 36
iswhite = 8
isnotblack = 6
pwhite = (2**iswhite)**(-1)
pnotblack = (2**isnotblack)**(-1)
pred = pnotblack - pwhite
all = red/pred
white = pwhite*all
black = all - white - red
print("Вместимость:", math.ceil(all), "| Белых:", math.ceil(white), "| Черных:", math.ceil(black), "| Красных:", math.ceil(red))