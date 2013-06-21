import front_back
import unittest

class FrontBackTests(unittest.TestCase):

    def testFrontBack_ForEmpty_ReturnEmpty(self):
        self.assertEquals("", front_back.Do(""))

    def testFrontBack_ForSingleChar_ReturnChar(self):
        self.assertEquals("c", front_back.Do("c"))

    def testFrontBack_ForSameString_ReturnthisString(self):
        self.assertEquals("aaa", front_back.Do("aaa"))

    def testFrontBack_ForString_ReturnReversedString(self):
        self.assertEquals("cba", front_back.Do("abc"))

    def testFrontBack_ForBiggerString_ReturnReversedString(self):
        self.assertEquals("dbca", front_back.Do("abcd"))

if __name__ == "__main__":
    unittest.main()

