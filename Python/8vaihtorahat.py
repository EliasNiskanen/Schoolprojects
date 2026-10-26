kymppi = 10
vitonen = 5
kakkonen = 2
euro = 1

citem = input("Ostosten hinta: ")
moneygiven = input("Maksettu rahasumma: ")
moneygiven = int(moneygiven)
citem = int(citem)
moneyback = moneygiven - citem

qmb = moneyback // kymppi
partialtotal = moneyback - qmb * kymppi
dmb = partialtotal // vitonen
dpartialtotal = partialtotal - dmb * vitonen
nmb = dpartialtotal // kakkonen
npartialtotal = dpartialtotal - nmb * kakkonen
pmb = npartialtotal // euro

if moneyback == 0:
    print ("Ei vaihtorahaa")
else:
    print ("Anna vaihtorahaa:")
if qmb >= 1:
    print (qmb,"kymppiä")
if dmb >= 1:
    print (dmb, "vitosta")
if nmb >= 1:
    print (nmb, "kaksieuroista")
if pmb >= 1:
    print (pmb, "euroa")