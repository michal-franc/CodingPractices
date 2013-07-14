def Do(input):
    
    if len(input) == 0:
        return 'not'
    
    if 'not' in input :
        return input.lstrip()
    
    return "not " + input.lstrip()
