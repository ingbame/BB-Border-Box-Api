using BBBorderBox.Data.Data;
using BBBorderBox.Entity.WServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Data.WServices.Telegram
{
    public class DABotIntegration
    {
        private readonly BBBorderBoxContext _context;
        #region Patron de Diseño
        private static DABotIntegration _instance;
        private static readonly object _instanceLock = new object();
        public static DABotIntegration Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new DABotIntegration();
                    }
                }

                return _instance;
            }
        }
        #endregion
        public DABotIntegration(BBBorderBoxContext context)
        {
            _context = context;
        }
        public async Task<ChatUpdate> GetBotUpdate(long id)
        {
            using (var dbctx = new BBBorderBoxContext())
            {
                var consult = await dbctx.ChatsUpdates.FindAsync(id);
            }
            return new ChatUpdate();
        }
        public async Task<ChatUpdate> PostUpdateAsync(ChatUpdate model)
        {
            using (var dbctx = new BBBorderBoxContext())
            {
                await dbctx.ChatsUpdates.AddAsync(model);
                await dbctx.SaveChangesAsync();
            }
            return model;
        }
    }
}
