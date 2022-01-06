using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
	public class Class1
	{
		/**************************
        * Copyleft (L) 2021 CENG - All Rights Not Reserved
        * You may use, distribute and modify this code.
        **************************/

		/**
	   * @file ce103-hw4-cs-dll
	   * @author Haluk Kurtulus
	   * @date 31 December 2021
	   *
	   * @brief <b> HW-4 Functions </b>
	   *
	   * HW-4 Sample Lib Functions
	   *
	   * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
	   *
	   */

		/**
	    * @name   fibonacciNumber (ce103_fibonacciNumber_cs)
	    *
	    * @brief Fibonacci Number Calculator
	    *
	    * Calculates the fibonacci number in the given index and return as output
	    *
	    * @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
	    *
	    * @retval [\b int] calculated fibonacci number
	    **/
		public int ce103_fibonacciNumber_cs(int fiIndex)
		{
			//TODO:Start from Here...

			/*
			  To begin, the value is increased up to FIINDEX and the third value is added to the first sum of the second first value. Second, the Second value is the same as the Third value.
			 We're going to return the first value. (Because the first and second values are the same, the third value is the same.)
			*/
			int one = 0, two = 1, three;
			for (int i = 1; i < fiIndex; i++)
			{
				three = one + two;
				one = two;
				two = three;
			}
			return one;
		}

		/**
		@name   strrev (ce103_strrev_cs)

		@brief \b Reverse String

		Reverse given string

		@param [in] fiStr [\b string] The given string which is needed to be reversed.

		@retval [\b string] This function returns the string after reversing the given string
	    **/
		public string ce103_strrev_cs(string fiStr)
		{
			char[] chrs = new char[ce103_strlen_cs(fiStr)];
			for (int g = 0, b = ce103_strlen_cs(fiStr) - 1; g <= b; g++, b--)
			{
				chrs[g] = fiStr[b];
				chrs[b] = fiStr[g];
			}
			return new string(chrs);
		}

		/**
		@name   strlen (ce103_strlen_cs)
		@brief \b Get string length

		Returns the length of the C# string str.

		@param [in] fiStr [\b string] the null-terminated byte string to be examined

		@retval [\b int] The length of the null-terminated byte string str.
	    **/
		public int ce103_strlen_cs(string fiStr)
		{

			int ly = 0;
			foreach (char c in fiStr)
			{
				ly++;
			}
			return ly;
		}

		/**
		@name   strcat (ce103_strcat_cs)
		@brief \b Concatenate strings

		In this function, we combine 2 randomly entered strings.
        We give one of our strings "fiDest" and the other "fiSrc", that is, a random string.
        The sum of these strings gives us the combined return value of the strings.


		@param  [in] fiDest [\b string] the null-terminated byte string to append to
		@param  [in] fiSrc  [\b string] the null-terminated byte string to copy from

		@retval [\b string] returns a copy of dest
	    **/
		public string ce103_strcat_cs(string fiDest, string fiSrc)
		{
			return fiDest + fiSrc;
		}

		/**
		@name   strcmp (ce103_strcmp_cs)
		@brief  \b Compare two strings

		Compares two null-terminated byte strings lexicographically.

		@param  [in] fiLhs [\b string] the null-terminated byte strings to compare
		@param  [in] fiRhs [\b string] the null-terminated byte strings to compare

		@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
				Zero if lhs and rhs compare equal.
				Positive value if lhs appears after rhs in lexicographical order.
	    **/
		public int ce103_strcmp_cs(string fiLhs, string fiRhs)
		{

			if (fiLhs == fiRhs)
			{
				return 0;
			}
			else if (ce103_strlen_cs(fiLhs) < (ce103_strlen_cs(fiRhs)))
			{
				return -1;
			}
			else
			{
				return 1;
			}
		}

		/**
	    *
		@name  strcpy (ce103_strcpy_cs)
		@brief \b Copy string

		Copies the C# string pointed by source into the array pointed by destination,
		including the terminating null character (and stopping at that point).

		@param [out] foDestination	[\b string] the destination array where the content is to be copied.
		@param [in]  fiSource		[\b string]	C string to be copied.

		@retval [\b string] returns a copy of dest
	    **/
		public string ce103_strcpy_cs(string foDestination, string fiSource)
		{
			foDestination = fiSource;
			return foDestination;
		}
		/**
        * @name    bin2hex (ce103_bin2hex_cs)
        * 
        * @brief   \b Binary to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\b byte[]]    Binary data to be converted.
        * 
        * @param [in]  fiBinLen   [\b int]	 Binary data length.
        * 
        * @param [out] foHex      [\b char[]]	 Convertion result as ascii. Doubles the binary length.
        **/
		public void ce103_bin2hex_cs(byte[] fiBin, int fiBinlen, char[] foHex)
		{
			char[] lb = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			for (int f = 0; f < fiBinlen; f++)
			{
				foHex[f * 2] = lb[fiBin[f] >> 4];
				foHex[f * 2 + 1] = lb[fiBin[f] & 0x0F];
			}
		}

		/**
        * @name    hex2bin (ce103_hex2bin_cs)
        * 
        * @brief   \b Hexadecimal string to byte array Conversion
        * 
        * Convert hex string to byte array
        *
        * @param   [in]  fiHex    [\b string] Ascii hex string.
        * 
        * @param   [in]  fiHexLen [\b int]     Ascii data length.
        * 
        * @param  [out]  foBin    [\b byte[]]   Convertion result as binary.
        **/
		public void ce103_hex2bin_cs(string fiHex, int fiHexLen, byte[] foBin)
		{ 

			int[] c = { 0, 0 };
			for (int g = 0; g < fiHexLen; g += 2)
			{  
				char[] b = new char[2];

				int hxi = 0;
				for (int u = 0; u < 2; u++)
				{  
					b[u] = (char)fiHex[g + u];
					if (u == 0)
					{  
						if (b[u] >= '0' && b[u] <= '9')
						{ 
							c[u] = b[u] - '0';
		
							c[u] *= 16;
						}
						else if (b[u] >= 'A' && b[u] <= 'F')
						{
						
							c[u] = b[u] - 'A' + 10;
							c[u] *= 16;
						}
					}
					else
					{
						if (b[u] >= '0' && b[u] <= '9')
						{
					
							c[u] = b[u] - '0';
						}
						else if (b[u] >= 'A' && b[u] <= 'F')
						{
							c[u] = b[u] - 'A' + 10;
						}
					}

					hxi += c[u];
				}

				foBin[g / 2] = (byte)hxi;
			}
		}



	}
}
	    


