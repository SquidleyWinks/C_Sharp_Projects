using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_Part_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            string[] JLA = { "Superman ", "Batman ", "Wonder Woman ", "The Flash ", "Green Lantern ", "Aquaman ", "Martian Manhunter " }; // create our standard array of the JLA roster
            Console.WriteLine("Please enter some text"); // prompt user for text
            string userText = Console.ReadLine(); // set variable for the user's input
            for (int i = 0; i < JLA.Length; i++) // standard setup for a for loop to iterate through each item in an array
            {
                JLA[i] = JLA[i] + userText; // sets the array element to itself plus the user's text (with this step, I added a space after each element of the array, so the user wouldn't have to worry about concatenating it properly)
            }
            for (int p = 0; p < JLA.Length; p++) // another loop
            {
                Console.WriteLine(JLA[p]); // this time for producing the results of our array plus user input
            }
            
            // Assignment Part 2
            for (int f = 0; f < JLA.Length; f++)
            {
                JLA[f] = JLA[f] + userText;
                Console.WriteLine(JLA[f]);
               // f--; This was the most simple infinite loop (and fix) I could think of. Adding in a decriment at the end of the executed code would effectively reset the loop to repeat the first iteration over and over. It was fixed by commenting out that line.
            }

            // Assignment Part 3
            // used '<' operators above.

            for (int l = 0; l <= 6; l++) // might be a bit of a cheat, but I just hard coded in the final index of the array in order to use <= rather than just <
            {
                JLA[l] = JLA[l] + userText;
                Console.WriteLine(JLA[l]); // It's hardly an elegant solution, but I'm still trying to catch up
            }

            // Assignment Part 4
            List<string> listJLA = new List<string>() { "Superman", "Batman", "Wonder Woman", "The Flash", "Green Lantern", "Aquaman", "Martian Manhunter" }; // sticking with what I know
            Console.WriteLine("Name a superhero to see if they are a member of the JLA"); // took a minute to figure out a search method
            string member = Console.ReadLine(); // stores user input in a variable
            for (int i = 0; i <= listJLA.Count; i++) // sets up the iteration count -- using <= so that we have an opprotunity to go through the entire list and then one more time
            {
                if (i == 7) // I originally had this block second, but there was an error with trying to look for listJLA[7], so I moved it up
                {
                    Console.WriteLine(member + " is not a member of the JLA (double check input for misspellings or improper capitalization)"); // took the opprotunity to reuse the user input rather than just "that hero"
                    break; // breakpoint, so we don't go looking for listJLA[7]
                }
                if (member == listJLA[i]) // checks to see if the user input matches a list item
                {
                    Console.WriteLine(listJLA[i] + " is a member of the JLA"); // produces that list item
                    break; // breakpoint, so we know when to stop once we've found a match
                }
            }

            // Assignment Part 5
            List<string> Batmans = new List<string>() { "Batman", "Batman", "Batman", "Batman", "Batman", "Batman", "Batman" }; // getting a little goofy with this one
            Console.WriteLine("Who is the most popular member of the JLA?");
            string popular = Console.ReadLine();  // variable for user input
            for (int i = 0; i < Batmans.Count; i++) // iterates through the list
            {
                if (popular == Batmans[i]) // checks for user input matching list item
                {
                    Console.WriteLine("Na na na na na na na na " + Batmans[i]); // had some fun here, ngl
                }
                if (i == 6 && popular != "Batman") // this check took me a minute to come up with. Had to take the <= back to <. First attempt had this getting produced after the correct match. Second attempt had this producing with every match. Satisfyied with how it turned out, but I feel like I kinda fell backwards into the solution
                {
                    Console.WriteLine(popular + " isn't that popular..."); // statement letting user know they guessed wrong
                }
            }

            // Assignment Part 6
            // Going to reuse the Batmans for this one; buckle up
            string first = ""; // declare an 'empty' string variable here
            foreach (string Batman in Batmans) // for each loop checking each Batman in Batmans
            {
                if (Batman != first) // executes if Batman is not equal to our empty variable
                {
                    Console.WriteLine(Batman + " - this item is unique"); // declares item unique
                    first = Batman; // sets our empty variable to our list item. This way, after the first Batman, every other one will not pass the inital check, and default to the else statement
                }
                else 
                {
                    Console.WriteLine(Batman + " - this item is a duplicate"); // declares item duplicate
                }
            }
            Console.ReadLine();
        }
    }
}
