import csv
import re


valid_list = []
invalid_list = []

#Sort function    
def sort(file):
    # Regex
    valid_names = re.compile(r"^[a-zA-Z]+-?[a-zA-Z]+$")
    # Read imported csv
    with open(file, 'r+') as imported:
        names = csv.reader(imported, quoting=csv.QUOTE_NONE)
        for l in names:
            for item in l:
                # Build valid names list
                if valid_names.match(item):
                    valid_list.append(item)
                # Build invalid names list
                else:
                    invalid_list.append(item)
    return(valid_list, invalid_list)
