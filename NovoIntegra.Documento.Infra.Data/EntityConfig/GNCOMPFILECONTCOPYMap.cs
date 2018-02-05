using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class GNCOMPFILECONTCOPYMap : EntityTypeConfiguration<GNCOMPFILECONTCOPY>
    {
        public GNCOMPFILECONTCOPYMap()
        {
            // Primary Key
            this.HasKey(t => t.CDCOMPLEXFILECONT);

            // Properties
            this.Property(t => t.CDCOMPLEXFILECONT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IDCOMPLEXFILECONT)
                .HasMaxLength(50);

            this.Property(t => t.NMCOMPLEXFILECONT)
                .HasMaxLength(255);

            this.Property(t => t.IDCONFIGURATION)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GNCOMPFILECONTCOPY");
            this.Property(t => t.CDCOMPLEXFILECONT).HasColumnName("CDCOMPLEXFILECONT");
            this.Property(t => t.FGFILETYPE).HasColumnName("FGFILETYPE");
            this.Property(t => t.IDCOMPLEXFILECONT).HasColumnName("IDCOMPLEXFILECONT");
            this.Property(t => t.NMCOMPLEXFILECONT).HasColumnName("NMCOMPLEXFILECONT");
            this.Property(t => t.FGCONECTOR).HasColumnName("FGCONECTOR");
            this.Property(t => t.CDISOSYSTEM).HasColumnName("CDISOSYSTEM");
            this.Property(t => t.FGDRAWTOISODOC).HasColumnName("FGDRAWTOISODOC");
            this.Property(t => t.CDCATEGORY).HasColumnName("CDCATEGORY");
            this.Property(t => t.IDCONFIGURATION).HasColumnName("IDCONFIGURATION");
        }
    }
}
