namespace Endpoints;

//Decryption code for ceaser cipher
//Endpoits are ALWAYS STATIC, declare class as Static
public class DecryptionServices
{
    public static string Decrypt(string Decrypt, int unshift)
    {
        char[] decyrptChars = Decrypt.ToLower().ToCharArray();

        for (int i = 0; i < decyrptChars.Length; i++)
        {
            // Convert the characters into integers (ASCII) so that we can easily shift the "letters"
            int originalV = (int)decyrptChars[i];

            // Using ASCII, make sure the conversion ONLY accounts for letters
            // For letters or characters, ASCII starts from #96 (character 'a') to #123 (character 'z')
            if (originalV > 96 && originalV < 123)
            {
                int shiftValue;

                // Prevent from going above 123, which is special characters and NO longer alphabets
                if ((originalV - unshift) < 96)
                {
                    // Run calculation to bring the shift back into scope
                    int overAlphabets = 96 - originalV;
                    // Reset back to 'z' 122 and re-shift
                    shiftValue = 122 - (unshift - overAlphabets);
                }
                else
                {
                    // Shift within scope
                    shiftValue = originalV - unshift;
                }

                // Apply the shift to the character in the array
                decyrptChars[i] = (char)shiftValue;
            }
        }

        // Convert the character array back to a string and return it
        return new string(decyrptChars);
    }
}






