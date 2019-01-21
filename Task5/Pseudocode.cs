//Create a program that converts cups to quarts/gallons and quarts to cups. The program shall ask the user what they want to convert, provide appropriate messages and output the result. The user will be given an option to quit or convert another measurement

//1 gal = 4 qts = 16cups
//1 cup = 1/4qts

//setup
double value1; //to conver to something else
single convertOptions; //Conversion Options
double multipyByFour = 4; //gallons to quarts and quarts to cups
double divideByFour = .25; //quarts to gallons and cups to quarts
double divideBySixteen = .0625; //cups to gallons
double value2; //answer
string units; // final units
single continueAnswer; // loop repeat yes or no option

//input
do {
    PUT "What is the numerical value of your measurement that you would like to convert?";
    GET value1; //make sure it's a number 

    PUT "What would you like to do with this measurment? (1) Convert Cups to Quarts (2) Convert Cups to Gallons (3) Convert quarts to cups"
    GET convertOptions; // make sure answer is 1, 2 or 3
    
//process

    if (convertOptions = 1)
	{
        value2 = value1 * multiplyByFour;
        units == " Quarts";
	} else if (convertOptions = 2)
	{
        value2 = value1* divideBySixteen;
        units == " Gallons";
	} else 
	{
        value2 = value1* multiplyByFour;
        units == " cups";
	}    

//output

    PUT "Your converted measurment is " + value2 + units;



    } while (Continue? = yes)