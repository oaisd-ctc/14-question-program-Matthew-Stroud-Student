using System;

public class Program
{
    static string name;
    static int age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteMovieOrShow;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static int numberOfSiblings;
    static int ageIn5Years;

    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteMovieOrShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        AskNumberOfSiblings();
        CalculateAgeIn5Years();
        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("Hi, please answer this questionnaire!");
        Thread.Sleep(3000);
        Console.WriteLine(" ");
        Console.WriteLine("What is your name?");

        name = Console.ReadLine();
    }
    
    public static void AskAge()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Hi " + name + ", what is your age?");
        
        string ageString = Console.ReadLine().ToLower();
        age = int.Parse(ageString);
    }
    
    public static void AskEyeColor()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What color are your eyes?");

        eyeColor = Console.ReadLine().ToLower();
    }
    
    public static void AskHairColor()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What color is your hair?");

        hairColor = Console.ReadLine().ToLower();
    }
    
    public static void AskShoeSize()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your shoe size?");

        shoeSize = Console.ReadLine().ToLower();
    }
    
    public static void AskFavoriteColor()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite color?");

        favoriteColor = Console.ReadLine().ToLower();
    }
    
    public static void AskFavoriteMovieOrShow()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite movie or tv show?");

        favoriteMovieOrShow = Console.ReadLine();
    }
    
    public static void AskFavoriteTeacher()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Who is your favorite teacher?");

        favoriteTeacher = Console.ReadLine();
    }
    
    public static void AskFavoriteClass()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite class?");

        favoriteClass = Console.ReadLine();
    }
    
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite holiday?");

        favoriteHoliday = Console.ReadLine();
    }
    
    public static void AskFavoriteSeason()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite season?");

        favoriteSeason = Console.ReadLine().ToLower();
    }
    
    public static void AskDreamJob()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What is your dream job?");

        dreamJob = Console.ReadLine().ToLower();
    }
    
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine(" ");
        Console.WriteLine("How many siblings do you have?");

        string numberOfSiblingsString = Console.ReadLine().ToLower();
        numberOfSiblings = int.Parse(numberOfSiblingsString);
    }
    
    public static void CalculateAgeIn5Years()
    {
        ageIn5Years = age + 5;
    }
    
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("What are the numbers on your credit/debit card? Make sure to also include the numbers on the back.");

        Thread.Sleep(3000);
        Console.WriteLine("jk");
        Thread.Sleep(1000);
        Console.WriteLine(" ");

        Console.WriteLine
        (
        "My friend's name is " + name + ". " 
        + name + " is " + age + " years old. " 
        + name + "'s eye color is " + eyeColor + ". " 
        + name + "'s hair color is " + hairColor + ". " 
        + name + "'s shoe size is " + shoeSize + ". " 
        + name + "'s favorite color is " + favoriteColor + ". " 
        + name + "'s favorite show or movie is " + favoriteMovieOrShow + ". " 
        + name + "'s favorite teacher is " + favoriteTeacher + ". " 
        + name + "'s favorite class is " + favoriteClass + ". " 
        + name + "'s favorite holiday is " + favoriteHoliday + ". " 
        + name + "'s favorite season is " + favoriteSeason + ". " 
        + name + " wants to be a " + dreamJob + ". " 
        + name + " has " + numberOfSiblings + " sibling/s. "
        + name + " will be " + ageIn5Years + " in 5 years. "
        );
        Console.WriteLine(" ");
    }
}