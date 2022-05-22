using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Shipment
{
    [Table("Packages", Schema = "Shipment")]
    public class Package
    {
        public long PackageId { get; set; }
        public long SaleId { get; set; }
        [Column(TypeName = "VARCHAR(21)")]
        public string PiceId { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string TrackNumber { get; set; }
        public int PackageTabId { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal TrueWeight { get; set; }
        public long CreatedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime CreationDate { get; set; }
        public long ModifiedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime ModificationDate { get; set; }
    }
}
