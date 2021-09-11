// Frederic Iranzi.
// Winter semeter 2021
// Console Assignment 1
// I would describe this course as a programming course that will cover C# programming skills with analysis and design of a software. 


// using:  help to manage resources and release all the resources automatically.
using static System.Console; //I used this console here to avoid to repeating in the main method or elsewhere in this program.

// namespace:Organaze and provide a level of separation of codes.
namespace Console_Assignement1
{
    // class: Defines the kind of date and functionality their objects will have.
    class Program 
    {
        // The main menthod here is used when you want the program to execute. Withough main, no output can be expected. U can compile but not run if no main method available
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //WhiteLine: is a method from Console that is used to printout the output of a given information on the console. 
            WriteLine("My major is Computer Science");
            WriteLine("I don't have much history in programming, this is my second class for programming after CIS 150");
            WriteLine("The reason I take CIS 207 is because i am study computer science and I am very interested in programming. So CIS 207 will help me to become a good programmer");
            WriteLine("I am look forward to work hard in CIS 207 I hope will help me into next classes for programming");
        }
    }
}
