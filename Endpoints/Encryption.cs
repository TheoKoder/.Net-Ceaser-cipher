namespace Endpoints;
public class EncryptionService
{
    //Encrytpion code for ceaser cipher
    //Endpoits are ALWAYS STATIC, declare class as Static
    public string Encryption(string W, int N)
    {
        //delare Character array to break down inserted word, into an Array
        //Account for Capitalized characters by converting everything into a lower case word
        char[] chars = W.ToLower().ToCharArray();

        //Iterate through the char []
        for (int i = 0; i < chars.Length; i++)
        {
            //convert the characters into integers(ASCII) so that we can easily shift the "letters" 
            int Ovlaue = (int)chars[i];
            //using ASCII, make sure the convesrion ONLY accounts for Letters! no special cases or anything
            //for lettes or characters, ASCII starts from #96( character 'a') to #123(character 'z')
            if (Ovlaue > 96 && Ovlaue < 123)
            {
                int shiftValue;
                //Prevent from going above 123 which is special charcters and NO longer aphabets
                if ((Ovlaue + N) > 123)
                {
                    //Run calculation to bring the shift Back into Scope
                    int OverAphabets = 122 - Ovlaue;
                    //reset back to 'a' 96 and reShift
                    shiftValue = 96 + (N - OverAphabets);
                }
                else
                {
                    //Shift within scope
                    shiftValue = Ovlaue + N;
                }
                // Apply the shift to the character in the array
                chars[i] = (char)shiftValue;
            }
        }

        // Convert the character array back to a string and return it
        return new string(chars);
    }
}
