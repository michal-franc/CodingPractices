def Do(string):
    if(len(string) <= 1):
        return string
    else:
        substring = string[1:-1]
        return string[-1] + substring + string[0]
