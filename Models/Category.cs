using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Column (TypeName = "nvarchar(50)")]
        public required string Title { get; set; }
        
        [Column (TypeName = "nvarchar(5)")]
        public required string Icon { get; set; } =  "";

        [Column (TypeName = "nvarchar(10)")]
        public required string Type { get; set; } = "Expense";
    }
}