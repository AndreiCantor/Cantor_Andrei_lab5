using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cantor_Andrei_lab5.Models;

namespace Cantor_Andrei_lab5.Data
{
    public class Cantor_Andrei_lab5Context : DbContext
    {
        public Cantor_Andrei_lab5Context (DbContextOptions<Cantor_Andrei_lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Cantor_Andrei_lab5.Models.Expense> Expense { get; set; } = default!;
    }
}
