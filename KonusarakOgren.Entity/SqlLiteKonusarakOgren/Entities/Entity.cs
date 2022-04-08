
namespace KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
