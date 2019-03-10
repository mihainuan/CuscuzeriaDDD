using Cuscuzeria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cuscuzeria.Infra.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        //Mapping DB fields configurations for Database (EntityFramework 6)
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Defines TableName
            builder.ToTable("Usuarios");

            //Defines PK
            builder.HasKey(u => u.UserId);
            //Defines Column Name
            builder.Property(u => u.Username).HasColumnName("Name");
            //Defines NOT NULL
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Phone).IsRequired();
            //Defines field Size
            builder.Property(u => u.Username).HasMaxLength(150);
            builder.Property(u => u.Password).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.Phone).HasMaxLength(150);
            builder.Property(u => u.UrlImg).HasMaxLength(500);
        }
    }
}
