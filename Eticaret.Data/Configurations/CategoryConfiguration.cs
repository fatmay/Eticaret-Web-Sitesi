using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Image).HasMaxLength(50);
            builder.HasData(
                new Category
                {
                    Name ="Ev Eşyaları",
                    id=1,
                    Isactive = true,
                    IsTopMenu = true,
                    ParentId = 1,
                    OrderNo = 1,

                },
                  new Category
                  {
                      Name = "Markalar",
                      id = 2,
                      Isactive = true,
                      IsTopMenu = true,
                      ParentId = 1,
                      OrderNo = 2,

                  }
                );
        }
    }
}
