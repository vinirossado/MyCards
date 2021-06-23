using MagicAPI.Extensions;
using MagicAPI.Mapping;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicAPI.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        //public void AddEntity(object entity)
        //{
        //    base.Add(entity);
        //}

        public void UpdateEntity(object entity)
        {
            var entry = Entry(entity);
            if (entry == null)
            {
                entry = Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
        public DbSet<CardModel> CardModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddConfiguration(new CardMap());


        }
    }
}
