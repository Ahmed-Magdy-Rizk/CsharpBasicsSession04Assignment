namespace Session04Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             * 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
             */

            // Promput user to enter an integer
            /*Console.Write("Please Enter a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }*/
            #endregion
            #region Q2
            /*
             2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
             */
            // Prompt user to enter a number
            /*Console.Write("Please type a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(number * i);
                //Console.Write(" ");
            }*/
            #endregion
            #region Q3
            /*
             3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
             */

            // Prompt user to enter a number
            /*Console.Write("Please type a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
            #endregion
            #region Q4
            /*
             4- Write a program that takes two integers then prints the power.
             */
            //Prompt user to enter 2 number
            /*Console.WriteLine("Please type two number: ");
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);

            int answer = number1;
            for (int i = 1; i < number2; i++) 
            {
                answer *= number1;
            }
            Console.WriteLine(answer);*/
            #endregion
            #region Q5
            /*
             5- Write a program to enter marks of five subjects and calculate total, average and percentage.
             */
            // Promput user to input 5 marks
            /*Console.WriteLine("Please enter 5 marks: ");
            int.TryParse(Console.ReadLine(), out int mark1);
            int.TryParse(Console.ReadLine(), out int mark2);
            int.TryParse(Console.ReadLine(), out int mark3);
            int.TryParse(Console.ReadLine(), out int mark4);
            int.TryParse(Console.ReadLine(), out int mark5);

            // calculate total marks
            int TotalMarks = mark1 + mark2 + mark3 + mark4 + mark5;

            //calculate avg marks
            float Avg = TotalMarks / 5;

            // calculate percentage
            float Percentage = ((float)TotalMarks / 500) * 100;

            Console.WriteLine($"Total marks = {TotalMarks}");
            Console.WriteLine($"Average Marks  = {Avg}");
            Console.WriteLine($"Percentage  = {Percentage}%");*/
            #endregion
            #region Q6
            /*
             6- Write a program to input the month number and print the number of days in that month.
             */

            // Prompt user to enter a month number
            /*Console.Write("Please enter a month number: ");
            int.TryParse(Console.ReadLine(), out int MonthNumber);

            int days = 0;
            switch (MonthNumber)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    days = 31; 
                    break;
                case 4: case 6: case 9: case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28; 
                    break;
                default: 
                    Console.WriteLine("Please enter a valid month number");
                    break;
            }
            Console.WriteLine($"Days in Month: {days}");*/
            #endregion
            #region Q7
            /*
             7- Write a program to create a Simple Calculator.
             */
            //Prompt user to enter the first number
            /*Console.Write("Please enter your first number: ");
            int.TryParse(Console.ReadLine(), out int FirstNumber);
            
            //Prompt user to enter the second number
            Console.Write("Please enter your second number: ");
            int.TryParse(Console.ReadLine(), out int SecondNumber);

            // Prompt user to choose an operation
            Console.Write("Please an operation (+ - (-) - * - /): ");
            char.TryParse(Console.ReadLine(), out char OpChar);

            float Result = 0;
            bool ValidOp = true;

            switch (OpChar)
            {
                case '+':
                    Result = FirstNumber + SecondNumber;
                    break;
                case '-':
                    Result = FirstNumber - SecondNumber;
                    break;
                case '*':
                    Result = FirstNumber * SecondNumber;
                    break;
                case '/':
                    if (SecondNumber == 0)
                    {
                        Console.WriteLine("Can't divide by zero");
                        ValidOp = false;
                        break;
                    }
                    Result = FirstNumber / SecondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid Operaton");
                    ValidOp = false;
                    break;
            }
            if (ValidOp == true)
            {
                Console.WriteLine($"Result = {Result}");
            }*/
            #endregion
            #region Q8
            /*
             8- Write a program to allow the user to enter int and print the REVERSED of it.
             */
            // Prompt the user to enter a int
            /*Console.Write("Please enter a number: ");
            string UserInput = Console.ReadLine();

            string Result = "";
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Result += UserInput[i];
            }

            int.TryParse(Result, out int NumberResult);

            Console.WriteLine($"Result: {NumberResult}");*/
            #endregion
            #region Q9
            /*
             9- Write a program in C# Sharp to find prime numbers within a range of numbers
            */
            /*Console.Write("starting number of range: ");
            int.TryParse(Console.ReadLine(), out int StartNumber);
            Console.Write("ending number of range : ");
            int.TryParse(Console.ReadLine(), out int EndNumber);

            bool isPrime = true;
            for (int i = StartNumber; i <= EndNumber; i++)
            {
                if (i <= 1)
                {
                    isPrime = false;
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }*/
            #endregion
            #region Q10
            /*10- . Write a program in C# Sharp to convert a decimal number into binary without using an array.*/
            // Prompt user to enter a decimal number
            /*Console.Write("Plase enter a decimal number: ");
            int.TryParse(Console.ReadLine(), out int Decimal);

            string ReveredResult = "";

            while (Decimal > 0)
            {
                if (Decimal % 2 == 1)
                {

                    ReveredResult += "1";
                }
                else
                {
                    ReveredResult += "0";
                }
                Decimal = Decimal / 2;
            }

            // Reverse the string to get the actual value
            string Result = "";
            for (int i = ReveredResult.Length - 1; i >= 0; i--)
            {
                Result += ReveredResult[i];
            }

            Console.WriteLine($"Result: {Result}");*/
            #endregion
        }
    }
}
