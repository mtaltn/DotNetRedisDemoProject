using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedisDemo.Api.Models;

namespace RedisDemo.Api.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,                
                Name = "Dolma Kalem",
                Price = 100
            },
            new Product
            {
                Id = 2,
                Name = "Tükenmez Kalem",
                Price = 500
            },
            new Product
            {
                Id = 3,
                Name = "Tükenmez Kalem",
                Price = 500                
            },
            new Product
            {
                Id = 4,
                Name = "Nutuk",
                Price = 1881
            },
            new Product
            {
                Id = 5,
                Name = "Şu Çılgın Türkler",
                Price = 1071
            }
            );
        }
    }
}
