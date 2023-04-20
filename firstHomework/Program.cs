using System.ComponentModel;
using System.ComponentModel.Design;

namespace firstQuestion
{
    //•	Declare variables of the following data types: int, float, and string. Assign appropriate values to each variable and output their values using Console.WriteLine().
    internal class Program
    {
        static void Question_1()
        {
            int myInt = 0;
            float myFloat = 0.0f;
            string myString = "hello";

            Console.WriteLine(myString);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
        }
    }
}

namespace secondQuestion
{
    //• Write a program that takes two integer inputs from the user and performs addition, subtraction, multiplication, and division operations on them.Display the results using Console.WriteLine().
    internal class Program
    {
        static void Question_2()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int addition = number1 + number2;
            int substraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;

            Console.WriteLine(addition);
            Console.WriteLine(substraction);
            Console.WriteLine(division);
            Console.WriteLine(multiplication);

        }
    }
}

namespace thirdQuestion
{
    //•	Create a program that accepts two numbers from the user, compares them using '==' and '!=' operators, and displays the results of the comparison using Console.WriteLine().
    internal class Program
    {
        static void Question_3()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("The first number is bigger than second number");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("The second number is bigger than first number");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}

namespace fourthQuestion
{
    //•	Write a program demonstrating the use of logical operators (AND, OR, and NOT) in an if statement. Use Console.WriteLine() to output the results.
    internal class Program
    {
        static void Question_4()
        {
            int number = 2;

            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by both 2 AND 3");
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                Console.WriteLine("The number is only divisible by 2 OR 3");
            }
            else
            {
                Console.WriteLine("The number is not divisible by neither");
            }
        }
    }
}

namespace fifthQuestion
{
    //•	Create a program that uses if-else statements to determine if a given number is positive, negative, or zero. Display the result using Console.WriteLine().
    internal class Program
    {
        static void Question_5()
        {
            int number = 5;

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("number is negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("number is 0");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}

namespace sixthQuestion
{
    //•	Write a program that accepts character input from the user and usess a switch statement to determine if the character is a vowel or a consonant. Display the result using Console.WriteLine().
    internal class Program
    {
        static void Question_6()
        {
            Console.WriteLine("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine(ch);

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("The character is a vowel");
                    break;

                default:
                    Console.WriteLine("The character is consonant");
                    break;
            }

            Console.ReadLine();
        }
    }
}

namespace seventhQuestion
{
    //•	Create a function called 'CalculateArea' that accepts the length and width of a rectangle as arguments and returns the area. Call this function from the main method and display the result using Console.WriteLine().
    internal class Program
    {
        static void Question_7()
        {
            int area = CalculateArea(5, 10);

            Console.WriteLine(area);
        }

        static int CalculateArea(int width, int height)
        {
            return (width * height);
        }
    }
}

namespace eighthQuestion
{
    //•	Write a program that demonstrates the use of nested if statements. For example, determine if a given number is divisible by 2 and 3, divisible by 2 or 3, or not divisible by either. Display the results using Console.WriteLine().
    internal class Program
    {
        static void Question_8()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 2 AND 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible only by 2");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible only by 3");
            }
            else
            {
                Console.WriteLine("The number is divisible by neither");
            }
        }
    }
}

namespace ninthQuestion
{
    //•	Write a program that uses a switch statement to display the name of a day based on its number (1-7). Use Console.WriteLine() to output the month's name.
    internal class Program
    {
        static void Question_9()
        {
            Console.WriteLine("Please enter a number between 1 and 7");
            int numberOfDay = Convert.ToInt32(Console.ReadLine());

            switch (numberOfDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter a value between 1-7");
                    break;
            }

        }
    }
}


