using System;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }

        public static bool IsPalindrome(string str)
        {
            string reversedstring = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedstring += str[i];
            }
            return str.Equals(reversedstring); 
        }    
    }
}
