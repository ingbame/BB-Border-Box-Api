using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Common
{
    [Table("TaxOrganizationTypes", Schema = "Common")]
    public class TaxOrganizationType
    {
        public int TaxOrganizationTypeId { get; set; }
        [Required]
        public int TaxOrganizationId { get; set; }
        [Required]
        [MaxLength(5)]
        public string StrKey { get; set; }
        [Required]
        [MaxLength(150)]
        public string TypeDescription { get; set; }
    }
}
