import unittest
import notstring

class NotStringTests(unittest.TestCase):

    def test_IfEmpty_return_not(self):
        expected = "not"
        input = ""

        actual = notstring.Do(input)

        self.assertEquals(expected, actual)

    def test_IfNot_return_not(self):
        expected = "not"
        input = "not"

        actual = notstring.Do(input)

        self.assertEquals(expected, actual)

    def test_IfValue_return_withNotAtTheBeginning(self):
        input = "test"
        expected = "not test"

        actual = notstring.Do(input)

        self.assertEquals(expected, actual)

    def test_IfNotWithSpaces_Return_trimmed_not(self):
        input = "    not"
        expected = "not"

        actual = notstring.Do(input)

        self.assertEquals(expected, actual)

if __name__ == "__main__":
    unittest.main()
