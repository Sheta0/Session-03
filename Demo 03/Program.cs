using Demo_03;
using System;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace Day03
{
    internal class Program
    {
        // Start Point
        static void Main()
        {

            #region String Formatting
            //// Equation : X + Y = 7
            //int X = 3, Y = 4;

            //// 1. String Concatnation
            //string Message = "Equation : " + X + " + " + Y + " = " + (X + Y);
            //Console.WriteLine(Message);
            //// String : Immutable -> Can't change its Value after creation

            //// 2. String Formating 
            //string Message = string.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Message);

            //// 3. String Interpolation
            //// $ : Manipulation Operator
            //string Message = $"Equation : {X} + {Y} = {X + Y}";
            //Console.WriteLine(Message);
            #endregion

            #region Control Statements

            #region 1. Conditional Statments [if, switch]



            // 1 --> Jan
            // 2 --> Feb
            // 3 --> Mar

            //Console.WriteLine("Jan");
            //Console.WriteLine("Feb");
            //Console.WriteLine("Mar");

            //if (/*Expression*/)
            //{
            //    // Code
            //    // This Code Will be Executed When The Condition is True
            //}

            //if (true)
            //{
            //    Console.WriteLine("Hello World ");
            //}

            //if (false)
            //{
            //    Console.WriteLine("Hello World ");
            //}

            #region EX01
            //Console.Write("enter a month number in the first quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //// using if

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number");
            //}

            //// using switch
            //// Jump Table
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //} 
            #endregion

            #region EX02
            //Console.WriteLine("Please Enter your Name: ");
            //string Name = Console.ReadLine();

            // Hi Ahmed

            //if (Name == "Ahmed" || Name == "ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (Name == "Omar" || Name == "omar")
            //    Console.WriteLine("Hello Omar");
            //else if (Name == "Amr" || Name == "amr")
            //    Console.WriteLine("Hello Ali");
            //else if (Name == "Mona" || Name == "mona")
            //    Console.WriteLine("Hello Mona");


            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;
            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine("Hi Omar");
            //        break;
            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine("Hi Ali");
            //        break;
            //    case "Mona":
            //    case "mona":
            //        Console.WriteLine("Hi Mona");
            //        break; 
            #endregion

            #region EX03
            //Console.Write("Enter your age : ");
            //int Age = int.Parse(Console.ReadLine());

            //// using if 

            //if( Age > 18 )
            //{
            //    Console.WriteLine("Hi :)");
            //} else if ( Age < 18)
            //{
            //    Console.WriteLine("Bye :(");
            //} else
            //{
            //    Console.WriteLine("Equal!");
            //}


            //// 2. using switch

            //switch (Age) 
            //{
            //    case > 18:
            //        Console.WriteLine("Hi :)");
            //        break;
            //    case < 18:
            //        Console.WriteLine("bye :(");
            //        break;
            //    default:
            //        Console.WriteLine("Equal");
            //        break;
            //} 
            #endregion

            #region C# 7.0
            //object Object = new object();

            //Object = "Ahmed";
            ////Object = 20;

            //switch (Object)
            //{
            //    case int X when X > 12:
            //        Console.WriteLine("Int Object > 12");
            //        break;
            //    case string X when X.Length > 5:
            //        Console.WriteLine("string Object > 5");
            //        break;
            //    case string X when X.Length <= 5:
            //        Console.WriteLine("string Object <= 5");
            //        break;
            //} 
            #endregion

            #region C# 8.0

            //string Input = Console.ReadLine();
            //// 1
            //// 2
            //// 3

            //Console.WriteLine(Input switch
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3",
            //    _ => "Unsupported Option!"
            //});

            #endregion

            #region C# 9.0

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

            #endregion

            #region 2. Loop Statements [For, Foreach, While, Do-While]

            #region For

            //for (/*Statement*/; /*Expression*/; /*Statement*/)
            //{
            //    // Code
            //    // This Code will be repeated

            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //int i = 1;
            //for (Console.Write(" Welcome \n"); i <= 10; Console.Write(i))
            //{
            //    Console.WriteLine(" Hello World");
            //    i++;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("i");
            //}

            #endregion

            #region Foreach

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //for (int i = 0; i < numbers.Length; i++) // You Can Manipulate Data // Data Structure with index
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (int n in numbers) // You Can't Manipulate Data
            //    Console.WriteLine(n);

            #endregion

            #region While

            //while(/*Expression*/)
            //{
            //    // Code
            //    // This Code Will be repeated while the expression is TRUE
            //}

            //while (true) // infinite loop
            //{
            //    Console.WriteLine("Hello World");
            //}

            //int i = 1;
            //while (i <= 10) 
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}
            //Console.WriteLine(i);

            #endregion

            #region Do-While

            //do
            //{
            //    // Code
            //    // This Code Will be executed first
            //}
            //while (/*Expression*/);

            int i = 1;

            //do
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //} while (i <= 10);

            //int Number;
            //do
            //{
            //    Console.Write("Enter an even Number : ");
            //} while (!int.TryParse(Console.ReadLine(), out Number) || Number % 2 != 0 );

            //Console.WriteLine("Even Number");
            #endregion

            #endregion

            #endregion

            #region String
            //// String : Reference Type : Heap (class)
            //// Immutable Type : Can't change its value after creation

            //string S01;
            //// Declare For Reference (Pointer) from Type 'String'
            //// S01 : Can Refer To Object From 'String'
            //// S01 : Refer to NULL

            //// 8 Bytes Will Be Allocated At Stack For Reference 'S01'
            //// 0 Bytes Will Be Allocated At Heap


            ////S01 = new string("Ahmed");
            //S01 = "Ahmed"; // Syntax Sugar
            //// new
            //// 1. Allocate The Number of Requiered Bytes for the object at Heap
            //// 2. Initialize The Allocated Bytes to Default Values
            //// 3. Call User-Defined Constructor if exists
            //// 4. Assign the object to the reference 
            //Console.WriteLine(S01.GetHashCode()); // Id : Indicate Address

            //S01 = "Ali";
            //// new
            //// 1. Allocate The Number of Requiered Bytes for the object at Heap
            //// 2. Initialize The Allocated Bytes to Default Values
            //// 3. Call User-Defined Constructor if exists
            //// 4. Assign the object to the reference 
            //Console.WriteLine(S01.GetHashCode()); // Id : Indicate Address

            //S01 = "Rana";
            //// new
            //// 1. Allocate The Number of Requiered Bytes for the object at Heap
            //// 2. Initialize The Allocated Bytes to Default Values
            //// 3. Call User-Defined Constructor if exists
            //// 4. Assign the object to the reference 
            //Console.WriteLine(S01.GetHashCode()); // Id : Indicate Address


            //string Message = "Hello";
            //Console.WriteLine($"Message : {Message}");
            //Console.WriteLine($"HashCode : {Message.GetHashCode()}");
            //Console.WriteLine();

            //Message += " Ahmed";
            //Console.WriteLine($"Message : {Message}");
            //Console.WriteLine($"HashCode : {Message.GetHashCode()}");
            #endregion

            #region StringBuilder
            ////// StringBuilder : Class (Reference Type) : HEAP
            ////// Mutable DataType : Can change its value after creation
            //StringBuilder S01;
            ////// Declare For Reference (Pointer) from Type 'StringBuilder'
            ////// S01 : Can Refer To Object From 'StringBuilder'
            ////// S01 : Refer to NULL

            //S01 = new StringBuilder("Hello ");
            ////// new
            ////// 1. Allocate The Number of Requiered Bytes for the object at Heap
            ////// 2. Initialize The Allocated Bytes to Default Values
            ////// 3. Call User-Defined Constructor if exists
            ////// 4. Assign the object to the reference 

            //Console.WriteLine($"S01 : {S01}");
            //Console.WriteLine($"S01 HashCode : {S01.GetHashCode()}");
            //Console.WriteLine();

            //S01.Append("Ahmed");
            //Console.WriteLine($"S01 : {S01}");
            //Console.WriteLine($"S01 HashCode : {S01.GetHashCode()}");

            #endregion

            #region String Methods

            //string S01 = "Hello World";

            //Console.WriteLine(S01.Substring(1));

            //Console.WriteLine(S01.Replace("Hello", "Welcome"));

            //Console.WriteLine(S01.StartsWith("H"));
            //Console.WriteLine(S01.StartsWith("h", true, null));

            //Console.WriteLine(S01.ToCharArray());

            //Console.WriteLine(S01.IndexOf("o"));
            //Console.WriteLine(S01.LastIndexOf("o"));

            //Console.WriteLine(S01.Contains("ll"));
            //Console.WriteLine(S01.Contains("no"));

            //Console.WriteLine(S01.EndsWith("d"));

            //Console.WriteLine(S01.Insert(5, " All The"));

            //Console.WriteLine(S01.PadLeft(20));

            //Console.WriteLine(S01.Remove(1));

            //Console.WriteLine(S01.ToLower());
            //Console.WriteLine(S01.ToUpper());

            #endregion
        }
    }
}
