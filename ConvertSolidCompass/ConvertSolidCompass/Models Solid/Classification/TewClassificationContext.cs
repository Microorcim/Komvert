using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConvertSolidCompass;

public partial class TewClassificationContext : DbContext
{
    public TewClassificationContext()
    {
    }

    public TewClassificationContext(DbContextOptions<TewClassificationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TewClassification> TewClassifications { get; set; }

    public virtual DbSet<TewNode> TewNodes { get; set; }

    public virtual DbSet<TewNodenode> TewNodenodes { get; set; }

    public virtual DbSet<TewObjectid> TewObjectids { get; set; }

    public virtual DbSet<TewRevision> TewRevisions { get; set; }

    public virtual DbSet<TewTranslatedtext> TewTranslatedtexts { get; set; }

    public virtual DbSet<TewUserdatum> TewUserdata { get; set; }

    public virtual DbSet<TewVersion> TewVersions { get; set; }

    public virtual DbSet<VewDataNode> VewDataNodes { get; set; }

    public virtual DbSet<VewVersionTewClassification0> VewVersionTewClassification0s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\TEW_SQLEXPRESS;Database=tew_classification;Integrated Security=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TewClassification>(entity =>
        {
            entity.HasKey(e => e.ClaId)
                .HasName("idxtew_classification_1")
                .IsClustered(false);

            entity.ToTable("tew_classification", "tew");

            entity.HasIndex(e => e.ClaName, "idxtew_classification_2").IsUnique();

            entity.Property(e => e.ClaId)
                .HasDefaultValue(-1)
                .HasColumnName("cla_id");
            entity.Property(e => e.ClaCreationdate)
                .HasColumnType("datetime")
                .HasColumnName("cla_creationdate");
            entity.Property(e => e.ClaDatatype)
                .HasDefaultValue(0)
                .HasColumnName("cla_datatype");
            entity.Property(e => e.ClaModificationdate)
                .HasColumnType("datetime")
                .HasColumnName("cla_modificationdate");
            entity.Property(e => e.ClaModifiedby)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cla_modifiedby");
            entity.Property(e => e.ClaName)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cla_name");
            entity.Property(e => e.ClaSwdefaultpartname)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cla_swdefaultpartname");
            entity.Property(e => e.ClaSymbolwiringpartname)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cla_symbolwiringpartname");
            entity.Property(e => e.ClaTwoddefaultpartname)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cla_twoddefaultpartname");
            entity.Property(e => e.ClaVersion)
                .HasDefaultValue(0)
                .HasColumnName("cla_version");
        });

        modelBuilder.Entity<TewNode>(entity =>
        {
            entity.HasKey(e => e.NodId)
                .HasName("idxtew_node_1")
                .IsClustered(false);

            entity.ToTable("tew_node", "tew");

            entity.HasIndex(e => new { e.NodClaId, e.NodClauid }, "idxtew_node_2").IsUnique();

            entity.Property(e => e.NodId)
                .HasDefaultValue(-1)
                .HasColumnName("nod_id");
            entity.Property(e => e.NodClaId)
                .HasDefaultValue(-1)
                .HasColumnName("nod_cla_id");
            entity.Property(e => e.NodClauid)
                .HasDefaultValue(-1)
                .HasColumnName("nod_clauid");
            entity.Property(e => e.NodClauiddefault)
                .HasDefaultValue(0)
                .HasColumnName("nod_clauiddefault");
            entity.Property(e => e.NodComponenttype)
                .HasDefaultValue(0)
                .HasColumnName("nod_componenttype");
            entity.Property(e => e.NodCreationdate)
                .HasColumnType("datetime")
                .HasColumnName("nod_creationdate");
            entity.Property(e => e.NodDatatype)
                .HasDefaultValue(0)
                .HasColumnName("nod_datatype");
            entity.Property(e => e.NodDepth)
                .HasDefaultValue(0)
                .HasColumnName("nod_depth");
            entity.Property(e => e.NodFamCode)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("nod_fam_code");
            entity.Property(e => e.NodModificationdate)
                .HasColumnType("datetime")
                .HasColumnName("nod_modificationdate");
            entity.Property(e => e.NodModifiedby)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("nod_modifiedby");
            entity.Property(e => e.NodNodId)
                .HasDefaultValue(-1)
                .HasColumnName("nod_nod_id");
            entity.Property(e => e.NodPartname)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("nod_partname");
            entity.Property(e => e.NodPartnametwod)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("nod_partnametwod");
            entity.Property(e => e.NodSymbolwiringpartname)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("nod_symbolwiringpartname");
            entity.Property(e => e.NodUdfilename)
                .HasMaxLength(1024)
                .HasDefaultValue("")
                .HasColumnName("nod_udfilename");
        });

        modelBuilder.Entity<TewNodenode>(entity =>
        {
            entity.HasKey(e => new { e.NndClaId, e.NndParentid, e.NndChildid })
                .HasName("idxtew_nodenode_1")
                .IsClustered(false);

            entity.ToTable("tew_nodenode", "tew");

            entity.Property(e => e.NndClaId)
                .HasDefaultValue(-1)
                .HasColumnName("nnd_cla_id");
            entity.Property(e => e.NndParentid)
                .HasDefaultValue(-1)
                .HasColumnName("nnd_parentid");
            entity.Property(e => e.NndChildid)
                .HasDefaultValue(-1)
                .HasColumnName("nnd_childid");
        });

        modelBuilder.Entity<TewObjectid>(entity =>
        {
            entity.HasKey(e => e.ObjObjectid)
                .HasName("idxtew_objectid_1")
                .IsClustered(false);

            entity.ToTable("tew_objectid", "tew", tb => tb.HasComment("Highest Object ID"));

            entity.Property(e => e.ObjObjectid)
                .HasDefaultValue(-1)
                .HasColumnName("obj_objectid");
        });

        modelBuilder.Entity<TewRevision>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tew_revision", "tew", tb => tb.HasComment("Revisions"));

            entity.Property(e => e.RevCreationdate)
                .HasColumnType("datetime")
                .HasColumnName("rev_creationdate");
            entity.Property(e => e.RevCreationname)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("rev_creationname");
            entity.Property(e => e.RevNo)
                .HasDefaultValue(-1)
                .HasColumnName("rev_no");
            entity.Property(e => e.RevObjId)
                .HasDefaultValue(-1)
                .HasColumnName("rev_obj_id");
            entity.Property(e => e.RevRevno)
                .HasDefaultValue(-1)
                .HasColumnName("rev_revno");
            entity.Property(e => e.RevTag)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("rev_tag");
            entity.Property(e => e.RevValidationdate)
                .HasColumnType("datetime")
                .HasColumnName("rev_validationdate");
            entity.Property(e => e.RevValidationname)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("rev_validationname");
            entity.Property(e => e.RevVerificationdate)
                .HasColumnType("datetime")
                .HasColumnName("rev_verificationdate");
            entity.Property(e => e.RevVerificationname)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("rev_verificationname");
        });

        modelBuilder.Entity<TewTranslatedtext>(entity =>
        {
            entity.HasKey(e => new { e.TraObjectid, e.TraObjectno, e.TraLanStrid })
                .HasName("idxtew_translatedtext_1")
                .IsClustered(false);

            entity.ToTable("tew_translatedtext", "tew", tb => tb.HasComment("Translated texts"));

            entity.Property(e => e.TraObjectid)
                .HasDefaultValue(-1)
                .HasColumnName("tra_objectid");
            entity.Property(e => e.TraObjectno)
                .HasDefaultValue(-1)
                .HasColumnName("tra_objectno");
            entity.Property(e => e.TraLanStrid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tra_lan_strid");
            entity.Property(e => e.Tra0)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_0");
            entity.Property(e => e.Tra1)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_1");
            entity.Property(e => e.Tra10)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_10");
            entity.Property(e => e.Tra11)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_11");
            entity.Property(e => e.Tra12)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_12");
            entity.Property(e => e.Tra13)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_13");
            entity.Property(e => e.Tra14)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_14");
            entity.Property(e => e.Tra2)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_2");
            entity.Property(e => e.Tra3)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_3");
            entity.Property(e => e.Tra4)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_4");
            entity.Property(e => e.Tra5)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_5");
            entity.Property(e => e.Tra6)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_6");
            entity.Property(e => e.Tra7)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_7");
            entity.Property(e => e.Tra8)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_8");
            entity.Property(e => e.Tra9)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("tra_9");
            entity.Property(e => e.TraStrobjectid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tra_strobjectid");
        });

        modelBuilder.Entity<TewUserdatum>(entity =>
        {
            entity.HasKey(e => new { e.UseObjectno, e.UseObjectid })
                .HasName("idxtew_userdata_1")
                .IsClustered(false);

            entity.ToTable("tew_userdata", "tew", tb => tb.HasComment("User data"));

            entity.Property(e => e.UseObjectno)
                .HasDefaultValue(-1)
                .HasColumnName("use_objectno");
            entity.Property(e => e.UseObjectid)
                .HasDefaultValue(-1)
                .HasColumnName("use_objectid");
            entity.Property(e => e.UseData0)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data0");
            entity.Property(e => e.UseData1)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data1");
            entity.Property(e => e.UseData10)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data10");
            entity.Property(e => e.UseData11)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data11");
            entity.Property(e => e.UseData12)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data12");
            entity.Property(e => e.UseData13)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data13");
            entity.Property(e => e.UseData14)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data14");
            entity.Property(e => e.UseData15)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data15");
            entity.Property(e => e.UseData16)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data16");
            entity.Property(e => e.UseData17)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data17");
            entity.Property(e => e.UseData18)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data18");
            entity.Property(e => e.UseData19)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data19");
            entity.Property(e => e.UseData2)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data2");
            entity.Property(e => e.UseData3)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data3");
            entity.Property(e => e.UseData4)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data4");
            entity.Property(e => e.UseData5)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data5");
            entity.Property(e => e.UseData6)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data6");
            entity.Property(e => e.UseData7)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data7");
            entity.Property(e => e.UseData8)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data8");
            entity.Property(e => e.UseData9)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("use_data9");
        });

        modelBuilder.Entity<TewVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tew_version");

            entity.Property(e => e.VerClassification).HasColumnName("ver_classification");
            entity.Property(e => e.VerId)
                .HasDefaultValue(1)
                .HasColumnName("ver_id");
        });

        modelBuilder.Entity<VewDataNode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vew_data_node", "tew");

            entity.Property(e => e.NodClaId).HasColumnName("nod_cla_id");
            entity.Property(e => e.NodClauid).HasColumnName("nod_clauid");
            entity.Property(e => e.NodClauiddefault).HasColumnName("nod_clauiddefault");
            entity.Property(e => e.NodComponenttype).HasColumnName("nod_componenttype");
            entity.Property(e => e.NodCreationdate)
                .HasColumnType("datetime")
                .HasColumnName("nod_creationdate");
            entity.Property(e => e.NodDatatype).HasColumnName("nod_datatype");
            entity.Property(e => e.NodDepth).HasColumnName("nod_depth");
            entity.Property(e => e.NodFamCode)
                .HasMaxLength(70)
                .HasColumnName("nod_fam_code");
            entity.Property(e => e.NodId).HasColumnName("nod_id");
            entity.Property(e => e.NodModificationdate)
                .HasColumnType("datetime")
                .HasColumnName("nod_modificationdate");
            entity.Property(e => e.NodModifiedby)
                .HasMaxLength(255)
                .HasColumnName("nod_modifiedby");
            entity.Property(e => e.NodNodId).HasColumnName("nod_nod_id");
            entity.Property(e => e.NodPartname)
                .HasMaxLength(255)
                .HasColumnName("nod_partname");
            entity.Property(e => e.NodPartnametwod)
                .HasMaxLength(255)
                .HasColumnName("nod_partnametwod");
            entity.Property(e => e.NodSymbolwiringpartname)
                .HasMaxLength(255)
                .HasColumnName("nod_symbolwiringpartname");
            entity.Property(e => e.NodTra0)
                .HasMaxLength(255)
                .HasColumnName("nod_tra_0");
            entity.Property(e => e.NodTraLanStrid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("nod_tra_lan_strid");
            entity.Property(e => e.NodUdfilename)
                .HasMaxLength(1024)
                .HasColumnName("nod_udfilename");
        });

        modelBuilder.Entity<VewVersionTewClassification0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vew_version_tew_classification_0", "tew");

            entity.Property(e => e.VerId).HasColumnName("ver_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
