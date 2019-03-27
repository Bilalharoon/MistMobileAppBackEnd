
using Microsoft.EntityFrameworkCore;


namespace QuotesAPI.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {

        }

        public DbSet<QuotesModel> QuotesModel { get; set; }
    }
}
