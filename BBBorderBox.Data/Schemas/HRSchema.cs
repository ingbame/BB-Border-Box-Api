using BBBorderBox.Entity.Data.Common;
using BBBorderBox.Entity.Data.HR;
using Microsoft.EntityFrameworkCore;

namespace BBBorderBox.Data.Data
{
    public partial class BBBorderBoxContext : DbContext
    {
        //SCHEMA HRSchema
        public DbSet<Employee> Employees { get; set; }

        #region Metodo Principal
        public void HRSchemaMainTablesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            EmployeesProperties(resposeModelBuilder, out resposeModelBuilder);
            EmployeesAddressProperties(resposeModelBuilder, out resposeModelBuilder);
        }
        #endregion

        #region Metodos Privados
        private void EmployeesProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<Employee>().HasKey(pk => pk.EmployeeId).HasName("PK_Employees_EmployeeId");
            resposeModelBuilder.Entity<Employee>().Property(pk => pk.EmployeeId).UseIdentityColumn(1,1);
            resposeModelBuilder.Entity<Employee>().HasOne<TaxOrganizationType>().WithMany().HasForeignKey(fk => fk.TaxOrganizationTypeId).HasConstraintName("FK_Clients_TaxOrganizationTypeId");
            resposeModelBuilder.Entity<Employee>().HasOne<Country>().WithMany().HasForeignKey(fk => fk.CountryId).HasConstraintName("FK_Clients_CountryId");
            resposeModelBuilder.Entity<Employee>().Property(p => p.Active).HasDefaultValue(false);
        }
        private void EmployeesAddressProperties(ModelBuilder sourceModelBuilder, out ModelBuilder resposeModelBuilder)
        {
            resposeModelBuilder = sourceModelBuilder;
            resposeModelBuilder.Entity<EmployeeAddress>().HasKey(pk => pk.EmployeeAddressId).HasName("PK_EmployeesAddress_Id");
            resposeModelBuilder.Entity<EmployeeAddress>().Property(pk => pk.EmployeeAddressId).UseIdentityColumn(1, 1);
            resposeModelBuilder.Entity<EmployeeAddress>().HasOne<Employee>().WithMany().HasForeignKey(fk => fk.EmployeeId).HasConstraintName("FK_EmployeesAddress_EmployeeId");
            resposeModelBuilder.Entity<EmployeeAddress>().HasOne<ZipCode>().WithMany().HasForeignKey(fk => fk.ZipCodeId).HasConstraintName("FK_EmployeesAddress_ZipCodeId");
            resposeModelBuilder.Entity<EmployeeAddress>().Property(p => p.MainAddress).HasDefaultValue(false);
        }
        #endregion
    }
}
