import unittest
import diff21

class Diff21Tests(unittest.TestCase):

    def test_DiffWithZero_ReturnsSameValue(self):
        self.assertEqual(diff21.diff(0), 21)

    def testDiff_For21_ReturnZero(self):
        self.assertEqual(diff21.diff(21), 0)

    def testDiff_For2_Return19(self):
        self.assertEqual(diff21.diff(19), 2)

    def testDiff_IfGreaterThan21_DoubleTheValue(self):
        self.assertEqual(diff21.diff(42), 42)
        self.assertEqual(diff21.diff(100), 158)

if __name__ == '__main__':
    unittest.main()
