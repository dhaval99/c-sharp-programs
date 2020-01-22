/************************************************************************
 * Program:     MidTermMarkCalculation                                  *
 *                                                                      *
 * Author:      Dhaval Shah                                             *
 * Date:        21th March 2018                                         *
 *                                                                      *
 * Description: This program is used to determine one's mid-term mark   *
 *              given input received from the user.                     *
 *              In this case, the program is set up to use arrays.      *
 *              It will accept a series of whole numbers between        *
 *              0 and 100 from the user based on the assessments in     *
 *              PROG 1205 for Fall 2014. There will be a loop to        *
 *              accept ICE data, a loop to accept CRA data, a loop for  *
 *              Labs and a loop for Tests. It will then calculate the   *
 *              averages for each category as well as a final mark      *
 *              based on those averages and display them to the user.   *
 *              Within each loop to accept data for a different type    *
 *              of assessment, some validation is performed.            *
 *                                                                      *
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermMarkCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * DECLARATIONS
             */


            // Declare constants for the number of ICEs, CRCs, and Labs
            // as well as constants for the overall category maximum values: ICE, CRC, and Lab.

            const int NUMBER_OF_ICES_INCLUDED = 8;  // for the number of all ICEs that count at present
            const double OVERALL_ICE_VALUE = 0.20; // the percentage that ICEs are worth, overall

            const int NUMBER_OF_CRCS_INCLUDED = 4;  // for the number of all CRCs that count at present
            const double OVERALL_CRC_VALUE = 0.40; // the percentage that CRCs are worth, overall

            const int NUMBER_OF_LABS_INCLUDED = 2;  // for the number of all Labs that count at present
            const double OVERALL_LAB_VALUE = 0.40; // the percentage that Labs are worth, overall

            // Declare an array for each of these evaluation types with a number of elements equal to the constant representing the number of evaluations.
            double[] iceScores = new double[NUMBER_OF_ICES_INCLUDED];
            double[] crcScores = new double[NUMBER_OF_CRCS_INCLUDED];
            double[] labScores = new double[NUMBER_OF_LABS_INCLUDED];

            // Declare a variable for the average grade in each evaluation category.

            double iceAverage = 0; // average ICE grade
            double crcAverage = 0; // average CRC grade
            double labAverage = 0; // average Lab grade

            // Declare a variable for the total grade overall.

            double overallAverage = 0; // average overall grade
            
            
            
            /*
             * INPUT
             */


            // Iterating up to the total number of ICEs...
            for (int iceCounter = 1; iceCounter < NUMBER_OF_ICES_INCLUDED + 1; iceCounter++)
            {
                // Prompt the user for their grade on each ICE as a real number out of 100
                Console.Write("Please enter your grade on ICE " + iceCounter + ": ");

                // Validate input from the user - re-prompt as needed
                // The use of TryParse below will store each valid value in 
                // elements in the array for ICE grades
                if (Double.TryParse(Console.ReadLine(), out iceScores[iceCounter - 1]) == false)
                {
                    // If the input is non-numeric, it will prompt for input again
                    Console.WriteLine("\nGrades must be entered as whole numbers.");
                    iceCounter--;
                }
                else if ((iceScores[iceCounter-1] < 0) || (iceScores[iceCounter-1] > 100))
                {
                    // If the input is out-of-range, it will prompt for input again
                    Console.WriteLine("\nGrades must be between 0 and 100.");
                    iceCounter--;
                }

            }





            /*
             * PROCESSING
             */

            // Determine the average of the ICE array, store this in the relevant variable

            // *** AVERAGE METHOD 1 ***

            iceAverage = iceScores.Average(); // this is the easy way to get an average from a
                                              // numeric array; it is expressly forbidden on
                                              // Lab 4, based on the requirements

           

            // Determine the average of the CRC array, store this in the relevant variable

            // *** AVERAGE METHOD 2 ***

            // Here's another way to determine an average, which should seem
            // familiar if you've watched the arrays videos
            for (int crcCounter = 1; crcCounter < crcScores.Length + 1; crcCounter++)
            {
                Console.Write("\nPlease enter your grade on CRC" + crcCounter + " : ");

                if (Double.TryParse(Console.ReadLine(), out crcScores[crcCounter - 1]) == false)
                {
                    // If the input is non-numeric, it will prompt for input again
                    Console.WriteLine("\nGrades must be entered as whole numbers.");
                    crcCounter--;
                }
                else if ((crcScores[crcCounter - 1] < 0) || (crcScores[crcCounter - 1] > 100))
                {
                    // If the input is out-of-range, it will prompt for input again
                    Console.WriteLine("\nGrades must be between 0 and 100.");
                    crcCounter--;
                }


                crcAverage += (crcScores[crcCounter - 1] / NUMBER_OF_CRCS_INCLUDED);
            }

            // this is adding the scores on each CRC and dividing by the total number of CRCs
            for (int labCounter = 1; labCounter < labScores.Length + 1; labCounter++)
            {
                Console.Write("\nPlease enter your grade on LAB" + labCounter + " : ");

                if (Double.TryParse(Console.ReadLine(), out labScores[labCounter - 1]) == false)
                {
                    // If the input is non-numeric, it will prompt for input again
                    Console.WriteLine("\nGrades must be entered as whole numbers.");
                    labCounter--;
                }
                else if ((labScores[labCounter - 1] < 0) || (labScores[labCounter - 1] > 100))
                {
                    // If the input is out-of-range, it will prompt for input again
                    Console.WriteLine("\nGrades must be between 0 and 100.");
                    labCounter--;
                }


                labAverage += (labScores[labCounter - 1] / NUMBER_OF_LABS_INCLUDED);
            }

          



            // *** YOU CAN COMPLETE THE PROCESSING FOR Labs ***
            // Do this using a loop rather than the Array.Average() method.

            // Determine the average of the Lab array, store this in the relevant variable


            // Determine the total grade overall:
           

            // Total grade overall: add the average of the Lab array multiplied by the value of the Lab array (0.40)
            overallAverage += labAverage * OVERALL_LAB_VALUE+iceAverage*OVERALL_ICE_VALUE + crcAverage * OVERALL_CRC_VALUE;


            /*
             * OUTPUT
             */




            // *** YOU CAN COMPLETE THE OUTPUT ***
            // This should be easy; it's barely even array-related.

            // Output the average of the ICE array (already determined above), with an appropriate identifier
            Console.Write("\n ICE average {0:n2}", iceAverage);

            // Output the average of the CRC array (already determined above), with an appropriate identifier
            Console.Write("\n CRC average is {0:n2}", crcAverage);

            // Output the average of the Lab array (already determined above), with an appropriate identifier
            Console.Write("\n LAB average is {0:n2}", labAverage);

            // Output the total grade overall (already determined above), with an appropriate identifier.
            Console.Write("\nTotal overall midterm average is {0:n2}", overallAverage);




            // Prompt the user to press a key to exit
            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();
	        
        }
    }
}
