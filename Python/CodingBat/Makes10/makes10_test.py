import unittest
import makes10

class Makest10Test(unittest.TestCase):

    def testDo_ReturnsTrue_IfFirstArgument10(self):
        input1 = 10
        input2 = 999

        actualValue = makes10.Do(input1, input2)

        self.assertTrue(actualValue)

    def testDo_ReturnsTrue_IfSecondArgument10(self):
        input1 = 999
        input2 = 10

        actualValue = makes10.Do(input1, input2)

        self.assertTrue(actualValue)

    def testDo_ReturnTrue_IfSumIs10(self):
        input1 = 1
        input2 = 9

        actualValue = makes10.Do(input1, input2)

        self.assertTrue(actualValue)

    def testDo_ReturnFalse_IfNoneIs10(self):
        input1 = 999
        input2 = 999

        actualValue = makes10.Do(input1, input2)

        self.assertFalse(actualValue)

    def testDo_ReturnFalse_IfSumNot10(self):
        input1 = 1
        input2 = 10

        actualValue = makes10.Do(input1, input2)

        self.assertTrue(actualValue)

if __name__ == "__main__":
    unittest.main()
