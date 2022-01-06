using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(13);
            Assert.AreEqual(result, 144);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_1()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(13);
            Assert.AreEqual(result, 144);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(13);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(13);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(21);
            Assert.AreEqual(result, 6765);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_2()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(21);
            Assert.AreEqual(result, 6765);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(21);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(21);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(2);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_3()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(2);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(2);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(2);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_strrev_cs_test_1()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("Keyboard"), "draobyeK");
        }
  
        [TestMethod]
        public void ce103_strrev_cs_test_2()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("World"), "dlroW");
        }
    
        [TestMethod]
        public void ce103_strrev_cs_test_3()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("Hello"), "olleH");         
        }
     
        [TestMethod]
        public void ce103_strlen_cs_test_1()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Planet"), 6);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_2()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Database"), 8);
        }
    
        [TestMethod]
        public void ce103_strlen_cs_test_3()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Whale"), 5);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_1()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("C","Sharp"),"CSharp");
        }
  
        [TestMethod]
        public void ce103_strcat_cs_test_2()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hot","Dog"),"HotDog");
        }
 
        [TestMethod]
        public void ce103_strcat_cs_test_3()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("New","Year"),"NewYear");
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_1()
        {
            Class1 strcmp = new Class1();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("System", "System"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_test_2()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Hardware", "system"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_3()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Haluk", "Kurtulus"), 0);
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_1()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("System", "Hello"), "Hello");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_2()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Science"), "Science");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_3()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Hardware", "Hello"), "Hello");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_1()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Keyboard"), "draobyeK");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Keyboard"), "draobyeK", Strrev.ce103_strrev_cs_imported("Keyboard"), "draobyeK");
        }
 
        [TestMethod]
        public void ce103_strrev_cs_imported_test_2()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("World"), "dlroW");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("World"), "dlroW", Strrev.ce103_strrev_cs_imported("World"), "dlroW");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_3()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Hello"), "olleH");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Hello"), "olleH", Strrev.ce103_strrev_cs_imported("Hello"), "olleH");
        }
       
        [TestMethod]
        public void ce103_strcat_cs_imported_test_1()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("C", "Sharp"), "CSharp");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("C", "Sharp"), "CSharp", Strcat.ce103_strcat_cs_imported("C", "Sharp"), "CSharp");
        }
      
        [TestMethod]
        public void ce103_strcat_cs_imported_test_2()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Hot", "Dog"), "HotDog");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hot", "Dog"), "HotDog", Strcat.ce103_strcat_cs_imported("Hot", "Dog"), "HotDog");
        }
        
        [TestMethod]
        public void ce103_strcat_cs_imported_test_3()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("New", "Year"), "NewYear");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("New", "Year"), "NewYear", Strcat.ce103_strcat_cs_imported("New", "Year"), "NewYear");
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_1()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Planet"), 6);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_1()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Planet"), 6, Strlen.ce103_strlen_cs_imported("Planet"));
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_2()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Database"), 8);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_2()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Database"), 8, Strlen.ce103_strlen_cs_imported("Database"));
        }
  
        [TestMethod]
        public void ce103_strlen_cs_imported_test_3()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Whale"), 5);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_3()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Whale"), 5, Strlen.ce103_strlen_cs_imported("Whale"));
        }

        [TestMethod]
        public void ce103_strcmp_cs_imported_test_1()
        {
            Class2 strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported("System", "System"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_1()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("System", "System"), 0, Strcmp.ce103_strcmp_cs_imported("System", "System"));
        }
     
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_2()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Hardware", "system"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_2()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Hardware", "system"), 0, Strcmp.ce103_strcmp_cs_imported("Hardware", "system"));
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_3()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Haluk", "Kurtulus"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_3()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Haluk", "Kurtulus"), 0, Strcmp.ce103_strcmp_cs_imported("Haluk", "Kurtulus"));
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_1()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("System", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("System", "Hello"), "Hello", Strcpy.ce103_strcpy_cs_imported("System", "Hello"), "Hello");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_2()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Science"), "Science");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Science"), "Science", Strcpy.ce103_strcpy_cs_imported("Computer", "Science"), "Science");
        }
     
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_3()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Hardware", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Hardware", "Hello"), "Hello", Strcpy.ce103_strcpy_cs_imported("Hardware", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0xAA, 0xBB, 0xCC, 0x12, 0x45, 0x28 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'B', 'B', 'C', 'C', '1', '2', '4', '5', '2', '8' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xCB, 0xCB, 0xCB, 0xCB, 0xCB, 0xCB, 0xCB, 0xCB };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'C', 'B', 'C', 'B', 'C', 'B', 'C', 'B', 'C', 'B', 'C', 'B', 'C', 'B', 'C', 'B' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test1()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xAA, 0xBB, 0xCC, 0x12, 0x45, 0x28 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test2()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0x16, 0x16, 0x16, 0x16, 0x16 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '6', '1', '6', '1', '6', '1', '6', '1', '6' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0x14, 0x14, 0x14, 0x14, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '4', '1', '4', '1', '4', '1', '4', '1', '4' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test2()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xDB, 0xFB, 0xCB, 0x25, 0x45, 0x15 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test3()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xAB, 0xAC, 0xAD, 0x19, 0x49, 0x29 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'B', 'A', 'C', 'A', 'D', '1', '9', '4', '9', '2', '9' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test3()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test1()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "1616161616161616";
            byte[] expectedArr = { 0x16, 0x16, 0x16, 0x16, 0x16, 0x16, 0x16, 0x16 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "AFFBFD132328";
            byte[] expectedArr = { 0xAF, 0xFB, 0xFD, 0x13, 0x23, 0x28 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test1()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "CCCCCCCCCC";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test2()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "2222222222222222";
            byte[] expectedArr = { 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "1318171912328822434447";
            byte[] expectedArr = { 0x13, 0x18, 0x17, 0x19, 0x12, 0x32, 0x88, 0x22, 0x43, 0x44, 0x47 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test2()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "FBCFEFFC";
            byte[] expectedArr = { 0xFB, 0xCF, 0xEF, 0xFC };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test3()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "FCFCFCFCFCFCFCFC";
            byte[] expectedArr = { 0xFC, 0xFC, 0xFC, 0xFC, 0xFC, 0xFC, 0xFC, 0xFC };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "6363636363636363636363";
            byte[] expectedArr = { 0x63, 0x63, 0x63, 0x63, 0x63, 0x63, 0x63, 0x63, 0x63, 0x63, 0x63 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test3()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "98223CF24D637842CD";
            byte[] expectedArr = { 0x98, 0x22, 0x3C, 0xF2, 0x4D, 0x63, 0x78, 0x42, 0xCD };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
