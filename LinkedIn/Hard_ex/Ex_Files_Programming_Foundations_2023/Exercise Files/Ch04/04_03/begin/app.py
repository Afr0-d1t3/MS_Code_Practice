import re # Regular expressions

five_digit_zip = '98101'
nine_digit_zip = '98101-0003'
phone_number = '234-567-8901'

five_digit_expression = r'\d{5}' # Set to only include first 5 indexes
print(re.search(five_digit_expression, five_digit_zip))  # This will search within these expressions
print(re.search(five_digit_expression, nine_digit_zip))
print(re.search(five_digit_expression, phone_number))