//Project name-BodyMassIndexCal
//Name-Dhaval Pankajkumar Shah 
//Date-14th February , 2018
/*Description-This program illustrates that how to calculate BMI of a person using 
weight and height in pounds and inches respectively entered by user*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexCal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variable for weight to store the value of weight entered by the user
            double weight = 0.0;
            
            //Declare variable for height to store the value of height entered by the user 
            double height = 0.0;
            
            //Declare variable to store the calculated value of BMI 
            double BMI = 0.0;
           
            //Declare mf=703 as an integer
            const int mf = 703;
            
            //Prompt user to enter weight in pounds
            Console.Write("Enter weight of the person in pounds");
            
            //Store value entered by the user in weight variable 
            weight = Convert.ToDouble(Console.ReadLine());
            
            //Prompt user to enter height in inches
            Console.Write("Enter height of the person in inches ");
            
            //Store value entered by the user in height variable
            height = Convert.ToDouble(Console.ReadLine());
            
            //Formula to calculate BMI of the person
            BMI = (weight * mf) / (Math.Pow(height, 2));
            
            //Showing message "the BMI of the person who is _ inches tall and weighs _ pounds is _ "
            Console.WriteLine("BMI of the person who is {0:n1} tall and weighs {1:n1} is {2:n1}", height, weight, BMI);
            
            //Prompt the user to press any key to end the application
            Console.Write("\nPress any key to end this application");
            
            //Pause the execution of code until any key is pressed by the user 
            Console.ReadKey();
        }
    }
}
