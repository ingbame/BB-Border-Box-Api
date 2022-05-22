using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Entity.Data.HR
{
    [Table("EmployeesAddress", Schema = "HR")]
    public class EmployeeAddress
    {
        [Required]
        public int EmployeeAddressId { get; set; }
        [Required]
        public long EmployeeId { get; set; }
        [Required, Column(TypeName = "VARCHAR(150)")]
        public string Street { get; set; }
        [Required, Column(TypeName = "VARCHAR(10)")]
        public string OutdoorNumber { get; set; }
        [Required, Column(TypeName = "VARCHAR(10)")]
        public string InteriorNumber { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(150)")]
        public string Colony { get; set; }
        [Required]
        public int ZipCodeId { get; set; }
        public string References { get; set; }
        public bool MainAddress { get; set; }
        public long CreatedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime CreationDate { get; set; }
        public long ModifiedUser { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime ModificationDate { get; set; }
    }
}
