using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Telegram
{
    [Table("Questions", Schema = "Telegram")]
    public class Question
    {
        [Key]
        public long QuestionId { get; set; }
        [Required,Column(TypeName = "VARCHAR(250)")]
        public string QuestionStr { get; set; }
        [Required]
        public long AnswerId { get; set; }
    }
}
