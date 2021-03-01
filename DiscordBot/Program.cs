using ChatBotConfig;
using DSharpPlus;
using System;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {

            // https://youtu.be/QxOCqUFPJVQ
            new Bot(
                config: DiscordConfig.Instance,
                logLevel: LogLevel.Info)
                .Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();         
        }
    }
}
