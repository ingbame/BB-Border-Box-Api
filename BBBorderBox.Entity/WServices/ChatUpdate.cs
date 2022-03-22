using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Entity.WServices
{
    [Table("ChatsUpdates", Schema = "Telegram")]
    public class ChatUpdate
    {
        public long UpdateId { get; set; }
        public long MessageId { get; set; }
        public DateTime Date { get; set; }
        public string? MessageText { get; set; }
        public long AppUserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? LanguageCode { get; set; }
        public long ChatId { get; set; }
        public string? TypedCommand { get; set; }
        public string? ReturnResponse { get; set; }
        public bool NeedHuman { get; set; }
        public bool TalkingWithHuman { get; set; }
        public long EmployId { get; set; }
    }
}
