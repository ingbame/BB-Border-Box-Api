using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Common
{
    [Table("Users", Schema = "Common")]
    public class User
    {
        public long UserId { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string SaltPswd { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Password { get; set; }
        public bool SessionOpen { get; set; }
        public int FailedAttempts { get; set; }
        public bool UserBlocked { get; set; }
        public long? CreatedUserId { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? CreationDate { get; set; }
    }
}
