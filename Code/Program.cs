using System;
using System.ComponentModel;
public class Panda
{
  string name;     
  int age;            
  public Panda (string n)
  {
    name = n; 
  }
  public Panda (string n, int a)
  {
    name = n; 
    age = a;
  }
  public void Print()
  {
    if (age == 0)
    {
        Console.WriteLine("Panda" + name + " has no recorded age! Would you like to add one?");
        string answer;
        answer = Console.ReadLine();
        answer = answer.ToUpper();
        if (answer == "YES")
        {
            Console.WriteLine("Great! What is it?");
            string inputAge;
            inputAge = Console.ReadLine();
            if (Int32.TryParse(inputAge, out age))
            {
                Print();
            }
            else
            {
                Console.WriteLine("That is not a number!");
            }
        }
        else
        {
          
        }
    }
    else 
    {
        Console.WriteLine("Panda " + name + " is " + age + " years old.");
  }
    }
}


