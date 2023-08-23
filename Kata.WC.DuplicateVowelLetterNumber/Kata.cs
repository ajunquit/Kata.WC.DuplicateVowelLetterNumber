using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.WC.DuplicateVowelLetterNumber
{
    public class Kata
    {
        public static string DuplicateVowelLetterNumber(string input)
        {
            string response = string.Empty;
            string vowels = "aeiou";
            var inputInArray = input.ToLower().ToCharArray();

            foreach (var character in inputInArray)
            {
                if (vowels.Contains(character))
                {
                    response += character.ToString() + character.ToString();
                }
                else if (char.IsLetter(character))
                {
                    response += character.ToString() + character.ToString() + character.ToString();
                }
                else if (char.IsDigit(character))
                {
                    response += character.ToString() + character.ToString() + character.ToString() + character.ToString();
                }
                else
                {
                    response += "*";
                }
            }

            return response;
        }
    }
}
