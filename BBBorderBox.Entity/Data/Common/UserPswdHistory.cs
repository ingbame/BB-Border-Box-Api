using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Common
{
    [Table("UserPswdHistory", Schema = "Common")]
    public class UserPswdHistory
    {
        public long UserPswdHistoryId { get; set; }
        public long UserId { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string OldPassword { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime ChangeDate { get; set; }
    }
}
