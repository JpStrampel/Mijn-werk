def faculteit(n):
    return 1 if n == 0 else n * faculteit(n - 1)

getal = int(input("Voer een positief geheel getal in: "))
print(f"De faculteit van {getal} is: {faculteit(getal)}")
