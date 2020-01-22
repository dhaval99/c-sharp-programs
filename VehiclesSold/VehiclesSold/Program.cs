
/*Program: Vehicles Sold                                  
                                                                       
Author: Dhaval Shah                                             
Date: 28th March 2018                                         
Description: This program uses array to collect amount of vehiclesales on each day from the user and displays it according to the day.
It finds average vehicle sales, maximum and minimum vehilces sold on respective day and prompts user to rerun or to terminate the program. */                                                       

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesSold
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            const int NUMBER_OF_DAYS = 7; 

            int[] vehicleTracker = new int[NUMBER_OF_DAYS];

            string clientInput = "";

            double averageVehicleSold = 0.0;

            int addition = 0;

            int highest = 0;

            int maxVehicleSold = 0;

            int minVehicleSold = 0;

            string command = "";

            int inspectElement = 0;


            //using do-while loop 
            do


            {
                //to clear the screen off during the consecutive program run
                Console.Clear();

                //implementing for loop to store 7 days' vehicle sales
                for (int vehicleCounter = 1; vehicleCounter < NUMBER_OF_DAYS + 1; vehicleCounter++)

                {
                    //promting user to enter the first day's vehicle sales and then of the next day consecutively
                    Console.Write("Please enter the number of vehicles sold on day " + vehicleCounter + ": ");
                    
                    //assigning value to the input entered by the user
                    clientInput = Console.ReadLine();
                    
                    // using if statement to implement tryparse method to validate the user input
                    if (int.TryParse(clientInput, out vehicleTracker[vehicleCounter - 1]) == false)

                    {
                        //error message 
                        Console.WriteLine("\"" + clientInput + "\" is not a valid entry.");

                        //error message
                        Console.WriteLine("The amount must be numeric and a whole number. Please try again.");
                       
                        vehicleCounter--; // using this statement to go back to the previous loop value
                    }
                    //using an else-if statement to implement input's numeric range
                    else if ((vehicleTracker[vehicleCounter - 1] < 0) || (vehicleTracker[vehicleCounter - 1] > 50))
                    {

                        Console.WriteLine("\"" + vehicleTracker[vehicleCounter - 1] + "\" is not a valid entry.\nThe amount entered must be between 0 and 50. Please try again.");

                        vehicleCounter--; // using this statement to go back to the previous loop value

                    }
                    //using an else-if statement to implement whole number's validation
                    else if (((vehicleTracker[vehicleCounter - 1]) % 1) > 0)
                    {
                        
                        Console.WriteLine("\n\"" + clientInput + "\" is not a valid entry.\nThe amount must be a whole number. Please try again.");

                        vehicleCounter--; // using this statement to go back to the previous loop value
                    }


                }
                // Clears the screen off
                Console.Clear();
                //Printing required "====" symbol in the program heading
                     Console.WriteLine("===================================================================================================");



                // Printing required heading 
                             Console.WriteLine("                                      VEHICLES SOLD                                                ");
                // Printing required "----" symbol in the program heading
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");

                // Printing each day's vehicle sales
                    Console.WriteLine(" D1: " + vehicleTracker[0] + "   D2: " + vehicleTracker[1] + "    D3: " + vehicleTracker[2] + "    D4: " + vehicleTracker[3] + "    D5: " + vehicleTracker[4] + "    D6: " + vehicleTracker[5] + "    D7: " + vehicleTracker[6] + " ");
                // Printing required "----" symbol in the program heading
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                //using for loop to get the average vehicle sales
                         for (int vehicleCounter = 0; vehicleCounter < 7; vehicleCounter++)

                {
                    // adding vehicle sales amount 
                    addition += vehicleTracker[vehicleCounter];


                }
                // formula for average vehicle sales
                        averageVehicleSold = addition / vehicleTracker.Length;

                // Printing statement for the average vehicle sales 
                Console.WriteLine("The average number of vehicles sold per day was " + Math.Round(averageVehicleSold, 0) + " vehicles.");

                // using for loop to find maximum vehicle sales on the respective day
                     for (int vehicleCounter = 0; vehicleCounter < 7; vehicleCounter++)
                {


                    if (vehicleTracker[vehicleCounter] > highest)

                    {
                        highest = vehicleTracker[vehicleCounter];


                        maxVehicleSold = vehicleCounter + 1;
                    }


                }
                // using for loop to find minimum vehicle sales on the respective day
                     for (int vehicleCounter = 0; vehicleCounter < 7; vehicleCounter++)

                {

                    if (vehicleTracker[vehicleCounter] < highest)

                    {
                        highest = vehicleTracker[vehicleCounter];
                        minVehicleSold = vehicleCounter + 1;
                    }
                }
                // Printing the day on which highest vehicles were sold
                Console.WriteLine("The highest number of vehicles sold on Day " + maxVehicleSold + ".");



                // Printing the day on which lowest vehicles were sold
                Console.WriteLine("The lowest number of vehicles sold on Day " + minVehicleSold + ".");

                //Printing required "====" symbol 
                Console.WriteLine("===================================================================================================");
               
                //using do-while statement for the terminate or rerun the program 
                do

                {
                 // Prompting user to command if want terminate or rerun the program 
                 Console.WriteLine("Would you like to process the number of vehicles sold for another 7 days? ");

                        // Prompt user to enter desired command
                        Console.Write("\nPlease enter 'Y' to continue or 'N' to exit: ");

                    command = Console.ReadLine();

                            // using if statements for the various required commands 
                            if (command == "Y" || command == "N" || command == "y" || command == "n")
                    {
                        inspectElement++;
                    }
                }
                while (inspectElement == 0);
            }


            while (command == "Y" || command == "y");




        }
    }

}
    

