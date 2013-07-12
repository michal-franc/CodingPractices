def Do(input):
    if( len(input) <= 3 and input[:3] == "not"):
        return input
    
    return "not" + input
