import unittest
import sumdouble

class SumDoubleTests(unittest.TestCase):

    def testSumDouble_IfTheSame_ReturnDoubleSum(self):
        value1 = 2
        value2 = 2
        expectedValue = 8

        actualValue = sumdouble.Do(value1, value2)

        self.assertEquals(expectedValue, actualValue)

    def testSumDouble_IfNotTheSame_ReturnSum(self):
        value1 = 1
        value2 = 2
        expectedValue = 3

        actualValue = sumdouble.Do(value1, value2)

        self.assertEquals(expectedValue, actualValue)

if __name__ == "__main__":
    unittest.main()
