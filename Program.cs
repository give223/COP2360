﻿// In Module 7, we discussed different Data Types and Data Structures. For this assignment, your group will develop a dictionary.
// Your group will choose the keys and associated values to be stored in the dictionary.
// Tasks to Complete:
// 1. Create a Switch Statement: Implement a switch statement that allows the user to perform the following tasks:
// a. Populate the Dictionary: Add keys and values determined by your group.
// b. Display Dictionary Contents: Show the contents of the dictionary using any of the three enumeration methods covered in Module 7.
// c. Remove a Key: Remove a specified key from the dictionary.
// d. Add a New Key and Value: Insert a new key-value pair into the dictionary.
// e. Add a Value to an Existing Key: Append a new value to an existing key.
// f. Sort the Keys: Sort the keys in the dictionary.
// 2. Submission: Submit a link to your group's work stored in a GitHub repository.
// Make sure your code is well-organized and thoroughly commented to explain each section's functionality.

using System; // Importing the System namespace
using System.Collections.Generic; // Importing the Collections namespace for using collections like Dictionary and List

class Program
{
    // Created a dictionary to store MLB teams and their details
    static Dictionary<string, List<string>> mlbTeams = new Dictionary<string, List<string>>();

    // Created a method to populate the dictionary with MLB teams and their details
    static void PopulateDictionary()
    {
        mlbTeams["Boston Red Sox"] = new List<string> { "Fenway Park", "David Ortiz", "Mookie Betts" };
        mlbTeams["New York Yankees"] = new List<string> { "Yankee Stadium", "Derek Jeter", "Aaron Judge" };
        mlbTeams["Houston Astros"] = new List<string> { "Minute Maid Park", "Jose Altuve", "George Springer" };
    }

    // Created a method to display the contents of the dictionary
    static void DisplayDictionaryContents()
    {
        // Created a collector and foreach loop to iterate through the dictionary keys
        ICollection<string> teamKeys = mlbTeams.Keys;

        foreach (var k in teamKeys)
        {
            Console.WriteLine($"Team: {k}"); // Prints the team name (key)
            Console.WriteLine("Details:"); // Prints the string 'Details:'
            
            // Created a foreach loop to iterate through each value of a team (key)
            foreach (var d in mlbTeams[k])
            {
                Console.WriteLine($"- {d}"); // Prints the team details (values)
            }
            Console.WriteLine(); // Prints a blank line for better readability
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
        PopulateDictionary(); // Calls the method to populate the dictionary
        AddNewTeam();
        DisplayDictionaryContents(); // Calls the method to display the contents of the dictionary
    }
}