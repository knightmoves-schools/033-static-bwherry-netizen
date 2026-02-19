namespace knightmoves;

public class Account
{
    // Public static class-level string variable
    public static string Name;

    // Static constructor
    static Account()
    {
        Name = "Main Account";
    }

    // Public static method that takes a parameter
    public static string ChangeName(string newName)
    {
        Name = newName;
        return Name;
    }
}

