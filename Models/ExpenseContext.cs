using Microsoft.EntityFrameworkCore;

namespace Cantor_Andrei_lab5.Models
{
	public class ExpenseContext : DbContext
	{
		public ExpenseContext(DbContextOptions<ExpenseContext> options)
		: base(options)
		{
		}
		public DbSet<Expense> Expense { get; set; }
		public DbSet<ExpenseDTO> ExpenseDTO { get; set; }


	}
}
