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
        public virtual List<LogAction> LogActions { get; set; }

        public override string ToString()
        {
            return $"{BookId}- {Title}, Author: {Author}, ISBN: {ISBN}, Category: {Category}, " +
                   $"Quantity: {Quantity}, PublishedYear: {PublishedYear}, " +
                   $"BorrowRecords: {BorrowRecords?.Count ?? 0}, LogActions: {LogActions?.Count ?? 0}";
        }


    }
}
