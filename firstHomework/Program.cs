using System.ComponentModel.Design;

namespace firstQuestion
{
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


