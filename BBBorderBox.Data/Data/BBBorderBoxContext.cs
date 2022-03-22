using BBBorderBox.Entity.WServices;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Data.Data
{
    public class BBBorderBoxContext : DbContext
    {
        public BBBorderBoxContext(DbContextOptions<BBBorderBoxContext> options) : base(options)
        {
        }

        public DbSet<ChatUpdate> ChatsUpdates { get; set; }
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
            ChatsUpdatesProperties(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        /*
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Aqui se puede personalizar la creación de las tablas y las relaciones entre ellas
            PackagesProperties(modelBuilder);
            SalesProperties(modelBuilder);

            base.OnModelCreating(modelBuilder); 
        }
        public ModelBuilder SalesProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().HasKey(pk => pk.SaleId).HasName("PK_Sales_SaleId");
            modelBuilder.Entity<Sale>().Property(p => p.CreatedDate).HasColumnType("DATETIME");
            modelBuilder.Entity<Sale>().Property(p => p.TaxIva).HasPrecision(18, 2);
            modelBuilder.Entity<Sale>().Property(p => p.Subtotal).HasPrecision(18, 2);
            modelBuilder.Entity<Sale>().Property(p => p.Total).HasPrecision(18, 2);
            return modelBuilder;
        }
        public ModelBuilder PackagesProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>().HasKey(pk => pk.PackageId).HasName("PK_Packages_PackageId");
            modelBuilder.Entity<Package>().HasOne<Sale>().WithMany().HasForeignKey(fk => fk.SaleId).HasConstraintName("FK_Packages_SaleId");
            modelBuilder.Entity<Package>().Property(p => p.Dimentions).HasPrecision(18, 2);
            modelBuilder.Entity<Package>().Property(p => p.Weigth).HasPrecision(18, 2);
            return modelBuilder;
        }

         */
        public ModelBuilder ChatsUpdatesProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatUpdate>().HasKey(pk => pk.UpdateId).HasName("PK_ChatsUpdates_UpdateId");
            modelBuilder.Entity<ChatUpdate>().Property(pk => pk.UpdateId).ValueGeneratedNever();
            modelBuilder.Entity<ChatUpdate>().Property(p => p.FirstName).HasColumnType("VARCHAR(100)");
            modelBuilder.Entity<ChatUpdate>().Property(p => p.LastName).HasColumnType("VARCHAR(100)");
            modelBuilder.Entity<ChatUpdate>().Property(p => p.LanguageCode).HasColumnType("VARCHAR(10)");
            modelBuilder.Entity<ChatUpdate>().Property(p => p.TypedCommand).HasColumnType("VARCHAR(20)");

            return modelBuilder;
        }
    }
}
