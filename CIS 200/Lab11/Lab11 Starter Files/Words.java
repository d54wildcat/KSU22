/*
*Words.java
*Dacey Wieland Thursday, 4:30
*
*Creates a new TreeSet and Hashmap, and contains several methods with these. It has a method that returns a string contiaining all letters converted to lowercase. 
*Also has a method that removes any non character input from the string. Also has a method that if the treeset has a certain string, it will add it to a hashmap.
*Lastly This class also has a method to display the words that have the same starting letter and length.
*/
import java.util.*;

public class Words {
	private TreeSet <String> noDups;
	private HashMap <String, Integer> wordLengths;

	public Words() {
	//** THIS CONSTRUCTOR IS DONE
		noDups = new TreeSet <String>();
		wordLengths = new HashMap <String, Integer>();
	} // end no-arg constructor

	/** 
	* removeNonAlpha returns a string containing all alphabetic
	* letters in s. All letters are converted to lowercase.
	* For example, if s is "Weren't", then removeNonAlpha would
	* return "werent".
	*
	* @param s A sequence of characters (not including spaces)
	* @return all alphabetic letters in s, represented in lower-case
	*
	*/
	private String removeNonAlpha(String s) {
	//** THIS METHOD IS DONE
		StringBuilder build = new StringBuilder();
		for (int i = 0; i < s.length(); i++) {
			char cur = s.charAt(i);

			if (Character.isUpperCase(cur)) {
				build.append(Character.toLowerCase(cur));
			}
			else if (Character.isLowerCase(cur)) {
				build.append(cur);
			}
		}

		return build.toString();
	} // end removeNonAlpha

	public void addWord(String s) {
	//** YOU DO THIS
		
		// Call the private removeNonAlpha method to remove any non-alphabetic characters from the passed in parameter
		String word = removeNonAlpha(s);
		// If the length of the parsed word is greater than zero,
		// add the parsed word to the TreeSet
		if (word.length() > 0) {
			noDups.add(word);
		}

		
	} // end addWord

	public void createHashMap() {
	//** YOU DO THIS
		
		// For each string cur in your TreeSet 'noDups' (use a for-each loop) add an entry to your HashMap _wordLengths withcur as the key and cur.length() as the value
		for (String cur : noDups) {
			wordLengths.put(cur, cur.length());
		}

		
	} // end createHashMap

	public void displayLetterAndLength(char letter, int len) {
	//** YOU DO THIS
		
		// For each entry in your HashMap (use a for-each loop)
		// if the entry's key's first letter matches letter and
		// the entry's value matches len, display that entry's key
		// Hint: getKey() / getValue() returns a given key / value
		for (Map.Entry<String, Integer> entry : wordLengths.entrySet()){
			if (entry.getKey().charAt(0) == letter && entry.getValue() == len) {
				System.out.println(entry.getKey());
			}
		}
	
		
	} // end displayLetterAndLength
	
} // end Words class