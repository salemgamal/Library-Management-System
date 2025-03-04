using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Models
{
    public enum LogActionType
    {
        Borrow,
        Return
    }
    public class LogAction
    {
        [Key]
        public int ActionId { get; set; }
        public LogActionType Action { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [ForeignKey("MemberId")]
        public virtual User Member { get; set; }
    }
}
