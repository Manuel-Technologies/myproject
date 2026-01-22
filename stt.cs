using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Speech.Recognition;

public class Program
{
    static SpeechRecognitionEngine recongnizer;
    public static void Main()
    {
        Console.WriteLine("welcome to our ultra fast speech to text console app ");
        Console.WriteLine("i am building this cause it will be part of my future softwares");
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine($"enter (GO) to start listening to your speech");

        string userInput = Console.ReadLine();
            if (userInput.ToLower()=="go")
            {
                ListenToSpeech();
                 Console.WriteLine("Speak now...");
            Console.WriteLine("Press any key to stop");
            // Console.ReadKey();
            }

    }
    public static void ListenToSpeech()
    {
        recongnizer = new SpeechRecognitionEngine();
        recongnizer.SetInputToDefaultAudioDevice();
        recongnizer.LoadGrammar(new DictationGrammar());
        recongnizer.SpeechRecognized += OnSpeechRecongnized;
        recongnizer.RecognizeAsync(RecognizeMode.Multiple);


    }
static void OnSpeechRecongnized(object sender , SpeechRecognizedEventArgs e)
    {
        System.Console.WriteLine($"you said {e.Result.Text}");
    }
// public static void ConvertToText()
//     {
        
//     }
}
