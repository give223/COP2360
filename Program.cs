using System; // Importing the System namespace for basic functionality
using System.Collections.Generic; // Importing the namespace for using collections like Dictionary and List

class Program
{
    // Dictionary to store MLB teams and their details
    static Dictionary<string, List<string>> mlbTeams = new Dictionary<string, List<string>>();

    // Method to populate the dictionary with MLB teams and their details
    static void PopulateDictionary()
    {
        mlbTeams["Boston Red Sox"] = new List<string> { "Fenway Park", "David Ortiz", "Mookie Betts" };
        mlbTeams["New York Yankees"] = new List<string> { "Yankee Stadium", "Derek Jeter", "Aaron Judge" };
        mlbTeams["Houston Astros"] = new List<string> { "Minute Maid Park", "Jose Altuve", "George Springer" };
    }

    // Method to display the contents of the dictionary
    static void DisplayDictionaryContents()
    {
        // Iterate through each team in the dictionary
        foreach (var team in mlbTeams)
        {
            // Print the team name
            Console.WriteLine($"Team: {team.Key}");
            Console.WriteLine("Details:");
            // Iterate through each detail of the team and print it
            foreach (var detail in team.Value)
            {
                Console.WriteLine($"- {detail}");
            }
            Console.WriteLine(); // Print a blank line for better readability
        }
    }

    // Method to insert a new MLB team and its details
    static void AddNewTeam()
    {
        Console.WriteLine("What is the name of the team?");
        String teamName = Console.ReadLine();
        Console.WriteLine("What is the stadium of the team?");
        String teamStadium = Console.ReadLine();
        Console.WriteLine("What are two players on the team?");
        String player1 = Console.ReadLine();
        String player2 = Console.ReadLine();
        mlbTeams[teamName] = new List<string> {teamStadium, player1, player2};
    }

    // The start of the program
    static void Main(string[] args)
    {
        AddNewTeam();
        DisplayDictionaryContents();
    }
}