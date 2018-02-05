using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class ADINTERFACEMap : EntityTypeConfiguration<ADINTERFACE>
    {
        public ADINTERFACEMap()
        {
            // Primary Key
            this.HasKey(t => t.CDINTERFACE);

            // Properties
            this.Property(t => t.CDINTERFACE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NMFIELD01)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD02)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD03)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD04)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD05)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD06)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD07)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD08)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD09)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD10)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD11)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD12)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD13)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD14)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD15)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD16)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD17)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD18)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD19)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD20)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD21)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD22)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD23)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD24)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD25)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD26)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD27)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD28)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD29)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD30)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD31)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD32)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD33)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD34)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD35)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD36)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD37)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD38)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD39)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD40)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD41)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD42)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD43)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD44)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD45)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD46)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD47)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD48)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD49)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD50)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD51)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD52)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD53)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD54)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD55)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD56)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD57)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD58)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD59)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD60)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD61)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD62)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD63)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD64)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD65)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD66)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD67)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD68)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD69)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD70)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD71)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD72)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD73)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD74)
                .HasMaxLength(255);

            this.Property(t => t.NMFIELD75)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ADINTERFACE");
            this.Property(t => t.CDINTERFACE).HasColumnName("CDINTERFACE");
            this.Property(t => t.CDISOSYSTEM).HasColumnName("CDISOSYSTEM");
            this.Property(t => t.CDSCHEDULE).HasColumnName("CDSCHEDULE");
            this.Property(t => t.DTEXECUTION).HasColumnName("DTEXECUTION");
            this.Property(t => t.FGIMPORT).HasColumnName("FGIMPORT");
            this.Property(t => t.FGBLOBOPTION).HasColumnName("FGBLOBOPTION");
            this.Property(t => t.FGOPTION).HasColumnName("FGOPTION");
            this.Property(t => t.QTHRFINISH).HasColumnName("QTHRFINISH");
            this.Property(t => t.QTHRINIT).HasColumnName("QTHRINIT");
            this.Property(t => t.DSERROR).HasColumnName("DSERROR");
            this.Property(t => t.NRSEQUENCE).HasColumnName("NRSEQUENCE");
            this.Property(t => t.NMFIELD01).HasColumnName("NMFIELD01");
            this.Property(t => t.NMFIELD02).HasColumnName("NMFIELD02");
            this.Property(t => t.NMFIELD03).HasColumnName("NMFIELD03");
            this.Property(t => t.NMFIELD04).HasColumnName("NMFIELD04");
            this.Property(t => t.NMFIELD05).HasColumnName("NMFIELD05");
            this.Property(t => t.NMFIELD06).HasColumnName("NMFIELD06");
            this.Property(t => t.NMFIELD07).HasColumnName("NMFIELD07");
            this.Property(t => t.NMFIELD08).HasColumnName("NMFIELD08");
            this.Property(t => t.NMFIELD09).HasColumnName("NMFIELD09");
            this.Property(t => t.NMFIELD10).HasColumnName("NMFIELD10");
            this.Property(t => t.NMFIELD11).HasColumnName("NMFIELD11");
            this.Property(t => t.NMFIELD12).HasColumnName("NMFIELD12");
            this.Property(t => t.NMFIELD13).HasColumnName("NMFIELD13");
            this.Property(t => t.NMFIELD14).HasColumnName("NMFIELD14");
            this.Property(t => t.NMFIELD15).HasColumnName("NMFIELD15");
            this.Property(t => t.NMFIELD16).HasColumnName("NMFIELD16");
            this.Property(t => t.NMFIELD17).HasColumnName("NMFIELD17");
            this.Property(t => t.NMFIELD18).HasColumnName("NMFIELD18");
            this.Property(t => t.NMFIELD19).HasColumnName("NMFIELD19");
            this.Property(t => t.NMFIELD20).HasColumnName("NMFIELD20");
            this.Property(t => t.NMFIELD21).HasColumnName("NMFIELD21");
            this.Property(t => t.NMFIELD22).HasColumnName("NMFIELD22");
            this.Property(t => t.NMFIELD23).HasColumnName("NMFIELD23");
            this.Property(t => t.NMFIELD24).HasColumnName("NMFIELD24");
            this.Property(t => t.NMFIELD25).HasColumnName("NMFIELD25");
            this.Property(t => t.NMFIELD26).HasColumnName("NMFIELD26");
            this.Property(t => t.NMFIELD27).HasColumnName("NMFIELD27");
            this.Property(t => t.NMFIELD28).HasColumnName("NMFIELD28");
            this.Property(t => t.NMFIELD29).HasColumnName("NMFIELD29");
            this.Property(t => t.NMFIELD30).HasColumnName("NMFIELD30");
            this.Property(t => t.NMFIELD31).HasColumnName("NMFIELD31");
            this.Property(t => t.NMFIELD32).HasColumnName("NMFIELD32");
            this.Property(t => t.NMFIELD33).HasColumnName("NMFIELD33");
            this.Property(t => t.NMFIELD34).HasColumnName("NMFIELD34");
            this.Property(t => t.NMFIELD35).HasColumnName("NMFIELD35");
            this.Property(t => t.NMFIELD36).HasColumnName("NMFIELD36");
            this.Property(t => t.NMFIELD37).HasColumnName("NMFIELD37");
            this.Property(t => t.NMFIELD38).HasColumnName("NMFIELD38");
            this.Property(t => t.NMFIELD39).HasColumnName("NMFIELD39");
            this.Property(t => t.NMFIELD40).HasColumnName("NMFIELD40");
            this.Property(t => t.NMFIELD41).HasColumnName("NMFIELD41");
            this.Property(t => t.NMFIELD42).HasColumnName("NMFIELD42");
            this.Property(t => t.NMFIELD43).HasColumnName("NMFIELD43");
            this.Property(t => t.NMFIELD44).HasColumnName("NMFIELD44");
            this.Property(t => t.NMFIELD45).HasColumnName("NMFIELD45");
            this.Property(t => t.NMFIELD46).HasColumnName("NMFIELD46");
            this.Property(t => t.NMFIELD47).HasColumnName("NMFIELD47");
            this.Property(t => t.NMFIELD48).HasColumnName("NMFIELD48");
            this.Property(t => t.NMFIELD49).HasColumnName("NMFIELD49");
            this.Property(t => t.NMFIELD50).HasColumnName("NMFIELD50");
            this.Property(t => t.NMFIELD51).HasColumnName("NMFIELD51");
            this.Property(t => t.NMFIELD52).HasColumnName("NMFIELD52");
            this.Property(t => t.NMFIELD53).HasColumnName("NMFIELD53");
            this.Property(t => t.NMFIELD54).HasColumnName("NMFIELD54");
            this.Property(t => t.NMFIELD55).HasColumnName("NMFIELD55");
            this.Property(t => t.NMFIELD56).HasColumnName("NMFIELD56");
            this.Property(t => t.NMFIELD57).HasColumnName("NMFIELD57");
            this.Property(t => t.NMFIELD58).HasColumnName("NMFIELD58");
            this.Property(t => t.NMFIELD59).HasColumnName("NMFIELD59");
            this.Property(t => t.NMFIELD60).HasColumnName("NMFIELD60");
            this.Property(t => t.NMFIELD61).HasColumnName("NMFIELD61");
            this.Property(t => t.NMFIELD62).HasColumnName("NMFIELD62");
            this.Property(t => t.NMFIELD63).HasColumnName("NMFIELD63");
            this.Property(t => t.NMFIELD64).HasColumnName("NMFIELD64");
            this.Property(t => t.NMFIELD65).HasColumnName("NMFIELD65");
            this.Property(t => t.NMFIELD66).HasColumnName("NMFIELD66");
            this.Property(t => t.NMFIELD67).HasColumnName("NMFIELD67");
            this.Property(t => t.NMFIELD68).HasColumnName("NMFIELD68");
            this.Property(t => t.NMFIELD69).HasColumnName("NMFIELD69");
            this.Property(t => t.NMFIELD70).HasColumnName("NMFIELD70");
            this.Property(t => t.NMFIELD71).HasColumnName("NMFIELD71");
            this.Property(t => t.NMFIELD72).HasColumnName("NMFIELD72");
            this.Property(t => t.NMFIELD73).HasColumnName("NMFIELD73");
            this.Property(t => t.NMFIELD74).HasColumnName("NMFIELD74");
            this.Property(t => t.NMFIELD75).HasColumnName("NMFIELD75");
            this.Property(t => t.DSFIELD01).HasColumnName("DSFIELD01");
            this.Property(t => t.DSFIELD02).HasColumnName("DSFIELD02");
            this.Property(t => t.DSFIELD03).HasColumnName("DSFIELD03");
            this.Property(t => t.DSFIELD04).HasColumnName("DSFIELD04");
            this.Property(t => t.DSFIELD05).HasColumnName("DSFIELD05");
            this.Property(t => t.FLFIELD01).HasColumnName("FLFIELD01");
        }
    }
}
