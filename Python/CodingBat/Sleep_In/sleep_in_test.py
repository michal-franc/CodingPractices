import unittest
import sleep_in

class   SleepInTests(unittest.TestCase):

    def test_IsFalse_when_IsWeekDay(self):
        #ar
        isWeekday = True
        isVacation = False
        expectedValue = False

        #act
        actualValue = sleep_in.SleepIn(isWeekday, isVacation)

        #as
        self.assertEquals(expectedValue, actualValue)

if __name__ == '__main__':
    unittest.main()
