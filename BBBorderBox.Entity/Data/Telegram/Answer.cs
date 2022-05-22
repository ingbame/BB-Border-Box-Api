using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Telegram
{
    [Table("Answers", Schema = "Telegram")]
    public class Answer
    {
        [Key]
        public long AnswerId { get; set; }
        [Required, Column(TypeName = "VARCHAR(250)")]
        public string AnswerStr { get; set; }
        public bool NeedHuman { get; set; }
        public bool HasResponseFunction { get; set; }
        public string FunctionName { get; set; }
        public object[] FunctionParams { get; set; }
    }
}
