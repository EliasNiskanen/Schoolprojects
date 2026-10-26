def aikataulu():
    lista = []
    aika1 = int(630)
    lista.append(aika1)
    aika2 = int(1015)
    lista.append(aika2)
    aika3 = int(1415)
    lista.append(aika3)
    aika4 = int(1620)
    lista.append(aika4)
    aika5 = int(1720)
    lista.append(aika5)
    aika6 = int(2000)
    lista.append(aika6)
    return lista

def main():
    lista = aikataulu()
    aika = int(input("Mitä kello on nyt? (kokonaislukuna): "))
    print("Seuraavat bussivuorot lähtevät:")
    if aika <= 630 or aika >2000:
        print(lista[0])
        print(lista[1])
        print(lista[2])
    elif aika > 630 and aika <=1015:
        print(lista[1])
        print(lista[2])
        print(lista[3])
    elif aika > 1015 and aika <= 1415:
        print(lista[2])
        print(lista[3])
        print(lista[4])
    elif aika > 1415 and aika <= 1620:
        print(lista[3])
        print(lista[4])
        print(lista[5])
    elif aika > 1620 and aika <= 1720:
        print(lista[4])
        print(lista[5])
        print(lista[6])
    elif aika > 1720 and aika <= 2000:
        print(lista[5])
        print(lista[0])
        print(lista[1])

main()
