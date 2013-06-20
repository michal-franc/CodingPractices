def IsTrouble(aSmile, bSmile):
    if((aSmile and bSmile) or (not aSmile and not bSmile)):
        return True
    else:
        return False
