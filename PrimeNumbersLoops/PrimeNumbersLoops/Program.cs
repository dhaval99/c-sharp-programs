using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            



                //declaration of  variable 

                int limit = 0;     // delclaring variable for user input 



            int inspect = 1;  //declaring variable to deal with the loop that shows prime numbers and letter "X" according to the entered limit



            //printing stars and program name 


            Console.WriteLine("***********************************************************************************************************");




            Console.WriteLine("                                       PRIME NUMBER FINDER");

                Console.WriteLine("***********************************************************************************************************");

                

                //Propt user to enter the limit 

                Console.WriteLine("Enter a limit to the prime numbers you want displayed: ");


                //using do-while loop 

                do

                {

                //using tryparse method to check wheather the entered number is whole number or not (data validation )



                if (!int.TryParse(Console.ReadLine(), out limit))
                    {

                    
                    // Data validation is implemented and showing error message 



                  Console.WriteLine("The value entered must be a whole number. Please try again: ");

                    }


                // implementing the condition that the number is between required range or not 



                else if (limit >= 2 && limit <= 70)

                    {

                        inspect = 0;
                    }



                else

                    //error message 

                    {


                    Console.WriteLine("The value entered must be between 2 and 70. Please try again: ");
                    }



                } while (inspect == 1);  //stoping loop execution with the required while statement

               
            // clears the screen
                Console.Clear();


                //showing the required result 
                Console.WriteLine("***********************************************************************************************************************");


            Console.WriteLine("                                    PRIME NUMBER UP TO " + limit);




            Console.WriteLine("***********************************************************************************************************************\n");

                

                //executing for loop for the required result 

                for (int l = 1; l <= limit; l++)


            {


                for (int m = 2; m <= l; m++)
                    {


                    if (l != m && l % m == 0)           //determinig that the number is prime or not 


                    {

                        inspect = 0;                        // using declared variable to satisfy the requirements 

                        }


                    }

                    if (inspect == 1)                  // executing if statement if value of inspect variable is one
                    {



                    for (int n = 0; n < l; n++)     // using loop for the required structure

                        {

                        Console.Write("X");      //showing "X" in required manner 
                        }

                        Console.WriteLine("" + l);
                    }

                    inspect = 1;                        // returning value of one according to the results and store one as a value inside inspect variable
                
                }


            //Prompt user to end the program 


            Console.WriteLine("Press any key to terminate the program");

            //Stop the program execution 


            Console.ReadKey();
            }
        }
    }
    
