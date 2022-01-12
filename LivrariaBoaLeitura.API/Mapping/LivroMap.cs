using LivrariaBoaLeitura.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaBoaLeitura.API.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(p => p.ID)
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("numeric(38,2)");

            builder.Property(p => p.Quantidade)
                .HasColumnType("numeric(30)");

            builder.Property(p => p.Categoria)
                .HasColumnType("varchar(100)");
        }
    }
}
