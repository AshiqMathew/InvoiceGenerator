using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.Models
{
    public class InvoiceDbContext:DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext>options):base(options)
        {
            
        }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
