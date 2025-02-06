import java.util.*;
public class LastZybooks{
    
    public static void printItems(ArrayList<Integer> numsList) {
        int i;
  
        System.out.print("items:");
  
        for (i = 0; i < numsList.size(); ++i) {
           System.out.print(" " + numsList.get(i));
        }
  
        System.out.println();
     }
  
     public static void main(String[] args) {
        int i;
        ArrayList<Integer> intList = new ArrayList<Integer>();
  
        for (i = 0; i < 5; ++i) {
           intList.add(i);
        }
        printItems(intList);
  
        intList.remove(2);
        printItems(intList);
  
        intList.add(3, 6);
        printItems(intList);
     }
  }
