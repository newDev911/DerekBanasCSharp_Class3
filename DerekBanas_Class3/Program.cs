using System;

namespace DerekBans_CSharp_Class_2
{
    class Program
    {
        // 
        /*
         * Relational Operator:
            > < >= <= == != 

            Logical Operator:
            && || !
         */
        static void Main(string[] args)
        {
            // Conditional Statement:
            int age = 6;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Elementary School!");
            }
            else if ((age >= 7) && (age <= 13))
            {
                Console.WriteLine("Middle School!");
            }
            else if ((age >= 13) && (age <= 19))
            {
                Console.WriteLine("High School!");
            }
            else
            {
                Console.WriteLine("College!");
            }
            Console.WriteLine();
            //*****
            if ((age <14) && (age < 19))
            {
                Console.WriteLine("No Job!");
            }

            Console.WriteLine("! true = " + (!true));

            Console.WriteLine("*************");
            // TERNARY OPERATOR:
            bool canDrive = age >= 16 ? true : false;

            Console.WriteLine("*************");
            // SWITCH STATEMENT:
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Day Care!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("PreSchool!");
                    break;
                case 5:
                    Console.WriteLine("Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school!");
                    goto OtherSchool; // 2
            }
            // 2.1
            OtherSchool:
                Console.WriteLine("Elementary, Middle, High School!");

            Console.WriteLine();
            Console.WriteLine("***********");
            // String Comparision
            string name = "Dane";
            string name2 = "Dane";

            if (name.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Name are Equal!");
            }


            Console.WriteLine();
            Console.WriteLine("********");
            // :3
            // While Loop
            int a = 1;

            while (a <= 10)
            {
                if (a % 2 == 0) // is even
                {
                    a++;
                    continue; // skip even
                }
                if (a == 9)break;

                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine();
            Console.WriteLine("********");
            // :4
            // DO While Loop
            Random rnd = new Random();
            int secretNum = rnd.Next(1, 11);
            int numGuessed = 0;
            do
            {
                Console.WriteLine("Enter a num between 1 & 10");
                numGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNum != numGuessed);


            // OTHER CONVERSION TYPES
            /* ToBoolean, ToByte, ToChar, ToDecimal, ToDouble, ToInt64 & ToString
             */



            Console.WriteLine();
            Console.WriteLine("********");
            // :5
            // Error Handling
            double num1 = 4;
            double num2 = 0;

            // ** 5.1 (below)

            // 5.2
            try
            {
                Console.WriteLine("4 / 0 = {0}", DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("*********\n");
                Console.WriteLine("An Exception Occured!");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("*********\n");
                Console.WriteLine("Cleaning Up!");
            }


            // :1
            Console.ReadKey();
        }

        // 5.1
        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}