using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Entity.Data.Common
{
    [Table("Countries", Schema = "Common")]
    public class Country
    {
        public int CountryId { get; set; }
        [Required, Column(TypeName = "VARCHAR(2)")]
        public string StrKey { get; set; }
        [Required, Column(TypeName = "VARCHAR(70)")]
        public string CountryName { get; set; }
        public bool IsActive { get; set; }
    }
}
