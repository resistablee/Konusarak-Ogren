using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Configurations
{
    public class User : IEntityTypeConfiguration<Entities.User.User>
    {
        public void Configure(EntityTypeBuilder<Entities.User.User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            SeedData.userList.ForEach(x =>
            {
                x.CreatedOn = DateTime.UtcNow;
                x.CreatedBy = 1;
                x.UpdatedBy = 1;
                x.UpdatedOn = DateTime.UtcNow;
            });

            builder.HasData(SeedData.userList);
        }
    }
}
