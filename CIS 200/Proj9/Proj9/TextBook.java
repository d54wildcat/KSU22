/**
 * @Original Author: Tony Gaddis
 * @Modified heavily by: Dr. Lang
 * 
 * Textbook.java - Provided to the student
 * Class stores data about the textbook required for the course
 * which includes title, author and price
 *
 * Includes a regular constructor and a constructor used to make a copy 
 * of a created textbook object as well as a toString method
*/


public class TextBook
{
   private String title;    // Title of the book
   private String author;   // Author's last name
   private static double price; 	// Wholesale cost of the book

   /**
      This constructor initializes the title,
      author, and price fields
      @param textTitle The book's title.
      @param auth The author's name.
      @param price Wholesale cost.
   */
   public TextBook(String t, String a,
                   double p)
   {
      title = t;
      author = a;
      price = p;
   }

   /**
      The copy constructor initializes the object
      as a copy of another TextBook object.
      @param object2 The object to copy.
   */
   public TextBook(TextBook object2)
   {
      title = object2.title;
      author = object2.author;
      price = object2.price;
   }

 
   /**
      toString method
      @return A string containing textbook information.
   */
   public String toString()
   {
      // Create a string representing the object.
      String str = "Title: " + title +
                   "\nAuthor: " + author +
                   "\nWhole Sale Price: $" + price;

      // Return the string.
      return str;
   }
   /**
    * Calculates the retail price of the textbook, with default 25% markup
   * @return the retail price of the textbook
   */
   public static double calcRetailPrice(){
      return price * 1.25;
   }
   /**
    * Calculates the retail price of the textbook, with a given markup
   * @param markup the markup to be applied
   * @return the retail price of the textbook
    */
   public static double calcRetailPrice(int markup){
      return price * (1 + markup/100.0);
   }
}

