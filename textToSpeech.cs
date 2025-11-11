ng System;

using System.Linq;

using System.Collections.Generic;
using System.Speech.Synthesis;



namespace HelloWorld;



public class textTospeech
{

    string userText;


    //A SIMPLE TEXT TO SPEECH
    public static void Main()
    {
        TextInput();

    }



    //FUNCTION FOR USERINPUT
    static void TextInput()
    {

        Console.WriteLine("welcome to my nini TTS app");
        Console.WriteLine("--------------------");
        Console.WriteLine("input your text");
        userText = Console.ReadLine();
        ConvertToSpeech(userText);

    }

    //Function for text to speech conversiom

    static void ConvertToSpeech(string text)
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        synthesizer.SetOutPutToWaveFile("output.wav");

    }

}


