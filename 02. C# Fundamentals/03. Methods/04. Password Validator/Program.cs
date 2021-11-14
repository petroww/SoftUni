using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
           

            if (!GetPasswordLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!GetLettersOrDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!GetTwoDigitsOfPassword(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                
            }

            if (GetPasswordLenght(password) && GetLettersOrDigits(password) && GetTwoDigitsOfPassword(password))
            {
                Console.WriteLine("Password is valid");
            }
            

        }


        static bool GetPasswordLenght(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool GetLettersOrDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            
            return true;
        }

        static bool GetTwoDigitsOfPassword(string password)
        {
            int counter = 0;
            bool isDigits = false;
            foreach (char digits in password)
            {
                if (char.IsDigit(digits))
                {
                    counter++;
                }
                if (counter == 2)
                {
                    isDigits = true;
                }
            }
            
            return isDigits;
        }

        
    }
}
