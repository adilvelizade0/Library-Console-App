using System;

namespace Library_Console_App.Helpers
{
    static class AdditionalEx
    {
        #region ReadLineStr
        public static string ReadLineStr(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            
            
            TryAgain:
            Console.Write($"Enter the {input}: ");
            string str =  Console.ReadLine()?.Trim();

            if (str is {Length: 0})
            {
                Console.Clear();
                Console.WriteLine($"\nWrong! Please enter the {input}\n");
                goto TryAgain;
            }

            return str;
        }
        #endregion

        #region ReadLineInt
        public static int ReadLineInt(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Value cannot be null or empty.", nameof(input));
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(input));

            TryAgain:
            try
            {
                return Convert.ToInt32(ReadLineStr(input));
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine($"\nWrong! Please enter the {input}\n");
                goto TryAgain;
            }
        }
        #endregion
        
    }
}