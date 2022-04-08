using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Configurations
{
    public class Question : IEntityTypeConfiguration<Entities.Question.Question>
    {
        public void Configure(EntityTypeBuilder<Entities.Question.Question> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
