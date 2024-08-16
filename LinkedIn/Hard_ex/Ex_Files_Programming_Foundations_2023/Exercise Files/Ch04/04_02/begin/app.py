first_name = 'malala'
last_name = 'yousafzai'
note = 'award: Nobel Peace Prize'

first_name_cap = first_name.capitalize()
last_name_cap = last_name.capitalize()
note_cap = note.capitalize()

print(first_name_cap)
print(last_name_cap)

award_location = note.find('award') # returns where text starts (occurs)
print(award_location)