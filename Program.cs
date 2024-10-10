using System;

public class Program
{
    public static void Main(string[] args)
    {
        //name
        Console.WriteLine("Hi, please answer this questionnaire!");
        Thread.Sleep(3000);
        Console.WriteLine(" ");
        Console.WriteLine("What is your name?");

        string name = Console.ReadLine();

        //age
        Console.WriteLine(" ");
        Console.WriteLine("Hi " + name + ", what is your age?");
        
        string age = Console.ReadLine().ToLower();

        //eyeColor
        Console.WriteLine(" ");
        Console.WriteLine("What color are your eyes?");

        string eyeColor = Console.ReadLine().ToLower();

        //hairColor
        Console.WriteLine(" ");
        Console.WriteLine("What color is your hair?");

        string hairColor = Console.ReadLine().ToLower();

        //shoeSize
        Console.WriteLine(" ");
        Console.WriteLine("What is your shoe size?");

        string shoeSize = Console.ReadLine().ToLower();

        //favoriteColor
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite color?");

        string favoriteColor = Console.ReadLine().ToLower();

        //favoriteShowOrMovie
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite tv show or movie?");

        string favoriteShowOrMovie = Console.ReadLine();

        //favoriteTeacher
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite teacher?");

        string favoriteTeacher = Console.ReadLine();

        //favoriteClass
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite class?");

        string favoriteClass = Console.ReadLine();

        //favoriteHoliday
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite holiday?");

        string favoriteHoliday = Console.ReadLine();

        //favoriteSeason
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite season?");

        string favoriteSeason = Console.ReadLine().ToLower();

        //dreamJob
        Console.WriteLine(" ");
        Console.WriteLine("What is your dream job?");

        string dreamJob = Console.ReadLine().ToLower();

        //siblingCount
        Console.WriteLine(" ");
        Console.WriteLine("How many siblings do you have?");

        string siblingCount = Console.ReadLine().ToLower();

        //uhh...
        Console.WriteLine(" ");
        Console.WriteLine("What is your mother's maiden name?" + " What is the name of your first pet?" + " What was your first car?" + " What is your social security number?");

        Thread.Sleep(3000);
        Console.WriteLine("jk");
        Thread.Sleep(1000);
        Console.WriteLine(" ");

        //output
        Console.WriteLine("My friend's name is " + name + ". " 
        + name + " is " + age + " years old. " 
        + name + "'s eye color is " + eyeColor + ". " 
        + name + "'s hair color is " + hairColor + ". " 
        + name + "'s shoe size is " + shoeSize + ". " 
        + name + "'s favorite color is " + favoriteColor + ". " 
        + name + "'s favorite show or movie is " + favoriteShowOrMovie + ". " 
        + name + "'s favorite teacher is " + favoriteTeacher + ". " 
        + name + "'s favorite class is " + favoriteClass + ". " 
        + name + "'s favorite holiday is " + favoriteHoliday + ". " 
        + name + "'s favorite season is " + favoriteSeason + ". " 
        + name + " wants to be a " + dreamJob + ". " 
        + name + " has " + siblingCount + " sibling/s. ");
        Console.WriteLine(" ");
    }
}
