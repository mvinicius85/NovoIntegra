using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class AA_ParametrosMap : EntityTypeConfiguration<AA_Parametros>
    {
        public AA_ParametrosMap()
        {
            // Primary Key
            this.HasKey(t => t.Cod_Parametro);

            // Properties
            this.Property(t => t.Cod_Parametro)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NomeParametro)
    .IsRequired()
    .HasMaxLength(50);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Valor)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AA_Parametros");
            this.Property(t => t.Cod_Parametro).HasColumnName("Cod_Parametro");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Valor).HasColumnName("Valor");
        }
    }
}
