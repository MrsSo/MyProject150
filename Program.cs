using System;

class Program 
{
  public static void Main (string[] args) 
  {
    string input = "49"; // or use "49" in a notebook
    try
    {
      int age = int.Parse(input);
      Console.WriteLine($"You are {age} years old.");
    }
    