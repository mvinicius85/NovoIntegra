using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class ADATTRIBUTEMap : EntityTypeConfiguration<ADATTRIBUTE>
    {
        public ADATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CDATTRIBUTE);

            // Properties
            this.Property(t => t.CDATTRIBUTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NMATTRIBUTE)
                .HasMaxLength(255);

            this.Property(t => t.NMCONNDBSERVER)
                .HasMaxLength(255);

            this.Property(t => t.NMCONNDBALIAS)
                .HasMaxLength(255);

            this.Property(t => t.NMCONNDBUSER)
                .HasMaxLength(255);

            this.Property(t => t.NMCONNDBPASSWD)
                .HasMaxLength(255);

            this.Property(t => t.NMFILTERFIELD)
                .HasMaxLength(255);

            this.Property(t => t.NMFILTEREDFIELD)
                .HasMaxLength(255);

            this.Property(t => t.NMREFERENCECOLUMN)
                .HasMaxLength(255);

            this.Property(t => t.NMLABEL)
                .HasMaxLength(255);

            this.Property(t => t.NMUSERUPD)
                .HasMaxLength(255);

            this.Property(t => t.NMCONNDBSQL)
                .HasMaxLength(255);

            this.Property(t => t.NMFILTER)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ADATTRIBUTE");
            this.Property(t => t.CDATTRIBUTE).HasColumnName("CDATTRIBUTE");
            this.Property(t => t.CDISOSYSTEM).HasColumnName("CDISOSYSTEM");
            this.Property(t => t.NMATTRIBUTE).HasColumnName("NMATTRIBUTE");
            this.Property(t => t.DSATTRIBUTE).HasColumnName("DSATTRIBUTE");
            this.Property(t => t.FGDATATYPE).HasColumnName("FGDATATYPE");
            this.Property(t => t.FGATTRIBUTETYPE).HasColumnName("FGATTRIBUTETYPE");
            this.Property(t => t.QTDATALENGTH).HasColumnName("QTDATALENGTH");
            this.Property(t => t.VLINITIAL).HasColumnName("VLINITIAL");
            this.Property(t => t.VLFINAL).HasColumnName("VLFINAL");
            this.Property(t => t.DTFINAL).HasColumnName("DTFINAL");
            this.Property(t => t.DTINITIAL).HasColumnName("DTINITIAL");
            this.Property(t => t.FGATTRIBENABLE).HasColumnName("FGATTRIBENABLE");
            this.Property(t => t.NMCONNDBSERVER).HasColumnName("NMCONNDBSERVER");
            this.Property(t => t.FGCONNDBTYPE).HasColumnName("FGCONNDBTYPE");
            this.Property(t => t.NMCONNDBALIAS).HasColumnName("NMCONNDBALIAS");
            this.Property(t => t.DSCONNDBSQL).HasColumnName("DSCONNDBSQL");
            this.Property(t => t.NMCONNDBUSER).HasColumnName("NMCONNDBUSER");
            this.Property(t => t.NMCONNDBPASSWD).HasColumnName("NMCONNDBPASSWD");
            this.Property(t => t.FGENABLELINK).HasColumnName("FGENABLELINK");
            this.Property(t => t.CDATTRIBUTELINK).HasColumnName("CDATTRIBUTELINK");
            this.Property(t => t.NMFILTERFIELD).HasColumnName("NMFILTERFIELD");
            this.Property(t => t.NMFILTEREDFIELD).HasColumnName("NMFILTEREDFIELD");
            this.Property(t => t.NMREFERENCECOLUMN).HasColumnName("NMREFERENCECOLUMN");
            this.Property(t => t.NMLABEL).HasColumnName("NMLABEL");
            this.Property(t => t.NMUSERUPD).HasColumnName("NMUSERUPD");
            this.Property(t => t.DTINSERT).HasColumnName("DTINSERT");
            this.Property(t => t.DTUPDATE).HasColumnName("DTUPDATE");
            this.Property(t => t.NMCONNDBSQL).HasColumnName("NMCONNDBSQL");
            this.Property(t => t.FGSELECTIONTYPE).HasColumnName("FGSELECTIONTYPE");
            this.Property(t => t.FGDEFAULTOPERATOR).HasColumnName("FGDEFAULTOPERATOR");
            this.Property(t => t.FGMULTIVALUED).HasColumnName("FGMULTIVALUED");
            this.Property(t => t.QTMEMLINES).HasColumnName("QTMEMLINES");
            this.Property(t => t.FGMEMZOOM).HasColumnName("FGMEMZOOM");
            this.Property(t => t.NMFILTER).HasColumnName("NMFILTER");
        }
    }
}
