/**
 * @Original Author: Tony Gaddis
 * @Modified heavily by: Dr. Lang
 * 
 * Course.java - Provided to the student
 * Class stores data about a course which includes course number
 * course name, instructor information (stored as an object) and
 * required textbook for the course information (stored as an object)
 *
 * Includes get methods for all data properties and a toString method
*/

public class Course
{
   private String courseNumber;    // e.g. CIS 200
   private String courseName;      // e.g. Programming Fundamentals
   private Instructor instructor;  // Course instructor (object)
   private TextBook textBook;      // Required Course textbook (object)

   /**
      This constructor initializes the courseName,
      instructor, and text fields.
      @param name The name of the course.
      @param instructor An Instructor object.
      @param text A TextBook object.
   */

   public Course(String number, String name, Instructor instr,
                 TextBook text)
   {
      // Assign the courseNumber.
      courseNumber = number;

      // Assign the courseName.
      courseName = name;

      // Create a new Instructor object, passing
      // instr as an argument to the copy constructor.
      instructor = new Instructor(instr);

      // Create a new TextBook object, passing
      // text as an argument to the copy constructor.
      textBook = new TextBook(text);
   }

   /**
      getName method
      @return The name of the course.
   */

   public String getName()
   {
      return courseName;
   }

   /**
      getName method
      @return The number of the course.
   */

   public String getNumber()
   {
      return courseNumber;
   }
   /**
      getInstructor method
      @return A reference to a copy of this course's
              Instructor object.
   */

   public Instructor getInstructor()
   {
      // Return a copy of the instructor object.
      return new Instructor(instructor);
   }

   /**
      getTextBook method
      @return A reference to a copy of this course's
              TextBook object.
   */

   public TextBook getTextBook()
   {
      // Return a copy of the textBook object.
      return new TextBook(textBook);
   }

   /**
      toString method
      @return A string containing the course information.
   */

   public String toString()
   {
      // Create a string representing the object.
      String str = "Course number: " + courseNumber +
				   "\nCourse name: " + courseName +
                   "\n\nInstructor Information:\n" +
                   instructor +
                   "\n\nTextbook Information:\n" +
                   textBook;

      // Return the string.
      return str;
   }
}