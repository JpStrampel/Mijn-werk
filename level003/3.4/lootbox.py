import random
import sys
 
from rewards import get_new_skin
 
 
if len(sys.argv) > 1:
    random.seed(sys.argv[1])
 
 
skins_count = {
    'COMMON': 0,
    'RARE': 0,
    'EPIC': 0,
    'LEGENDARY': 0
}
 
 
for _ in range(5):
 
    new_skin_rarity = get_new_skin()
 
 
    skins_count[new_skin_rarity] += 1
 
 
for rarity, count in skins_count.items():
    print(f"Aantal {rarity} skins: {count}")