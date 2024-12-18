
namespace Eticaret.Core.Entities
{
    public class News : IEntity
    {
        public int id { get; set; }
        public string ? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool Isactive { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
