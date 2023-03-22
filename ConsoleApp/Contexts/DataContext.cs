using ConsoleApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Contexts
{
    internal class DataContext : DbContext
    {
        #region constructors and overrides
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leon\source\repos\2022\managementsystem\Live_Lecture-3v1\ConsoleApp\Contexts\consolapp_db.mdf;Integrated Security=True;Connect Timeout=30");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<CommentEntity>()
            //    .HasOne(x => x.User)
            //    .WithMany(p => p.Comments)
            //    .HasForeignKey(x => x.User)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
        #endregion

        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<UserTypeEntity> UserTypes { get; set; }
        public DbSet<StatusTypeEntity> StatusTypes { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CaseEntity> Cases { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
    }
}
