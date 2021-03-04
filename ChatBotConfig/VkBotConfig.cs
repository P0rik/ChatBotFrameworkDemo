using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBotConfig
{
    public class VkConfig
    {
        // https://vk.com/dev/bots
        // https://vk.com/dev/bots_docs - основа

        // Создать сообщество
        // Включаем бота https://vk.com/club202670669?act=messages&tab=bots
        //
        // 1.1. Получение ключа доступа Long Poll
        // Откройте раздел «Управление сообществом» 
        // («Управление страницей», если у Вас публичная страница), 
        // выберите вкладку «Работа с API» и нажмите «Создать ключ доступа».
        // https://vk.com/club202670669?act=longpoll_api
        //
        // Получение groupId https://vk.com/dev/groups.getById
        //

        private static readonly VkConfig config;

        static VkConfig()
        {
            config = new VkConfig();
        }
        public string AccessToken => accessToken;

        public static VkConfig Instance => config;
        public ulong GroupId => groupId;

        private VkConfig()
        {
           this.accessToken = "";
           this.groupId = 0;

            #region other

            //this.login = "";
            //this.password = "";
            //this.appId = "";
            
            #endregion
        }

        string accessToken;
        ulong groupId;

        #region other

        //public string Login => login;
        //public string Password => password; 
        //public ulong AppId  => appId;
        //ulong appId;
        //string login;
        //string password;

        #endregion
    }
}
