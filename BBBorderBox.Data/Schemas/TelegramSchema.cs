using BBBorderBox.Entity.Data.Telegram;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Data.Data
{
    public partial class BBBorderBoxContext : DbContext
    {
        //SCHEMA TelegramSchema
        public DbSet<ChatUpdate> ChatsUpdates { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        #region Metodo Principal
        public void TelegramSchemaMainTablesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            ChatsUpdatesProperties(resposeModelBuilder, out resposeModelBuilder);
        }
        #endregion

        #region Metodos Privados
        private void ChatsUpdatesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<ChatUpdate>().HasKey(pk => pk.UpdateId).HasName("PK_ChatsUpdates_UpdateId");
            resposeModelBuilder.Entity<ChatUpdate>().Property(pk => pk.UpdateId).ValueGeneratedNever();
            resposeModelBuilder.Entity<ChatUpdate>().Property(u => u.NeedHuman).HasDefaultValue(false);
            resposeModelBuilder.Entity<ChatUpdate>().Property(u => u.TalkingWithHuman).HasDefaultValue(false);
        }
        #endregion
    }
}
