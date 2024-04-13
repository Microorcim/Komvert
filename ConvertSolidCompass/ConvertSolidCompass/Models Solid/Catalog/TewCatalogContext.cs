using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConvertSolidCompass.Models.Catalog;

public partial class TewCatalogContext : DbContext
{
    public TewCatalogContext()
    {
    }

    public TewCatalogContext(DbContextOptions<TewCatalogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TewCatelement> TewCatelements { get; set; }

    public virtual DbSet<TewCatreference> TewCatreferences { get; set; }

    public virtual DbSet<TewCatreferencelink> TewCatreferencelinks { get; set; }

    public virtual DbSet<TewCatsuperpair> TewCatsuperpairs { get; set; }

    public virtual DbSet<TewCatterminal> TewCatterminals { get; set; }

    public virtual DbSet<TewCrsuserdatum> TewCrsuserdata { get; set; }

    public virtual DbSet<TewTranslatedtext> TewTranslatedtexts { get; set; }

    public virtual DbSet<TewTrctranslatedtext> TewTrctranslatedtexts { get; set; }

    public virtual DbSet<TewVersion> TewVersions { get; set; }

    public virtual DbSet<VewDataManufacturerpart> VewDataManufacturerparts { get; set; }

    public virtual DbSet<VewVersionTewCatalog0> VewVersionTewCatalog0s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\TEW_SQLEXPRESS;Database=tew_catalog;Integrated Security=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TewCatelement>(entity =>
        {
            entity.HasKey(e => new { e.CaeCreUid, e.CaeNo })
                .HasName("idxtew_catelement_1")
                .IsClustered(false);

            entity.ToTable("tew_catelement", "tew");

            entity.Property(e => e.CaeCreUid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("cae_cre_uid");
            entity.Property(e => e.CaeNo)
                .HasDefaultValue(-1)
                .HasColumnName("cae_no");
            entity.Property(e => e.CaeBlockctno)
                .HasDefaultValue(-1)
                .HasColumnName("cae_blockctno");
            entity.Property(e => e.CaeBlockname)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cae_blockname");
            entity.Property(e => e.CaeBlockno)
                .HasDefaultValue(-1)
                .HasColumnName("cae_blockno");
            entity.Property(e => e.CaeChanneladdress)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("cae_channeladdress");
            entity.Property(e => e.CaeChannelgroup)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasColumnName("cae_channelgroup");
            entity.Property(e => e.CaeGroup)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cae_group");
            entity.Property(e => e.CaeKeycode)
                .HasMaxLength(12)
                .HasDefaultValue("")
                .HasColumnName("cae_keycode");
        });

        modelBuilder.Entity<TewCatreference>(entity =>
        {
            entity.HasKey(e => e.CreUid)
                .HasName("idxtew_catreference_1")
                .IsClustered(false);

            entity.ToTable("tew_catreference", "tew");

            entity.HasIndex(e => new { e.CreReference, e.CreManufacturer }, "idxtew_catreference_2").IsUnique();

            entity.HasIndex(e => e.CreNodClauid, "idxtew_catreference_3").IsClustered();

            entity.Property(e => e.CreUid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("cre_uid");
            entity.Property(e => e.CreArticlename)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_articlename");
            entity.Property(e => e.CreBloschname)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_bloschname");
            entity.Property(e => e.CreBlosynname)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_blosynname");
            entity.Property(e => e.CreClaName)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_cla_name");
            entity.Property(e => e.CreCofrequency)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_cofrequency");
            entity.Property(e => e.CreCovoltage)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_covoltage");
            entity.Property(e => e.CreCreationdate)
                .HasColumnType("datetime")
                .HasColumnName("cre_creationdate");
            entity.Property(e => e.CreDatasheet)
                .HasMaxLength(1024)
                .HasDefaultValue("")
                .HasColumnName("cre_datasheet");
            entity.Property(e => e.CreDatatype)
                .HasDefaultValue(0)
                .HasColumnName("cre_datatype");
            entity.Property(e => e.CreEcpcontactid)
                .HasDefaultValue(-1)
                .HasColumnName("cre_ecpcontactid");
            entity.Property(e => e.CreElementcount)
                .HasDefaultValue(0)
                .HasColumnName("cre_elementcount");
            entity.Property(e => e.CreExternalid)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_externalid");
            entity.Property(e => e.CreFolderpartname)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_folderpartname");
            entity.Property(e => e.CreImplantx)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("cre_implantx");
            entity.Property(e => e.CreImplanty)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("cre_implanty");
            entity.Property(e => e.CreImplantz)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("cre_implantz");
            entity.Property(e => e.CreIsobsolete)
                .HasDefaultValue(0)
                .HasColumnName("cre_isobsolete");
            entity.Property(e => e.CreLibName)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_lib_name");
            entity.Property(e => e.CreManufacturer)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_manufacturer");
            entity.Property(e => e.CreModificationdate)
                .HasColumnType("datetime")
                .HasColumnName("cre_modificationdate");
            entity.Property(e => e.CreModifiedby)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_modifiedby");
            entity.Property(e => e.CreNodClauid)
                .HasDefaultValue(102)
                .HasColumnName("cre_nod_clauid");
            entity.Property(e => e.CreObjecttype)
                .HasDefaultValue(0)
                .HasColumnName("cre_objecttype");
            entity.Property(e => e.CrePartname)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_partname");
            entity.Property(e => e.CrePartnametwod)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_partnametwod");
            entity.Property(e => e.CrePcbfilename)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_pcbfilename");
            entity.Property(e => e.CrePcbfolderpath)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_pcbfolderpath");
            entity.Property(e => e.CreReference)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasColumnName("cre_reference");
            entity.Property(e => e.CreRootmark)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_rootmark");
            entity.Property(e => e.CreSerie)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_serie");
            entity.Property(e => e.CreStocknumber)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasColumnName("cre_stocknumber");
            entity.Property(e => e.CreSuppliername)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_suppliername");
            entity.Property(e => e.CreTerminalcount)
                .HasDefaultValue(0)
                .HasColumnName("cre_terminalcount");
            entity.Property(e => e.CreTerminalstripsymbol)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_terminalstripsymbol");
            entity.Property(e => e.CreUpdate)
                .HasDefaultValue(0)
                .HasColumnName("cre_update");
            entity.Property(e => e.CreUsefrequency)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_usefrequency");
            entity.Property(e => e.CreUsevoltage)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_usevoltage");
            entity.Property(e => e.CreValue1)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_value1");
            entity.Property(e => e.CreValue2)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_value2");
            entity.Property(e => e.CreValue3)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_value3");
            entity.Property(e => e.CreValue4)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_value4");
            entity.Property(e => e.CreValue5)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_value5");
            entity.Property(e => e.CreValue6)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cre_value6");
            entity.Property(e => e.CreValue7)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("cre_value7");
            entity.Property(e => e.CreWiringpartname)
                .HasMaxLength(512)
                .HasDefaultValue("")
                .HasColumnName("cre_wiringpartname");
        });

        modelBuilder.Entity<TewCatreferencelink>(entity =>
        {
            entity.HasKey(e => new { e.CliCreParentid, e.CliCreChildid })
                .HasName("idxtew_catreferencelink_1")
                .IsClustered(false);

            entity.ToTable("tew_catreferencelink", "tew");

            entity.Property(e => e.CliCreParentid)
                .HasDefaultValue(-1)
                .HasColumnName("cli_cre_parentid");
            entity.Property(e => e.CliCreChildid)
                .HasDefaultValue(-1)
                .HasColumnName("cli_cre_childid");
            entity.Property(e => e.CliElementtype)
                .HasDefaultValue(-1)
                .HasColumnName("cli_elementtype");
            entity.Property(e => e.CliObjecttype)
                .HasDefaultValue(-1)
                .HasColumnName("cli_objecttype");
        });

        modelBuilder.Entity<TewCatsuperpair>(entity =>
        {
            entity.HasKey(e => new { e.CspCreParentuid, e.CspOrderno })
                .HasName("idxtew_catsuperpair_1")
                .IsClustered(false);

            entity.ToTable("tew_catsuperpair", "tew");

            entity.Property(e => e.CspCreParentuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("csp_cre_parentuid");
            entity.Property(e => e.CspOrderno).HasColumnName("csp_orderno");
            entity.Property(e => e.CspCreChilduid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("csp_cre_childuid");
        });

        modelBuilder.Entity<TewCatterminal>(entity =>
        {
            entity.HasKey(e => new { e.CatCreUid, e.CatCaeNo, e.CatNo })
                .HasName("idxtew_catterminal_1")
                .IsClustered(false);

            entity.ToTable("tew_catterminal", "tew");

            entity.Property(e => e.CatCreUid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("cat_cre_uid");
            entity.Property(e => e.CatCaeNo)
                .HasDefaultValue(-1)
                .HasColumnName("cat_cae_no");
            entity.Property(e => e.CatNo)
                .HasDefaultValue(-1)
                .HasColumnName("cat_no");
            entity.Property(e => e.CatConnectionnb)
                .HasDefaultValue(0)
                .HasColumnName("cat_connectionnb");
            entity.Property(e => e.CatFlowdirectiontype)
                .HasDefaultValue(-1)
                .HasColumnName("cat_flowdirectiontype");
            entity.Property(e => e.CatMaxgauge)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cat_maxgauge");
            entity.Property(e => e.CatMaxsection)
                .HasDefaultValue(0.0)
                .HasColumnName("cat_maxsection");
            entity.Property(e => e.CatMingauge)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cat_mingauge");
            entity.Property(e => e.CatMinsection)
                .HasDefaultValue(0.0)
                .HasColumnName("cat_minsection");
            entity.Property(e => e.CatMnemo)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cat_mnemo");
            entity.Property(e => e.CatTtycode)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cat_ttycode");
            entity.Property(e => e.CatTxt)
                .HasMaxLength(70)
                .HasDefaultValue("")
                .HasColumnName("cat_txt");
        });

        modelBuilder.Entity<TewCrsuserdatum>(entity =>
        {
            entity.HasKey(e => e.CrsCreUid)
                .HasName("idxtew_crsuserdata_1")
                .IsClustered(false);

            entity.ToTable("tew_crsuserdata", "tew", tb => tb.HasComment("Customer user data of manufacturer parts"));

            entity.Property(e => e.CrsCreUid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("crs_cre_uid");
            entity.Property(e => e.CrsData0)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data0");
            entity.Property(e => e.CrsData1)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data1");
            entity.Property(e => e.CrsData10)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data10");
            entity.Property(e => e.CrsData11)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data11");
            entity.Property(e => e.CrsData12)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data12");
            entity.Property(e => e.CrsData13)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data13");
            entity.Property(e => e.CrsData14)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data14");
            entity.Property(e => e.CrsData15)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data15");
            entity.Property(e => e.CrsData16)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data16");
            entity.Property(e => e.CrsData17)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data17");
            entity.Property(e => e.CrsData18)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data18");
            entity.Property(e => e.CrsData19)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data19");
            entity.Property(e => e.CrsData2)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data2");
            entity.Property(e => e.CrsData3)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data3");
            entity.Property(e => e.CrsData4)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data4");
            entity.Property(e => e.CrsData5)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data5");
            entity.Property(e => e.CrsData6)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data6");
            entity.Property(e => e.CrsData7)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data7");
            entity.Property(e => e.CrsData8)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data8");
            entity.Property(e => e.CrsData9)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("crs_data9");
        });

        modelBuilder.Entity<TewTranslatedtext>(entity =>
        {
            entity.HasKey(e => new { e.TraObjectid, e.TraLanStrid })
                .HasName("idxtew_translatedtext_1")
                .IsClustered(false);

            entity.ToTable("tew_translatedtext", "tew");

            entity.Property(e => e.TraObjectid)
                .HasDefaultValue(-1)
                .HasColumnName("tra_objectid");
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
            entity.Property(e => e.TraObjectno)
                .HasDefaultValue(-1)
                .HasColumnName("tra_objectno");
            entity.Property(e => e.TraStrobjectid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tra_strobjectid");
        });

        modelBuilder.Entity<TewTrctranslatedtext>(entity =>
        {
            entity.HasKey(e => new { e.TrcCreUid, e.TrcLanStrid })
                .HasName("idxtew_trctranslatedtext_1")
                .IsClustered(false);

            entity.ToTable("tew_trctranslatedtext", "tew");

            entity.Property(e => e.TrcCreUid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("trc_cre_uid");
            entity.Property(e => e.TrcLanStrid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("trc_lan_strid");
            entity.Property(e => e.Trc0)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_0");
            entity.Property(e => e.Trc1)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_1");
            entity.Property(e => e.Trc10)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_10");
            entity.Property(e => e.Trc11)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_11");
            entity.Property(e => e.Trc12)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_12");
            entity.Property(e => e.Trc13)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_13");
            entity.Property(e => e.Trc14)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_14");
            entity.Property(e => e.Trc2)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_2");
            entity.Property(e => e.Trc3)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_3");
            entity.Property(e => e.Trc4)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_4");
            entity.Property(e => e.Trc5)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_5");
            entity.Property(e => e.Trc6)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_6");
            entity.Property(e => e.Trc7)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_7");
            entity.Property(e => e.Trc8)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_8");
            entity.Property(e => e.Trc9)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("trc_9");
        });

        modelBuilder.Entity<TewVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tew_version", tb => tb.HasComment("Database structure and content version"));

            entity.Property(e => e.VerId)
                .HasDefaultValue(1)
                .HasColumnName("ver_id");
            entity.Property(e => e.VerReference).HasColumnName("ver_reference");
            entity.Property(e => e.VerReferencedatas)
                .HasDefaultValue(-1)
                .HasColumnName("ver_referencedatas");
        });

        modelBuilder.Entity<VewDataManufacturerpart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vew_data_manufacturerpart", "tew");

            entity.Property(e => e.CreArticlename)
                .HasMaxLength(255)
                .HasColumnName("cre_articlename");
            entity.Property(e => e.CreBloschname)
                .HasMaxLength(512)
                .HasColumnName("cre_bloschname");
            entity.Property(e => e.CreBlosynname)
                .HasMaxLength(512)
                .HasColumnName("cre_blosynname");
            entity.Property(e => e.CreClaName)
                .HasMaxLength(255)
                .HasColumnName("cre_cla_name");
            entity.Property(e => e.CreCofrequency)
                .HasMaxLength(70)
                .HasColumnName("cre_cofrequency");
            entity.Property(e => e.CreCovoltage)
                .HasMaxLength(70)
                .HasColumnName("cre_covoltage");
            entity.Property(e => e.CreCreationdate)
                .HasColumnType("datetime")
                .HasColumnName("cre_creationdate");
            entity.Property(e => e.CreCrsData0)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data0");
            entity.Property(e => e.CreCrsData1)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data1");
            entity.Property(e => e.CreCrsData10)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data10");
            entity.Property(e => e.CreCrsData11)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data11");
            entity.Property(e => e.CreCrsData12)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data12");
            entity.Property(e => e.CreCrsData13)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data13");
            entity.Property(e => e.CreCrsData14)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data14");
            entity.Property(e => e.CreCrsData15)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data15");
            entity.Property(e => e.CreCrsData16)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data16");
            entity.Property(e => e.CreCrsData17)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data17");
            entity.Property(e => e.CreCrsData18)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data18");
            entity.Property(e => e.CreCrsData19)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data19");
            entity.Property(e => e.CreCrsData2)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data2");
            entity.Property(e => e.CreCrsData3)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data3");
            entity.Property(e => e.CreCrsData4)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data4");
            entity.Property(e => e.CreCrsData5)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data5");
            entity.Property(e => e.CreCrsData6)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data6");
            entity.Property(e => e.CreCrsData7)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data7");
            entity.Property(e => e.CreCrsData8)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data8");
            entity.Property(e => e.CreCrsData9)
                .HasMaxLength(255)
                .HasColumnName("cre_crs_data9");
            entity.Property(e => e.CreDatasheet)
                .HasMaxLength(1024)
                .HasColumnName("cre_datasheet");
            entity.Property(e => e.CreDatatype).HasColumnName("cre_datatype");
            entity.Property(e => e.CreEcpcontactid).HasColumnName("cre_ecpcontactid");
            entity.Property(e => e.CreElementcount).HasColumnName("cre_elementcount");
            entity.Property(e => e.CreExternalid)
                .HasMaxLength(255)
                .HasColumnName("cre_externalid");
            entity.Property(e => e.CreFolderpartname)
                .HasMaxLength(512)
                .HasColumnName("cre_folderpartname");
            entity.Property(e => e.CreImplantx).HasColumnName("cre_implantx");
            entity.Property(e => e.CreImplanty).HasColumnName("cre_implanty");
            entity.Property(e => e.CreImplantz).HasColumnName("cre_implantz");
            entity.Property(e => e.CreIsobsolete).HasColumnName("cre_isobsolete");
            entity.Property(e => e.CreLibName)
                .HasMaxLength(255)
                .HasColumnName("cre_lib_name");
            entity.Property(e => e.CreManufacturer)
                .HasMaxLength(70)
                .HasColumnName("cre_manufacturer");
            entity.Property(e => e.CreModificationdate)
                .HasColumnType("datetime")
                .HasColumnName("cre_modificationdate");
            entity.Property(e => e.CreModifiedby)
                .HasMaxLength(255)
                .HasColumnName("cre_modifiedby");
            entity.Property(e => e.CreNodClauid).HasColumnName("cre_nod_clauid");
            entity.Property(e => e.CreObjecttype).HasColumnName("cre_objecttype");
            entity.Property(e => e.CrePartname)
                .HasMaxLength(512)
                .HasColumnName("cre_partname");
            entity.Property(e => e.CrePartnametwod)
                .HasMaxLength(512)
                .HasColumnName("cre_partnametwod");
            entity.Property(e => e.CrePcbfilename)
                .HasMaxLength(255)
                .HasColumnName("cre_pcbfilename");
            entity.Property(e => e.CrePcbfolderpath)
                .HasMaxLength(255)
                .HasColumnName("cre_pcbfolderpath");
            entity.Property(e => e.CreReference)
                .HasMaxLength(150)
                .HasColumnName("cre_reference");
            entity.Property(e => e.CreRootmark)
                .HasMaxLength(70)
                .HasColumnName("cre_rootmark");
            entity.Property(e => e.CreSerie)
                .HasMaxLength(255)
                .HasColumnName("cre_serie");
            entity.Property(e => e.CreStocknumber)
                .HasMaxLength(150)
                .HasColumnName("cre_stocknumber");
            entity.Property(e => e.CreSuppliername)
                .HasMaxLength(70)
                .HasColumnName("cre_suppliername");
            entity.Property(e => e.CreTerminalcount).HasColumnName("cre_terminalcount");
            entity.Property(e => e.CreTerminalstripsymbol)
                .HasMaxLength(512)
                .HasColumnName("cre_terminalstripsymbol");
            entity.Property(e => e.CreTrc0)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_0");
            entity.Property(e => e.CreTrc1)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_1");
            entity.Property(e => e.CreTrc10)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_10");
            entity.Property(e => e.CreTrc11)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_11");
            entity.Property(e => e.CreTrc12)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_12");
            entity.Property(e => e.CreTrc13)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_13");
            entity.Property(e => e.CreTrc14)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_14");
            entity.Property(e => e.CreTrc2)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_2");
            entity.Property(e => e.CreTrc3)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_3");
            entity.Property(e => e.CreTrc4)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_4");
            entity.Property(e => e.CreTrc5)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_5");
            entity.Property(e => e.CreTrc6)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_6");
            entity.Property(e => e.CreTrc7)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_7");
            entity.Property(e => e.CreTrc8)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_8");
            entity.Property(e => e.CreTrc9)
                .HasMaxLength(255)
                .HasColumnName("cre_trc_9");
            entity.Property(e => e.CreTrcLanStrid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cre_trc_lan_strid");
            entity.Property(e => e.CreUid).HasColumnName("cre_uid");
            entity.Property(e => e.CreUpdate).HasColumnName("cre_update");
            entity.Property(e => e.CreUsefrequency)
                .HasMaxLength(70)
                .HasColumnName("cre_usefrequency");
            entity.Property(e => e.CreUsevoltage)
                .HasMaxLength(70)
                .HasColumnName("cre_usevoltage");
            entity.Property(e => e.CreValue1)
                .HasMaxLength(70)
                .HasColumnName("cre_value1");
            entity.Property(e => e.CreValue2)
                .HasMaxLength(70)
                .HasColumnName("cre_value2");
            entity.Property(e => e.CreValue3)
                .HasMaxLength(70)
                .HasColumnName("cre_value3");
            entity.Property(e => e.CreValue4)
                .HasMaxLength(70)
                .HasColumnName("cre_value4");
            entity.Property(e => e.CreValue5)
                .HasMaxLength(70)
                .HasColumnName("cre_value5");
            entity.Property(e => e.CreValue6)
                .HasMaxLength(70)
                .HasColumnName("cre_value6");
            entity.Property(e => e.CreValue7)
                .HasMaxLength(255)
                .HasColumnName("cre_value7");
            entity.Property(e => e.CreWiringpartname)
                .HasMaxLength(512)
                .HasColumnName("cre_wiringpartname");
        });

        modelBuilder.Entity<VewVersionTewCatalog0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vew_version_tew_catalog_0", "tew");

            entity.Property(e => e.VerId).HasColumnName("ver_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
