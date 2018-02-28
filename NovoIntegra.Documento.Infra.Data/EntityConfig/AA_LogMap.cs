using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class AA_LogMap : EntityTypeConfiguration<AA_Log>
    {
        public AA_LogMap()
        {
            // Primary Key
            this.HasKey(t => t.Cod_EntradaLog);

            // Properties
            this.Property(t => t.Arquivo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Documento)
                .HasMaxLength(50);

            this.Property(t => t.Categoria)
                .HasMaxLength(500);

            this.Property(t => t.Msg)
                .HasMaxLength(200);

            this.Property(t => t.MsgErroSistema)
                .HasMaxLength(2000);

            this.Property(t => t.IdDocumentSE)
                 .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AA_Log");
            this.Property(t => t.Cod_EntradaLog).HasColumnName("Cod_EntradaLog");
            this.Property(t => t.Arquivo).HasColumnName("Arquivo");
            this.Property(t => t.Documento).HasColumnName("Documento");
            this.Property(t => t.Categoria).HasColumnName("Categoria");
            this.Property(t => t.Msg).HasColumnName("Msg");
            this.Property(t => t.MsgErroSistema).HasColumnName("MsgErroSistema");
            this.Property(t => t.DtEvento).HasColumnName("DtEvento");
            this.Property(t => t.IndErro).HasColumnName("IndErro");
            this.Property(t => t.IdDocumentSE).HasColumnName("IdDocumentSE");
        }
    }
}
