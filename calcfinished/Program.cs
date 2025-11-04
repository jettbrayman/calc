namespace calcfinished
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool On = true;

            while (On)
            {
                Console.WriteLine("Welcome to CALC. What do you want to do?");
                Console.WriteLine(
                    "1. Add\n2. Subtract\n3. Multiply\n4. Divide\nAnything else. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice != "1" && choice != "2" && choice != "3" &&
                    choice != "4")  // decides if your input is valid
                {
                    Console.WriteLine("exiting program");
                    break;
                }

                int a;
                int b;

                while (true)
                {
                    Console.Write("Enter first number: ");
                    string input1 = Console.ReadLine();

                    try
                    {
                        a = Convert.ToInt32(input1);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("invalid input");
                    }
                }

                // Get second number
                while (true)
                {
                    Console.Write("Enter second number: ");
                    string input2 = Console.ReadLine();

                    try
                    {
                        b = Convert.ToInt32(input2);
                        break;  // valid input, exit loop
                    }
                    catch
                    {
                        Console.WriteLine("invalid input");
                    }
                }

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine($"sum = {Add(a, b)}");
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine($"difference = {Subtract(a, b)}");
                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine($"product = {Multiply(a, b)}");
                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine(Divide(a, b));
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("invalid choice");
                            break;
                        }
                }
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("cant divide by 0");
                return 0;
            }
            else
            {
                return a / b;
            }
        }

        // The Main Loop of the Code
        // previous main method works with dothemath method

        /*
        static void Main() //added main method
        {
            // Starting Values
            bool On = true;
            bool Confirm = true;
            int x;
            int y;
            int PlayChoice = 0;
            while (On == true)
            {
                // Ask user for Choice
                Console.WriteLine("Welcome to CALC. What do you want to do?");
                // 1. Add
                Console.WriteLine("1. Addition");
                // 2. Subtract
                Console.WriteLine("2. Subtraction");
                // 3. Multiply
                Console.WriteLine("3. Multiplication");
                // 4. Divide
                Console.WriteLine("4. Division");



                // Anything Else. Exit
                Console.WriteLine("Other. Exit");
                Console.Write("Type in the Choice's number here > ");
                string Choice = Console.ReadLine();

                // Handles what code will go
                switch (Choice)
                {
                    case "1":
                        PlayChoice = 1;
                        break;

                    case "2":
                        PlayChoice = 2;
                        break;

                    case "3":
                        PlayChoice = 3;
                        break;

                    case "4":
                        PlayChoice = 4;
                        break;

                    default:
                        Console.WriteLine("Are you sure?");
                        string Confirmation = Console.ReadLine();
                        if (Confirmation == "Yes")
                        {
                            On = false;
                        }
                        else
                        {
                            Confirm = true;
                        }
                        break;

                }
                if (On == true & Confirm == false)
                {
                    try
                    {
                        // Ask for two Numbers
                        Console.Write("What's your first Number > ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What's your second Number > ");
                        y = Convert.ToInt32(Console.ReadLine());

                        DoTheMath(PlayChoice, x, y);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR: LETTER IN CALCULATION");
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("ERROR: DIVISION BY ZERO IS IMPOSSIBLE");
                    }
                    }
                Confirm = false;
            }
        }
        */

        // The Calculating Loop before individual methods were added

        /*
        static void DoTheMath(int Calc, int firstNum, int secondNum)
        {
            // Values for this Loop
            int Sum = firstNum + secondNum;
            int Difference = firstNum - secondNum;
            int Product = firstNum * secondNum;
            int Quotient = firstNum / secondNum;

            // Calculate Answer to code
            switch (Calc)
            {
                case 1:
                    // Put in Add
                    Console.WriteLine($"The Sum of {firstNum} and {secondNum} is
        {Sum}!"); break;

                case 2:
                    // Put in Subtract
                    Console.WriteLine($"The Difference of {firstNum} and {secondNum}
        is {Difference}!"); break;

                case 3:
                    // Put in Multiply
                    Console.WriteLine($"The Product of {firstNum} and {secondNum} is
        {Product}!"); break;

                case 4:
                    if (secondNum == 0)
                        {
                            // State it can't Divide by Zero
                            Console.WriteLine("ERROR: DIVISION BY ZERO IS
        IMPOSSIBLE");
                        }
                    else
                        {
                            // Put in Divide
                            Console.WriteLine($"The Quotient of {firstNum} and
        {secondNum} is {Quotient}!");

                        }
                    break;
            }
        }
        */
    }
}
