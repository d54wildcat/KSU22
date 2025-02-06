/*
*Student.java
*Dacey Wieland Thurs 4:30
*
*This program contains the student class, and creates the student objects
* It also contains the methods to get and set name, userName, and GPA, as well as the toString Method
*/
public class Student{
    private String name;
    private String userName;
    private double gpa;
    public Student(String name, String userName, double gpa){
        this.name = name;
        this.userName = userName;
        this.gpa = gpa;
    }
    public Student(String name, String userName){
        this.name = name;
        this.userName = userName;
    }
    public String getName(){
        return name;
    }
    public double getGPA(){
        return gpa;
    }
    public String getEmail(){
        return (userName + "@ksu.edu");
    }
    public void setGPA(double x){
        this.gpa = x;
    }
    public void setGPA(String GPA){
        this.gpa = Double.parseDouble(GPA);
    }
    public String toString(){
        return name + "\n" + getEmail() + "\nGPA: " + gpa + "\n";
    }
}