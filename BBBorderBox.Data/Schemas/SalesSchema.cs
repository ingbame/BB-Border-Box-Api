using BBBorderBox.Entity.Data.Common;
using BBBorderBox.Entity.Data.HR;
using BBBorderBox.Entity.Data.Sales;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Data.Data
{
    public partial class BBBorderBoxContext : DbContext
    {
        //SCHEMA SalesSchema
        public DbSet<Client> Clients { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Sale> Sales { get; set; }

        #region Metodo Principal
        public void SalesSchemaMainTablesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            ClientsProperties(resposeModelBuilder, out resposeModelBuilder);
            CustomerAddressesProperties(resposeModelBuilder, out resposeModelBuilder);
            SalesProperties(resposeModelBuilder, out resposeModelBuilder);
        }
        #endregion

        #region Metodos Privados
        private void ClientsProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<Client>().HasKey(pk => pk.ClientId).HasName("PK_Clients_ClientId");
            resposeModelBuilder.Entity<Client>().Property(pk => pk.ClientId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<Client>().HasOne<TaxOrganizationType>().WithMany().HasForeignKey(fk => fk.TaxOrganizationTypeId).HasConstraintName("FK_Clients_TaxOrganizationTypeId");
        }
        private void CustomerAddressesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<CustomerAddress>().HasKey(pk => pk.CustomerAddressId).HasName("PK_CustomerAddresses_CustomerAddressId");
            resposeModelBuilder.Entity<CustomerAddress>().Property(pk => pk.CustomerAddressId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<CustomerAddress>().HasOne<Client>().WithMany().HasForeignKey(fk => fk.ClientId).HasConstraintName("FK_CustomerAddresses_ClientId");
            resposeModelBuilder.Entity<CustomerAddress>().HasOne<ZipCode>().WithMany().HasForeignKey(fk => fk.ZipCodeId).HasConstraintName("FK_CustomerAddresses_ZipCodeId");
            resposeModelBuilder.Entity<CustomerAddress>().Property(u => u.MainAddress).HasDefaultValue(false);
            resposeModelBuilder.Entity<CustomerAddress>().Property(u => u.BillingAddress).HasDefaultValue(false);
        }
        private void SalesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<Sale>().HasKey(pk => pk.SaleId).HasName("PK_Sales_SaleId");
            resposeModelBuilder.Entity<Sale>().Property(pk => pk.SaleId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<Sale>().HasOne<Client>().WithMany().HasForeignKey(fk => fk.ClientId).HasConstraintName("FK_Sales_ClientId");
            resposeModelBuilder.Entity<Sale>().HasOne<Employee>().WithMany().HasForeignKey(fk => fk.VendorId).HasConstraintName("FK_Sales_VendorId");
        }
        #endregion
    }
}
