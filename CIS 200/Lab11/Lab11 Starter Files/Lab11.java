/*
*Lab11.java
*Dacey Wieland Thursday, 4:30
*
*This file takes in the text file and creates a new word object, and reads through the words on the text file.
*It adds each word to the object, and makes a hashmap of the words and their lengths. It then has the user input a starting word and the length.
*It then prints out the words that are within the length of the starting letter.
*/



import java.util.*;
import java.io.*;

public class Lab11 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		//** YOU DO THIS
		//Create a new Words object
		Words w = new Words();


		try {
			//for some reason it doesn't read the whole file without specifying UTF-8
			Scanner inFile = new Scanner(new File("wonderland.txt"), "UTF-8");
			while (inFile.hasNext()) {
				String line = inFile.nextLine();
				String[] pieces = line.split(" ");
				
				//loops through the pieces (the words on the current line)
				for (int i = 0; i < pieces.length; i++) {
				//** YOU DO THIS
				// Call addWord on your Words object to add the current word (pieces[i])
				w.addWord(pieces[i]);
				} //end for
			} // end while

			inFile.close();
			
		//** YOU DO THIS to create a HashMap
		// Call createHashMap on your Words object
		w.createHashMap();

		
		} // end try
		catch (IOException ioe) {
			System.out.println("Error reading input file");
		} // end catch

// Searching the HashMap
		char again;
		do {
			System.out.print("Enter a letter: ");
			char let = (s.nextLine()).charAt(0);
			System.out.print("Enter a length: ");
			int len = Integer.parseInt(s.nextLine());

			System.out.println();
			
		//** YOU DO THIS
		// Call the displayLetterAndLength method on your 
		// Words object (pass the user's letter and length)
		w.displayLetterAndLength(let, len);


			System.out.print("\nDo you want to go again? (y/n) ");
			again = (s.nextLine().toLowerCase()).charAt(0);
		} while (again == 'y');
		
	} // end main
} // end Lab 11 class