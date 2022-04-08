using KonusarakOgren.Entity.SqlLiteKonusarakOgren;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Article;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Exam;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.Question;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KonusarakOgren.DataAccess.Context
{
    public class KonusarakOgrenContext : DbContext
    {
        public KonusarakOgrenContext(DbContextOptions<KonusarakOgrenContext> options) : base(options) { }

        #region DBTables
        public DbSet<Article> Articles { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exam { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.ApplyConfiguration(new Entity.SqlLiteKonusarakOgren.Configurations.Answer());
            modelBuilder.ApplyConfiguration(new Entity.SqlLiteKonusarakOgren.Configurations.Article());
            modelBuilder.ApplyConfiguration(new Entity.SqlLiteKonusarakOgren.Configurations.Question());
            modelBuilder.ApplyConfiguration(new Entity.SqlLiteKonusarakOgren.Configurations.User());


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(KonusarakOgren.Entity.DBConnection.SqlLite.ConnectionString, x => x.MigrationsAssembly("KonusarakOgren.DataAccess"));
        }
    }
}
