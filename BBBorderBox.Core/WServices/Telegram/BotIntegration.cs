using BBBorderBox.Data.WServices.Telegram;
using BBBorderBox.Entity.Data.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Core.WServices.Telegram
{
    public class BotIntegration
    {
        #region Patron de Diseño
        private static BotIntegration _instance;
        private static readonly object _instanceLock = new object();
        public static BotIntegration Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new BotIntegration();
                    }
                }
                return _instance;
            }
        }
        #endregion
        public async Task<ChatUpdate> GetBotUpdate(long id)
        {
            var update = await DABotIntegration.Instance.GetBotUpdate(id);
            return update;
        }
        public async Task<ChatUpdate> PostBotIntegrationAsync(ChatUpdate model)
        {
            var Result = await DABotIntegration.Instance.PostUpdateAsync(model);
            return Result;
        }
    }
}
