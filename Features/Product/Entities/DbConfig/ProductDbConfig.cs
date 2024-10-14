using Microsoft.EntityFrameworkCore;

namespace ORM_TurmaFormacao.Features.Product.Entities.DbConfig
{
    public class ProductDbConfig : IEntityTypeConfiguration<Products>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("products", schema: "dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .HasColumnName("name")
                .IsRequired();

            //TODO: Estudar e implementar como realizar o mapeamento de entidades com a categoryId
        }
    }
}
