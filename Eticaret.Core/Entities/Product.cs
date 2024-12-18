

namespace Eticaret.Core.Entities
{
    public class Product : IEntity
    {
        
        public int id { get; set; }
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public string ? Image { get; set; }
        public decimal Price { get; set; }
        public string? ProductCode { get; set; }
        public int Stock {  get; set; }
        public bool Isactive { get; set; }

        public bool IsHome { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
