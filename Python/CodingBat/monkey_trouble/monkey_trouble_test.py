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


if __name__ == "__main__":
    unittest.main()
