using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class AA_TipoCampoMap : EntityTypeConfiguration<AA_TipoCampo>
    {
        public AA_TipoCampoMap()
        {
            // Primary Key
            this.HasKey(t => t.Cod_TipoCampo);

            // Properties
            this.Property(t => t.Cod_TipoCampo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AA_TipoCampo");
            this.Property(t => t.Cod_TipoCampo).HasColumnName("Cod_TipoCampo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
