using System;

using System.Linq;

using System.Collections.Generic;



namespace HelloWorld;



public class CeaserEncryption
{
    static List<char> alphabets = new List<char> {

    'a' , 'b' , 'c' ,'d' , 'e' , 'f' , 'g' , 'h' , 'i' , 'j' ,
    'k' , 'l' , 'm' , 'n' , 'o' , 'p' , 'q' , 'r' , 's' , 't' ,
    'u' , 'v' , 'w' , 'x' , 'y' , 'z'
};

    public static void Main()
    {
        Console.WriteLine("welcome to ceaser encryption console app....");
        Console.Write($"input the text you want to encrypt  :  ");
        string textToBeEncrypted = Console.ReadLine();

        Console.Write($"how many positions to shift the key ?  :  ");
        int positionKey = int.Parse(Console.ReadLine());

        string outcome = Encrypt(textToBeEncrypted, positionKey);
        Console.WriteLine(outcome);

        string decrypt = Decrypt(outcome, positionKey);

        Console.WriteLine(decrypt);




    }

    static string Encrypt(string textToBeEncrypted, int positionKey)
    {
        char[] result = new char[textToBeEncrypted.Length];
        for (int i = 0; i < textToBeEncrypted.Length; i++)
        {
            char c = textToBeEncrypted[i];

            if (char.IsLetter(c))
            {
                int index = alphabets.IndexOf(c);
                int newIndex = (index + positionKey) % 26;
                result[i] = alphabets[newIndex];

            }

            else
            {
                result[i] = c;
            }


        }

        return new string(result);
    }


    static string Decrypt(string textToBeEncrypted, int positionKey)
    {
        return Encrypt(textToBeEncrypted, 26 - positionKey + 26); // Decryption is just
    }

}

