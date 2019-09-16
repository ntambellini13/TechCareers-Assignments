import csv

# Writes invalid names into a InvalidNames.csv
def invalid_writer(invalid_list):
    with open('InvalidNames.csv', 'w+', newline='') as invalid_names:
            writer = csv.writer(invalid_names)
            writer.writerow(invalid_list)