public class Practice Test{
    //Question 1
    private string[] words = new string[10];
    public WordList(string[] args){
        words = new string[arr.Length];
        for(int i = 0; i < words.Length; i++){
            words[i] = arr[i];
        }
    }
    public bool ContainsWord(string s){
        for(int i = 0; i < words.Length; i++){
            if(words[i].equals s){
                return true;
            }
            return false;
        }
    }
    public int StartsWith(char c){
        int count = 0;
        for(int i = 0; i < words.Length; i++){
            if(words[i][0] == c){
                count++;
            }
            }
        }
        return count;
    }
    //Question 2
    public static void Main(string[] args){
        string[] arr = {
            "apple", "banana", "avacado", "carrot"
        }
        WordList d = new WordList(arr);
        int result = d.StartsWith('a');
        Console.WriteLine(result);
    }
    public static int Min(int a, int b){
        if( a <= b){return a}
        else{return b};
    }
    public static double Min(double a, double b){
        if( a <= b){return a}
        else{return b};
    }
    Console.WriteLine("The smaller of 33 and 55 is " + Min(33, 55));
    Console.WriteLine("The smaller of 33.5 and 55.5 is " + Min(33.5, 55.5));
}
//Question 10- the problem question
/*
*1 Reading in the values and puttin them in the array
*2 It's trying to find the index of the smallest value and move it to the first position
*3 It will print original array
*4 It's trying to swap the index and the position of the values, it's not doing it in the array
*5 Pass the array down and then the number we want to swap and that we want to swap it with.
*
*