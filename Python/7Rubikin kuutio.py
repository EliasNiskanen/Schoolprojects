def rubik():
    lista = []
    luku1 = input("Syötä 1. suorituksen aika: ")
    luku1 = float(luku1)
    lista.append(luku1)
    luku2 = input("Syötä 2. suorituksen aika: ")
    luku2 = float(luku2)
    lista.append(luku2)
    luku3 = input("Syötä 3. suorituksen aika: ")
    luku3 = float(luku3)
    lista.append(luku3)
    luku4 = input("Syötä 4. suorituksen aika: ")
    luku4 = float(luku4)
    lista.append(luku4)
    luku5 = input("Syötä 5. suorituksen aika: ")
    luku5 = float(luku5)
    lista.append(luku5)
    return lista
def main():
    lista = rubik()
    lista.sort()
    keskiarvo = (lista[1]+lista[2]+lista[3])/3
    print ("Virallinen kilpailutulos on {:.2f} sekuntia.".format(keskiarvo))
main()