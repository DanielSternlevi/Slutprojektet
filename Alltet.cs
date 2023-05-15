public class alltext
{
    List<string> nyckelnamn = new List<string>();
    List<string> choices = new List<string>() { "Silver Key", "Green Key" };
    public static int roomNumber = 1;
    public static bool hasSilverkey = false;
    public static bool hasGreenkey = false;
    public static void FirstRoom()
    {
        Console.WriteLine("Skriv någon siffra för att välja vad du ska göra");
        Console.WriteLine("1. Go to the next room.");
        int option;
        if (hasSilverkey)
        {
            Console.WriteLine("2. Escape");
            option = GetIntInRange(2);
        }
        else option = GetIntInRange(1);

        if (option == 1)
        {
            Console.WriteLine("You went to the secound room");
            roomNumber = 2;
        }
        else if (option == 2)
        {
            Ending();
        }
    }
    public static void SecoundRoom()
    {
        Console.WriteLine("2.Skriv någon siffra för att välja vad du ska göra");
        Console.WriteLine("1. Go to the next room.");
        Console.WriteLine("2. Go back.");
        int option;
        if (hasSilverkey)
        {
            Console.WriteLine("3. Escape");
            option = GetIntInRange(3);
        }
        else option = GetIntInRange(2);
        if (option == 1)
        {
            Console.WriteLine("You went to the third room");
            roomNumber = 3;
        }
        if (option == 2)
        {
            Console.WriteLine("You went back to the secound room");
            roomNumber = 2;
        }
        else if (option == 3)
        {
            Ending();
        }
    }
    public static void ThirdRoom()
    {
        Console.ReadLine();
    }
    public static void FourthRoom()
    {

    }
    public static void FifthRoom()
    {

    }
    public static void Ending()
    {
        Console.WriteLine("You escaped");
    }
    static int GetIntInRange(int optionsNumber) // Denna metod omvandlar string input till int 
    {
        string input = Console.ReadLine();
        int number = 0;
        bool isConverted = int.TryParse(input, out number);
        bool isInRange = number >= 1 && number <= optionsNumber;

        while (!isConverted || !isInRange)
        {
            Console.WriteLine("You cant type that");
            input = Console.ReadLine();
            isConverted = int.TryParse(input, out number);
            isInRange = number >= 1 && number <= optionsNumber;
        }
        return number;
    }

}