using BBBorderBox.Entity.Data.Sales;
using BBBorderBox.Entity.Data.Shipment;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Data.Data
{
    public partial class BBBorderBoxContext : DbContext
    {
        //SCHEMA ShipmentSchema
        public DbSet<PackageTabs> PackageTabs { get; set; }
        public DbSet<Package> Packages { get; set; }

        #region Metodo Principal
        public void ShipmentSchemaMainTablesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            PackagesProperties(resposeModelBuilder, out resposeModelBuilder);
            PackageTabsProperties(resposeModelBuilder, out resposeModelBuilder);
        }
        #endregion

        #region Metodos Privados
        private void PackagesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<Package>().HasKey(pk => pk.PackageId).HasName("PK_Packages_PackageId");
            resposeModelBuilder.Entity<Package>().Property(pk => pk.PackageId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<Package>().HasOne<Sale>().WithMany().HasForeignKey(fk => fk.SaleId).HasConstraintName("FK_Package_SaleId");
            resposeModelBuilder.Entity<Package>().HasOne<PackageTabs>().WithMany().HasForeignKey(fk => fk.PackageTabId).HasConstraintName("FK_Packages_PackageTabId");
        }

        private void PackageTabsProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<PackageTabs>().HasKey(pk => pk.PackageTabId).HasName("PK_PackageTabs_PackageTabId");
        }
        #endregion
    }
}
