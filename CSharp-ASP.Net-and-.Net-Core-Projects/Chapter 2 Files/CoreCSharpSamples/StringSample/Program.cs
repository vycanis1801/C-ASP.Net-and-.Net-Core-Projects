using static System.Console;

class Program
{
    static void Main()
    {
        // Old way
        string s1 = "a string";
        string s2 = s1;
        WriteLine("s1 is " + s1);
        WriteLine("s2 is " + s2);
        s1 = "another string";
        WriteLine("s1 is now " + s1);
        WriteLine("s2 is now " + s2);

        // New way with C# 6.
        string s3 = "a string";
        string s4 = s3;
        WriteLine($"s3 is { s3 }");
        WriteLine($"s4 is { s4 }");
        s3 = "another string";
        WriteLine($"s3 is now { s3 }");
        WriteLine($"s4 is now { s4 }");
    }
}