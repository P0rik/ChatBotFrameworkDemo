using ChatBotConfig;
using System;

namespace VkBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/vc7qAeeW-_M
            new Bot(VkConfig.Instance).Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine(); 
        }
    }
}
