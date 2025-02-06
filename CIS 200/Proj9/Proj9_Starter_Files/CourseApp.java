/*
*CourseApp.java
*Dacey Wieland Thurs 4:30
* This class contains the main method of the program. The main method first creates an array list of courses and then asks the user to fill in the information for each course.
*It will do this until the user says to stop. It will then print out the information for each course, and ask for the price markup for each course. After running through all courses
*That the user put in the program will ask the user for a number to input and if the number matches it will delete that course from the array list. Finally it will ask the user for
*One more course and will put it at the front of the array list and will then print out the rest of the array list.
*/
import java.util.*;
public class CourseApp {
    public static void main(String[] args){
        ArrayList<Course> courses = new ArrayList<Course>();
        //have user input course name and number, then instructor last name, first name, and email, and textbook title, author, and wholesale price
        Scanner s = new Scanner(System.in);
        boolean inputValid = true;
        boolean again = true;
        String answer = "";
        while (again){
            String courseName = "";
            String courseNumber = "";
            String instructorLastName = "";
            String instructorFirstName = "";
            String instructorEmail = "";
            String textbookTitle = "";
            String textbookAuthor = "";
            double textbookRetailPrice = 0.0;
            double textbookWholesalePrice = 0.0;
            
            try{   
                System.out.println("Enter course name: ");
                courseName = s.nextLine();
                if (courseName.length() == 0){
                    System.out.println("Course name is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter course number: ");
                courseNumber = s.nextLine();
                if (courseNumber.length() == 0){
                    System.out.println("Course number is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter instructor last name: ");
                instructorLastName = s.nextLine();
                if (instructorLastName.length() == 0){
                    System.out.println("Instructor last name is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter instructor first name: ");
                instructorFirstName = s.nextLine();
                if (instructorFirstName.length() == 0){
                    System.out.println("Instructor first name is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter instructor email: ");
                instructorEmail = s.nextLine();
                if (instructorEmail.length() == 0){
                    System.out.println("Instructor email is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter textbook title: ");
                textbookTitle = s.nextLine();
                if (textbookTitle.length() == 0){
                    System.out.println("Textbook title is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter textbook author: ");
                textbookAuthor = s.nextLine();
                if (textbookAuthor.length() == 0){
                    System.out.println("Textbook author is required (Please re-enter)");
                    throw new IllegalArgumentException();
                }
                System.out.println("Enter textbook wholesale price: ");
                textbookWholesalePrice = s.nextDouble();
                inputValid = true;
            }
            catch(NumberFormatException e){
                System.out.print("No Characters Allowed for Price and Markup");
                inputValid = false;
            }
            catch(IllegalArgumentException e){
                inputValid = false;
            }
        
            if (inputValid){
                Instructor instructor = new Instructor(instructorLastName, instructorFirstName, instructorEmail);
                TextBook textbook = new TextBook(textbookTitle, textbookAuthor, textbookWholesalePrice);
                Course course = new Course(courseNumber, courseName, instructor, textbook);
                courses.add(course); 
                System.out.println("Course added to list.\n");
                System.out.println("Would you like to add another course? (Y/N)");
                s.nextLine();
                answer = s.nextLine();
                //if answer is not Y or N, ask again, and if answer is N then break
                if (answer.equalsIgnoreCase("N")){
                    again = false;
                }
                else if (answer.equalsIgnoreCase("Y")){
                    again = true;
                }
                else{
                    System.out.println("Invalid input. Please enter Y or N.");
                }    
                inputValid = true;
            }
        } 
        for (int i = 0; i < courses.size(); i++){
            System.out.println(courses.get(i));
            System.out.print("Enter textbook % markup, or just enter 0 for default 25% markup:");
            int textbookRetailPrice = s.nextInt();
            if(textbookRetailPrice == 0){
                System.out.printf("Total Price of textbook: $%.2f", TextBook.calcRetailPrice());
            }
            //output total price of textbook for each course
            else{
                System.out.printf("Total Price of textbook: $%.2f", TextBook.calcRetailPrice(textbookRetailPrice));
            }
            s.nextLine();
            s.nextLine();
        }
        boolean found = false;
        while(!found){
        System.out.print("Please enter a course number: ");
        String next = s.nextLine();
        //if the course number is found in the arraylist delete the course, otherwise print out that the course was not found, and loop back
            for(int i = 0; i < courses.size(); i++){
                if(courses.get(i).getNumber().equals(next)){
                    courses.remove(i);
                    System.out.println("Course deleted.");
                    found = true;
                }
                else if(i == courses.size() - 1){
                    System.out.println("Course not found.");
                    found = false;
                }
            }
        }
        //have user enter course name, number, instructor firstName, lastName, and textbook information, and place it at the start of the arraylist
        System.out.println("Enter course name: ");
        String courseName = s.nextLine();
        System.out.println("Enter course number: ");
        String courseNumber = s.nextLine();
        System.out.println("Enter instructor last name: ");
        String instructorLastName = s.nextLine();
        System.out.println("Enter instructor first name: ");
        String instructorFirstName = s.nextLine();
        System.out.println("Enter instructor email: ");
        String instructorEmail = s.nextLine();
        System.out.println("Enter textbook title: ");
        String textbookTitle = s.nextLine();
        System.out.println("Enter textbook author: ");
        String textbookAuthor = s.nextLine();
        System.out.println("Enter textbook wholesale price: ");
        double textbookWholesalePrice = s.nextDouble();
        Instructor instructor = new Instructor(instructorLastName, instructorFirstName, instructorEmail);
        TextBook textbook = new TextBook(textbookTitle, textbookAuthor, textbookWholesalePrice);
        Course course = new Course(courseNumber, courseName, instructor, textbook);
        courses.add(0, course);
        //output the arraylist again using the toString method
        for (int i = 0; i < courses.size(); i++){
            System.out.println(courses.get(i));
            s.nextLine();
        }
        s.close();
    }
}