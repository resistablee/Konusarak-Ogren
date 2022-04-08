using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Configurations
{
    public class Article : IEntityTypeConfiguration<Entities.Article.Article>
    {
        public void Configure(EntityTypeBuilder<Entities.Article.Article> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            SeedData.articleList.ForEach(x =>
            {
                x.CreatedOn = DateTime.UtcNow;
                x.CreatedBy = 1;
                x.UpdatedBy = 1;
                x.UpdatedOn = DateTime.UtcNow;
            });

            builder.HasData(SeedData.articleList);
        }
    }
}
