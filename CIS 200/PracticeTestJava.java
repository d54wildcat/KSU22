public class PracticeTest{
    public static int indexOf(String [] words, String s){
            for(int i = 0; i < words.length; i++){
                if(words[i].equals(s)){
                return i;
                }
            }
            throw new IllegalArgumentException();
    }

}
public class GuessingGame{
    public static void main(String [] args){
        Random r = new Random();
        int val = r.nextInt(100) + 1;
        Guesser user = new Guesser(val);
        IO view = new IO();
        int guess = view.getNum();
        String result = user.checkGuess(guess);
        view.displayResults(guess,val,result);
}
//Question 6
int sum = 0;
Iterator <Integer> iterator = scores.iterator();
System.out.println("Test Scores: ");
while(iterator.hasNext()){
    int score = iterator.next();
    sum += score;
    System.out.println(score);
}
System.out.println("Average:" + (double)sum/scores.size());
System.out.println("Highest:" + scores.last());
System.out.println("Lowest:" + scores.first());
//Question 7
ArrayList<String> words = new ArrayList<String>();
HashMap<Integer, Integer> map = new HashMap<>();
Iterator<String> it = words.iterator();
while(it.hasNext()){
    String cur = it.next();
    if (map.get(cur.length() == null)){
        map.put(cur.length(), 1);
    }
    else{
        int count = map.get(cur.length());
        map.put(cur.length(), count + 1);
    }
}
System.out.print("Enter a word length to search for: ");
int key = Integer.parseInt(input.nextLine());
int count = map.get(key);
System.out.println("There are " + count + " words of length " + key);