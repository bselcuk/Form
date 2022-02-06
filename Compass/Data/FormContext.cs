using Compass.Entity;
using Microsoft.EntityFrameworkCore;

namespace Compass.Data
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options):base(options)
        {

        }
        public DbSet<Form> Forms { get; set; }
        public DbSet<ICRHeader> IcrHeaders { get; set; }
        public DbSet<ICRValue> ICRValues { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Data Source=forms.db");
        //}
    }
}
