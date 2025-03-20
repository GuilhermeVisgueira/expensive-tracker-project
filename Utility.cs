namespace ExpenseTracker;

public static class Utility
{
    // Print a message and read a string from the console
    public static string PrintAndRead(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
}