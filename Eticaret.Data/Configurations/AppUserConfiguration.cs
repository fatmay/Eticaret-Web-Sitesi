﻿using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);

            builder.Property(x => x.Username).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.HasData(
                new AppUser
                {
                    id = 1,
                    Username ="Admin",
                    Email="admin@eticaret.io",
                    IsActive=true,
                    IsAdmin=true,
                    Name ="Test",
                    Password ="123456*",
                    Surname= "User"


                }
                );
        }
    }
}
