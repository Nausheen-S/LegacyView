using Microsoft.EntityFrameworkCore;
using LegacyView.Models; // referencing the model class

namespace LegacyView.Data
{
    public class LegacyViewContext :DbContext //inheriting from DbContext
    {
        public LegacyViewContext(DbContextOptions<LegacyViewContext> options)
            : base(options)
        {
        }

        public DbSet<DVD> DVD { get; set; } // creating the table (or entity set) for the DVD class
    }
}
