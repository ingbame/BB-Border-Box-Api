using BBBorderBox.Data.Data;
using BBBorderBox.Entity.Data.Telegram;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
        private DABotIntegration() : this(new BBBorderBoxContext(new DbContextOptions<BBBorderBoxContext>()))
        {

        }
        private DABotIntegration(BBBorderBoxContext context)
        {
            _context = context;
        }
        public async Task<ChatUpdate> GetBotUpdate(long id)
        {
            var consult = await _context.ChatsUpdates.FindAsync(id);
            return consult;
        }
        public async Task<ChatUpdate> PostUpdateAsync(ChatUpdate model)
        {
            await _context.ChatsUpdates.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
