import fizzbuzz
import unittest

class   FizzBuzzTests(unittest.TestCase):

    def testFizzBuzz_1_1(self):
        createdArray = fizzbuzz.Do(1, 1)
        self.assertEquals(createdArray, [])

    def testFizzBuzz_1_2(self):
        createdArray = fizzbuzz.Do(1, 2)
        self.assertEquals(createdArray, ["1"])

    def testFizzBuzz_1_4(self):
        createdArray = fizzbuzz.Do(1, 4)
        self.assertEquals(createdArray, ["1", "2", "Fizz"])

    def testFizzBuzz_1_6(self):
        createdArray = fizzbuzz.Do(1, 6)
        self.assertEquals(createdArray, ["1", "2", "Fizz", "4", "Buzz"])

    def testFizzBuzz_1_16(self):
        createdArray = fizzbuzz.Do(1, 16)
        assert createdArray.count("Fizz") == 4
        assert createdArray.count("Buzz") == 2
        self.assertIn("FizzBuzz", createdArray)

if __name__ == "__main__":
    unittest.main()
