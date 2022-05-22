using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Common
{
    [Table("TaxOrganizations", Schema = "Common")]
    public class TaxOrganization
    {
        public int TaxOrganizationId { get; set; }
        [Required]
        [MaxLength(5)]
        public string StrKey { get; set; }
        [Required]
        [MaxLength(150)]
        public string OrgDescription { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
