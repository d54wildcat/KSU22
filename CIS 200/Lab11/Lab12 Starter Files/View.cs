/*	Your Name
* Dacey Wieland
* View.Cs
* This program has the user inter in the key that they want to use. and then has the user input the message they 
* want to use.
*/

// Lab 12 - View (Console) class

using System;

public class View {


// Constructor	
public View() {

} // end Constructor

	
public string GetMessage() {
//YOU DO THIS
	//Ask the user to enter the message
	//return message they enter
	Console.WriteLine("Enter a message to encrypyt/decrypt: ");
	string message = Console.ReadLine();



//replace the line below
	return message;
} // end GetMessage()

public int GetKey() {
//YOU DO THIS
	//Ask the user to enter a key value between 1-25
	//return value after verifying value is
	//a valid int (not a double or string)
	// and is between 1-25

	//Use a try/catch with a loop to keep
	//asking until they enter an integer between 1-25
	try{
		Console.WriteLine("Enter a key value between 1-25: ");
		int key = int.Parse(Console.ReadLine());
		if(key > 0 && key < 26){
			return key;
		}
		else{
			throw new Exception();
		}
	}
	catch(Exception){
		Console.WriteLine("Invalid key value. Please try again.");
		return GetKey();
	}

//Hint: catch (FormatException) is equal to 
//catch (NumberFormatException n) in Java
	
//replace the line below
	
} // end GetKey()

public void DisplayResult(string msg) {
//YOU DO THIS
	//display msg to the console
	Console.WriteLine(msg);
} // end displayResult

// To hold screen output until a key is pressed
public void HoldScreen() {
		Console.WriteLine("Press any key to end program...");
		Console.ReadKey();	
} // end holdScreen
	
} // end class