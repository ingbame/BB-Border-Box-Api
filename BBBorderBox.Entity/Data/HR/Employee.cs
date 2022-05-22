using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.HR
{
    [Table("Employees", Schema = "HR")]
    public class Employee
    {
        public long EmployeeId { get; set; }
        [Required, Column(TypeName = "VARCHAR(200)")]
        public string Name { get; set; }
        [Required, Column(TypeName = "VARCHAR(200)")]
        public string LastName { get; set; }
        public int? TaxOrganizationTypeId { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string TaxValue { get; set; }
        [Required, Column(TypeName = "DATE")]
        public DateTime? Birthbay { get; set; }
        public long UserId { get; set; }
        public bool Active { get; set; }
        public int CountryId { get; set; }
        public long CreatedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime CreationDate { get; set; }
        public long? ModifiedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? ModificationDate { get; set; }
    }
}
