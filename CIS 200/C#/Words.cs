/**
*Words.cs
*Dacey Wieland/ Thursday 4:30
*
*This program is the random word generator of the class. It first reads in the file and then will put that into a list
* it will then randomly select a word from that list, decrement the index and return that word.
*/
using System;
using System.Collections.Generic;

namespace WordGen {
public class Words{
    public static String getWord(){
        //read in the words.txt file and store them in an array list
        System.IO.StreamReader file = new System.IO.StreamReader("words.txt");
        string line;
        List<string> words = new List<string>();
        while((line = file.ReadLine()) != null){
            words.Add(line);
        }
        //randomly pick a word from the array list by generating a random number between 1 and the number of words in the array list, then return the word that is the index - 1
        Random rand = new Random();
        int index = rand.Next(1, words.Count);
 
        return words[index - 1];
    }
    
}
}