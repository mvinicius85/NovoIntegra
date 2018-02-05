using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class AA_VinculoMap : EntityTypeConfiguration<AA_Vinculo>
    {
        public AA_VinculoMap()
        {
            // Primary Key
            this.HasKey(t => t.Cod_Vinculo);

            // Properties
            this.Property(t => t.IDCategory)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.NmCampoImagem)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AA_Vinculo");
            this.Property(t => t.Cod_Vinculo).HasColumnName("Cod_Vinculo");
            this.Property(t => t.IDCategory).HasColumnName("IDCategory");
            this.Property(t => t.CDAttribuite_SE).HasColumnName("CDAttribuite_SE");
            this.Property(t => t.NmCampoImagem).HasColumnName("NmCampoImagem");
            this.Property(t => t.Ind_Titulo).HasColumnName("Ind_Titulo");
            this.Property(t => t.Cod_TipoCampo).HasColumnName("Cod_TipoCampo");
        }
    }
}
