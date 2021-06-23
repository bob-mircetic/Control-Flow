using System;

namespace Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {   
            int age = 0;
            int price = 14;
            bool isStudent = false;
             
            Console.WriteLine("Enter your age:");
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Are you a student? (Y/N):");
            var student = Console.ReadLine();
            if (student == "Y" | student == "y") isStudent = true;

            // try {
            //     string.IsNullOrEmpty(Console.ReadLine());
            //     throw new ArgumentOutOfRangeException("age" "Age cannot be blank");
            // }
            try 
            {
                if (age < 1) {
                    throw new ArgumentOutOfRangeException("age","Age cannot be less than 1");
                }
                else {
                    if (age < 13) price = 8; 
                    if (age > 64) price = 10;
                    if (isStudent == true) price = 8;

                    Console.WriteLine("Your price is: " + price);
                }
            }
            catch(ArgumentOutOfRangeException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
