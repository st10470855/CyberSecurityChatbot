using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        PlayVoiceGreeting();
        ShowLogo();
        StartChat();
    }

    static void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.Play();
        }
        catch
        {
            Console.WriteLine("(Voice greeting not found)");
        }
    }

    static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("======================================");
        Console.WriteLine("   ____   __   ____  ____  ____ ");
        Console.WriteLine("  / ___| / _| | __ )| __ )|  _ \\");
        Console.WriteLine(" | |    | |_  |  _ \\|  _ \\| |_) |");
        Console.WriteLine(" | |___ |  _| | |_) | |_) |  __/ ");
        Console.WriteLine("  \\____||_|   |____/|____/|_|    ");
        Console.WriteLine("");
        Console.WriteLine("      CYBER SECURITY BOT");
        Console.WriteLine("======================================");

        Console.ResetColor();
    }
    static void TypeText(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(30);
        }
        Console.WriteLine();
    }

    static void StartChat()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome " + name + "! I am your Cybersecurity Assistant.");
        Console.ResetColor();

        while (true)
        {
            Console.Write("\nAsk me something: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please type something so I can help you.");
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I am functioning perfectly and ready to help!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to help you stay safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with uppercase, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Phishing is when attackers trick you into giving personal information.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Always check website URLs and avoid suspicious links.");
            }
            else if (input.Contains("malware"))
            {
                Console.WriteLine("Malware is harmful software. Avoid downloading from unknown sources.");
            }
            else if (input.Contains("exit"))
            {
                TypeText("Goodbye " + name + "! Stay safe online.");
                break;

            }
            else
            {
                Console.WriteLine("I didn’t understand that. Try asking about passwords, phishing, or malware.");
            }
        }
    }
}
