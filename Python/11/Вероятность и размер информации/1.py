import math
shuk = 1500
somov = 500
psh = shuk / (shuk + somov)
psomov = somov / (shuk + somov)
ish = math.log2(1/psh)
isomov = math.log2(1/psomov)
i = psh * ish + psomov * isomov
print("Информация о щуке:", round(ish, 2), "бит | Информация о соме:", round(isomov, 2), "бит | Информация о рыбе:", round(i, 2), "бит")