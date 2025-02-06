/*	Your Name
	Class Name
	1-2 lines describing the purpose of THIS class / What does THIS CLASS do?
	(used for your later reference)
*/

// Lab 12 - Model class

using System;
using System.Text; // needed for StringBuilder

public class Cipher {
	private int key;

// Constructor	
 public Cipher(int k) {
		key = k % 26;
 } // end Constructor

 public string Encrypt(string message) {
	StringBuilder sb = new StringBuilder();		

//YOU DO THIS
	//For each character in message, determine the new character
	//once the integer key is applied and add it to 'sb'
	// use Append method to add to sb
	//For example, if the character is 'a' and
	//key is 4, you should assign 'e'.

	//use ASCII values to find the replacement
	//build a string of the replacement characters,
	//and return it using sb.ToString()
//Hint: If 'ch' is a char, int value = (int) ch; assigns ASCII value




//replace the line below
	return "";
 } // end Encrypt()

	
	
 public string Decrypt(string message) {
	StringBuilder sb = new StringBuilder();		

//YOU DO THIS
	//For each character in message, determine the original char
	//by "un-applying" the integer key
	//For example, if the character is 'e' and
	//key is 4, you should assign 'a'.

	//use ASCII values to find the replacement
	//build a string of the replacement characters,
	//and return it using sb.ToString()

//FYI: If decrypted character is a ':' replaces with a space ' '

//replace the line below
	return "";
 } // end Decrypt()
	
} // end class