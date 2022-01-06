#include "ce103-hw4-c-dll.h"

__declspec(dllexport) int ce103_fibonacciNumber(int fiIndex)
{
	//TODO:Start from Here...

	/*
	  To begin, the value is increased up to FIINDEX and the third value is added to the first sum of the second first value. Second, the Second value is the same as the Third value.
	 We're going to return the first value. (Because the first and second values are the same, the third value is the same.)
	*/
	int first = 0, second = 1, third;
	for (int i = 1; i < fiIndex; i++)
	{
		third = first + second;
		first = second;
		second = third;
	}
	return first;
}

__declspec(dllexport) char* ce103_strrev(char* fiStr)
{
	//TODO:Start from Here...
	/*
		We constructed an empty string called ch, with p and q values equal to those provided by fistru.
	 Q We're increasing the Q value, not leaving it blank.
	 P + 1 obtains Q-1 value as long as the P value is less than Q.
	 To the CH p value, p equals Q, and to the CH repetition, p equals Q.
	 The new form of the provided fistr is returned. (From beginning to end, a full word changes.)
	 Abcdefgh - hgfedcba, for example.
	*/

	char ch;
	char* p = fiStr;
	char* q = fiStr;

	for (; *q != '\0'; q++);
	;
	q--;
	for (; p < q; p++, q--) {
		ch = *p;
		*p = *q;
		*q = ch;
	}
	return fiStr;
}

__declspec(dllexport) int ce103_strlen(const char* fiStr)
{
	//TODO:Start from Here...
	/*
		We equate the PTR value to us to the first PTR value I = 0). We increase the number of characters in the ID and increase the number of characters in the ID.
	 The number of characters in the supplied word is returned by i.
	*/
	int i = 0;
	char* ptr = fiStr;
	while (*ptr != '\0')
	{
		++i;
		++ptr;
	}
	return i;
}


__declspec(dllexport) char* ce103_strcat(char* fiDest, char* fiSrc)
{
	//TODO:Start from Here...
	/*
		We've synced the CP value with the Fidest value we were provided.
	 We enhance the CP value and the CP using FisRC as long as the CP value is.
	 As a result, the first string is copied from the second Stringe (Fidest).
	*/

	char* cp = fiDest;

	while (*cp)

		cp++; // find end of dst 

	while (*cp++ = *fiSrc++); // Copy src to end of dst 

	return(fiDest); // return dst 
}
__declspec(dllexport) int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	//TODO:Start from Here...
	/*
		As long as the filhs is as long as the filhs characters are equal to Firhs, we increase while the words are the same. (Returns number one.)

	 On the other hand, Firhs is eliminated from Filhs. (The result is 0 - 0 = 0.) Words are not interchangeable.
	*/
	while (*fiLhs && (*fiLhs == *fiRhs)) {
		fiLhs++;
		fiRhs++;
	}
	return *fiLhs - *fiRhs;
}

__declspec(dllexport) char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	//TODO:Start from Here...
	/*
		The P variable has been set to Fodestination.
	 Unless the Fodestination Fisource is equal to all characters, the Fisource value is delivered.
	 As a result, Fodestination will return a string that is identical to Fisource.
	 Process of copying.
	*/
	char* p = foDestination;
	while (*fiSource)
	{
		*foDestination++ = *fiSource++;
	}
	*foDestination = '\0';
	return p;
}


__declspec(dllexport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	//TODO:Start from Here...
	/*
		We are creating C and D values, we add value C to FiEx, C should not be idle.
		If it is greater than C 96, we are extracting from C 87.
		If you are greater than C 64, we are extracting from C 55.
		If both of the two are not provided, we are removing 48.
		We add d'to Fihex, again D shouldn't be idle.We equate fobin to c.adding 4 to C.
		We repeat the transactions we do to c in d.
		4 is added to the fobin c and adjusted to the end of the end.
		We return the Fihex value.
		*/
	int c, d;
	for (;;) {
		c = *fiHex++; if (c == 0) break;
		if (c > 96) c -= 87;
		else if (c > 64) c -= 55;
		else c -= 48;
		d = *fiHex++; if (d == 0) { *foBin = c << 4; break; }
		if (d > 96) d -= 87;
		else if (d > 64) d -= 55;
		else d -= 48;
		*foBin++ = (c << 4) | d;
	}
	return fiHex;
}

__declspec(dllexport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	//TODO:Start from Here...
	/*
Fibinlen is equal to the end value created by C, D, and Fibin.
		D is synchronized after the fourth character of C as long as the fibin is less than the end value(loop).
		48) is added to the FOHEX if D is greater than D 9.
		d equals the collection or removal of C and 15's value.
		The FOHEX is re - adding 48 or 55.
		Fohex is set to 0.
		We return the fibin value.
		*/
	int c, d, * end = fiBin + fiBinLen;
	while (fiBin < end) {
		c = *(fiBin++);
		d = c >> 4;
		*(foHex++) = d + (d > 9 ? 55 : 48);
		d = c & 15;
		*(foHex++) = d + (d > 9 ? 55 : 48);
	}
	*foHex = 0;
	return fiBin;
}

