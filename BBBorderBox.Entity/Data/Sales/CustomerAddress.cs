using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Sales
{
    [Table("CustomerAddresses", Schema = "Sales")]
    public class CustomerAddress
    {
        public long CustomerAddressId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required, Column(TypeName = "VARCHAR(150)")]
        public string Street { get; set; }
        [Required, Column(TypeName = "VARCHAR(10)")]
        public string OutdoorNumber { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string InteriorNumber { get; set; }
        [Required, Column(TypeName = "VARCHAR(150)")]
        public string Colony { get; set; }
        [Required]
        public int ZipCodeId { get; set; }
        public string References { get; set; }
        public bool MainAddress { get; set; }
        public bool BillingAddress { get; set; }
        public long CreatedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime CreationDate { get; set; }
        public long ModifiedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime ModificationDate { get; set; }
    }
}
