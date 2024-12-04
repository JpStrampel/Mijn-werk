import random

def roulette():
	# Chips voor de speler
	chips = 10
	
	# vraag om de inzet van de speler
	while chips > 0:
		locations = {}
		while True:
			## Request user chip location
			print(f"Je hebt {chips} chips")
			print("Waar wil je je chip inzetten? Als je wil stoppen type dan STOP")
			location = input()
			
			# Check if we want to stop
			if location == "STOP":
				break
			
			# Determine if the location is valid
			try:
				location_value = int(location)
				if location_value < 0 or location_value > 36:
					print("Dit is geen geldig getal, probeer opnieuw..")
					continue
			except:
				print("Dit is een ongeldige waarde, probeer opnieuw..")
				continue
			
			while True:
				print(f"Hoeveel chips wil je op {location} inzetten?")
				bet = input()
				try:
					bet_value = int(bet)
					if bet_value < 0:
						print("Deze waarde is te klein, probeer opnieuw")
						continue
					
					if bet_value > chips:
						print(f"U gaat all-in: {chips} chips worden ingezet")
						bet_value = chips
					
					if location in locations:
						locations[location] += bet_value
					else: locations[location] = bet_value
					chips = chips - bet_value
					break
				except:
					print("Dit is geen geldig getal, probeer opnieuw..")
					continue
			
		
		winning_number = random.randint(1, 36)
		winning_id = str(winning_number)
		print(f"Het winnende getal is {winning_id}")
		if winning_id in locations:
			chips_at_location = locations[winning_id]
			if chips_at_location > 0:
				winning_count = chips_at_location * 35
				print(f"Je hebt gewonnen: Je krijgt {winning_count}")
				chips = chips + winning_count
			else: print("Helaas..")
		else: print("Helaas..")
	
	print("GAME OVER")
	
	
roulette()