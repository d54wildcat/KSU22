/**
 * @Original Author: Tony Gaddis
 * @Modified heavily by: Dr. Lang
 * 
 * Instructor.java - Provided to the student
 * Class stores data about an instructor of a course which includes
 * the instructor's firstname, lastname, and username
 *
 * Includes a regular constructor and a constructor used to make a copy 
 * of a created instructor object as well as a toString method
*/

public class Instructor
{
   private String lastName;     // Last name   
   private String firstName;    // First name
   private String userName; 	// Username ID

   /**
      This constructor initializes the last name,
      first name, and user name.
      @param lname The instructor's last name.
      @param fname The instructor's first name.
      @param userName The instructor's user name.
   */
   public Instructor(String lname, String fname, String un)
   {
      lastName = lname;
      firstName = fname;
      userName = un;
   }

   /**
      The copy constructor initializes the object
      as a copy of another Instructor object.
      @param object2 The object to copy.
   */
   public Instructor(Instructor object2)
   {
      lastName = object2.lastName;
      firstName = object2.firstName;
      userName = object2.userName;
   }

   /**
      toString method
      @return A string containing instructor information.
   */
   public String toString()
   {
      // Create a string representing the object.
      String str = "Last Name: " + lastName +
                   "\nFirst Name: " + firstName +
                   "\nEmail: " + (userName + "@ksu.edu");

      // Return the string.
      return str;
   }
}