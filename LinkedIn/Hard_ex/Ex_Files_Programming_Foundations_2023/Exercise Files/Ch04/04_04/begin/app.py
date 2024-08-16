# User Input
miles = input('Enter a distance in miles: ')

# Cast to int
miles_value = float(miles)

# Convert
kilometers_value = miles_value * 1.609344

print(miles_value, 'Miles is', kilometers_value, 'kilometers')