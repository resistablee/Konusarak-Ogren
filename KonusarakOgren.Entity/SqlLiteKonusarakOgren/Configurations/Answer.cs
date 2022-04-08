using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Configurations
{
    public class Answer : IEntityTypeConfiguration<Entities.Question.Answer>
    {
        public void Configure(EntityTypeBuilder<Entities.Question.Answer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Text).IsRequired();

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
