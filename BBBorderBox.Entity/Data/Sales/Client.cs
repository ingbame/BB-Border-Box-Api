using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Sales
{
    [Table("Clients", Schema = "Sales")]
    public class Client
    {
        public long ClientId { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(250)")]
        public string ClientName { get; set; }
        public int? TaxOrganizationTypeId { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string TaxValue { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime? Anniversary { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public long CreatedUser { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime CreationDate { get; set; }
        public long ModifiedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime ModificationDate { get; set; }
    }
}
