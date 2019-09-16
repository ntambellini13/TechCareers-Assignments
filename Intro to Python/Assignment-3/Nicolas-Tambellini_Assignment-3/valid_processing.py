import csv

# Convert names to proper format of first letter capitalized and if there is a - the first letter after the hyphen will be capitalized as well
converted_names = []
def convert (valid_list):
    for name in valid_list:
        converted_names.append(name.title())
    return(converted_names)   

# Writes valid and converted names into a CleanNames.csv
def valid_writer(converted_names):
    with open('CleanNames.csv', 'w+', newline='') as cleaned_names:
            writer = csv.writer(cleaned_names)
            writer.writerow(converted_names)
