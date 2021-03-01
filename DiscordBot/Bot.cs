using ChatBotConfig;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    internal class Bot
    {
 
        DiscordClient client;

        public Bot(DiscordConfig config, LogLevel logLevel = LogLevel.Info)
        {
            this.client = new DiscordClient(new DiscordConfiguration()
            {
                Token = config.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,

                LogLevel = logLevel
            });
        }

        public void Start(AsyncEventHandler<MessageCreateEventArgs> e = null)
        {
            if (e != null) client.MessageCreated += e;
            else client.MessageCreated += new AsyncEventHandler<MessageCreateEventArgs>(DefaultMessageReceived);

            client.ConnectAsync();
        } 

        private Task DefaultMessageReceived(MessageCreateEventArgs e)
        {
            if (e.Author.IsBot) return Task.CompletedTask;

            var msgType = e.Message.MessageType;
            var username = e.Author.Username;
            var msg = e.Message.Content;

            Console.WriteLine(String.Format("{0} {1} {2}",
                msgType,
                username,
                msg));

            var ans = msg switch
            {
                "!hi" => "Привет",
                "!time" => DateTime.Now.ToString(),
                _ => $"Получено {msg}"
            };


            ans = String.Format(
                "**{0}** жирный \n "
                + "__{0}__ подчеркивание \n "
                + "_{0}_ курсив \n "
                + "*{0}* курсив \n "
                + "~~{0}~~ зачеркнут \n "
                + "||{0}|| спойлер \n "
                + "`{0}` однострочный блок \n "
                + @"```
for (int i = 0; i < length; i++)
    Console.WriteLine(i);

``` многострочный блок "

                + "<http://ksergey.ru/>\n "
                ,
                ans
                );  
            // https://discord.fandom.com/ru/wiki/Форматирование_текста



            var embed = new DiscordEmbedBuilder
            {
                Title = "Важное сообщение и его тема ",
                ImageUrl = "http://ksergey.ru/icons/telegram.png",
                Url = "http://ksergey.ru/ ",
                Description = $"{DiscordEmoji.FromName(client, ":no_entry:")} \n Текст сообщения",
                Color = new DiscordColor(0x0000FF), //цвет линейки
                Footer = new DiscordEmbedBuilder.EmbedFooter()
                {
                    Text = $"Footer Text"
                }
            };

            return e.Message.RespondAsync(
               content: ans,
               embed: embed
              );
        }
    }
}