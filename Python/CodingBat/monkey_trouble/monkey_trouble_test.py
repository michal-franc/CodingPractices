import monkey_trouble
import unittest

class MonkeyTrouble(unittest.TestCase):

    def testIsTrouble_WhenBothSmile(self):
        #ar
        monkeyASmile = True
        monkeyBSmile = True
        isTrouble = True

        #act
        actualIsTrouble = monkey_trouble.IsTrouble(monkeyASmile, monkeyBSmile)

        #as
        self.assertEqual(isTrouble, actualIsTrouble) 

    def testIsTrouble_WhenBothNotSmile(self):
        monkeyASmile = False
        monkeyBSmile = False
        isTrouble = True

        actualIsTrouble = monkey_trouble.IsTrouble(monkeyASmile, monkeyBSmile)

        self.assertEquals(isTrouble, actualIsTrouble)

    def testIsNotTrouble_WhenOneSmiles(self):
        monkeyASmile = True
        monkeyBSmile = False
        isTrouble = False 

        actualIsTrouble = monkey_trouble.IsTrouble(monkeyASmile, monkeyBSmile)

        self.assertEquals(isTrouble, actualIsTrouble)

if __name__ == "__main__":
    unittest.main()
