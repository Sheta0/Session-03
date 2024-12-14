using System.ComponentModel.DataAnnotations;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //if (Num % 3 == 0 && Num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //} else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region Q2

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //Console.WriteLine(Num switch
            //{
            //    > 0 => "Positive",
            //    < 0 => "Negative",
            //    _ => 0
            //});

            #endregion

            #region Q3

            //int[] Num = new int[3];
            //for (int i = 0; i < Num.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write("Enter a number : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out Num[i]));
            //}

            //Console.WriteLine($"Max element = {Num.Max()}");
            //Console.WriteLine($"Min element = {Num.Min()}");

            #endregion

            #region Q4

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //if (Num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}


            #endregion

            #region Q5

            //char Character;
            //do
            //{
            //    Console.Write("Enter a character : ");

            //}
            //while (!char.TryParse(Console.ReadLine(), out Character));

            //Console.WriteLine(Character switch
            //{
            //    'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U' => "Vowel",
            //    _ => "Constant"
            //});


            #endregion

            #region Q6

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //for (int i = 1; i <= Num; i++)
            //{ 
            //    Console.WriteLine(i); 
            //}

            #endregion

            #region Q7

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(Num * i);
            //}


            #endregion

            #region Q8

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //for (int i = 1; i <= Num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Q9

            //int Base;

            //do
            //{
            //    Console.Write("Enter the base: ");
            //} while (!int.TryParse(Console.ReadLine(), out Base));

            //int Exponent;
            //do
            //{
            //    Console.Write("Enter the exponent: ");
            //} while (!int.TryParse(Console.ReadLine(), out Exponent) || Exponent < 0);

            //int result = 1;
            //for (int i = 0; i < Exponent; i++)
            //{
            //    result *= Base;
            //}

            //Console.WriteLine(result);

            #endregion

            #region Q10

            //int[] Num = new int[5];
            //for (int i = 0; i < Num.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write("Enter a grade : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out Num[i]));
            //}

            //Console.WriteLine($"Total = {Num.Sum()}");
            //Console.WriteLine($"Average = {Num.Average()}");

            #endregion

            #region Q11


            //int month;
            //bool isValidInput;

            //do
            //{
            //    Console.Write("Enter a month number (1 - 12): ");
            //    string input = Console.ReadLine();
            //    isValidInput = int.TryParse(input, out month) && month >= 1 && month <= 12;

            //} while (!isValidInput);

            //if (month == 2)
            //{
            //    Console.WriteLine("29 if it's a leap year \n28 if it's a non-leap year");
            //}
            //else
            //{
            //    int days = month switch
            //    {
            //        1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            //        4 or 6 or 9 or 11 => 30,
            //        _ => 0
            //    };

            //    Console.WriteLine($"{days} days.");
            //}
            #endregion

            #region Q12

            //double num1, num2, result = 0;
            //char operation;
            //bool isValidInput;

            //do
            //{
            //    Console.Write("Enter the first number: ");
            //    isValidInput = double.TryParse(Console.ReadLine(), out num1);
            //    if (!isValidInput) 
            //    {                     
            //        Console.WriteLine("Please enter a valid number.");
            //    }
            //} while (!isValidInput);

            //do
            //{
            //    Console.Write("Enter the second number: ");
            //    isValidInput = double.TryParse(Console.ReadLine(), out num2);
            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }
            //} while (!isValidInput);

            //do
            //{
            //    Console.Write("Enter an operation (+, -, *, /): ");
            //    isValidInput = char.TryParse(Console.ReadLine(), out operation);

            //    if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            //    {
            //        Console.WriteLine("Please enter +, -, *, /.");
            //    }

            //} while (operation != '+' && operation != '-' && operation != '*' && operation != '/');

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not allowed.");
            //            return;
            //        }
            //        break;
            //}

            //Console.WriteLine($"{num1} {operation} {num2} = {result}");

            #endregion

            #region Q13

            //Console.WriteLine("Enter a string");
            //string input = Console.ReadLine();
            //char[] inputArray = input.ToCharArray();
            //Array.Reverse(inputArray);
            //Console.WriteLine(inputArray);

            #endregion

            #region Q14

            //int Num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Num));

            //string NumString = Num.ToString();
            //char[] NumCharArray = NumString.ToCharArray();
            //Array.Reverse(NumCharArray);

            //Console.WriteLine(NumCharArray);

            #endregion

            #region Q15

            //int start;
            //do
            //{
            //    Console.Write("Enter the starting number : ");
            //} while (!int.TryParse(Console.ReadLine(), out start));

            //int end;
            //do
            //{
            //    Console.Write("Enter the ending number : ");
            //} while (!int.TryParse(Console.ReadLine(), out end));

            //if (start > end)
            //{
            //    Console.WriteLine("The starting number must be less than or equal to the ending number.");
            //    return;
            //}

            //Console.WriteLine($"Prime numbers between {start} and {end}:");

            //for (int n = start; n <= end; n++)
            //{
            //    if (n <= 1) 
            //    { 
            //        continue;
            //    }
            //    if (n == 2 || n == 3) 
            //    {
            //        Console.WriteLine(n);
            //        continue;
            //    }
            //    if (n % 2 == 0)
            //    {
            //        continue;
            //    } 

            //    bool isPrime = true;
            //    for (int i = 3; i <= Math.Sqrt(n); i += 2)
            //    {
            //        if (n % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            #endregion

            #region Q16

            //int decimalNumber;

            //do
            //{
            //    Console.Write("Enter a decimal number: ");
            //} while (!int.TryParse(Console.ReadLine(), out decimalNumber) || decimalNumber < 0);

            //Console.Write($"The Binary of {decimalNumber} is ");

            //if (decimalNumber == 0)
            //{
            //    Console.WriteLine("0");
            //    return;
            //}

            //string binaryResult = "";
            //int number = decimalNumber;

            //while (number > 0)
            //{
            //    binaryResult = (number % 2) + binaryResult; // Add remainder to the binary string
            //    number /= 2;
            //}

            //Console.WriteLine(binaryResult);

            #endregion

            #region Q17

            //double x1, y1, x2, y2, x3, y3;

            //Console.WriteLine("Enter the coordinates for the first point : ");
            //do
            //{
            //    Console.Write("x1 : ");
            //} while (!double.TryParse(Console.ReadLine(), out x1));
            //do
            //{
            //    Console.Write("y1 : ");
            //} while (!double.TryParse(Console.ReadLine(), out y1));

            //Console.WriteLine("Enter the coordinates for the second point : ");
            //do
            //{
            //    Console.Write("x2 : ");
            //} while (!double.TryParse(Console.ReadLine(), out x2));
            //do
            //{
            //    Console.Write("y2 : ");
            //} while (!double.TryParse(Console.ReadLine(), out y2));

            //Console.WriteLine("Enter the coordinates for the third point : ");
            //do
            //{
            //    Console.Write("x3 : ");
            //} while (!double.TryParse(Console.ReadLine(), out x3));
            //do
            //{
            //    Console.Write("y3 : ");
            //} while (!double.TryParse(Console.ReadLine(), out y3));


            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}

            #endregion

            #region Q18

            //double NumberOfHours;
            //do
            //{
            //    Console.Write("Enter the number of hours : ");
            //}
            //while (!double.TryParse(Console.ReadLine(), out NumberOfHours));

            //Console.WriteLine(NumberOfHours switch
            //{
            //    >= 2 and <= 3 => "Highly efficient",
            //    > 3 and <= 4 => "Increase your speed",
            //    > 4 and <= 5 => "You need training to improve your speed",
            //    > 5 => "Leave the company",
            //    _ => "Invalid Number Of Hours"
            //});

            #endregion

            #region TASK C# 9.0

            //Person person = new Person();

            //Console.Write("Enter your name : ");
            //person.Name = Console.ReadLine();
            //Console.Write("Enter your age : ");
            //person.Age = int.Parse(Console.ReadLine());

            //Console.WriteLine(person switch
            //{
            //    { Age: <= 10 } => $"{person.Name}, You're just a kid.",
            //    { Age: > 10 and <= 20 } => $"{person.Name}, You're just a bit older kid.",
            //    { Age: > 20 and <= 40 } => $"{person.Name}, You're now adult.",
            //    { Age: > 40 } => $"{person.Name}, You're still young.",
            //});

            #endregion
        }
    }
}

