Pelaaja1 = input("Pelaaja 1, syötä valintasi (K/P/S): ")
Pelaaja2 = input("Pelaaja 2, syötä valintasi (K/P/S): ")

def compare(Pelaaja1, Pelaaja2):
    if Pelaaja1 == Pelaaja2:
        print("Tuli tasapeli.")
    else:
        if Pelaaja1 == 'K'  and Pelaaja2 == 'P':
            print("Pelaaja 2 voitti!")
        elif Pelaaja1 == 'P' and Pelaaja2 == 'K':
            print("Pelaaja 1 voitti!")
        elif Pelaaja1 == 'K' and Pelaaja2 == 'S':
            print("Pelaaja 1 voitti!")
        elif Pelaaja1 == 'S' and Pelaaja2 == 'K':
            print("Pelaaja 2 voitti!")
        elif Pelaaja1 == 'P' and Pelaaja2 == 'S':
            print("Pelaaja 2 voitti!")
        else:
            print("Pelaaja 1 voitti!")

compare(Pelaaja1, Pelaaja2)