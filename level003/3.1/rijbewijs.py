print('Hoe oud bent u?')
leeftijd = float(input())  # Taking input as a float, as age could be a decimal number

MinLeeftijd = 16.5  # Minimum age to start driving lessons

if leeftijd >= MinLeeftijd:
    print("U kunt beginnen met rijles.")
else:
    print("U mag nog niet beginnen met rijles.")
