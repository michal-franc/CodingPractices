def Do(start, end):

    returnString = []

    for val in range(start, end):
        if (val % 3 == 0 and val % 5 == 0):
            returnString.append("FizzBuzz")
        elif(val % 3 == 0):
            returnString.append("Fizz")
        elif (val % 5 == 0):
            returnString.append("Buzz")
        else:
            returnString.append(str(val))

    return returnString
