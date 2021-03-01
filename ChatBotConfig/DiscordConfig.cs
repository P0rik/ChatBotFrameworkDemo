using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBotConfig
{
    public class DiscordConfig
    {
        private static DiscordConfig config;
        public string Token => token;
        public static DiscordConfig Instance { get => config == null ? new DiscordConfig() : config; }
        
        private DiscordConfig()
        {
            /// сделать сервер
            /// https://discord.com/developers/applications
            /// 
            /// application/Bot DoIt
            this.token = "";

            // скопировать CLIENT ID из General Information
            // далее авторизовать бота на сервере 
            // https://discord.com/developers/docs/topics/oauth2#bot-authorization-flow-url-example
        }
        string token;
    } 
}
