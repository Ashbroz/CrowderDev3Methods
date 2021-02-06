// Author: Ashton Crowder
//Date: 2/5/2021

using System;

namespace CrowderDev3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please Enter Your First & Last Name");

            /* use try catch to validate user input and if the user has bad input the catch will handle the error */
            try
            {
                // This variable will gather data from user input
                string name = Console.ReadLine();

                // Takes in user input
                Console.WriteLine("Hello {0}", name);
            }
            catch
            {
                Console.WriteLine("Please enter your name");
            }
        }
    }
}
