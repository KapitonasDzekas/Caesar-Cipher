using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarCipher
{
    public class CeasarCipherAlgorithm
    {
        private static char Cipher(char ch, int shift)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)(((ch + shift - offset) % 26) + offset); //26 galimi raktai, nes 26 skirtingos raidės
        }
        public static string Encrypt(string text, int shift)
        {
            string result = "";
            foreach (char ch in text)
            {
                result += Cipher(ch, shift);
            }
            return result;
        }

        public static string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - shift);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write your message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Enter your encryption key (0-26): ");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key >= 0 && key <= 26)
            {
                string encryptedMessage = Encrypt(message, key);
                string decryptedMessage = Decrypt(encryptedMessage, key);

                Console.WriteLine("\nMessage: " + message);
                Console.WriteLine("Key: {0}", key);

                Console.WriteLine("\nEncrypted message: " + encryptedMessage);
                Console.WriteLine("Decrypted message: " + decryptedMessage + "\n");
            }
            else Console.WriteLine("Wrong key.");        
        }
    }
}
