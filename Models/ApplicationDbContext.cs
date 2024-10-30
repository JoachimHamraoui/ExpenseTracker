using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext()
        {
            
        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}