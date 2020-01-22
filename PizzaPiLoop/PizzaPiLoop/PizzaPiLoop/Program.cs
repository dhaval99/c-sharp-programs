using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPiLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            double pizzaArea; // area of pizza
            double diameter; // diameter of the pizza 
            double sliceArea; // area of the slices
            double radius; // divide the diameter by two
            double slices = 0; // number of pizza slices
            const int MAXIMUM_DIAMETER = 36; // maximum entry for diameter 
            const int LARGE_DIAMETER = 30; // diameter range used to figure out slices
            const int MEDIUM_DIAMETER = 24; // diameter range used to figure out slices
            const int SMALL_DIAMETER = 16; // diameter range used to figure out slices
            const int MINIMUM_DIAMETER = 12; // minimum entry for diameter 
            const int SMALL_SLICE_MAXIMUM = 8; // number of pizza slices depend on diameter 
            const int MEDIUM_SLICE_MAXIMUM = 12; // number of pizza slices depend on diameter
            const int LARGE_SLICE_MAXIMUM = 16; // number of pizza slices depend on diameter 
            const int EXTRA_LARGE_SLICE_MAXIMUM = 24; // number of pizza slices depend on diameter
            bool needInput = true; // required input is true or false 
            const int END_PROGRAM = 0; // terminates program if its 0


            // prompt user to enter input 

            Console.Write("Please enter the diameter of your pizza: ");
            //storing user input into varible 
            diameter = Convert.ToDouble(Console.ReadLine());

            // using while loop to if the is 0 and if the input is required (true)

            do

            {
                // check if the diameter is between 12" to 36"
                // if it is not then prompt user to enter it again 

                if (diameter < MINIMUM_DIAMETER || diameter > MAXIMUM_DIAMETER)
                {
                    Console.WriteLine("ENTRY ERROR\nPizza must have a diameter in the range of  12” to 36”  inclusive!\nPlease try again.");
                }


                else
                {
                    needInput = false;
                    // required slices based on diameter

                    if (diameter < SMALL_DIAMETER)
                    {
                        slices = (SMALL_SLICE_MAXIMUM);
                    }
                    else if (diameter < MEDIUM_DIAMETER)
                    {
                        slices = (MEDIUM_SLICE_MAXIMUM);
                    }
                    else if (diameter < LARGE_DIAMETER)
                    {
                        slices = (LARGE_SLICE_MAXIMUM);
                    }
                    else
                    {
                        slices = (EXTRA_LARGE_SLICE_MAXIMUM);
                    }

                    Console.Clear();

                    Console.WriteLine("A {0}\" Pizza diameter: {0}\".", diameter);
                    Console.WriteLine("======================================");

                    for (int slicesAddFour = 8; slicesAddFour <= slices; slicesAddFour += 4) //for each slices
                    {
                        // calculation of area 
                        radius = diameter / 2;
                        pizzaArea = Math.PI * Math.Pow(radius, 2); // using math class
                        sliceArea = Math.Round((pizzaArea / slicesAddFour), 2);

                        Console.WriteLine("Cut in {0} slices results in an area of {1}\" per slice. ", slicesAddFour, sliceArea);
                    }
                }
                Console.Write("Please enter the diameter of your pizza (0 to exit): ");
                diameter = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                // set the need input value back to true for new entry
                needInput = true;
            } while (diameter != END_PROGRAM && needInput);
        }
    }
}


                                  
                            

