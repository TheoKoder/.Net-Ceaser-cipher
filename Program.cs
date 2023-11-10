// See https://aka.ms/new-console-template for more information
using System;

using Endpoints;

namespace CeaserCipher
{


    class Program
    {
        public enum Options
        {
            Quit = 0,
            Encrypt,
            Decrypt

        }
        static void Main(string[] args)
        {
            string CypheredText;
            //Encryption
            Console.WriteLine("Welcome to Ceaser's cipher");
            Console.WriteLine("Please select an option: \n0.Quit,\n1.start Encryption,\n 2.Start Decryption");

            int value = Convert.ToInt32(Console.ReadLine());
            Options selectedOption = (Options)value;

            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a Number.");
                return;
            }


            switch (selectedOption)
            {
                case Options.Encrypt:
                    // Encrypt user input
                    Console.WriteLine("Enter a Text to be Encrypted");
                    string? word = Console.ReadLine();
                    //Handle possible null values using the null-conditional operator (?.) and the null-coalescing operator (??) 
                    string wordshift = word?.ToString() ?? string.Empty;

                    Console.WriteLine("Enter Shift [0-5]");
                    int shift = Convert.ToInt32(Console.ReadLine());

                    EncryptionService encryption = new EncryptionService();

                    CypheredText = encryption.Encryption(wordshift, shift);

                    //print
                    Console.Write("Encrypting.........");
                    Console.WriteLine($"Text: {word} was Encrypted to {CypheredText}");

                    break;
                case Options.Decrypt:
                    //Decrypt user input
                    Console.WriteLine("Enter a Text to be Decrypted");
                    string? unShiftWord = Console.ReadLine();

                    //Handle possible null values using the null-conditional operator (?.) and the null-coalescing operator (??) 
                    string unshift = unShiftWord?.ToString() ?? string.Empty;


                    Console.WriteLine("Enter Shift [0-5]");
                    int decryptShift = Convert.ToInt32(Console.ReadLine());

                    CypheredText = DecryptionServices.Decrypt(unshift, decryptShift);

                    //Print 
                    Console.Write("Decrypting.........");
                    Console.WriteLine($"Text: {unShiftWord} was Decrypted to {CypheredText}");

                    break;
                case Options.Quit:

                    Console.WriteLine("Exiting program, Goodbye!");

                    break;
                default:

                    Console.WriteLine("Invalid operation, please select from those listed above");
                    break;
            }
        }
    }
}