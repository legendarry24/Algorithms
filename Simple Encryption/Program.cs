/*For building the encrypted string:
Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
Do this n times!
For both methods:
If the input-string is null or empty return exactly this value!
If n is <= 0 then return the input text.*/

using System;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace Simple_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            Console.WriteLine(Encrypt("This is a test!", 1));
            watch.Stop();
            Console.WriteLine($"Encrypt elapsed time: {watch.Elapsed}");
            
            watch.Restart();
            Console.WriteLine(Decrypt("hsi  etTi sats!", 1));
            watch.Stop();
            Console.WriteLine($"Decrypt elapsed time: {watch.Elapsed}");           

            watch.Restart();
            Console.WriteLine(EncryptWithLINQ("This is a test!", 1));
            watch.Stop();
            Console.WriteLine($"EncryptWithLINQ elapsed time: {watch.Elapsed}");
            
            watch.Restart();
            Console.WriteLine(DecryptWithLINQ("hsi  etTi sats!", 1));
            watch.Stop();
            Console.WriteLine($"DecryptWithLINQ elapsed time: {watch.Elapsed}");

            Console.WriteLine(Encrypt("This is a test!", 2));
            Console.WriteLine(Decrypt("s eT ashi tist!", 2));
        }

        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0) 
                return text;

            var builder = new StringBuilder(); 
            while (n != 0)
            {
                builder.Clear(); // clear a builder before n-th encryption

                for (int i = 0; i < text.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        builder.Append(text[i]);
                    }
                }

                for (int i = 0; i < text.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        builder.Append(text[i]);
                    }
                }

                text = builder.ToString();

                n--;
            }

            return text;
        }
  
        public static string Decrypt(string encryptedText, int n)
        {
            if (string.IsNullOrWhiteSpace(encryptedText) || n <= 0) 
                return encryptedText;

            var builder = new StringBuilder(encryptedText); 
            while (n != 0)
            {               
                int indexForOdd = 0;
                int indexForEven = encryptedText.Length / 2;
                for (int i = 0; i < encryptedText.Length; i++)
                {                    
                    if (i % 2 != 0)
                    {
                        builder[i] = encryptedText[indexForOdd++];
                    }

                    if (i % 2 == 0)
                    {
                        builder[i] = encryptedText[indexForEven++];
                    }
                }

                encryptedText = builder.ToString();
                
                n--;
            }

            return encryptedText;
        }

        public static string EncryptWithLINQ(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
                return text;

            while (n != 0)
            {
                text = string.Concat(text.Where((c, i) => i % 2 == 1)
                    .Concat(text.Where((c, i) => i % 2 == 0)));

                n--;
            }

            return text;
        }
        
        public static string DecryptWithLINQ(string encryptedText, int n)
        {
            if (string.IsNullOrWhiteSpace(encryptedText) || n <= 0)
                return encryptedText;

            while (n != 0)
            {
                string leftPart = string.Concat(encryptedText.Take(encryptedText.Length / 2));
                string rightPart = string.Concat(encryptedText.Skip(encryptedText.Length / 2));

                encryptedText = string.Concat(Enumerable.Range(0, encryptedText.Length)
                    .Select(i => i % 2 == 0 ? rightPart[i / 2] : leftPart[i / 2]));

                n--;
            }

            return encryptedText;
        }
    }
}