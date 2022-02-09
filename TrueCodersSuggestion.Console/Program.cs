using System;
using TrueCodersSuggestion.Library;
using static System.Console;

namespace TrueCodersSuggestion.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var suggestion = new Suggestion();

            WriteLine("Please give your first name!");
            student.FirstName = ReadLine();

            WriteLine("Please give your last name!");
            student.LastName = ReadLine();

            WriteLine("Please enter the corresponding number. What is your Teachers name?\n1.Ben Bryant\n2.Jeremy Huddleston\n3.John Ward");
            switch (ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    student.TeacherName = "Ben Bryant";
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    student.TeacherName = "Jeremy Huddleston";
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    student.TeacherName = "John Ward";
                    break;
            }

            WriteLine("Please enter your class name. Example: CSharp-24 OR Node-6");
            student.ClassName = ReadLine().ToUpper();

            do
            {
                Clear();
                WriteLine("Do you want this suggestion to be anonymous? y/n (invalid inputs will be marked as NOT ANONYMOUS)");
                var isAnon = ReadLine().ToLower();

                if (isAnon == "y")
                {
                    suggestion.IsAnonymous = true;
                    WriteLine("Entering anonymous mode");
                }

                WriteLine($"{student.FirstName}, please write your suggestion.");
                suggestion.Description = ReadLine();

                WriteLine($"Thank you, {student.FirstName}! We have added this to our database. Would you like to submit another response? y/n (invalid inputs will terminate the application)");                

            } while (ReadLine().ToLower() == "y");

            Environment.Exit(0);
        }
    }
}
