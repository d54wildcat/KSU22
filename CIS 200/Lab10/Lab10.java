/*
*Lab10.java
*Dacey Wieland Thurs 4:30
*
*This program has the user input student information and once they are done inputting student information,
* it will print out the information, then will print out the deans list and will finally print out the students info as the first index in the list.
*/

// ADD Documentation Heading here
// Include the PURPOSE of THIS CLASS

import java.util.*;

public class Lab10 {
 public static void main(String[] args) {
	Scanner s = new Scanner (System.in);
		
	//YOU DO THIS:
	//Declare an ArrayList to hold Student Objects
	ArrayList<Student> students = new ArrayList<Student>();

// Given to the student...	
	double gpa = -1;
	String name = "", userName="";
	String reply = "Y";	
	boolean inputValid = true; 		// if no exceptions, input is valid
		
	do {
 
 	 try{	

	//---Enter and validate name
	// YOU DO THIS: if user just presses enter, display
	// "Name is required (Please re-enter)" and throw an IllegalArgumentException


		System.out.print("\nEnter the student's name: ");
		name = s.nextLine();
		if (name.length() == 0) {
			System.out.print("Name is required (Please re-enter)");
            throw new IllegalArgumentException();
		}
		
		
	//---Enter and validate name userName
	// YOU DO THIS: if user just presses enter, display
	// "User name is required (Please re-enter)" and throw an IllegalArgumentException
		System.out.print("Enter student's user name: ");
		userName = s.nextLine();
		if (userName.length() == 0) {
            System.out.print("User name is required (Please re-enter)\n");
			throw new IllegalArgumentException();
		}

	//---Enter and validate GPA
	// YOU DO THIS: LOOP until the GPA is 0-4 (inclusive) otherwise display
	// "GPA must be between 0.0-4.0 (inclusive). Please re-enter: "
		boolean valid = false;
		while (!valid){
			System.out.print("Enter student's GPA: ");
			gpa = Double.parseDouble(s.nextLine());
			if (gpa < 0 || gpa > 4) {
				System.out.println("GPA must be between 0.0-4.0 (inclusive). Please re-enter: ");
			}
			else {
				valid = true;
			}
	// If execution gets to this line, no exceptions were thrown		
		inputValid = true;
		}
	} // end try

// Following exception handlers given to the student	 
	 catch (NumberFormatException e)
		{ System.out.println("No characters allow for GPA...Please re-enter all information\n");
		  inputValid = false;
		} // end catch

// Reminder NumberFormatException is a SUBCLASS of IllegalArgumentException
// so if you catch IllegalArgumentException first, compile error
// " exception NumberFormatException has already been caught"
	 catch (IllegalArgumentException e)
	 { inputValid = false;
	 } // end catch

//---Input valid, add to arraylist	 
	 if (inputValid) { 
		
	 // only does the following if ALL input is valid

	//YOU DO THIS:
	//Create a student object and add to the arraylist
		Student s1 = new Student(name, userName, gpa);
		students.add(s1);
		System.out.println("Student added to the arraylist...");
		
		System.out.print("Add another student? ('Y' or 'N'): ");
		reply = s.nextLine();
		
		// reset booleans so input is read in
		inputValid = true;
	 } // end if inputValid

	} while (reply.equalsIgnoreCase ("Y"));
	
	//YOU DO THIS:
	// Create a loop that uses the toString method in the Student class
	// to display all objects added to the arraylist
	for (int i = 0; i < students.size(); i++) {
		System.out.println(students.get(i).toString());
	}




	// Display Dean's list - OVER 3.0
	System.out.println("\nDean's list - OVER 3.0");
	for (int i = 0; i < students.size(); i++) {
		if (students.get(i).getGPA() > 3.0) {
			System.out.println(students.get(i).toString());
		}
	}


	
	// Add YOU as an object at the START of the arraylist using the 2-arg constructor
	// Then, use the overloaded setGPA method to set your GPA to 3.9
	// Lastly, display ONLY the first element in the Arraylist using the toString method
	System.out.print("First element in the Arraylist: \n");
	name = "Dacey Wieland";
	userName = "dwieland";
    students.set(0, new Student(name, userName));
	students.get(0).setGPA(3.9);
    System.out.println(students.get(0).getGPA());
    s.close();

 } // end main
} // end class Lab10