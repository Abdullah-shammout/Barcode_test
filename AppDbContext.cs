using Barcode.Models;
using Microsoft.EntityFrameworkCore;

namespace Barcode
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<BarcodeTypes> BarcodeType { get; set; }
    }
}
