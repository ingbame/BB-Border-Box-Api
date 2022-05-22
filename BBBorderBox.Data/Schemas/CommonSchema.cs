using BBBorderBox.Data.Data.InitialData;
using BBBorderBox.Entity.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Data.Data
{
    public partial class BBBorderBoxContext : DbContext
    {
        //SCHEMA CommonSchema
        public DbSet<Country> Countries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPswdHistory> UserPswdHistory { get; set; }
        public DbSet<TaxOrganization> TaxOrganizations { get; set; }
        public DbSet<TaxOrganizationType> TaxOrganizationTypes { get; set; }

        #region Metodo Principal
        public void CommonSchemaMainTablesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            CountryProperties(resposeModelBuilder, out resposeModelBuilder);
            ZipCodesProperties(resposeModelBuilder, out resposeModelBuilder);
            UsersProperties(resposeModelBuilder, out resposeModelBuilder);
            UserPswdHistoryProperties(resposeModelBuilder, out resposeModelBuilder);
            TaxOrganizationsProperties(resposeModelBuilder, out resposeModelBuilder);
            TaxOrganizationTypesProperties(resposeModelBuilder, out resposeModelBuilder);
        }
        #endregion

        #region Metodos Privados
        private void CountryProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<Country>().HasKey(pk => pk.CountryId).HasName("PK_Countries_CountryId");
            resposeModelBuilder.Entity<Country>().Property(pk => pk.CountryId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<Country>().HasIndex(u => u.StrKey).IsUnique();
            resposeModelBuilder.Entity<Country>().Property(u => u.IsActive).HasDefaultValue(false);
            resposeModelBuilder.Entity<Country>().HasData(CommonInitialData.Instance.AddCountries());
        }
        private void ZipCodesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<ZipCode>().HasKey(pk => pk.ZipCodeId).HasName("PK_ZipCodes_Id");
            resposeModelBuilder.Entity<ZipCode>().Property(pk => pk.ZipCodeId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<ZipCode>().HasIndex(u => u.ZipCodeVal).IsUnique();
        }
        private void UsersProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<User>().HasKey(pk => pk.UserId).HasName("PK_Users_UserId");
            resposeModelBuilder.Entity<User>().Property(pk => pk.UserId).UseIdentityColumn(1,1);
            resposeModelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            resposeModelBuilder.Entity<User>().HasOne<User>().WithMany().HasForeignKey(fk => fk.CreatedUserId).HasConstraintName("FK_Users_UserId");
            resposeModelBuilder.Entity<User>().Property(u => u.SessionOpen).HasDefaultValue(false);
            resposeModelBuilder.Entity<User>().Property(u => u.FailedAttempts).HasDefaultValue(0);
            resposeModelBuilder.Entity<User>().Property(u => u.UserBlocked).HasDefaultValue(false);
            resposeModelBuilder.Entity<User>().HasData(CommonInitialData.Instance.AddUsers());
        }
        private void UserPswdHistoryProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<UserPswdHistory>().HasKey(pk => pk.UserPswdHistoryId).HasName("PK_UserPswdHistory_UserPswdHistoryId");
            resposeModelBuilder.Entity<UserPswdHistory>().Property(pk => pk.UserPswdHistoryId).UseIdentityColumn(1,1);
            resposeModelBuilder.Entity<UserPswdHistory>().HasOne<User>().WithMany().HasForeignKey(fk => fk.UserId).HasConstraintName("FK_UserPswdHistory_UserId");
        }
        private void TaxOrganizationsProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<TaxOrganization>().HasKey(pk => pk.TaxOrganizationId).HasName("PK_TaxOrganizations_TaxOrganizationId");
            resposeModelBuilder.Entity<TaxOrganization>().Property(pk => pk.TaxOrganizationId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<TaxOrganization>().HasIndex(u => u.StrKey).IsUnique();
            resposeModelBuilder.Entity<TaxOrganization>().HasData(CommonInitialData.Instance.AddTaxOrganizations());
        }
        private void TaxOrganizationTypesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<TaxOrganizationType>().HasKey(pk => pk.TaxOrganizationTypeId).HasName("PK_TaxOrganizationTypes_TaxOrganizationTypeId");
            resposeModelBuilder.Entity<TaxOrganizationType>().Property(pk => pk.TaxOrganizationTypeId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<TaxOrganizationType>().HasOne<TaxOrganization>().WithMany().HasForeignKey(fk => fk.TaxOrganizationId).HasConstraintName("FK_TaxOrganizationTypes_TaxOrganizationId");
            resposeModelBuilder.Entity<TaxOrganizationType>().HasIndex(u => u.StrKey).IsUnique();
        }
        #endregion
    }
}
