//Project name-BodyMassIndexCategory
//Name-Dhaval Pankajkumar Shah 
//Date-28th February,2018
/*Description-This program illustrates that how to calculate BMI of a person using 
weight and height in pounds and inches respectively entered by user and categorized them 
into various specific categories using if-else statements */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variable for height to store the value of height entered by the user
            double height = 0.0;

            //Declare variable for weight to store the value of weight entered by the user 
            double weight = 0.0;

            //Declare matricfactor=703 as a constant variable using double datatype
            const double matricfactor = 703;
            //Declare variable to store the calculated value of BMI 
            double BodyMassIndex = 0;
            //Declare maximumHeight = 120 as a constant variable using double datatype
            const double maximumHeight = 120;
            //Declare minimumHeight = 5 as a constant variable using double datatype
            const double minimumHeight = 5;
            //Declare maximumWeight = 999 as a constant variable using double datatype
            const double maximumWeight = 999;

            //Declare minimumWeight = 0.5 as a constant variable using double datatype
            const double minimumWeight = 0.5;
            //Prompt user to enter height in inches
            Console.Write("Please enter the person's height in inches:");

            if (double.TryParse(Console.ReadLine(), out height))
            {
                if (height <= maximumHeight && height >= minimumHeight)
                {
                    //Prompt user to enter weight in pounds
                    Console.Write("Please enter the person's weight in pounds:");
                    //using if statement and TryParse( ) method to ensure that user input is numeric
                    if (double.TryParse(Console.ReadLine(), out weight))
                    {
                        //using if statement ensure that user input is between maximumWeight and minimumWeight
                        if (weight <= maximumWeight && weight >= minimumWeight)
                        {
                            //using formula to calculate Body Mass Index 
                            BodyMassIndex = Math.Round(((weight / Math.Pow(height, 2)) * matricfactor), 1);
                            //using if statement to set the criteria that Body Mass Index should be less than 16 
                            if (BodyMassIndex < 16)
                            {
                                //Showing message that The BMI for a __ tall person who weighs __ lb. is __, which is categorized as “severely underweight”.
                                Console.WriteLine("\nThe BMI for a {0:n1} inches tall person who weighs {1:n1} lb. is {2:n1},which is categorised as \"severely underweight\".", height, weight, BodyMassIndex);
                            }
                            /*using else if statement to set the criteria that Body Mass Index should be greater than or equal to 16 and 
                            less than 18.5*/
                            else if (BodyMassIndex >= 16 && BodyMassIndex < 18.5)
                            {
                                //Showing message that The BMI for a __ tall person who weighs __ lb. is __, which is categorized as “underweight”.
                                Console.WriteLine("\nThe BMI for a {0:n1} inches tall person who weighs {1:n1} lb. is {2:n1},which is categorised as \"underweight\".", height, weight, BodyMassIndex);
                            }
                            /*using else if statement to set the criteria that Body Mass Index should be greater than or equal to 18.5 and 
                           less than 25*/
                            else if (BodyMassIndex >= 18.5 && BodyMassIndex < 25)
                            {
                                //Showing message that The BMI for a __ tall person who weighs __ lb. is __, which is categorized as “healthy”.
                                Console.WriteLine("\nThe BMI for a {0:n1} inches tall person who weighs {1:n1} lb. is {2:n1},which is categorised as \"healthy\".", height, weight, BodyMassIndex);
                            }/*using else if statement to set the criteria that Body Mass Index should be greater than or equal to 25 and 
                           less than 30*/
                            else if (BodyMassIndex >= 25 && BodyMassIndex < 30)
                            {
                                //Showing message that The BMI for a __ tall person who weighs __ lb. is __, which is categorized as “overweight”.
                                Console.WriteLine("\nThe BMI for a {0:n1} inches tall person who weighs {1:n1} lb. is {2:n1}, which is categorised as \"overweight\".", height, weight, BodyMassIndex);
                            }
                            
                            //using else if statement to set the criteria that Body Mass Index should be greater than or equal to 30 
            
                            else if (BodyMassIndex >= 30)
                            {
                                //Showing message that The BMI for a __ tall person who weighs __ lb. is __, which is categorized as “obese”.
                                Console.WriteLine("\nThe BMI for a {0:n1} inches tall person who weighs {1:n1} lb. is {2:n1}, which is categorised as \"obese\".", height, weight, BodyMassIndex);
                            }
                        }
                        //using else statement to show the error message 
                        else
                        {
                            //Showing error message that The weight entered must be between 0.5 l.b. and 999 l.b. inclusive
                            Console.WriteLine("\nENTRY ERORR!\n\nThe weight entered must be between 0.5 l.b. and 999 l.b. inclusive");
                        }
                    }
                    //using else statement to show the error message 
                    else
                    {
                        //Showing error message that the value entered must be numeric 
                        Console.Write("\nENTRY ERROR!\n\n the value entered must be numeric");
                    }
                }
                //using else statement to show the error message
                else
                {
                    //Showing the error message that The height entered must be between 5” and 120” inclusive.
                    Console.WriteLine("\nENTRY ERROR!\n\nThe height entered must be between 5\" and 120\" inclusive");
                }
            }
            //using else statement to show the error message
            else
            {
                //Showing error message that the value entered must be numeric 
                Console.Write("\nENTRY ERROR!\n\n the value entered must be numeric");
            }
            //Prompt the user to press any key to end the application
            Console.Write("\nPress any key to end this application. . .");
            //Pause the execution of code until any key is pressed by the user 
            Console.ReadKey();




        }
    }


}
    

