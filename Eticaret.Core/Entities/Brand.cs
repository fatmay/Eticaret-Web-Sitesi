

namespace Eticaret.Core.Entities
{
    public class Brand : IEntity
    {
        public int ıd { get; set; }
        public string Name { get; set; }
        public  string Description {  get; set; }
        public string Logo {  get; set; }
        public bool Isactive { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; }
        public IList<Product>? Products { get; set; }


    }
}
