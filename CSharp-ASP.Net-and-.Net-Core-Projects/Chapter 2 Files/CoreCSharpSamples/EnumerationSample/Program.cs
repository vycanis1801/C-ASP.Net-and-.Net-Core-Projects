using static System.Console;
using System;

/* 
 * This enum class declares 3 variables
 * and initializes them to different int32
 * values
 */ 
public enum TimeOfDay
{
    Morning = 0,
    Afternoon = 1,
    Evening = 2
}

class Program
{
    static void Main()
    {
        // Call the WriteGreeting Method and 
        // pass the enum Morning as an argument
        // by value.
        WriteGreeting(TimeOfDay.Morning);

        // Get the enum value by invoking the ToString method
        TimeOfDay time = TimeOfDay.Afternoon;
        WriteLine(time.ToString());

        // Parse the string into an int32
        TimeOfDay time2 = (TimeOfDay) 
        Enum.Parse(typeof(TimeOfDay), "Afternoon", true);
        WriteLine((int) time2);
    }

    /*
     * The WriteGreeting method accepts a TimeOfDay
     * enum class as an object. The method uses a switch
     * statement to change the output bassed on the enum that it 
     * recieves.
     * @param: timeOfDay (TimeOfDay) - an enum value.
     */
    static void WriteGreeting(TimeOfDay timeOfDay)
    {
        switch (timeOfDay)
        {
            case TimeOfDay.Morning:
                WriteLine("Good Morning!");
                break;
            case TimeOfDay.Afternoon:
                WriteLine("Good Afternoon!");
                break;
            case TimeOfDay.Evening:
                WriteLine("Good Night!");
                break;
            default: // If no accepatble parameter is recieved show default.
                WriteLine("Hello!");
                break;
        }
    }
}
