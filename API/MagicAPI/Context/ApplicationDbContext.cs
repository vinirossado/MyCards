using MagicAPI.Extensions;
using MagicAPI.Mapping;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MagicAPI.Context
{
    public partial class ApplicationDbContext : DbContext
    {
        #region Properties
        protected readonly IConfiguration _configuration;
        #endregion Properties

        #region Constructors
        public ApplicationDbContext(IConfiguration configuration, DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            _configuration = configuration;
        }
        #endregion Constructors

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = deck.db");
        }
        public virtual DbSet<CardModel> Card { get; set; } = null;
        public virtual DbSet<DeckModel> Deck { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CardModel>().ToTable("Card").HasKey(x => x.Id);

            //modelBuilder.Entity<DeckModel>().ToTable("Deck").HasOne(x => x.Card).WithMany().HasForeignKey(x => x.CardId);

            modelBuilder.AddConfiguration(new CardMap());
            modelBuilder.AddConfiguration(new DeckMap());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        #endregion Methods

    }
}
