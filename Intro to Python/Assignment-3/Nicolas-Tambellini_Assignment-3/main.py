import sorter
import invalid_processing
import valid_processing

#Import file
path = input('What is the path of the .csv file you want to sort?\n')
def import_file(file):
        if path[-4:] != ('.csv'):
            raise TypeError()
        else:
            return path
try: 
    import_file(path)

    #Sort csv into valid and invalid names 
    valid, invalid = sorter.sort(path)

    #Make InvalidNames.csv file
    invalid_processing.invalid_writer(invalid)

    #Convert valid names to correct format
    converted_names = valid_processing.convert(valid)

    # Make CleanNames.csv file
    valid_processing.valid_writer(converted_names)
# file path imported is not a valid .csv
except TypeError:
    print('Please make sure you are importing a .csv file.')
# the code is broken somewhere else and needs to be checked by the programmer
except:    
    print('Oh no, something went wrong!')

                 
                










