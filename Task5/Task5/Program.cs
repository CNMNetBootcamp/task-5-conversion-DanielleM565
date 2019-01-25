using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            //TODO: Initialize all variables
            double value1; //to conver to something else
            Single convertOptions; //Conversion Options
            double multipyByFour = 4; //gallons to quarts and quarts to cups
            double divideBySixteen = .0625; //cups to gallons divide by 16
            double value2; //answer
            string units; // final units
            string continueAnswer; // loop repeat yes or no option

            //input
            do
            {
                do
                {
                    Console.WriteLine("What is the numerical value of your measurement that you would like to convert?");
                } while (!Double.TryParse(Console.ReadLine(), out value1));

                do
                {
                    Console.WriteLine("What would you like to do with this measurment? (1) Convert Cups to Quarts (2) Convert Cups to Gallons (3) Convert quarts to cups");
                } while (!Single.TryParse(Console.ReadLine(), out convertOptions));

                //process
                if (convertOptions == 1) //gallons to quarts and quarts to cups
                {
                    //TODO: Refactor away from magic numbers
                    value2 = value1 * multipyByFour;
                    units = " Quarts";
                }
                else if (convertOptions == 2) //cups to gallons
                {
                    //TODO: Refactor away from magic numbers
                    value2 = value1 * divideBySixteen;
                    units = " Gallons";
                }
                else
                {
                    //TODO: Refactor away from magic numbers
                    value2 = value1 * multipyByFour; //quarts to cups
                    units = " cups";
                }

                //output
                Console.WriteLine("Your converted measurment is " + value2 + units);

                Console.WriteLine("Do you wish to continue? (Y)es (N)o");
                continueAnswer = Console.ReadLine();

            } while (continueAnswer == "Y");
           
            Console.ReadLine();
        }
    }
}

