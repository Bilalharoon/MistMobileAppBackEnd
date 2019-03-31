
using Microsoft.EntityFrameworkCore;
using System;

namespace QuotesAPI.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            QuotesModel[] quotes = new QuotesModel[32];

            for (int i = 1; i <= 31; i++)
            {
                quotes[i] = new QuotesModel { Id = i, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur." + i, Author = "Lorem Ipsum" + i};
                Console.WriteLine("i: " + i);
                Console.WriteLine("quote[i]: " + quotes[i].Text);
                modelBuilder.Entity<QuotesModel>().HasData(quotes[i]);
                
            }

            
            
        }

        public DbSet<QuotesModel> QuotesModel { get; set; }
    }
}
