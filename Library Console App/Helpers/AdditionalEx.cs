using System;
using System.Text;

namespace Library_Console_App.Helpers
{
    static class AdditionalEx
    {
        
        #region ToStr

        private static string ToStr(this char chr)
        {
            return chr + "";
        }

        private static string ToStr(this int num)
        {
            return num + "";
        }

        private static string ToStr(this object obj)
        {
            return obj + "";
        }
        #endregion
        
        #region ToLowerCase
        private static string ToLowerCase(this string str)
        {
            StringBuilder newStr = new StringBuilder();
            foreach (var chr in str)
            {
                if (Convert.ToInt32(chr) <= 90 && Convert.ToInt32(chr) >= 65)
                {
                    newStr.Append(Convert.ToChar(Convert.ToInt32(chr) + 32));
                }
                else
                {
                    newStr.Append(chr);
                }

            }
            return newStr.ToStr();
        }
        
        private static char ToLowerCase(this char chr)
        {
            return Convert.ToInt32(chr) <= 90 && Convert.ToInt32(chr) >= 65
                ? Convert.ToChar(Convert.ToInt32(chr) + 32)
                : chr;
        }
        

        #endregion

        #region ToUpperCase
        private static string ToUpperCase(this string str)
        {
            StringBuilder newStr = new StringBuilder();
            foreach (var chr in str)
            {
                if (Convert.ToInt32(chr) <= 122 && Convert.ToInt32(chr) >= 97)
                {
                    newStr.Append(Convert.ToChar(Convert.ToInt32(chr) - 32));
                }
                else
                {
                    newStr.Append(chr);
                }

            }
            return newStr.ToStr();
        }

        private static char ToUpperCase(this char chr)
        {
            return Convert.ToInt32(chr) <= 122 && Convert.ToInt32(chr) >= 97
                ? Convert.ToChar(Convert.ToInt32(chr) - 32)
                : chr;
        }
        

        #endregion
        
        #region Capitalize
        public static string CapitalizeStr(this string str)
        {
            StringBuilder newStr = new StringBuilder(str.ToLowerCase());
            newStr[0] = str[0].ToUpperCase();
            return newStr.ToStr();
        }
        

        #endregion

        #region ReadLineStr
        public static string ReadLineStr(this string str,string input)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            
            
            TryAgain:
            Console.Write($"\nEnter the {input}: ");
            str =  Console.ReadLine()?.Trim();
            

            if (str is {Length: 0})
            {
                Console.Clear();
                Console.WriteLine($"\nWrong! Please enter the {input}\n");
                goto TryAgain;
            }

            return str;
        }
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