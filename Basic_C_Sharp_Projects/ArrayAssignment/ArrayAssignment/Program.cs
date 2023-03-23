using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] JLA = { "Superman", "Batman", "Wonder Woman", "The Flash", "Green Lantern", "Aquaman", "Martian Manhunter" }; // first string array is the JLA roster
            Console.WriteLine("Select a number from 0 to 6");
            int x = Convert.ToInt32(Console.ReadLine()); // sets variable for chosen index
            while (x > 6 || x < 0) // used while over if so that the prompt would repeat itself if a non-existent index was chosen twice in a row
            {
                Console.WriteLine("That index does not exist. Please select a number from 0 to 6"); // alerts user of impossible choice
                x = Convert.ToInt32(Console.ReadLine()); // prompts for selection again
            }
            Console.WriteLine(JLA[x]); // produces chosen index
            int[] nums = { 8, 24, 21, 28, 30, 32, 40 }; // int array
            Console.WriteLine("Select a number from 0 to 6 (again)");
            int y = Convert.ToInt32(Console.ReadLine()); // sets a different variable for chosen index
            while (y > 6 || y < 0) // while loop again
            {
                Console.WriteLine("That index does not exist. Please select a number from 0 to 6");
                y = Convert.ToInt32(Console.ReadLine()); // prompts for selection again
            }
            Console.WriteLine(nums[y]); // produces int array index
            List<string> TeenTitans = new List<string>() { "Robin", "Cyborg", "Starfire", "Raven", "Beast Boy" }; // for the list, I went with the classic Teen Titans roster (RIP George Perez)
            Console.WriteLine("Select a number from 0 to 4"); 
            int z = Convert.ToInt32(Console.ReadLine()); // a third variable used for index selection (upon reflection, I might have gotten away with reusing the same index variable, but I decided to play it safe
            while (z > 4 || z < 0)
            {
                Console.WriteLine("That index does not exist. Please select a number from 0 to 4");
                z = Convert.ToInt32(Console.ReadLine()); // prompts for reselection
            }
            Console.WriteLine(TeenTitans[z]); // produces the chosen index number
            Console.ReadLine();
        }
    }
}
