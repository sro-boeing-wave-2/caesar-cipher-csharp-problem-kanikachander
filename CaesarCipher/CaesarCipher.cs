using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string alphabets = "abcdefghijklmnopqrstuvwxyz";

            //var x = text.Select(c => char.IsUpper(c) ? (alphabets.IndexOf(char.ToLower(c)) + shiftKey) % 26 : (alphabets.IndexOf(c) + shiftKey) % 26).ToString();

            string str = "";
            foreach (var i in text)
            {
                if (alphabets.Contains(i))
                {
                    var index = alphabets.IndexOf(i);
                    index = (index + shiftKey) % 26;

                    str += alphabets[index];
                }
                else if (alphabets.ToUpper().Contains(i))
                {
                    var index = alphabets.ToUpper().IndexOf(i);
                    index = (index + shiftKey) % 26;
                    str += alphabets.ToUpper()[index];
                }
                else
                {
                    str += i;
                }
            }
            return str;
        }
    }
}
