import random

def roll_dice():
    return random.randint(1, 6)

def main():
    roll = roll_dice()
    print("You rolled:", roll)

if __name__ == "__main__":
    main()
