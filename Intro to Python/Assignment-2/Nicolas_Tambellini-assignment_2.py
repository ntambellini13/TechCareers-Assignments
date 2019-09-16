def song():
    for num in range (99,-1,-1):
        if num == 0:
            print ("No more bottles of beer on the wall, no more bottles of beer.")
            print ("Go to the store and buy some more, 99 bottles of beer on the wall.")
        elif num == 1:
            print ("1 bottle of beer on the wall, 1 bottle of beer.")
            print ("Take one down and pass it around, no more bottles of beer on the wall.")
            print ()
        elif num == 2:
            print (f"{num} bottles of beer on the wall, {num} bottles of beer.")
            print (f"Take one down and pass it around, {num-1} bottle of beer on the wall.")
            print ()
        else:
            print (f"{num} bottles of beer on the wall, {num} bottles of beer.")
            print (f"Take one down and pass it around, {num-1} bottles of beer on the wall.")
            print ()

song()

