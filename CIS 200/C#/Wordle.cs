/**
*Wordle.cs
*Dacey Wieland/ Thursday 4:30
*
*This program Is the main class for the wordle program. It first asks the user for their skill level
*and will then display the chosen word. It will then allow the user that many guesses, and will display
*a star and a dash accordingly. If he guesses the word correctly, they will be congratulated and will be asked if the user
*would like to play again. If not, the program will end.
*/
using System;
using System.Text;
namespace WordGen{
public class Wordle{
    static void Main(){
        //ask the user for their skill level and that will correspond to how many rows are provided in the game
        bool again = true;
        while(again){
        Console.WriteLine("What is your skill level? Beginner, Proficient, or Expert?");
        string skill = Console.ReadLine();
        int rows = 6;
        if (skill == "Beginner"){
            rows = 6;
        }
        else if (skill == "Proficient"){
            rows = 4;
        }
        else if (skill == "Expert"){
            rows = 3;
        }
        String actual = Words.getWord();
        Console.WriteLine("Your word is: " + actual);
        bool correct = false;
        for(int i = 0; i < rows; i++){
            Console.WriteLine("Enter guess " + (i+1));
            string word = Console.ReadLine();
            if (word.ToUpper() == actual.ToUpper()){
                correct = true;
                break;
            }
            else{
                StringBuilder sb = new StringBuilder();
                for(int j = 0; j < word.Length; j++){
                    string wordU = word.ToUpper();
                    string actualU = actual.ToUpper();
                    if(word.ToUpper()[j] == actual.ToUpper()[j]){
                    sb.Append(word[j]);
                    }
                    else if(actualU.Contains(wordU[j].ToString())){
                        sb.Append("*");
                    }
                    else{
                    sb.Append("-");
                    }
                }
                Console.WriteLine(sb.ToString());
            }
        }
        if (correct){
            Console.WriteLine("You got it!");
        }
        else{
            Console.WriteLine("You didn't get it!");
            Console.WriteLine("Word was: " + actual);
        }
        Console.WriteLine("Would you like to play again? (y/n)");
        string playAgain = Console.ReadLine();
        if (playAgain == "y"){
            again = true;
        }
        else{
            again = false;
        }
    }
    }
}

}