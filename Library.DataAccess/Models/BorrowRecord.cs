using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Models
{
    public class BorrowRecord
    {
        [Key]
        public int BorrowId { get; set; }
        //[Key , Column(Order =0)]
        public int BookId { get; set; } //References BookId
        //[Key, Column(Order = 1)]
        public int MemberId { get; set; } // References UserId
        [Required]
        public DateTime BorrowDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable for books not yet returned

        //Navigation Properties
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        [ForeignKey("MemberId")]
        public virtual User Member { get; set; }

    }
}
