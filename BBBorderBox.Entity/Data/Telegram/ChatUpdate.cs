using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBBorderBox.Entity.Data.Telegram
{
    [Table("ChatsUpdates", Schema = "Telegram")]
    public class ChatUpdate
    {
        [Key]
        public long UpdateId { get; set; }
        public long MessageId { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "VARCHAR(MAX)")]
        public string MessageText { get; set; }
        public long AppUserId { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string LastName { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string LanguageCode { get; set; }
        public long ChatId { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string TypedCommand { get; set; }
        [Column(TypeName = "VARCHAR(MAX)")]
        public string ReturnResponse { get; set; }
        public bool NeedHuman { get; set; }
        public bool TalkingWithHuman { get; set; }
        public long EmployId { get; set; }
    }
}
