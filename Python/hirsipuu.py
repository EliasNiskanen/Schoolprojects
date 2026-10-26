# Funktio, joka tuottaa sanan verran alaviivoja
def alaviiva(lista):
    alaviivat=len(lista)*"_"
    return alaviivat

# Funktio, joka muokkaa alaviivat annettujen oikeiden kirjaimien mukaan
def tarkista_kirjain(arvaus,sanat,alaviivat):
    i=-1
    alaviivat=list(alaviivat)
    for kirjain in sanat:
        i+=1
        if arvaus == sanat[i]:
            alaviivat[i]=arvaus.upper()
    alaviivat="".join(alaviivat)
    return alaviivat

# pääfunktio joka tutkii kymmenen eri kirjainta tarkista_kirjain funktion avulla
def main():
    merkkijono=""
    rivi=input("Syötä arvuuteltava sana: ")
    merkkijono+=rivi
    merkkijono=merkkijono.lower()
    aloitus=alaviiva(merkkijono)
    print("Putsataan näyttö...")
    for i in range(0,9):
        print("")
    print("Peli alkakoon! Saat arvata 10 kirjainta. Mikä sana on kyseessä?")
    print(aloitus)
    arvaukset=""
    for i in range(0,10):
        arvaus=input("Arvaa kirjain: ")
        arvaus=arvaus.lower()
        if len(arvaus) != 1:
            print("Virhe: syötä yksi kirjain.")
        if arvaus in arvaukset:
            print("Hölmö arvaus,", arvaus.upper(), " on jo arvattu.")
        if len(arvaus)==1:
            arvaukset += arvaus
        aloitus=tarkista_kirjain(arvaus,merkkijono,aloitus)
        print(aloitus)
        if aloitus == merkkijono.upper():
            print("Hyvä! Arvasit koko sanan!")
            break
        if i == 9 and aloitus != merkkijono.upper():
            print("Arvauskerrat loppuivat kesken. Sana olisi ollut ", merkkijono.upper())
        if i == 9 and aloitus == merkkijono.upper():
            print("Hyvä! Arvasit koko sanan!")
            break

main()
