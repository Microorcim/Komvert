using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConvertSolidCompass;

public partial class Kampas3Context : DbContext
{
    public Kampas3Context()
    {
    }

    public Kampas3Context(DbContextOptions<Kampas3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Apparatus> Apparatuses { get; set; }

    public virtual DbSet<Bugo> Bugos { get; set; }

    public virtual DbSet<Cable> Cables { get; set; }

    public virtual DbSet<Cablecontent> Cablecontents { get; set; }

    public virtual DbSet<Clamp> Clamps { get; set; }

    public virtual DbSet<ClampsReference> ClampsReferences { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<CommentsPlk> CommentsPlks { get; set; }

    public virtual DbSet<Comprise> Comprises { get; set; }

    public virtual DbSet<Fastener> Fasteners { get; set; }

    public virtual DbSet<FastenerImage> FastenerImages { get; set; }

    public virtual DbSet<FunctionalityPlk> FunctionalityPlks { get; set; }

    public virtual DbSet<GoElementsPlk> GoElementsPlks { get; set; }

    public virtual DbSet<Hierarchy> Hierarchies { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<KomplPlk> KomplPlks { get; set; }

    public virtual DbSet<KposPlk> KposPlks { get; set; }

    public virtual DbSet<KpostoGoPlk> KpostoGoPlks { get; set; }

    public virtual DbSet<Link> Links { get; set; }

    public virtual DbSet<LpapparatusPlk> LpapparatusPlks { get; set; }

    public virtual DbSet<Lug> Lugs { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Metal> Metals { get; set; }

    public virtual DbSet<Metalscolumn> Metalscolumns { get; set; }

    public virtual DbSet<Metalvalue> Metalvalues { get; set; }

    public virtual DbSet<ModelReference> ModelReferences { get; set; }

    public virtual DbSet<ModelsPlk> ModelsPlks { get; set; }

    public virtual DbSet<OtherProduce> OtherProduces { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<PartsReference> PartsReferences { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<ReportCatalog> ReportCatalogs { get; set; }

    public virtual DbSet<ReportForm> ReportForms { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Sheathe> Sheathes { get; set; }

    public virtual DbSet<Sprcharcode> Sprcharcodes { get; set; }

    public virtual DbSet<Sprclampdiameter> Sprclampdiameters { get; set; }

    public virtual DbSet<Sprlugdiameter> Sprlugdiameters { get; set; }

    public virtual DbSet<Sprrecdocform> Sprrecdocforms { get; set; }

    public virtual DbSet<Sprrecdocname> Sprrecdocnames { get; set; }

    public virtual DbSet<Sprrecgost> Sprrecgosts { get; set; }

    public virtual DbSet<Sprrecgroup> Sprrecgroups { get; set; }

    public virtual DbSet<Sprrecname> Sprrecnames { get; set; }

    public virtual DbSet<Sprsheatheintdiameter> Sprsheatheintdiameters { get; set; }

    public virtual DbSet<Sprtechvalue> Sprtechvalues { get; set; }

    public virtual DbSet<Sprwiresection> Sprwiresections { get; set; }

    public virtual DbSet<SpvvstringsPlk> SpvvstringsPlks { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Techcolum> Techcolums { get; set; }

    public virtual DbSet<TechcolumName> TechcolumNames { get; set; }

    public virtual DbSet<Techvalue> Techvalues { get; set; }

    public virtual DbSet<Texthelp> Texthelps { get; set; }

    public virtual DbSet<TexthelpTb> TexthelpTbs { get; set; }

    public virtual DbSet<Ugo> Ugos { get; set; }

    public virtual DbSet<Wire> Wires { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments)}\\ASCON\\KOMPAS-Electric_v22\\bdk.mdb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apparatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("APPARATUS$Index_FB51F1C7_9554_4E1B");

            entity.ToTable("APPARATUS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");

            entity.HasOne(d => d.Record).WithMany(p => p.Apparatuses)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("APPARATUS$FK_APPARATUS");
        });

        modelBuilder.Entity<Bugo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("BUGO$Index_41D70F9C_C6A2_4910");

            entity.ToTable("BUGO");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Number).HasColumnName("NUMBER_");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
        });

        modelBuilder.Entity<Cable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CABLES$Index_8C78F2FA_7BFC_47AB");

            entity.ToTable("CABLES");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Diameter).HasColumnName("DIAMETER");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Record).WithMany(p => p.Cables)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("CABLES$FK_CABLES");
        });

        modelBuilder.Entity<Cablecontent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CABLECONTENT$Index_AD9FDEB4_B829_4332");

            entity.ToTable("CABLECONTENT");

            entity.HasIndex(e => e.ParentId, "CABLECONTENT$IX_PARENT_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.CableId)
                .HasMaxLength(32)
                .HasColumnName("CABLE_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("NAME");
            entity.Property(e => e.ParentId)
                .HasMaxLength(32)
                .HasColumnName("PARENT_ID");
            entity.Property(e => e.Screenortwist).HasColumnName("SCREENORTWIST");

            entity.HasOne(d => d.Cable).WithMany(p => p.Cablecontents)
                .HasForeignKey(d => d.CableId)
                .HasConstraintName("CABLECONTENT$FK_CABLECONTENT");
        });

        modelBuilder.Entity<Clamp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CLAMPS$Index_AE612A48_2368_435E");

            entity.ToTable("CLAMPS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Diameter).HasColumnName("DIAMETER");
            entity.Property(e => e.Lug).HasColumnName("LUG");
            entity.Property(e => e.MaxConnectionNumber).HasColumnName("MAX_CONNECTION_NUMBER");
            entity.Property(e => e.MaxSectionValue).HasColumnName("MAX_SECTION_VALUE");
            entity.Property(e => e.Number)
                .HasMaxLength(32)
                .HasColumnName("NUMBER_");
            entity.Property(e => e.PartId)
                .HasMaxLength(32)
                .HasColumnName("PART_ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.WireNumber)
                .HasMaxLength(40)
                .HasColumnName("WIRE_NUMBER");
            entity.Property(e => e.Wiring).HasColumnName("WIRING");

            entity.HasOne(d => d.Part).WithMany(p => p.Clamps)
                .HasForeignKey(d => d.PartId)
                .HasConstraintName("CLAMPS$FK_CLAMPS");
        });

        modelBuilder.Entity<ClampsReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CLAMPS_REFERENCES$Index_4597BAA5_0941_4CF5");

            entity.ToTable("CLAMPS_REFERENCES");

            entity.HasIndex(e => e.ClampId, "CLAMPS_REFERENCES$IX_CLAMP_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.ClampId)
                .HasMaxLength(32)
                .HasColumnName("CLAMP_ID");
            entity.Property(e => e.ImageId)
                .HasMaxLength(32)
                .HasColumnName("IMAGE_ID");
            entity.Property(e => e.UgoclampId).HasColumnName("UGOCLAMP_ID");

            entity.HasOne(d => d.Image).WithMany(p => p.ClampsReferences)
                .HasForeignKey(d => d.ImageId)
                .HasConstraintName("CLAMPS_REFERENCES$FK_CLAMPS_REFERENCES");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("COLORS$Index_FE9A69D2_353F_481C");

            entity.ToTable("COLORS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<CommentsPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("COMMENTS_PLK$Index_B30B3DA9_BF6C_4190");

            entity.ToTable("COMMENTS_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .HasColumnName("COMMENTS");
        });

        modelBuilder.Entity<Comprise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("COMPRISES$Index_EE09E97F_8DBD_4264");

            entity.ToTable("COMPRISES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Gost)
                .HasMaxLength(255)
                .HasColumnName("GOST_");
            entity.Property(e => e.Group)
                .HasMaxLength(255)
                .HasColumnName("GROUP_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME_");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("NOTES");
            entity.Property(e => e.Pos)
                .HasMaxLength(255)
                .HasColumnName("POS");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");

            entity.HasOne(d => d.Record).WithMany(p => p.Comprises)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("COMPRISES$FK_COMPRISES");
        });

        modelBuilder.Entity<Fastener>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FASTENERS$Index_AF53B826_5C54_4E56");

            entity.ToTable("FASTENERS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.DiameterMax).HasColumnName("DIAMETER_MAX");
            entity.Property(e => e.DiameterMin).HasColumnName("DIAMETER_MIN");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Record).WithMany(p => p.Fasteners)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("FASTENERS$FK_FASTENERS");
        });

        modelBuilder.Entity<FastenerImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FASTENER_IMAGES$Index_D4A02D1F_D3B7_4281");

            entity.ToTable("FASTENER_IMAGES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FastenerId)
                .HasMaxLength(32)
                .HasColumnName("FASTENER_ID");
            entity.Property(e => e.UgoReference)
                .HasMaxLength(32)
                .HasColumnName("UGO_REFERENCE");

            entity.HasOne(d => d.Fastener).WithMany(p => p.FastenerImages)
                .HasForeignKey(d => d.FastenerId)
                .HasConstraintName("FASTENER_IMAGES$FK_FASTENER_IMAGES");

            entity.HasOne(d => d.UgoReferenceNavigation).WithMany(p => p.FastenerImages)
                .HasForeignKey(d => d.UgoReference)
                .HasConstraintName("FASTENER_IMAGES$FK_FASTENER_IMAGES1");
        });

        modelBuilder.Entity<FunctionalityPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FUNCTIONALITY_PLK$Index_7CB9EC95_3D40_4EA4");

            entity.ToTable("FUNCTIONALITY_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<GoElementsPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GoElements_PLK$Index_07C8226B_EA29_43B0");

            entity.ToTable("GoElements_PLK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<Hierarchy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("HIERARCHY$Index_1690ECA8_5FE5_4B58");

            entity.ToTable("HIERARCHY");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ColorInd).HasColumnName("COLOR_IND");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Number).HasColumnName("NUMBER_");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("IMAGES$Index_6FA79AF1_5869_41CA");

            entity.ToTable("IMAGES");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.ApparatusId)
                .HasMaxLength(32)
                .HasColumnName("APPARATUS_ID");
            entity.Property(e => e.Type).HasColumnName("TYPE_");
            entity.Property(e => e.UgoReference)
                .HasMaxLength(32)
                .HasColumnName("UGO_REFERENCE");

            entity.HasOne(d => d.Apparatus).WithMany(p => p.Images)
                .HasForeignKey(d => d.ApparatusId)
                .HasConstraintName("IMAGES$FK_IMAGES");

            entity.HasOne(d => d.UgoReferenceNavigation).WithMany(p => p.Images)
                .HasForeignKey(d => d.UgoReference)
                .HasConstraintName("IMAGES$FK_IMAGES1");
        });

        modelBuilder.Entity<KomplPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("KOMPL_PLK$Index_867749EE_FE39_4A67");

            entity.ToTable("KOMPL_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.Selected).HasColumnName("SELECTED");
            entity.Property(e => e.Typemdl)
                .HasMaxLength(10)
                .HasColumnName("TYPEMDL");
        });

        modelBuilder.Entity<KposPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("KPOS_PLK$Index_5E12C587_19CA_40F0");

            entity.ToTable("KPOS_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Codetypemodule)
                .HasMaxLength(50)
                .HasColumnName("CODETYPEMODULE");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Gonamedef)
                .HasMaxLength(50)
                .HasColumnName("GONAMEDEF");
            entity.Property(e => e.Gospiddef)
                .HasMaxLength(32)
                .HasColumnName("GOSPIDDEF");
            entity.Property(e => e.Kpos)
                .HasMaxLength(50)
                .HasColumnName("KPOS");
            entity.Property(e => e.Ktadefid)
                .HasMaxLength(32)
                .HasColumnName("KTADEFID");
            entity.Property(e => e.Namedef)
                .HasMaxLength(50)
                .HasColumnName("NAMEDEF");
            entity.Property(e => e.Numberoutsidecontact).HasColumnName("NUMBEROUTSIDECONTACT");
        });

        modelBuilder.Entity<KpostoGoPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("KPOSToGo_PLK$Index_FD00A936_1E10_4241");

            entity.ToTable("KPOSToGo_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Addaddr).HasColumnName("ADDADDR");
            entity.Property(e => e.GoId).HasColumnName("GO_ID");
            entity.Property(e => e.KodGo)
                .HasMaxLength(50)
                .HasColumnName("KOD_GO");
            entity.Property(e => e.KposId)
                .HasMaxLength(32)
                .HasColumnName("KPOS_ID");
            entity.Property(e => e.ModelId)
                .HasMaxLength(32)
                .HasColumnName("MODEL_ID");
            entity.Property(e => e.Type).HasColumnName("TYPE_");

            entity.HasOne(d => d.Go).WithMany(p => p.KpostoGoPlks)
                .HasForeignKey(d => d.GoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("KPOSToGo_PLK$FK_KPOS_TO_GO2");

            entity.HasOne(d => d.Kpos).WithMany(p => p.KpostoGoPlks)
                .HasForeignKey(d => d.KposId)
                .HasConstraintName("KPOSToGo_PLK$FK_KPOS_TO_GO1");

            entity.HasOne(d => d.Model).WithMany(p => p.KpostoGoPlks)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("KPOSToGo_PLK$FK_MODELS2");
        });

        modelBuilder.Entity<Link>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("LINKS$Index_A0F952DD_A565_43A3");

            entity.ToTable("LINKS");

            entity.HasIndex(e => e.ToId, "LINKS$IX_TO_ID");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.RecordFromId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_FROM_ID");
            entity.Property(e => e.ToId)
                .HasMaxLength(32)
                .HasColumnName("TO_ID");
            entity.Property(e => e.WhereTo).HasColumnName("WHERE_TO");

            entity.HasOne(d => d.RecordFrom).WithMany(p => p.Links)
                .HasForeignKey(d => d.RecordFromId)
                .HasConstraintName("LINKS$FK_LINKS");
        });

        modelBuilder.Entity<LpapparatusPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("LPApparatus_PLK$Index_86F70A8D_28E1_4E8C");

            entity.ToTable("LPApparatus_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Addrbegin)
                .HasMaxLength(50)
                .HasColumnName("ADDRBEGIN");
            entity.Property(e => e.Addrend)
                .HasMaxLength(50)
                .HasColumnName("ADDREND");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Dimension).HasColumnName("DIMENSION");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Gost)
                .HasMaxLength(90)
                .HasColumnName("GOST");
            entity.Property(e => e.Group)
                .HasMaxLength(150)
                .HasColumnName("GROUP_");
            entity.Property(e => e.Islogical).HasColumnName("ISLOGICAL");
            entity.Property(e => e.KtmKta)
                .HasMaxLength(50)
                .HasColumnName("KTM_KTA");
            entity.Property(e => e.Mask)
                .HasMaxLength(50)
                .HasColumnName("MASK");
            entity.Property(e => e.ModelId)
                .HasMaxLength(32)
                .HasColumnName("MODEL_ID");
            entity.Property(e => e.Pzone)
                .HasMaxLength(50)
                .HasColumnName("PZONE");
            entity.Property(e => e.Type).HasColumnName("TYPE_");
            entity.Property(e => e.Voltage)
                .HasMaxLength(50)
                .HasColumnName("VOLTAGE");

            entity.HasOne(d => d.Model).WithMany(p => p.LpapparatusPlks)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("LPApparatus_PLK$FK_MODELS1");
        });

        modelBuilder.Entity<Lug>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("LUGS$Index_74DE010C_E472_4826");

            entity.ToTable("LUGS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Diameter).HasColumnName("DIAMETER");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.Section).HasColumnName("SECTION_");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Type).HasColumnName("TYPE_");

            entity.HasOne(d => d.Record).WithMany(p => p.Lugs)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("LUGS$FK_LUGS");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("MATERIALS$Index_BD265D32_F5D3_4DA6");

            entity.ToTable("MATERIALS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Metal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("METALS$Index_17E3CBF2_7C9A_4FAD");

            entity.ToTable("METALS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Metalscolumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("METALSCOLUMNS$Index_092D00A1_3B15_4919");

            entity.ToTable("METALSCOLUMNS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Fromlist).HasColumnName("FROMLIST");
            entity.Property(e => e.Ininfo).HasColumnName("ININFO");
            entity.Property(e => e.Isequal).HasColumnName("ISEQUAL");
            entity.Property(e => e.MetalNameId).HasColumnName("METAL_NAME_ID");
            entity.Property(e => e.TableId).HasColumnName("TABLE_ID");

            entity.HasOne(d => d.MetalName).WithMany(p => p.Metalscolumns)
                .HasForeignKey(d => d.MetalNameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("METALSCOLUMNS$FK_METALSCOLUMNS1");

            entity.HasOne(d => d.Table).WithMany(p => p.Metalscolumns)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("METALSCOLUMNS$FK_METALSCOLUMNS");
        });

        modelBuilder.Entity<Metalvalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("METALVALUES$Index_0C04DADD_EDB5_4A6B");

            entity.ToTable("METALVALUES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ColumnId).HasColumnName("COLUMN_ID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Value).HasColumnName("VALUE_");

            entity.HasOne(d => d.Column).WithMany(p => p.Metalvalues)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("METALVALUES$FK_METALVALUES1");

            entity.HasOne(d => d.Record).WithMany(p => p.Metalvalues)
                .HasForeignKey(d => d.RecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("METALVALUES$FK_METALVALUES");
        });

        modelBuilder.Entity<ModelReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("MODEL_REFERENCE$Index_9951D602_9816_4047");

            entity.ToTable("MODEL_REFERENCE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("REFERENCE_");
            entity.Property(e => e.Type).HasColumnName("TYPE_");

            entity.HasOne(d => d.Record).WithMany(p => p.ModelReferences)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("MODEL_REFERENCE$FK_MODELREF");
        });

        modelBuilder.Entity<ModelsPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Models_PLK$Index_1362D298_C39C_488E");

            entity.ToTable("Models_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Code1).HasColumnName("CODE1");
            entity.Property(e => e.Code2).HasColumnName("CODE2");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Name1)
                .HasMaxLength(50)
                .HasColumnName("NAME1");
            entity.Property(e => e.Name2)
                .HasMaxLength(50)
                .HasColumnName("NAME2");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TableId).HasColumnName("TABLE_ID");

            entity.HasOne(d => d.Table).WithMany(p => p.ModelsPlks)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("Models_PLK$FK_MODELS");
        });

        modelBuilder.Entity<OtherProduce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OTHER_PRODUCES$Index_75EC6D99_A145_41F5");

            entity.ToTable("OTHER_PRODUCES");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.UgoReference)
                .HasMaxLength(32)
                .HasColumnName("UGO_REFERENCE");

            entity.HasOne(d => d.Record).WithMany(p => p.OtherProduces)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("OTHER_PRODUCES$FK_OTHER_PRODUCES");

            entity.HasOne(d => d.UgoReferenceNavigation).WithMany(p => p.OtherProduces)
                .HasForeignKey(d => d.UgoReference)
                .HasConstraintName("OTHER_PRODUCES$FK_OTHER_PRODUCES1");
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PARTS$Index_8628F09A_509F_4745");

            entity.ToTable("PARTS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.ApparatusId)
                .HasMaxLength(32)
                .HasColumnName("APPARATUS_ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .HasColumnName("COMMENT_");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("NAME");
            entity.Property(e => e.Type).HasColumnName("TYPE_");

            entity.HasOne(d => d.Apparatus).WithMany(p => p.Parts)
                .HasForeignKey(d => d.ApparatusId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PARTS$FK_PARTS");
        });

        modelBuilder.Entity<PartsReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PARTS_REFERENCES$Index_A989F22F_FD99_4293");

            entity.ToTable("PARTS_REFERENCES");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.ImageId)
                .HasMaxLength(32)
                .HasColumnName("IMAGE_ID");
            entity.Property(e => e.PartId)
                .HasMaxLength(32)
                .HasColumnName("PART_ID");
            entity.Property(e => e.TextfieldBco)
                .HasMaxLength(255)
                .HasColumnName("TEXTFIELD_BCO");

            entity.HasOne(d => d.Image).WithMany(p => p.PartsReferences)
                .HasForeignKey(d => d.ImageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PARTS_REFERENCES$FK_PARTS_REFERENCES");
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("RECORDS$Index_31A2E838_3175_485D");

            entity.ToTable("RECORDS");

            entity.HasIndex(e => e.Number, "RECORDS$IX_RECORDS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.Available).HasColumnName("AVAILABLE");
            entity.Property(e => e.ColorInd).HasColumnName("COLOR_IND");
            entity.Property(e => e.Diameter).HasColumnName("DIAMETER");
            entity.Property(e => e.DocumentForm)
                .HasMaxLength(8)
                .HasColumnName("DOCUMENT_FORM");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(60)
                .HasColumnName("DOCUMENT_NAME");
            entity.Property(e => e.Gost)
                .HasMaxLength(90)
                .HasColumnName("GOST");
            entity.Property(e => e.GraphHelp).HasColumnName("GRAPH_HELP");
            entity.Property(e => e.Group)
                .HasMaxLength(150)
                .HasColumnName("GROUP_");
            entity.Property(e => e.Hight).HasColumnName("HIGHT");
            entity.Property(e => e.Kind).HasColumnName("KIND");
            entity.Property(e => e.Length).HasColumnName("LENGTH_");
            entity.Property(e => e.Mass).HasColumnName("MASS");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Number).HasColumnName("NUMBER_");
            entity.Property(e => e.Okp)
                .HasMaxLength(255)
                .HasColumnName("OKP");
            entity.Property(e => e.OtherFieldInt).HasColumnName("OTHER_FIELD_INT");
            entity.Property(e => e.OtherFieldName).HasColumnName("OTHER_FIELD_NAME");
            entity.Property(e => e.Purchasable).HasColumnName("PURCHASABLE");
            entity.Property(e => e.RiseMax).HasColumnName("RISE_MAX");
            entity.Property(e => e.RiseMin).HasColumnName("RISE_MIN");
            entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
            entity.Property(e => e.TableId).HasColumnName("TABLE_ID");
            entity.Property(e => e.TextHelp).HasColumnName("TEXT_HELP");
            entity.Property(e => e.Width).HasColumnName("WIDTH");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Records)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("RECORDS$FK_RECORDS1");

            entity.HasOne(d => d.Table).WithMany(p => p.Records)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RECORDS$FK_RECORDS");
        });

        modelBuilder.Entity<ReportCatalog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("REPORT_CATALOG$Index_4D1A755D_C206_4B03");

            entity.ToTable("REPORT_CATALOG");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Number).HasColumnName("NUMBER_");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
        });

        modelBuilder.Entity<ReportForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("REPORT_FORMS$Index_5BCAFBAD_D648_4231");

            entity.ToTable("REPORT_FORMS");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.CatalogId).HasColumnName("CATALOG_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Number).HasColumnName("NUMBER_");
            entity.Property(e => e.Preview).HasColumnName("PREVIEW");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.XmlFile).HasColumnName("XML_FILE");

            entity.HasOne(d => d.Catalog).WithMany(p => p.ReportForms)
                .HasForeignKey(d => d.CatalogId)
                .HasConstraintName("REPORT_FORMS$FK_RFORMS_RCATALOG");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SETTINGS$Index_E0031234_4010_4468");

            entity.ToTable("SETTINGS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SortUgo).HasColumnName("SORT_UGO");
            entity.Property(e => e.Variant).HasColumnName("VARIANT");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<Sheathe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SHEATHES$Index_E3B50133_4AB8_4CE3");

            entity.ToTable("SHEATHES");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.ExternalDiameter).HasColumnName("EXTERNAL_DIAMETER");
            entity.Property(e => e.ExternalX).HasColumnName("EXTERNAL_X");
            entity.Property(e => e.ExternalY).HasColumnName("EXTERNAL_Y");
            entity.Property(e => e.InternalDiameter).HasColumnName("INTERNAL_DIAMETER");
            entity.Property(e => e.InternalX).HasColumnName("INTERNAL_X");
            entity.Property(e => e.InternalY).HasColumnName("INTERNAL_Y");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Record).WithMany(p => p.Sheathes)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("SHEATHES$FK_SHEATHES");
        });

        modelBuilder.Entity<Sprcharcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRCHARCODE$Index_06A5CDDC_4FA6_4A72");

            entity.ToTable("SPRCHARCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .HasColumnName("CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<Sprclampdiameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRCLAMPDIAMETER$Index_FB60D184_1A25_47C3");

            entity.ToTable("SPRCLAMPDIAMETER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Diameter).HasColumnName("DIAMETER");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<Sprlugdiameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRLUGDIAMETER$Index_9F62A3E4_A432_474C");

            entity.ToTable("SPRLUGDIAMETER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Diameter).HasColumnName("DIAMETER");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<Sprrecdocform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRRECDOCFORM$Index_AA7F2662_76F4_47D1");

            entity.ToTable("SPRRECDOCFORM");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.DocumentForm)
                .HasMaxLength(8)
                .HasColumnName("DOCUMENT_FORM");
        });

        modelBuilder.Entity<Sprrecdocname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRRECDOCNAME$Index_AEB2F364_DACB_4D15");

            entity.ToTable("SPRRECDOCNAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(60)
                .HasColumnName("DOCUMENT_NAME");
        });

        modelBuilder.Entity<Sprrecgost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRRECGOST$Index_F8C07C16_74B5_4160");

            entity.ToTable("SPRRECGOST");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.Gost)
                .HasMaxLength(60)
                .HasColumnName("GOST");
        });

        modelBuilder.Entity<Sprrecgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRRECGROUP$Index_69CC86B8_516E_4D9B");

            entity.ToTable("SPRRECGROUP");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.Group)
                .HasMaxLength(100)
                .HasColumnName("GROUP_");
        });

        modelBuilder.Entity<Sprrecname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRRECNAME$Index_D8C89E3A_9917_4BA6");

            entity.ToTable("SPRRECNAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<Sprsheatheintdiameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRSHEATHEINTDIAMETER$Index_B991214B_8097_4B0B");

            entity.ToTable("SPRSHEATHEINTDIAMETER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.InternalDiameter).HasColumnName("INTERNAL_DIAMETER");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<Sprtechvalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRTECHVALUES$Index_6526DECC_2AEC_4E34");

            entity.ToTable("SPRTECHVALUES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ColumnNameId).HasColumnName("COLUMN_NAME_ID");
            entity.Property(e => e.Techvalue)
                .HasMaxLength(250)
                .HasColumnName("TECHVALUE");

            entity.HasOne(d => d.ColumnName).WithMany(p => p.Sprtechvalues)
                .HasForeignKey(d => d.ColumnNameId)
                .HasConstraintName("SPRTECHVALUES$FK_SPRTECHVALUES");
        });

        modelBuilder.Entity<Sprwiresection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPRWIRESECTION$Index_D6428A85_5817_4763");

            entity.ToTable("SPRWIRESECTION");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Section).HasColumnName("SECTION_");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<SpvvstringsPlk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SPVVSTRINGS_PLK$Index_B2156DED_0F4B_4DC4");

            entity.ToTable("SPVVSTRINGS_PLK");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.AppId)
                .HasMaxLength(32)
                .HasColumnName("APP_ID");
            entity.Property(e => e.Iso)
                .HasMaxLength(50)
                .HasColumnName("ISO");
            entity.Property(e => e.Type).HasColumnName("TYPE_");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SUPPLIER$Index_100B0F0B_63F7_4D0D");

            entity.ToTable("SUPPLIER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TABLES$Index_A626A49A_3911_4D0F");

            entity.ToTable("TABLES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.ColorInd).HasColumnName("COLOR_IND");
            entity.Property(e => e.Fromlist).HasColumnName("FROMLIST");
            entity.Property(e => e.Ininfo).HasColumnName("ININFO");
            entity.Property(e => e.Isequal).HasColumnName("ISEQUAL");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
            entity.Property(e => e.Unit).HasColumnName("UNIT");

            entity.HasOne(d => d.Parent).WithMany(p => p.Tables)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TABLES$FK_TABLES");
        });

        modelBuilder.Entity<Techcolum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TECHCOLUMS$Index_DD4DF685_3D56_442B");

            entity.ToTable("TECHCOLUMS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ColumnNameId).HasColumnName("COLUMN_NAME_ID");
            entity.Property(e => e.Fromlist).HasColumnName("FROMLIST");
            entity.Property(e => e.Ininfo).HasColumnName("ININFO");
            entity.Property(e => e.Isequal).HasColumnName("ISEQUAL");
            entity.Property(e => e.TableId).HasColumnName("TABLE_ID");

            entity.HasOne(d => d.ColumnName).WithMany(p => p.Techcolums)
                .HasForeignKey(d => d.ColumnNameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TECHCOLUMS$FK_TECHCOLUMS1");

            entity.HasOne(d => d.Table).WithMany(p => p.Techcolums)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TECHCOLUMS$FK_TECHCOLUMS");
        });

        modelBuilder.Entity<TechcolumName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TECHCOLUM_NAMES$Index_45EAE457_A058_424A");

            entity.ToTable("TECHCOLUM_NAMES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Techvalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TECHVALUES$Index_C3B8124A_E2B5_47B1");

            entity.ToTable("TECHVALUES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ColumnId).HasColumnName("COLUMN_ID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .HasColumnName("VALUE_");

            entity.HasOne(d => d.Column).WithMany(p => p.Techvalues)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TECHVALUES$FK_TECHVALUES1");

            entity.HasOne(d => d.Record).WithMany(p => p.Techvalues)
                .HasForeignKey(d => d.RecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TECHVALUES$FK_TECHVALUES");
        });

        modelBuilder.Entity<Texthelp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TEXTHELP$Index_6FAC71CA_91BE_410B");

            entity.ToTable("TEXTHELP");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.PdfFile).HasColumnName("PDF_FILE");
            entity.Property(e => e.RecordId)
                .HasMaxLength(32)
                .HasColumnName("RECORD_ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Record).WithMany(p => p.Texthelps)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("TEXTHELP$FK_TEXTHELP");
        });

        modelBuilder.Entity<TexthelpTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TEXTHELP_TB$Index_002272B2_7E38_4161");

            entity.ToTable("TEXTHELP_TB");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.PdfFile).HasColumnName("PDF_FILE");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TableId).HasColumnName("TABLE_ID");

            entity.HasOne(d => d.Table).WithMany(p => p.TexthelpTbs)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("TEXTHELP_TB$FK_TEXTHELP_TB");
        });

        modelBuilder.Entity<Ugo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UGO$Index_5D51F36B_5800_45B2");

            entity.ToTable("UGO");

            entity.HasIndex(e => e.BugoId, "UGO$IX_UGO_BUGO_Id");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("ID");
            entity.Property(e => e.BugoId).HasColumnName("BUGO_ID");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Icon).HasColumnName("ICON");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Number).HasColumnName("NUMBER_");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Type).HasColumnName("TYPE_");
            entity.Property(e => e.Ugo1).HasColumnName("UGO");

            entity.HasOne(d => d.Bugo).WithMany(p => p.Ugos)
                .HasForeignKey(d => d.BugoId)
                .HasConstraintName("UGO$FK_UGO");
        });

        modelBuilder.Entity<Wire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WIRES$Index_B1289126_0A56_4D36");

            entity.ToTable("WIRES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Coax).HasColumnName("COAX");
            entity.Property(e => e.ColorId).HasColumnName("COLOR_ID");
            entity.Property(e => e.ContentId)
                .HasMaxLength(32)
                .HasColumnName("CONTENT_ID");
            entity.Property(e => e.ExternalDiameter).HasColumnName("EXTERNAL_DIAMETER");
            entity.Property(e => e.MaterialId).HasColumnName("MATERIAL_ID");
            entity.Property(e => e.Section).HasColumnName("SECTION_");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Color).WithMany(p => p.Wires)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WIRES$FK_WIRES1");

            entity.HasOne(d => d.Content).WithMany(p => p.Wires)
                .HasForeignKey(d => d.ContentId)
                .HasConstraintName("WIRES$FK_WIRES");

            entity.HasOne(d => d.Material).WithMany(p => p.Wires)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WIRES$FK_WIRES2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
