using Cuscuzeria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cuscuzeria.Infra.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //Defines PK
            builder.HasKey(o => o.OrderId);
            //Defines NOT NULL
            builder.Property(o => o.UserId).IsRequired();
            builder.Property(o => o.Delivered).IsRequired();
        }
    }
}
