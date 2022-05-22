using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Shipment
{
    [Table("PackageTabs", Schema = "Shipment")]
    public class PackageTabs
    {
        [Key]
        public int PackageTabId { get; set; }
        public long PackageTypeId { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal MinWeight { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal MaxWeight { get; set; }
        public int UnitId { get; set; }
        public long CreatedUser { get; set; }
        public DateTime CreationDate { get; set; }
        public long ModifiedUser { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
