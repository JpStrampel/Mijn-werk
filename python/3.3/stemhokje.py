def stemhokjes_computer():
    stemmen = {'Dominique': 0, 'Zacharia': 0}
    
    while True:
        stem = input("Typ de naam van de kandidaat op wie je wilt stemmen (Dominique of Zacharia), of typ 'UITSLAG' om de uitslag te zien: ").strip().capitalize()
        
        if stem == 'Uitslag':
            break
        elif stem in stemmen:
            stemmen[stem] += 1
            print("Stem ontvangen voor", stem)
        else:
            print("Ongeldige invoer. Typ alleen de naam van de kandidaat op wie je wilt stemmen.")
    
    print("\nHet stemmen is gesloten. Hier is de uitslag:")
    winnaar = max(stemmen, key=stemmen.get)
    if stemmen['Dominique'] == stemmen['Zacharia']:
        print("Het is een gelijkspel! Beide kandidaten hebben", stemmen[winnaar], "stemmen.")
    else:
        print("President", winnaar, "heeft gewonnen met", stemmen[winnaar], "stemmen.")

stemhokjes_computer()
