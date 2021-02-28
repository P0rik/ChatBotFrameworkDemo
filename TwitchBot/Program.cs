using System;

using ChatBotConfig;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace TwitchBot
{
    class Program
    {
        static void Main(string[] args)
        {

            new Bot(TwitchConfig.Instance).Start();
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
