import front3
import unittest

class Front3Tests(unittest.TestCase):

    def testFront3_IfEmpty_ReturnEmpty(self):
        empty = ""
        expected = ""

        actual = front3.Do(empty)

        self.assertEquals(expected, actual)

    def testFront3_IfLessThan3_ReturnWhateverThereIs(self):
        value = "va"
        expected = "vavava"

        actual = front3.Do(value)

        self.assertEquals(expected, actual)

    def testFront3_IfMoreEqal3_ReturnStringWith3TimesFirst3(self):
        value = "vav"
        expected = "vavvavvav"

        actual = front3.Do(value)

        self.assertEquals(expected, actual)

if __name__ == "__main__":
    unittest.main()
