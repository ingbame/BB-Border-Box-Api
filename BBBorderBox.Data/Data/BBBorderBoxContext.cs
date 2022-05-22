using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BBBorderBox.Data.Data
{
    public partial class BBBorderBoxContext : DbContext
    {
        public BBBorderBoxContext(DbContextOptions<BBBorderBoxContext> options) : base(options) { }

        #region Override Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();
                    var connectionString = configuration.GetConnectionString("BBBorderBoxCon");
                    optionsBuilder.UseSqlServer(connectionString);
                }
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Aqui se puede personalizar la creación de las tablas y las relaciones entre ellas
            #region Schemas
            CommonSchemaMainTablesProperties(modelBuilder, out modelBuilder);
            HRSchemaMainTablesProperties(modelBuilder, out modelBuilder);
            SalesSchemaMainTablesProperties(modelBuilder, out modelBuilder);
            ShipmentSchemaMainTablesProperties(modelBuilder, out modelBuilder);
            TelegramSchemaMainTablesProperties(modelBuilder, out modelBuilder);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
