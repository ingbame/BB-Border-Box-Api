using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Entity.Data.Common
{
    [Table("ZipCodes", Schema = "Common")]
    public class ZipCode
    {
        public int ZipCodeId { get; set; }
        [Required, Column(TypeName = "VARCHAR(10)")]
        public string ZipCodeVal { get; set; }
        public int CountryId { get; set; }
    }
}
