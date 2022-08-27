using System;


public class Assignment1C 
{
  
  public static void Main (string[] args)
  {
    
    Console.Write("Please enter a letter: ");
    char letter = Convert.ToChar(Console.ReadLine());
    
    char next = (char) (((int)letter) + 1);
    char second = (char) (((int)next) + 1);
    char last = (char) (((int)second) + 1);

    Console.Write("The next letters after " + letter + " are " + next +", " + second + ", and " + last + "!");
    
    

    

    
    
  }
}