using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
             
            string str = "";
            foreach(var i in text)
            {
                if(alphabet.Contains(i))
                {
                    var index = Array.IndexOf(alphabet, i);
                    index = (index + shiftKey) % 26;
                    
                    str += alphabet[index];
                }
                else if(ALPHABET.Contains(i))
                {
                    var index = Array.IndexOf(ALPHABET, i);
                    index = (index + shiftKey) % 26;
                    str += ALPHABET[index];
                }
                else
                {
                    str += i;
                }
            }
            return str;
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
