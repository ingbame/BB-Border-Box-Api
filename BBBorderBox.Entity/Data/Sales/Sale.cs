using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Sales
{
    [Table("Sales", Schema = "Sales")]
    public class Sale
    {
        public long SaleId { get; set; }
        public long ClientId { get; set; }
        public long VendorId { get; set; }
        public int OfficeId { get; set; }
        [MaxLength(32)]
        public string OrderNumber { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Subtotal { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Tax { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Total { get; set; }
        public long CreatedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime CreationDate { get; set; }
        public long ModifiedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime ModificationDate { get; set; }
    }
}
