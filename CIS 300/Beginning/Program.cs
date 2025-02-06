internal class Program
{
    private static void Main(string[] args)
    {
        //Data Types
        string name = "Tom Cruise";
        int age = 35;
        char grade = 'A';
        double gpa = 3.5;
        bool isMale = true;

        //Outputting Things
        Console.WriteLine(name.Length);
        Console.WriteLine(name.ToUpper());
        Console.WriteLine("There once was a man named " + name);
        Console.WriteLine("He was " + age + " years old");
        Cosole.WriteLine(name.IndexOf("Cruise"));
        Console.WriteLine(name.Substring(4, 3));

        name = "Mike";
        age = "20";

        Console.WriteLine("He really\nliked the name " + name);
        Console.WriteLine("But didn't like being " + age);
        
        Console.ReadLine();
    }
} 