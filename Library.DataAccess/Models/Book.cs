using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        [Required]
        [StringLength(50)]
        public string ISBN { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Quantity { get; set; }   
        [Required]
        [Range(1450, 2100)]
        public int PublishedYear { get; set; }

        //Navigation Properties
        public virtual List<BorrowRecord> BorrowRecords { get; set; }
    }
}
