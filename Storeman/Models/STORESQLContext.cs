using System.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Storeman.Models
{
    public partial class STORESQLContext : IdentityDbContext<User>
    {
        public STORESQLContext()
        {
        }

        public STORESQLContext(DbContextOptions<STORESQLContext> options)
            : base(options)
        {
        }
        public async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var admin = new IdentityRole("Admin");
                await roleManager.CreateAsync(admin);
            }
        }
        public virtual DbSet<AccTab> AccTab { get; set; }
        public virtual DbSet<AllowBat> AllowBat { get; set; }
        public virtual DbSet<AltDel> AltDel { get; set; }
        public virtual DbSet<AltTab> AltTab { get; set; }
        public virtual DbSet<AssrtTab> AssrtTab { get; set; }
        public virtual DbSet<BioDel> BioDel { get; set; }
        public virtual DbSet<BioTab> BioTab { get; set; }
        public virtual DbSet<BmpDel> BmpDel { get; set; }
        public virtual DbSet<BmpTab> BmpTab { get; set; }
        public virtual DbSet<BtlTab> BtlTab { get; set; }
        public virtual DbSet<CatTab> CatTab { get; set; }
        public virtual DbSet<CfgTab> CfgTab { get; set; }
        public virtual DbSet<CkzTab> CkzTab { get; set; }
        public virtual DbSet<ClfSdpTab> ClfSdpTab { get; set; }
        public virtual DbSet<ClfTab> ClfTab { get; set; }
        public virtual DbSet<ClgTab> ClgTab { get; set; }
        public virtual DbSet<ClkDel> ClkDel { get; set; }
        public virtual DbSet<ClkTab> ClkTab { get; set; }
        public virtual DbSet<CllDel> CllDel { get; set; }
        public virtual DbSet<CllTab> CllTab { get; set; }
        public virtual DbSet<ClrTab> ClrTab { get; set; }
        public virtual DbSet<ClsAux> ClsAux { get; set; }
        public virtual DbSet<ClsDel> ClsDel { get; set; }
        public virtual DbSet<ClsTab> ClsTab { get; set; }
        public virtual DbSet<CltDel> CltDel { get; set; }
        public virtual DbSet<CltItmDel> CltItmDel { get; set; }
        public virtual DbSet<CltItmTab> CltItmTab { get; set; }
        public virtual DbSet<CltTab> CltTab { get; set; }
        public virtual DbSet<CostDel> CostDel { get; set; }
        public virtual DbSet<CostTab> CostTab { get; set; }
        public virtual DbSet<CpnTab> CpnTab { get; set; }
        public virtual DbSet<DataReg> DataReg { get; set; }
        public virtual DbSet<DelvTab> DelvTab { get; set; }
        public virtual DbSet<DeptTab> DeptTab { get; set; }
        public virtual DbSet<DrilFile> DrilFile { get; set; }
        public virtual DbSet<DrilPage> DrilPage { get; set; }
        public virtual DbSet<DsdDel> DsdDel { get; set; }
        public virtual DbSet<DsdTab> DsdTab { get; set; }
        public virtual DbSet<DssTab> DssTab { get; set; }
        public virtual DbSet<EclDel> EclDel { get; set; }
        public virtual DbSet<EclTab> EclTab { get; set; }
        public virtual DbSet<ExcTab> ExcTab { get; set; }
        public virtual DbSet<FamTab> FamTab { get; set; }
        public virtual DbSet<FbbackBat> FbbackBat { get; set; }
        public virtual DbSet<FcostBat> FcostBat { get; set; }
        public virtual DbSet<FcstbrkBat> FcstbrkBat { get; set; }
        public virtual DbSet<FctTab> FctTab { get; set; }
        public virtual DbSet<FczTab> FczTab { get; set; }
        public virtual DbSet<FdiscBat> FdiscBat { get; set; }
        public virtual DbSet<FeclBat> FeclBat { get; set; }
        public virtual DbSet<FgcostBat> FgcostBat { get; set; }
        public virtual DbSet<FgpriceBat> FgpriceBat { get; set; }
        public virtual DbSet<FilTab> FilTab { get; set; }
        public virtual DbSet<FinstoreBat> FinstoreBat { get; set; }
        public virtual DbSet<FobjBat> FobjBat { get; set; }
        public virtual DbSet<FpidBat> FpidBat { get; set; }
        public virtual DbSet<FposBat> FposBat { get; set; }
        public virtual DbSet<FpriceBat> FpriceBat { get; set; }
        public virtual DbSet<FredeemBat> FredeemBat { get; set; }
        public virtual DbSet<FspriceBat> FspriceBat { get; set; }
        public virtual DbSet<FtpriceBat> FtpriceBat { get; set; }
        public virtual DbSet<HeaderBat> HeaderBat { get; set; }
        public virtual DbSet<HeaderDct> HeaderDct { get; set; }
        public virtual DbSet<HeaderDel> HeaderDel { get; set; }
        public virtual DbSet<HeaderExe> HeaderExe { get; set; }
        public virtual DbSet<HeaderIns> HeaderIns { get; set; }
        public virtual DbSet<HeaderOld> HeaderOld { get; set; }
        public virtual DbSet<HeaderSav> HeaderSav { get; set; }
        public virtual DbSet<HookTab> HookTab { get; set; }
        public virtual DbSet<InvBat> InvBat { get; set; }
        public virtual DbSet<InvHdr> InvHdr { get; set; }
        public virtual DbSet<InvReg> InvReg { get; set; }
        public virtual DbSet<InvTtl> InvTtl { get; set; }
        public virtual DbSet<ItdDel> ItdDel { get; set; }
        public virtual DbSet<ItdTab> ItdTab { get; set; }
        public virtual DbSet<ItzDel> ItzDel { get; set; }
        public virtual DbSet<ItzTab> ItzTab { get; set; }
        public virtual DbSet<KitDel> KitDel { get; set; }
        public virtual DbSet<KitTab> KitTab { get; set; }
        public virtual DbSet<LabelTab> LabelTab { get; set; }
        public virtual DbSet<LabelTpl> LabelTpl { get; set; }
        public virtual DbSet<LikeTab> LikeTab { get; set; }
        public virtual DbSet<LnkTab> LnkTab { get; set; }
        public virtual DbSet<LocDel> LocDel { get; set; }
        public virtual DbSet<LocTab> LocTab { get; set; }
        public virtual DbSet<LstHdr> LstHdr { get; set; }
        public virtual DbSet<LstReg> LstReg { get; set; }
        public virtual DbSet<LvlTab> LvlTab { get; set; }
        public virtual DbSet<MixDel> MixDel { get; set; }
        public virtual DbSet<MixTab> MixTab { get; set; }
        public virtual DbSet<ModItmTab> ModItmTab { get; set; }
        public virtual DbSet<ModTab> ModTab { get; set; }
        public virtual DbSet<NacsTab> NacsTab { get; set; }
        public virtual DbSet<OallowBat> OallowBat { get; set; }
        public virtual DbSet<ObbackBat> ObbackBat { get; set; }
        public virtual DbSet<ObjDel> ObjDel { get; set; }
        public virtual DbSet<ObjTab> ObjTab { get; set; }
        public virtual DbSet<OcostBat> OcostBat { get; set; }
        public virtual DbSet<OcstbrkBat> OcstbrkBat { get; set; }
        public virtual DbSet<OdiscBat> OdiscBat { get; set; }
        public virtual DbSet<OeclBat> OeclBat { get; set; }
        public virtual DbSet<OfrTab> OfrTab { get; set; }
        public virtual DbSet<OgcostBat> OgcostBat { get; set; }
        public virtual DbSet<OgpriceBat> OgpriceBat { get; set; }
        public virtual DbSet<OinstoreBat> OinstoreBat { get; set; }
        public virtual DbSet<OobjBat> OobjBat { get; set; }
        public virtual DbSet<OpidBat> OpidBat { get; set; }
        public virtual DbSet<OposBat> OposBat { get; set; }
        public virtual DbSet<OpriceBat> OpriceBat { get; set; }
        public virtual DbSet<OrebateBat> OrebateBat { get; set; }
        public virtual DbSet<OredeemBat> OredeemBat { get; set; }
        public virtual DbSet<OspriceBat> OspriceBat { get; set; }
        public virtual DbSet<OtpriceBat> OtpriceBat { get; set; }
        public virtual DbSet<PayTab> PayTab { get; set; }
        public virtual DbSet<PeriodTab> PeriodTab { get; set; }
        public virtual DbSet<PosDel> PosDel { get; set; }
        public virtual DbSet<PosTab> PosTab { get; set; }
        public virtual DbSet<PriceDel> PriceDel { get; set; }
        public virtual DbSet<PriceTab> PriceTab { get; set; }
        public virtual DbSet<ProfileTab> ProfileTab { get; set; }
        public virtual DbSet<PubTab> PubTab { get; set; }
        public virtual DbSet<RbFields> RbFields { get; set; }
        public virtual DbSet<RbJoins> RbJoins { get; set; }
        public virtual DbSet<RbTables> RbTables { get; set; }
        public virtual DbSet<RcpDetTab> RcpDetTab { get; set; }
        public virtual DbSet<RcpItmTab> RcpItmTab { get; set; }
        public virtual DbSet<RcpTab> RcpTab { get; set; }
        public virtual DbSet<ReasonTab> ReasonTab { get; set; }
        public virtual DbSet<RebateBat> RebateBat { get; set; }
        public virtual DbSet<RecBat> RecBat { get; set; }
        public virtual DbSet<RecHdr> RecHdr { get; set; }
        public virtual DbSet<RecHdrSav> RecHdrSav { get; set; }
        public virtual DbSet<RecReg> RecReg { get; set; }
        public virtual DbSet<RecRegSav> RecRegSav { get; set; }
        public virtual DbSet<RecTtl> RecTtl { get; set; }
        public virtual DbSet<RecTtlSav> RecTtlSav { get; set; }
        public virtual DbSet<RentTab> RentTab { get; set; }
        public virtual DbSet<ResTab> ResTab { get; set; }
        public virtual DbSet<RevExec> RevExec { get; set; }
        public virtual DbSet<RevHdr> RevHdr { get; set; }
        public virtual DbSet<RevList> RevList { get; set; }
        public virtual DbSet<RevQueue> RevQueue { get; set; }
        public virtual DbSet<RouteTab> RouteTab { get; set; }
        public virtual DbSet<RpcTab> RpcTab { get; set; }
        public virtual DbSet<RptClkD> RptClkD { get; set; }
        public virtual DbSet<RptClkF> RptClkF { get; set; }
        public virtual DbSet<RptClkM> RptClkM { get; set; }
        public virtual DbSet<RptClkN> RptClkN { get; set; }
        public virtual DbSet<RptClkP> RptClkP { get; set; }
        public virtual DbSet<RptClkW> RptClkW { get; set; }
        public virtual DbSet<RptClkY> RptClkY { get; set; }
        public virtual DbSet<RptCltD> RptCltD { get; set; }
        public virtual DbSet<RptCltF> RptCltF { get; set; }
        public virtual DbSet<RptCltItmD> RptCltItmD { get; set; }
        public virtual DbSet<RptCltItmN> RptCltItmN { get; set; }
        public virtual DbSet<RptCltM> RptCltM { get; set; }
        public virtual DbSet<RptCltN> RptCltN { get; set; }
        public virtual DbSet<RptCltP> RptCltP { get; set; }
        public virtual DbSet<RptCltW> RptCltW { get; set; }
        public virtual DbSet<RptCltY> RptCltY { get; set; }
        public virtual DbSet<RptDpt> RptDpt { get; set; }
        public virtual DbSet<RptFin> RptFin { get; set; }
        public virtual DbSet<RptHou> RptHou { get; set; }
        public virtual DbSet<RptItmD> RptItmD { get; set; }
        public virtual DbSet<RptItmF> RptItmF { get; set; }
        public virtual DbSet<RptItmM> RptItmM { get; set; }
        public virtual DbSet<RptItmN> RptItmN { get; set; }
        public virtual DbSet<RptItmP> RptItmP { get; set; }
        public virtual DbSet<RptItmW> RptItmW { get; set; }
        public virtual DbSet<RptItmY> RptItmY { get; set; }
        public virtual DbSet<RptSub> RptSub { get; set; }
        public virtual DbSet<RptVnd> RptVnd { get; set; }
        public virtual DbSet<RunTab> RunTab { get; set; }
        public virtual DbSet<SalBat> SalBat { get; set; }
        public virtual DbSet<SalDet> SalDet { get; set; }
        public virtual DbSet<SalDetSav> SalDetSav { get; set; }
        public virtual DbSet<SalHdr> SalHdr { get; set; }
        public virtual DbSet<SalHdrSav> SalHdrSav { get; set; }
        public virtual DbSet<SalReg> SalReg { get; set; }
        public virtual DbSet<SalRegSav> SalRegSav { get; set; }
        public virtual DbSet<SalTtl> SalTtl { get; set; }
        public virtual DbSet<SalTtlSav> SalTtlSav { get; set; }
        public virtual DbSet<SclCctDel> SclCctDel { get; set; }
        public virtual DbSet<SclCctTab> SclCctTab { get; set; }
        public virtual DbSet<SclCptDel> SclCptDel { get; set; }
        public virtual DbSet<SclCptTab> SclCptTab { get; set; }
        public virtual DbSet<SclCslDel> SclCslDel { get; set; }
        public virtual DbSet<SclCslTab> SclCslTab { get; set; }
        public virtual DbSet<SclCtxDel> SclCtxDel { get; set; }
        public virtual DbSet<SclCtxTab> SclCtxTab { get; set; }
        public virtual DbSet<SclDel> SclDel { get; set; }
        public virtual DbSet<SclNutDel> SclNutDel { get; set; }
        public virtual DbSet<SclNutTab> SclNutTab { get; set; }
        public virtual DbSet<SclStoDel> SclStoDel { get; set; }
        public virtual DbSet<SclStoTab> SclStoTab { get; set; }
        public virtual DbSet<SclTab> SclTab { get; set; }
        public virtual DbSet<SclTxtDel> SclTxtDel { get; set; }
        public virtual DbSet<SclTxtTab> SclTxtTab { get; set; }
        public virtual DbSet<SdpTab> SdpTab { get; set; }
        public virtual DbSet<SetupTab> SetupTab { get; set; }
        public virtual DbSet<ShfTab> ShfTab { get; set; }
        public virtual DbSet<StdTab> StdTab { get; set; }
        public virtual DbSet<StoTab> StoTab { get; set; }
        public virtual DbSet<SysTab> SysTab { get; set; }
        public virtual DbSet<TarTab> TarTab { get; set; }
        public virtual DbSet<TaskTab> TaskTab { get; set; }
        public virtual DbSet<TerTab> TerTab { get; set; }
        public virtual DbSet<TlzTab> TlzTab { get; set; }
        public virtual DbSet<TrsClk> TrsClk { get; set; }
        public virtual DbSet<TrsClt> TrsClt { get; set; }
        public virtual DbSet<TrsDpt> TrsDpt { get; set; }
        public virtual DbSet<TrsFin> TrsFin { get; set; }
        public virtual DbSet<TrsItm> TrsItm { get; set; }
        public virtual DbSet<TrsLog> TrsLog { get; set; }
        public virtual DbSet<TrsSub> TrsSub { get; set; }
        public virtual DbSet<TrsVnd> TrsVnd { get; set; }
        public virtual DbSet<TzsTab> TzsTab { get; set; }
        public virtual DbSet<UntTab> UntTab { get; set; }
        public virtual DbSet<VendorDel> VendorDel { get; set; }
        public virtual DbSet<VendorTab> VendorTab { get; set; }
        public virtual DbSet<WatchTab> WatchTab { get; set; }

        // Unable to generate entity type for table 'dbo.SHF_CHG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RB_CALCULATED'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_MENU_LIST'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["StoremanDatabase"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccTab>(entity =>
            {
                entity.HasKey(e => new { e.F1068, e.F1033, e.F01, e.F1034, e.F1253, e.F1000 })
                    .HasName("ACC_TAB_P1068");

                entity.ToTable("ACC_TAB");

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1033)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1253)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1128)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1129)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1130)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllowBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("ALLOW_BAT_P01");

                entity.ToTable("ALLOW_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F156)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F201).HasColumnType("money");

                entity.Property(e => e.F202).HasColumnType("datetime");

                entity.Property(e => e.F203).HasColumnType("datetime");

                entity.Property(e => e.F204)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F222)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F223)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AltDel>(entity =>
            {
                entity.HasKey(e => new { e.F154, e.F1000 })
                    .HasName("ALT_DEL_P154");

                entity.ToTable("ALT_DEL");

                entity.HasIndex(e => e.F01)
                    .HasName("ALT_DEL_F01");

                entity.HasIndex(e => e.F902)
                    .HasName("ALT_DEL_F902");

                entity.Property(e => e.F154)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1898)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2637)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AltTab>(entity =>
            {
                entity.HasKey(e => new { e.F154, e.F1000 })
                    .HasName("ALT_TAB_P154");

                entity.ToTable("ALT_TAB");

                entity.HasIndex(e => e.F01)
                    .HasName("ALT_TAB_F01");

                entity.HasIndex(e => e.F902)
                    .HasName("ALT_TAB_F902");

                entity.Property(e => e.F154)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1898)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2637)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssrtTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("ASSRT_TAB_P01");

                entity.ToTable("ASSRT_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2932)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BioDel>(entity =>
            {
                entity.HasKey(e => new { e.F1063, e.F1148 })
                    .HasName("BIO_DEL_P1063");

                entity.ToTable("BIO_DEL");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1581)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1849)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");
            });

            modelBuilder.Entity<BioTab>(entity =>
            {
                entity.HasKey(e => new { e.F1063, e.F1148 })
                    .HasName("BIO_TAB_P1063");

                entity.ToTable("BIO_TAB");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1581)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1849)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");
            });

            modelBuilder.Entity<BmpDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2926, e.F2927, e.F2928 })
                    .HasName("BMP_DEL_P01");

                entity.ToTable("BMP_DEL");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2926)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2927)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2928)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2929)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BmpTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2926, e.F2927, e.F2928 })
                    .HasName("BMP_TAB_P01");

                entity.ToTable("BMP_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2926)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2927)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2928)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2929)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BtlTab>(entity =>
            {
                entity.HasKey(e => e.F05)
                    .HasName("BTL_TAB_P05");

                entity.ToTable("BTL_TAB");

                entity.Property(e => e.F05).ValueGeneratedNever();

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1020)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1594)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1595).HasColumnType("money");

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F186).HasColumnType("money");

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatTab>(entity =>
            {
                entity.HasKey(e => e.F17)
                    .HasName("CAT_TAB_P17");

                entity.ToTable("CAT_TAB");

                entity.Property(e => e.F17).ValueGeneratedNever();

                entity.Property(e => e.F1023)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1943)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1944)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1945)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1967)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfgTab>(entity =>
            {
                entity.HasKey(e => new { e.F2845, e.F2846, e.F1000 })
                    .HasName("CFG_TAB_P2845");

                entity.ToTable("CFG_TAB");

                entity.Property(e => e.F2845)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F2846)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2847)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CkzTab>(entity =>
            {
                entity.HasKey(e => new { e.F2827, e.F1034 })
                    .HasName("CKZ_TAB_P2827");

                entity.ToTable("CKZ_TAB");

                entity.Property(e => e.F2827)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2826)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClfSdpTab>(entity =>
            {
                entity.HasKey(e => new { e.F1152, e.F04 })
                    .HasName("CLF_SDP_TAB_P1152");

                entity.ToTable("CLF_SDP_TAB");
            });

            modelBuilder.Entity<ClfTab>(entity =>
            {
                entity.HasKey(e => e.F1152)
                    .HasName("CLF_TAB_P1152");

                entity.ToTable("CLF_TAB");

                entity.Property(e => e.F1152).ValueGeneratedNever();

                entity.Property(e => e.F1073).HasColumnType("money");

                entity.Property(e => e.F1074)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1075).HasColumnType("money");

                entity.Property(e => e.F1174)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1270).HasColumnType("money");

                entity.Property(e => e.F1271)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1272)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1273)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1274)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1275).HasColumnType("money");

                entity.Property(e => e.F1277)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1279)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1282)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1284)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1286).HasColumnType("money");

                entity.Property(e => e.F1287)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1288)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1289).HasColumnType("money");

                entity.Property(e => e.F1291).HasColumnType("money");

                entity.Property(e => e.F1292)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1295)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1297).HasColumnType("money");

                entity.Property(e => e.F1298).HasColumnType("money");

                entity.Property(e => e.F1745)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1746)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1747)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1748)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1749)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1750)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1751)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1752)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1753)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1754)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1755)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1756)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1757)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1758)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1812)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1886)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2743)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClgTab>(entity =>
            {
                entity.HasKey(e => e.F1154)
                    .HasName("CLG_TAB_P1154");

                entity.ToTable("CLG_TAB");

                entity.Property(e => e.F1154)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1268)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClkDel>(entity =>
            {
                entity.HasKey(e => e.F1185)
                    .HasName("CLK_DEL_P1185");

                entity.ToTable("CLK_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLK_DEL_F1001");

                entity.HasIndex(e => e.F1126)
                    .HasName("CLK_DEL_F1126")
                    .IsUnique();

                entity.HasIndex(e => e.F1571)
                    .HasName("CLK_DEL_F1571");

                entity.Property(e => e.F1185).ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1141)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1143)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1144)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1145).HasColumnType("datetime");

                entity.Property(e => e.F1146)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1176)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1552)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1553).HasColumnType("datetime");

                entity.Property(e => e.F1554).HasColumnType("datetime");

                entity.Property(e => e.F1555).HasColumnType("datetime");

                entity.Property(e => e.F1557)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1558)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1559)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1560)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1561)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1562)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1563)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1564)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1565)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1571)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1585)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1586)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1587)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1588)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1589)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1590)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2587).HasColumnType("datetime");

                entity.Property(e => e.F2597)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2692)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2806)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2827)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2832)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2844)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClkTab>(entity =>
            {
                entity.HasKey(e => e.F1185)
                    .HasName("CLK_TAB_P1185");

                entity.ToTable("CLK_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLK_TAB_F1001");

                entity.HasIndex(e => e.F1126)
                    .HasName("CLK_TAB_F1126")
                    .IsUnique();

                entity.HasIndex(e => e.F1571)
                    .HasName("CLK_TAB_F1571");

                entity.Property(e => e.F1185).ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1141)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1143)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1144)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1145).HasColumnType("datetime");

                entity.Property(e => e.F1146)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1176)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1552)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1553).HasColumnType("datetime");

                entity.Property(e => e.F1554).HasColumnType("datetime");

                entity.Property(e => e.F1555).HasColumnType("datetime");

                entity.Property(e => e.F1557)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1558)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1559)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1560)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1561)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1562)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1563)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1564)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1565)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1571)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1585)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1586)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1587)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1588)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1589)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1590)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2587).HasColumnType("datetime");

                entity.Property(e => e.F2597)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2692)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2806)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2827)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2832)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2844)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CllDel>(entity =>
            {
                entity.HasKey(e => new { e.F1577, e.F1578 })
                    .HasName("CLL_DEL_P1577");

                entity.ToTable("CLL_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("CLL_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLL_DEL_F1001");

                entity.HasIndex(e => e.F1148)
                    .HasName("CLL_DEL_F1148");

                entity.HasIndex(e => e.F902)
                    .HasName("CLL_DEL_F902");

                entity.Property(e => e.F1577)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.F1578)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1898)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2966)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2967)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2971)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2972)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2973).HasColumnType("money");

                entity.Property(e => e.F2974).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CllTab>(entity =>
            {
                entity.HasKey(e => new { e.F1577, e.F1578 })
                    .HasName("CLL_TAB_P1577");

                entity.ToTable("CLL_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("CLL_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLL_TAB_F1001");

                entity.HasIndex(e => e.F1148)
                    .HasName("CLL_TAB_F1148");

                entity.HasIndex(e => e.F902)
                    .HasName("CLL_TAB_F902");

                entity.Property(e => e.F1577)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.F1578)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1898)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2966)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2967)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2971)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2972)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2973).HasColumnType("money");

                entity.Property(e => e.F2974).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClrTab>(entity =>
            {
                entity.HasKey(e => e.F1153)
                    .HasName("CLR_TAB_P1153");

                entity.ToTable("CLR_TAB");

                entity.Property(e => e.F1153).ValueGeneratedNever();

                entity.Property(e => e.F1162)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1165).HasColumnType("money");

                entity.Property(e => e.F1167)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1175)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1257).HasColumnType("money");

                entity.Property(e => e.F1258).HasColumnType("money");

                entity.Property(e => e.F1259).HasColumnType("money");

                entity.Property(e => e.F1260)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1762)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1877)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1878).HasColumnType("money");

                entity.Property(e => e.F1879).HasColumnType("money");

                entity.Property(e => e.F253).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClsAux>(entity =>
            {
                entity.HasKey(e => e.F2935)
                    .HasName("CLS_AUX_P2935");

                entity.ToTable("CLS_AUX");

                entity.Property(e => e.F2935)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F2936)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClsDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2935 })
                    .HasName("CLS_DEL_P01");

                entity.ToTable("CLS_DEL");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2935)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClsTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2935 })
                    .HasName("CLS_TAB_P01");

                entity.ToTable("CLS_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2935)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CltDel>(entity =>
            {
                entity.HasKey(e => e.F1148)
                    .HasName("CLT_DEL_P1148");

                entity.ToTable("CLT_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("CLT_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLT_DEL_F1001");

                entity.HasIndex(e => e.F1150)
                    .HasName("CLT_DEL_F1150");

                entity.HasIndex(e => e.F1152)
                    .HasName("CLT_DEL_F1152");

                entity.HasIndex(e => e.F1153)
                    .HasName("CLT_DEL_F1153");

                entity.HasIndex(e => e.F1154)
                    .HasName("CLT_DEL_F1154");

                entity.HasIndex(e => e.F1172)
                    .HasName("CLT_DEL_F1172");

                entity.HasIndex(e => e.F1573)
                    .HasName("CLT_DEL_F1573");

                entity.HasIndex(e => e.F902)
                    .HasName("CLT_DEL_F902");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1149)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1150)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1151)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1154)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1155)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1156)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1157)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1158)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1159)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1160)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1161)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1170)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1171)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1172)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1173)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1265).HasColumnType("datetime");

                entity.Property(e => e.F1501)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1502)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1504)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1520).HasColumnType("datetime");

                entity.Property(e => e.F1521).HasColumnType("datetime");

                entity.Property(e => e.F1522).HasColumnType("datetime");

                entity.Property(e => e.F1523)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1524)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1525)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1526).HasColumnType("datetime");

                entity.Property(e => e.F1527)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1528)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1529)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1550)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1573)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1574)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1575).HasColumnType("datetime");

                entity.Property(e => e.F1576)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1581)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1582)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1583).HasColumnType("datetime");

                entity.Property(e => e.F1584).HasColumnType("datetime");

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1697)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1777)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1778)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F1809)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1950)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1957)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2597)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2602)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F2615)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2617).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2743)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2808).HasColumnType("money");

                entity.Property(e => e.F2810).HasColumnType("money");

                entity.Property(e => e.F2812).HasColumnType("money");

                entity.Property(e => e.F2875)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2889)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2899)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2900)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F2901).HasColumnType("datetime");

                entity.Property(e => e.F2904)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2934)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F2977)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2978)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CltItmDel>(entity =>
            {
                entity.HasKey(e => new { e.F1148, e.F01 })
                    .HasName("CLT_ITM_DEL_P1148");

                entity.ToTable("CLT_ITM_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLT_ITM_DEL_F1001");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1005)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1714)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1780)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2604).HasColumnType("money");

                entity.Property(e => e.F2606).HasColumnType("datetime");

                entity.Property(e => e.F2607).HasColumnType("datetime");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F63).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CltItmTab>(entity =>
            {
                entity.HasKey(e => new { e.F1148, e.F01 })
                    .HasName("CLT_ITM_TAB_P1148");

                entity.ToTable("CLT_ITM_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLT_ITM_TAB_F1001");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1005)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1714)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1780)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2604).HasColumnType("money");

                entity.Property(e => e.F2606).HasColumnType("datetime");

                entity.Property(e => e.F2607).HasColumnType("datetime");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F63).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CltTab>(entity =>
            {
                entity.HasKey(e => e.F1148)
                    .HasName("CLT_TAB_P1148");

                entity.ToTable("CLT_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("CLT_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("CLT_TAB_F1001");

                entity.HasIndex(e => e.F1150)
                    .HasName("CLT_TAB_F1150");

                entity.HasIndex(e => e.F1152)
                    .HasName("CLT_TAB_F1152");

                entity.HasIndex(e => e.F1153)
                    .HasName("CLT_TAB_F1153");

                entity.HasIndex(e => e.F1154)
                    .HasName("CLT_TAB_F1154");

                entity.HasIndex(e => e.F1172)
                    .HasName("CLT_TAB_F1172");

                entity.HasIndex(e => e.F1573)
                    .HasName("CLT_TAB_F1573");

                entity.HasIndex(e => e.F902)
                    .HasName("CLT_TAB_F902");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1149)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1150)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1151)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1154)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1155)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1156)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1157)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1158)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1159)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1160)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1161)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1170)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1171)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1172)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1173)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1265).HasColumnType("datetime");

                entity.Property(e => e.F1501)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1502)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1504)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1520).HasColumnType("datetime");

                entity.Property(e => e.F1521).HasColumnType("datetime");

                entity.Property(e => e.F1522).HasColumnType("datetime");

                entity.Property(e => e.F1523)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1524)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1525)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1526).HasColumnType("datetime");

                entity.Property(e => e.F1527)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1528)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1529)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1550)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1573)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1574)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1575).HasColumnType("datetime");

                entity.Property(e => e.F1576)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1581)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1582)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1583).HasColumnType("datetime");

                entity.Property(e => e.F1584).HasColumnType("datetime");

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1697)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1777)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1778)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F1809)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1950)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1957)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2597)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2602)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F2615)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2617).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2743)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2808).HasColumnType("money");

                entity.Property(e => e.F2810).HasColumnType("money");

                entity.Property(e => e.F2812).HasColumnType("money");

                entity.Property(e => e.F2875)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2889)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2899)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2900)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F2901).HasColumnType("datetime");

                entity.Property(e => e.F2904)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2934)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F2977)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2978)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000, e.F27, e.F1184 })
                    .HasName("COST_DEL_P01");

                entity.ToTable("COST_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("COST_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("COST_DEL_F1001");

                entity.HasIndex(e => e.F26)
                    .HasName("COST_DEL_F26");

                entity.HasIndex(e => e.F27)
                    .HasName("COST_DEL_F27");

                entity.HasIndex(e => e.F902)
                    .HasName("COST_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1037)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1038)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1121).HasColumnType("money");

                entity.Property(e => e.F1140).HasColumnType("money");

                entity.Property(e => e.F120).HasColumnType("money");

                entity.Property(e => e.F127)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F134).HasColumnType("datetime");

                entity.Property(e => e.F151).HasColumnType("money");

                entity.Property(e => e.F152).HasColumnType("datetime");

                entity.Property(e => e.F156)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F165)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1658).HasColumnType("money");

                entity.Property(e => e.F1659)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1660)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1661)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1662).HasColumnType("money");

                entity.Property(e => e.F1664).HasColumnType("money");

                entity.Property(e => e.F1666).HasColumnType("money");

                entity.Property(e => e.F1668)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1669).HasColumnType("money");

                entity.Property(e => e.F1766).HasColumnType("money");

                entity.Property(e => e.F1791)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1792)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1797).HasColumnType("money");

                entity.Property(e => e.F1798).HasColumnType("money");

                entity.Property(e => e.F185).HasColumnType("money");

                entity.Property(e => e.F1875)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F195).HasColumnType("money");

                entity.Property(e => e.F196).HasColumnType("money");

                entity.Property(e => e.F1961)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1973)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1974)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1975)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1976)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F201).HasColumnType("money");

                entity.Property(e => e.F202).HasColumnType("datetime");

                entity.Property(e => e.F203).HasColumnType("datetime");

                entity.Property(e => e.F204)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F212)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F216).HasColumnType("datetime");

                entity.Property(e => e.F219).HasColumnType("datetime");

                entity.Property(e => e.F220)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F222)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F223)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F225).HasColumnType("money");

                entity.Property(e => e.F227).HasColumnType("datetime");

                entity.Property(e => e.F229).HasColumnType("datetime");

                entity.Property(e => e.F230).HasColumnType("datetime");

                entity.Property(e => e.F231)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F233).HasColumnType("money");

                entity.Property(e => e.F234).HasColumnType("datetime");

                entity.Property(e => e.F235).HasColumnType("datetime");

                entity.Property(e => e.F236)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2601)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2626).HasColumnType("money");

                entity.Property(e => e.F2699).HasColumnType("datetime");

                entity.Property(e => e.F28)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F39).HasColumnType("datetime");

                entity.Property(e => e.F90)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000, e.F27, e.F1184 })
                    .HasName("COST_TAB_P01");

                entity.ToTable("COST_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("COST_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("COST_TAB_F1001");

                entity.HasIndex(e => e.F26)
                    .HasName("COST_TAB_F26");

                entity.HasIndex(e => e.F27)
                    .HasName("COST_TAB_F27");

                entity.HasIndex(e => e.F902)
                    .HasName("COST_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1037)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1038)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1121).HasColumnType("money");

                entity.Property(e => e.F1140).HasColumnType("money");

                entity.Property(e => e.F120).HasColumnType("money");

                entity.Property(e => e.F127)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F134).HasColumnType("datetime");

                entity.Property(e => e.F151).HasColumnType("money");

                entity.Property(e => e.F152).HasColumnType("datetime");

                entity.Property(e => e.F156)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F165)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1658).HasColumnType("money");

                entity.Property(e => e.F1659)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1660)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1661)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1662).HasColumnType("money");

                entity.Property(e => e.F1664).HasColumnType("money");

                entity.Property(e => e.F1666).HasColumnType("money");

                entity.Property(e => e.F1668)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1669).HasColumnType("money");

                entity.Property(e => e.F1766).HasColumnType("money");

                entity.Property(e => e.F1791)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1792)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1797).HasColumnType("money");

                entity.Property(e => e.F1798).HasColumnType("money");

                entity.Property(e => e.F185).HasColumnType("money");

                entity.Property(e => e.F1875)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F195).HasColumnType("money");

                entity.Property(e => e.F196).HasColumnType("money");

                entity.Property(e => e.F1961)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1973)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1974)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1975)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1976)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F201).HasColumnType("money");

                entity.Property(e => e.F202).HasColumnType("datetime");

                entity.Property(e => e.F203).HasColumnType("datetime");

                entity.Property(e => e.F204)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F212)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F216).HasColumnType("datetime");

                entity.Property(e => e.F219).HasColumnType("datetime");

                entity.Property(e => e.F220)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F222)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F223)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F225).HasColumnType("money");

                entity.Property(e => e.F227).HasColumnType("datetime");

                entity.Property(e => e.F229).HasColumnType("datetime");

                entity.Property(e => e.F230).HasColumnType("datetime");

                entity.Property(e => e.F231)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F233).HasColumnType("money");

                entity.Property(e => e.F234).HasColumnType("datetime");

                entity.Property(e => e.F235).HasColumnType("datetime");

                entity.Property(e => e.F236)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2601)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2626).HasColumnType("money");

                entity.Property(e => e.F2699).HasColumnType("datetime");

                entity.Property(e => e.F28)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F39).HasColumnType("datetime");

                entity.Property(e => e.F90)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CpnTab>(entity =>
            {
                entity.HasKey(e => new { e.F2034, e.F1000 })
                    .HasName("CPN_TAB_P2034");

                entity.ToTable("CPN_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2036)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2039)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataReg>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1031, e.F1056, e.F1068, e.F154, e.F1034 })
                    .HasName("DATA_REG_P254");

                entity.ToTable("DATA_REG");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F154)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<DelvTab>(entity =>
            {
                entity.HasKey(e => new { e.F27, e.F1000, e.F2659, e.F2663, e.F2664, e.F2665, e.F2656, e.F2655 })
                    .HasName("DELV_TAB_P27");

                entity.ToTable("DELV_TAB");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2659)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2663)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2656)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2655)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2658)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2662)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptTab>(entity =>
            {
                entity.HasKey(e => e.F03)
                    .HasName("DEPT_TAB_P03");

                entity.ToTable("DEPT_TAB");

                entity.Property(e => e.F03).ValueGeneratedNever();

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1132)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F121)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1894)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1967)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F238)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F239).HasColumnType("money");

                entity.Property(e => e.F240).HasColumnType("money");

                entity.Property(e => e.F241).HasColumnType("money");

                entity.Property(e => e.F242).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F78)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrilFile>(entity =>
            {
                entity.HasKey(e => new { e.F1000, e.F1597 })
                    .HasName("Dril_File_P1000");

                entity.ToTable("Dril_File");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1597)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1606)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1607)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1608)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrilPage>(entity =>
            {
                entity.HasKey(e => new { e.F1597, e.F1598 })
                    .HasName("Dril_Page_P1597");

                entity.ToTable("Dril_Page");

                entity.Property(e => e.F1597)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1599)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1600)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1601)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1602)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1604)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1605)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1609)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1698)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DsdDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("DSD_DEL_P01");

                entity.ToTable("DSD_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("DSD_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("DSD_DEL_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("DSD_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F68)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F69)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DsdTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("DSD_TAB_P01");

                entity.ToTable("DSD_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("DSD_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("DSD_TAB_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("DSD_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F68)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F69)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DssTab>(entity =>
            {
                entity.HasKey(e => new { e.F2729, e.F2730, e.F2731 })
                    .HasName("DSS_TAB_P2729");

                entity.ToTable("DSS_TAB");

                entity.Property(e => e.F2729)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2730)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2731)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2728)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2732).HasColumnType("datetime");

                entity.Property(e => e.F2733)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclDel>(entity =>
            {
                entity.HasKey(e => new { e.F164, e.F1033, e.F01, e.F1031, e.F1034, e.F1000 })
                    .HasName("ECL_DEL_P164");

                entity.ToTable("ECL_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("ECL_DEL_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("ECL_DEL_F902");

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1033)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EclTab>(entity =>
            {
                entity.HasKey(e => new { e.F164, e.F1033, e.F01, e.F1031, e.F1034, e.F1000 })
                    .HasName("ECL_TAB_P164");

                entity.ToTable("ECL_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("ECL_TAB_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("ECL_TAB_F902");

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1033)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExcTab>(entity =>
            {
                entity.HasKey(e => e.F1511)
                    .HasName("EXC_TAB_P1511");

                entity.ToTable("EXC_TAB");

                entity.Property(e => e.F1511).ValueGeneratedNever();

                entity.Property(e => e.F1512)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1513)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1897)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FamTab>(entity =>
            {
                entity.HasKey(e => e.F16)
                    .HasName("FAM_TAB_P16");

                entity.ToTable("FAM_TAB");

                entity.Property(e => e.F16).ValueGeneratedNever();

                entity.Property(e => e.F1040)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1967)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FbbackBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("FBBACK_BAT_P01");

                entity.ToTable("FBBACK_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1662).HasColumnType("money");

                entity.Property(e => e.F1664).HasColumnType("money");

                entity.Property(e => e.F1666).HasColumnType("money");

                entity.Property(e => e.F1668)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1669).HasColumnType("money");
            });

            modelBuilder.Entity<FcostBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("FCOST_BAT_P01");

                entity.ToTable("FCOST_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1121).HasColumnType("money");

                entity.Property(e => e.F120).HasColumnType("money");

                entity.Property(e => e.F185).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F212)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2626).HasColumnType("money");

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F39).HasColumnType("datetime");
            });

            modelBuilder.Entity<FcstbrkBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("FCSTBRK_BAT_P01");

                entity.ToTable("FCSTBRK_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1661)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1975)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F219).HasColumnType("datetime");

                entity.Property(e => e.F225).HasColumnType("money");

                entity.Property(e => e.F227).HasColumnType("datetime");
            });

            modelBuilder.Entity<FctTab>(entity =>
            {
                entity.HasKey(e => new { e.F1063, e.F1000 })
                    .HasName("FCT_TAB_P1063");

                entity.ToTable("FCT_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1050)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1051)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1052)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1053)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1064)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1082)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1083)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1084)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1085)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1086)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1088)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1089)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1090)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1091)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1092)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1895)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1897)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F239).HasColumnType("money");

                entity.Property(e => e.F240).HasColumnType("money");

                entity.Property(e => e.F241).HasColumnType("money");

                entity.Property(e => e.F242).HasColumnType("money");

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F85)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FczTab>(entity =>
            {
                entity.HasKey(e => new { e.F1063, e.F1034, e.F1000 })
                    .HasName("FCZ_TAB_P1063");

                entity.ToTable("FCZ_TAB");

                entity.HasIndex(e => e.F1034)
                    .HasName("FCZ_TAB_F1034");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1065)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FdiscBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("FDISC_BAT_P01");

                entity.ToTable("FDISC_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1658).HasColumnType("money");

                entity.Property(e => e.F1659)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1973)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F229).HasColumnType("datetime");

                entity.Property(e => e.F230).HasColumnType("datetime");

                entity.Property(e => e.F231)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeclBat>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F164, e.F1033, e.F01, e.F1031, e.F1034, e.F1000 })
                    .HasName("FECL_BAT_P902");

                entity.ToTable("FECL_BAT");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1033)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<FgcostBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("FGCOST_BAT_P01");

                entity.ToTable("FGCOST_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1037)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F127)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F165)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1766).HasColumnType("money");

                entity.Property(e => e.F1791)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1792)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1797).HasColumnType("money");

                entity.Property(e => e.F1798).HasColumnType("money");

                entity.Property(e => e.F1875)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1961)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1976)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F216).HasColumnType("datetime");

                entity.Property(e => e.F220)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2601)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2699).HasColumnType("datetime");

                entity.Property(e => e.F28)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F90)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FgpriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("FGPRICE_BAT_P01");

                entity.ToTable("FGPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F109)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1135)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F122)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1233).HasColumnType("money");

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F166).HasColumnType("money");

                entity.Property(e => e.F175)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1799)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1800)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1885).HasColumnType("money");

                entity.Property(e => e.F1935).HasColumnType("money");

                entity.Property(e => e.F2694)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2695)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2696)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F41)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F43)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FilTab>(entity =>
            {
                entity.HasKey(e => e.F1101)
                    .HasName("FIL_TAB_P1101");

                entity.ToTable("FIL_TAB");

                entity.Property(e => e.F1101).ValueGeneratedNever();

                entity.Property(e => e.F1025)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1026)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1027)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1028)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinstoreBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("FINSTORE_BAT_P01");

                entity.ToTable("FINSTORE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1133).HasColumnType("money");

                entity.Property(e => e.F1194)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1195)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1196).HasColumnType("money");

                entity.Property(e => e.F1198).HasColumnType("money");

                entity.Property(e => e.F1201)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1216).HasColumnType("datetime");

                entity.Property(e => e.F1217).HasColumnType("datetime");

                entity.Property(e => e.F1222).HasColumnType("money");

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F59)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FobjBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902 })
                    .HasName("FOBJ_BAT_P01");

                entity.ToTable("FOBJ_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1118)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.F1119)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F155)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1737)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1738)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1781)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1782)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F180)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F193)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1939)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1940)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1941)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1942)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1957)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F1958)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1959)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1960)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1962)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F213)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F214)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F218)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F22)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F23)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F255)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F2600)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2693)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2789)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F29)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F93)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FpidBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F383 })
                    .HasName("FPID_BAT_P01");

                entity.ToTable("FPID_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FposBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000 })
                    .HasName("FPOS_BAT_P01");

                entity.ToTable("FPOS_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F09).HasColumnType("datetime");

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F107)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F110)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1136)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F121)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F123)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1236)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F149)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F158)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F159)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F160)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F161)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F162)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F173)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1735)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F174)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F176)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1786)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F188)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F189)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1892)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1933).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F210).HasColumnType("money");

                entity.Property(e => e.F211).HasColumnType("datetime");

                entity.Property(e => e.F2608)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2930)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F302)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F303).HasColumnType("datetime");

                entity.Property(e => e.F304)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F388)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F397)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F40)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F60).HasColumnType("money");

                entity.Property(e => e.F61).HasColumnType("money");

                entity.Property(e => e.F78)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F83)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F84)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F85)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F86)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F87)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F92)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FpriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("FPRICE_BAT_P01");

                entity.ToTable("FPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1005)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F111).HasColumnType("money");

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F130)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F133).HasColumnType("datetime");

                entity.Property(e => e.F140).HasColumnType("money");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1714)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1768)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1770)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1934).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F205).HasColumnType("money");

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F36)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F63).HasColumnType("money");
            });

            modelBuilder.Entity<FredeemBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("FREDEEM_BAT_P01");

                entity.ToTable("FREDEEM_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1229).HasColumnType("money");

                entity.Property(e => e.F1234).HasColumnType("datetime");

                entity.Property(e => e.F1235).HasColumnType("datetime");

                entity.Property(e => e.F2744)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FspriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("FSPRICE_BAT_P01");

                entity.ToTable("FSPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1220).HasColumnType("money");

                entity.Property(e => e.F136).HasColumnType("money");

                entity.Property(e => e.F137).HasColumnType("datetime");

                entity.Property(e => e.F138).HasColumnType("datetime");

                entity.Property(e => e.F139).HasColumnType("money");

                entity.Property(e => e.F144)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F145)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F146)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F148).HasColumnType("money");

                entity.Property(e => e.F179)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1955).HasColumnType("money");

                entity.Property(e => e.F1956).HasColumnType("money");

                entity.Property(e => e.F2668)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F42)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FtpriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("FTPRICE_BAT_P01");

                entity.ToTable("FTPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1186).HasColumnType("money");

                entity.Property(e => e.F1188).HasColumnType("money");

                entity.Property(e => e.F1218).HasColumnType("money");

                entity.Property(e => e.F181).HasColumnType("money");

                entity.Property(e => e.F183).HasColumnType("datetime");

                entity.Property(e => e.F184).HasColumnType("datetime");

                entity.Property(e => e.F1953).HasColumnType("money");

                entity.Property(e => e.F1954).HasColumnType("money");

                entity.Property(e => e.F221)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2667)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderBat>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_BAT_P902");

                entity.ToTable("HEADER_BAT");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderDct>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_DCT_P902");

                entity.ToTable("HEADER_DCT");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderDel>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_DEL_P902");

                entity.ToTable("HEADER_DEL");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderExe>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_EXE_P902");

                entity.ToTable("HEADER_EXE");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderIns>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_INS_P902");

                entity.ToTable("HEADER_INS");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderOld>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_OLD_P902");

                entity.ToTable("HEADER_OLD");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderSav>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F903 })
                    .HasName("HEADER_SAV_P902");

                entity.ToTable("HEADER_SAV");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F901)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F904)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F905)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F906)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F907).HasColumnType("datetime");

                entity.Property(e => e.F908)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F909).HasColumnType("datetime");

                entity.Property(e => e.F910)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F911).HasColumnType("datetime");

                entity.Property(e => e.F912)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F913)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F914)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F915)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F916)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F919)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F920)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F921)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F922)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.F930)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F932)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HookTab>(entity =>
            {
                entity.HasKey(e => new { e.F1700, e.F1701, e.F1702, e.F1703, e.F1704, e.F1705 })
                    .HasName("HOOK_TAB_P1700");

                entity.ToTable("HOOK_TAB");

                entity.Property(e => e.F1700)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1701)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1702)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1703)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1704)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1705)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvBat>(entity =>
            {
                entity.HasKey(e => e.F1032)
                    .HasName("INV_BAT_P1032");

                entity.ToTable("INV_BAT");

                entity.Property(e => e.F1032).ValueGeneratedNever();

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2641)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2643).HasColumnType("money");

                entity.Property(e => e.F2645).HasColumnType("money");

                entity.Property(e => e.F2647).HasColumnType("datetime");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvHdr>(entity =>
            {
                entity.HasKey(e => e.F1032)
                    .HasName("INV_HDR_P1032");

                entity.ToTable("INV_HDR");

                entity.Property(e => e.F1032).ValueGeneratedNever();

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2641)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2643).HasColumnType("money");

                entity.Property(e => e.F2645).HasColumnType("money");

                entity.Property(e => e.F2647).HasColumnType("datetime");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvReg>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1101 })
                    .HasName("INV_REG_P1032");

                entity.ToTable("INV_REG");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1007).HasColumnType("money");

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1140).HasColumnType("money");

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F151).HasColumnType("money");

                entity.Property(e => e.F1690)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1707).HasColumnType("money");

                entity.Property(e => e.F1708).HasColumnType("money");

                entity.Property(e => e.F1813).HasColumnType("money");

                entity.Property(e => e.F1875)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F195).HasColumnType("money");

                entity.Property(e => e.F196).HasColumnType("money");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2640).HasColumnType("money");

                entity.Property(e => e.F2641)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2643).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvTtl>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1034 })
                    .HasName("INV_TTL_P1032");

                entity.ToTable("INV_TTL");

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1093).HasColumnType("money");

                entity.Property(e => e.F1094).HasColumnType("money");

                entity.Property(e => e.F1095).HasColumnType("money");

                entity.Property(e => e.F1096).HasColumnType("money");

                entity.Property(e => e.F1097).HasColumnType("money");

                entity.Property(e => e.F1098).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<ItdDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2834, e.F1000 })
                    .HasName("ITD_DEL_P01");

                entity.ToTable("ITD_DEL");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2834)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2835)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItdTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2834, e.F1000 })
                    .HasName("ITD_TAB_P01");

                entity.ToTable("ITD_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2834)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2835)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItzDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1034, e.F1000 })
                    .HasName("ITZ_DEL_P01");

                entity.ToTable("ITZ_DEL");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2823)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItzTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1034, e.F1000 })
                    .HasName("ITZ_TAB_P01");

                entity.ToTable("ITZ_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2823)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KitDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F126, e.F1507 })
                    .HasName("KIT_DEL_P01");

                entity.ToTable("KIT_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("KIT_DEL_F1001");

                entity.HasIndex(e => e.F1507)
                    .HasName("KIT_DEL_F1507");

                entity.HasIndex(e => e.F902)
                    .HasName("KIT_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1507)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1509)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KitTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F126, e.F1507 })
                    .HasName("KIT_TAB_P01");

                entity.ToTable("KIT_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("KIT_TAB_F1001");

                entity.HasIndex(e => e.F1507)
                    .HasName("KIT_TAB_F1507");

                entity.HasIndex(e => e.F902)
                    .HasName("KIT_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1507)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1509)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabelTab>(entity =>
            {
                entity.HasKey(e => new { e.F1148, e.F95, e.F01, e.F126 })
                    .HasName("LABEL_TAB_P1148");

                entity.ToTable("LABEL_TAB");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F95)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F111).HasColumnType("money");

                entity.Property(e => e.F113)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F117)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F130)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F140).HasColumnType("money");

                entity.Property(e => e.F1401)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1402)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F154)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F155)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F166).HasColumnType("money");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1806).HasColumnType("money");

                entity.Property(e => e.F22)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F23)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F25)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F255)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F2588)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F29)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F36)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F63).HasColumnType("money");

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabelTpl>(entity =>
            {
                entity.HasKey(e => new { e.F2783, e.F113 })
                    .HasName("LABEL_TPL_P2783");

                entity.ToTable("LABEL_TPL");

                entity.Property(e => e.F2783)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F113)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F95)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LikeTab>(entity =>
            {
                entity.HasKey(e => e.F122)
                    .HasName("LIKE_TAB_P122");

                entity.ToTable("LIKE_TAB");

                entity.Property(e => e.F122)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F2790)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LnkTab>(entity =>
            {
                entity.HasKey(e => new { e.F1000, e.F1056, e.F1057 })
                    .HasName("LNK_TAB_P1000");

                entity.ToTable("LNK_TAB");

                entity.HasIndex(e => e.F1056)
                    .HasName("LNK_TAB_F1056");

                entity.HasIndex(e => e.F1057)
                    .HasName("LNK_TAB_F1057");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000, e.F117 })
                    .HasName("LOC_DEL_P01");

                entity.ToTable("LOC_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("LOC_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("LOC_DEL_F1001");

                entity.HasIndex(e => e.F117)
                    .HasName("LOC_DEL_F117");

                entity.HasIndex(e => e.F902)
                    .HasName("LOC_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F117)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F116)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F118)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F157)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F187)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F190)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1963)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F25)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2851)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F95)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000, e.F117 })
                    .HasName("LOC_TAB_P01");

                entity.ToTable("LOC_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("LOC_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("LOC_TAB_F1001");

                entity.HasIndex(e => e.F117)
                    .HasName("LOC_TAB_F117");

                entity.HasIndex(e => e.F902)
                    .HasName("LOC_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F117)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F116)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F118)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F157)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F187)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F190)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1963)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F25)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2851)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F95)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LstHdr>(entity =>
            {
                entity.HasKey(e => e.F2891)
                    .HasName("LST_HDR_P2891");

                entity.ToTable("LST_HDR");

                entity.HasIndex(e => e.F1148)
                    .HasName("LST_HDR_F1148");

                entity.Property(e => e.F2891)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2892)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LstReg>(entity =>
            {
                entity.HasKey(e => new { e.F2891, e.F01 })
                    .HasName("LST_REG_P2891");

                entity.ToTable("LST_REG");

                entity.Property(e => e.F2891)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1071)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");
            });

            modelBuilder.Entity<LvlTab>(entity =>
            {
                entity.HasKey(e => e.F126)
                    .HasName("LVL_TAB_P126");

                entity.ToTable("LVL_TAB");

                entity.Property(e => e.F126).ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1017)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MixDel>(entity =>
            {
                entity.HasKey(e => e.F32)
                    .HasName("MIX_DEL_P32");

                entity.ToTable("MIX_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("MIX_DEL_F1001");

                entity.Property(e => e.F32).ValueGeneratedNever();

                entity.Property(e => e.F1019)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MixTab>(entity =>
            {
                entity.HasKey(e => e.F32)
                    .HasName("MIX_TAB_P32");

                entity.ToTable("MIX_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("MIX_TAB_F1001");

                entity.Property(e => e.F32).ValueGeneratedNever();

                entity.Property(e => e.F1019)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModItmTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2765, e.F2882 })
                    .HasName("MOD_ITM_TAB_P01");

                entity.ToTable("MOD_ITM_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2882)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2886)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2887)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2888)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2765 })
                    .HasName("MOD_TAB_P01");

                entity.ToTable("MOD_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2766)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2767)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2768)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F2769)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NacsTab>(entity =>
            {
                entity.HasKey(e => e.F2931)
                    .HasName("NACS_TAB_P2931");

                entity.ToTable("NACS_TAB");

                entity.Property(e => e.F2931).ValueGeneratedNever();

                entity.Property(e => e.F2933)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OallowBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("OALLOW_BAT_P01");

                entity.ToTable("OALLOW_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F156)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F201).HasColumnType("money");

                entity.Property(e => e.F202).HasColumnType("datetime");

                entity.Property(e => e.F203).HasColumnType("datetime");

                entity.Property(e => e.F204)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F222)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F223)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObbackBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("OBBACK_BAT_P01");

                entity.ToTable("OBBACK_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1662).HasColumnType("money");

                entity.Property(e => e.F1664).HasColumnType("money");

                entity.Property(e => e.F1666).HasColumnType("money");

                entity.Property(e => e.F1668)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1669).HasColumnType("money");
            });

            modelBuilder.Entity<ObjDel>(entity =>
            {
                entity.HasKey(e => e.F01)
                    .HasName("OBJ_DEL_P01");

                entity.ToTable("OBJ_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("OBJ_DEL_F1001");

                entity.HasIndex(e => e.F16)
                    .HasName("OBJ_DEL_F16");

                entity.HasIndex(e => e.F17)
                    .HasName("OBJ_DEL_F17");

                entity.HasIndex(e => e.F18)
                    .HasName("OBJ_DEL_F18");

                entity.HasIndex(e => e.F193)
                    .HasName("OBJ_DEL_F193");

                entity.HasIndex(e => e.F902)
                    .HasName("OBJ_DEL_F902");

                entity.HasIndex(e => e.F93)
                    .HasName("OBJ_DEL_F93");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1118)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.F1119)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F155)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1737)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1738)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1781)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1782)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F180)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F193)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1939)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1940)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1941)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1942)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1957)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F1958)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1959)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1960)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1962)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F213)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F214)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F218)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F22)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F23)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F255)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F2600)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2693)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2789)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F29)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F93)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObjTab>(entity =>
            {
                entity.HasKey(e => e.F01)
                    .HasName("OBJ_TAB_P01");

                entity.ToTable("OBJ_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("OBJ_TAB_F1001");

                entity.HasIndex(e => e.F16)
                    .HasName("OBJ_TAB_F16");

                entity.HasIndex(e => e.F17)
                    .HasName("OBJ_TAB_F17");

                entity.HasIndex(e => e.F18)
                    .HasName("OBJ_TAB_F18");

                entity.HasIndex(e => e.F193)
                    .HasName("OBJ_TAB_F193");

                entity.HasIndex(e => e.F902)
                    .HasName("OBJ_TAB_F902");

                entity.HasIndex(e => e.F93)
                    .HasName("OBJ_TAB_F93");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1118)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.F1119)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F155)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1737)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1738)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1781)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1782)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F180)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F193)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1939)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1940)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1941)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1942)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1957)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F1958)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1959)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1960)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1962)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F213)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F214)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F218)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F22)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F23)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F255)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F2600)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2693)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2789)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F29)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F93)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OcostBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("OCOST_BAT_P01");

                entity.ToTable("OCOST_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1121).HasColumnType("money");

                entity.Property(e => e.F120).HasColumnType("money");

                entity.Property(e => e.F185).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F212)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2626).HasColumnType("money");

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F39).HasColumnType("datetime");
            });

            modelBuilder.Entity<OcstbrkBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("OCSTBRK_BAT_P01");

                entity.ToTable("OCSTBRK_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1661)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1975)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F219).HasColumnType("datetime");

                entity.Property(e => e.F225).HasColumnType("money");

                entity.Property(e => e.F227).HasColumnType("datetime");
            });

            modelBuilder.Entity<OdiscBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("ODISC_BAT_P01");

                entity.ToTable("ODISC_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1658).HasColumnType("money");

                entity.Property(e => e.F1659)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1973)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F229).HasColumnType("datetime");

                entity.Property(e => e.F230).HasColumnType("datetime");

                entity.Property(e => e.F231)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OeclBat>(entity =>
            {
                entity.HasKey(e => new { e.F902, e.F164, e.F1033, e.F01, e.F1031, e.F1034, e.F1000 })
                    .HasName("OECL_BAT_P902");

                entity.ToTable("OECL_BAT");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1033)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<OfrTab>(entity =>
            {
                entity.HasKey(e => new { e.F1148, e.F2817, e.F301 })
                    .HasName("OFR_TAB_P1148");

                entity.ToTable("OFR_TAB");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2817)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F301)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1525)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2813)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2814)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2815)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2818).HasColumnType("datetime");

                entity.Property(e => e.F2819).HasColumnType("datetime");

                entity.Property(e => e.F2820)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F302)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F303).HasColumnType("datetime");

                entity.Property(e => e.F304)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F305).HasColumnType("money");

                entity.Property(e => e.F307).HasColumnType("money");

                entity.Property(e => e.F308)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F309)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F310)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F312).HasColumnType("datetime");

                entity.Property(e => e.F313)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F315)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F317)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F319)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F321)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F385)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OgcostBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("OGCOST_BAT_P01");

                entity.ToTable("OGCOST_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1037)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F127)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F165)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1766).HasColumnType("money");

                entity.Property(e => e.F1791)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1792)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1797).HasColumnType("money");

                entity.Property(e => e.F1798).HasColumnType("money");

                entity.Property(e => e.F1875)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1961)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1976)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F216).HasColumnType("datetime");

                entity.Property(e => e.F220)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2601)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2699).HasColumnType("datetime");

                entity.Property(e => e.F28)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F90)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OgpriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("OGPRICE_BAT_P01");

                entity.ToTable("OGPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F109)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1135)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F122)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1233).HasColumnType("money");

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F166).HasColumnType("money");

                entity.Property(e => e.F175)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1799)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1800)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1885).HasColumnType("money");

                entity.Property(e => e.F1935).HasColumnType("money");

                entity.Property(e => e.F2694)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2695)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2696)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F41)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F43)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OinstoreBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("OINSTORE_BAT_P01");

                entity.ToTable("OINSTORE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1133).HasColumnType("money");

                entity.Property(e => e.F1194)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1195)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1196).HasColumnType("money");

                entity.Property(e => e.F1198).HasColumnType("money");

                entity.Property(e => e.F1201)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1216).HasColumnType("datetime");

                entity.Property(e => e.F1217).HasColumnType("datetime");

                entity.Property(e => e.F1222).HasColumnType("money");

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F59)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OobjBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902 })
                    .HasName("OOBJ_BAT_P01");

                entity.ToTable("OOBJ_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1118)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.F1119)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F155)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1737)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1738)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1781)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1782)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F180)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F193)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1939)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1940)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1941)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1942)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1957)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F1958)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1959)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1960)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1962)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F213)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F214)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F218)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F22)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F23)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F255)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F2600)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2693)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2789)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F29)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F93)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpidBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F383 })
                    .HasName("OPID_BAT_P01");

                entity.ToTable("OPID_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OposBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000 })
                    .HasName("OPOS_BAT_P01");

                entity.ToTable("OPOS_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F09).HasColumnType("datetime");

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F107)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F110)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1136)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F121)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F123)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1236)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F149)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F158)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F159)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F160)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F161)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F162)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F173)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1735)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F174)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F176)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1786)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F188)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F189)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1892)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1933).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F210).HasColumnType("money");

                entity.Property(e => e.F211).HasColumnType("datetime");

                entity.Property(e => e.F2608)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2930)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F302)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F303).HasColumnType("datetime");

                entity.Property(e => e.F304)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F388)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F397)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F40)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F60).HasColumnType("money");

                entity.Property(e => e.F61).HasColumnType("money");

                entity.Property(e => e.F78)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F83)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F84)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F85)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F86)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F87)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F92)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("OPRICE_BAT_P01");

                entity.ToTable("OPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1005)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F111).HasColumnType("money");

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F130)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F133).HasColumnType("datetime");

                entity.Property(e => e.F140).HasColumnType("money");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1714)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1768)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1770)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1934).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F205).HasColumnType("money");

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F36)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F63).HasColumnType("money");
            });

            modelBuilder.Entity<OrebateBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("OREBATE_BAT_P01");

                entity.ToTable("OREBATE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1660)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1974)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F233).HasColumnType("money");

                entity.Property(e => e.F234).HasColumnType("datetime");

                entity.Property(e => e.F235).HasColumnType("datetime");

                entity.Property(e => e.F236)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OredeemBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("OREDEEM_BAT_P01");

                entity.ToTable("OREDEEM_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1229).HasColumnType("money");

                entity.Property(e => e.F1234).HasColumnType("datetime");

                entity.Property(e => e.F1235).HasColumnType("datetime");

                entity.Property(e => e.F2744)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OspriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("OSPRICE_BAT_P01");

                entity.ToTable("OSPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1220).HasColumnType("money");

                entity.Property(e => e.F136).HasColumnType("money");

                entity.Property(e => e.F137).HasColumnType("datetime");

                entity.Property(e => e.F138).HasColumnType("datetime");

                entity.Property(e => e.F139).HasColumnType("money");

                entity.Property(e => e.F144)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F145)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F146)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F148).HasColumnType("money");

                entity.Property(e => e.F179)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1955).HasColumnType("money");

                entity.Property(e => e.F1956).HasColumnType("money");

                entity.Property(e => e.F2668)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F42)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtpriceBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F126 })
                    .HasName("OTPRICE_BAT_P01");

                entity.ToTable("OTPRICE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1186).HasColumnType("money");

                entity.Property(e => e.F1188).HasColumnType("money");

                entity.Property(e => e.F1218).HasColumnType("money");

                entity.Property(e => e.F181).HasColumnType("money");

                entity.Property(e => e.F183).HasColumnType("datetime");

                entity.Property(e => e.F184).HasColumnType("datetime");

                entity.Property(e => e.F1953).HasColumnType("money");

                entity.Property(e => e.F1954).HasColumnType("money");

                entity.Property(e => e.F221)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2667)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayTab>(entity =>
            {
                entity.HasKey(e => e.F1567)
                    .HasName("PAY_TAB_P1567");

                entity.ToTable("PAY_TAB");

                entity.Property(e => e.F1567).ValueGeneratedNever();

                entity.Property(e => e.F2648)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2649).HasColumnType("money");

                entity.Property(e => e.F2650).HasColumnType("money");

                entity.Property(e => e.F2651).HasColumnType("money");

                entity.Property(e => e.F2652).HasColumnType("money");

                entity.Property(e => e.F2779).HasColumnType("money");

                entity.Property(e => e.F2780).HasColumnType("money");
            });

            modelBuilder.Entity<PeriodTab>(entity =>
            {
                entity.HasKey(e => new { e.F1000, e.F1031, e.F254 })
                    .HasName("PERIOD_TAB_P1000");

                entity.ToTable("PERIOD_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1951)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");
            });

            modelBuilder.Entity<PosDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("POS_DEL_P01");

                entity.ToTable("POS_DEL");

                entity.HasIndex(e => e.F04)
                    .HasName("POS_DEL_F04");

                entity.HasIndex(e => e.F1000)
                    .HasName("POS_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("POS_DEL_F1001");

                entity.HasIndex(e => e.F383)
                    .HasName("POS_DEL_F383");

                entity.HasIndex(e => e.F902)
                    .HasName("POS_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F09).HasColumnType("datetime");

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F107)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F110)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1136)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F121)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F123)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1236)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F149)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F158)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F159)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F160)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F161)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F162)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F173)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1735)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F174)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F176)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1786)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F188)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F189)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1892)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1933).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F210).HasColumnType("money");

                entity.Property(e => e.F211).HasColumnType("datetime");

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2608)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2930)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F302)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F303).HasColumnType("datetime");

                entity.Property(e => e.F304)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F388)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F397)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F40)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F60).HasColumnType("money");

                entity.Property(e => e.F61).HasColumnType("money");

                entity.Property(e => e.F78)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F83)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F84)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F85)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F86)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F87)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F92)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PosTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("POS_TAB_P01");

                entity.ToTable("POS_TAB");

                entity.HasIndex(e => e.F04)
                    .HasName("POS_TAB_F04");

                entity.HasIndex(e => e.F1000)
                    .HasName("POS_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("POS_TAB_F1001");

                entity.HasIndex(e => e.F383)
                    .HasName("POS_TAB_F383");

                entity.HasIndex(e => e.F902)
                    .HasName("POS_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F02)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F09).HasColumnType("datetime");

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F107)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F110)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1136)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F121)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F123)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1236)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F149)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F158)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F159)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F160)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F161)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F162)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F173)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1735)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F174)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F176)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1786)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F188)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F189)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1892)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1933).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F210).HasColumnType("money");

                entity.Property(e => e.F211).HasColumnType("datetime");

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2608)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2930)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F302)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F303).HasColumnType("datetime");

                entity.Property(e => e.F304)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F388)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F397)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F40)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F60).HasColumnType("money");

                entity.Property(e => e.F61).HasColumnType("money");

                entity.Property(e => e.F78)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F83)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F84)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F85)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F86)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F87)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F92)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriceDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000, e.F126 })
                    .HasName("PRICE_DEL_P01");

                entity.ToTable("PRICE_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("PRICE_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("PRICE_DEL_F1001");

                entity.HasIndex(e => e.F1014)
                    .HasName("PRICE_DEL_F1014");

                entity.HasIndex(e => e.F126)
                    .HasName("PRICE_DEL_F126");

                entity.HasIndex(e => e.F32)
                    .HasName("PRICE_DEL_F32");

                entity.HasIndex(e => e.F902)
                    .HasName("PRICE_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1005)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1007).HasColumnType("money");

                entity.Property(e => e.F1008).HasColumnType("datetime");

                entity.Property(e => e.F1009)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1010)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1011)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1013).HasColumnType("money");

                entity.Property(e => e.F1014).HasColumnType("datetime");

                entity.Property(e => e.F1015)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F109)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F111).HasColumnType("money");

                entity.Property(e => e.F113)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1133).HasColumnType("money");

                entity.Property(e => e.F1135)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1186).HasColumnType("money");

                entity.Property(e => e.F1188).HasColumnType("money");

                entity.Property(e => e.F119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1194)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1195)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1196).HasColumnType("money");

                entity.Property(e => e.F1198).HasColumnType("money");

                entity.Property(e => e.F1201)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1203).HasColumnType("money");

                entity.Property(e => e.F1205).HasColumnType("money");

                entity.Property(e => e.F1208)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1210).HasColumnType("money");

                entity.Property(e => e.F1212).HasColumnType("money");

                entity.Property(e => e.F1216).HasColumnType("datetime");

                entity.Property(e => e.F1217).HasColumnType("datetime");

                entity.Property(e => e.F1218).HasColumnType("money");

                entity.Property(e => e.F122)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1220).HasColumnType("money");

                entity.Property(e => e.F1222).HasColumnType("money");

                entity.Property(e => e.F1224).HasColumnType("money");

                entity.Property(e => e.F1226).HasColumnType("money");

                entity.Property(e => e.F1229).HasColumnType("money");

                entity.Property(e => e.F1231).HasColumnType("money");

                entity.Property(e => e.F1233).HasColumnType("money");

                entity.Property(e => e.F1234).HasColumnType("datetime");

                entity.Property(e => e.F1235).HasColumnType("datetime");

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F130)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F133).HasColumnType("datetime");

                entity.Property(e => e.F136).HasColumnType("money");

                entity.Property(e => e.F137).HasColumnType("datetime");

                entity.Property(e => e.F138).HasColumnType("datetime");

                entity.Property(e => e.F139).HasColumnType("money");

                entity.Property(e => e.F140).HasColumnType("money");

                entity.Property(e => e.F144)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F145)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F146)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F148).HasColumnType("money");

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F166).HasColumnType("money");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1714)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F175)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1768)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1770)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F179)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1799)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1800)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1805).HasColumnType("money");

                entity.Property(e => e.F1806).HasColumnType("money");

                entity.Property(e => e.F181).HasColumnType("money");

                entity.Property(e => e.F183).HasColumnType("datetime");

                entity.Property(e => e.F184).HasColumnType("datetime");

                entity.Property(e => e.F1885).HasColumnType("money");

                entity.Property(e => e.F1934).HasColumnType("money");

                entity.Property(e => e.F1935).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F205).HasColumnType("money");

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F221)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2569)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2571).HasColumnType("money");

                entity.Property(e => e.F2573).HasColumnType("money");

                entity.Property(e => e.F2577).HasColumnType("money");

                entity.Property(e => e.F2579)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2667)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2668)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2694)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2695)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2696)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2744)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F36)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F41)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F42)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F43)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F59)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F63).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriceTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000, e.F126 })
                    .HasName("PRICE_TAB_P01");

                entity.ToTable("PRICE_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("PRICE_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("PRICE_TAB_F1001");

                entity.HasIndex(e => e.F1014)
                    .HasName("PRICE_TAB_F1014");

                entity.HasIndex(e => e.F126)
                    .HasName("PRICE_TAB_F126");

                entity.HasIndex(e => e.F32)
                    .HasName("PRICE_TAB_F32");

                entity.HasIndex(e => e.F902)
                    .HasName("PRICE_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1005)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1007).HasColumnType("money");

                entity.Property(e => e.F1008).HasColumnType("datetime");

                entity.Property(e => e.F1009)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1010)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1011)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1013).HasColumnType("money");

                entity.Property(e => e.F1014).HasColumnType("datetime");

                entity.Property(e => e.F1015)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F109)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F111).HasColumnType("money");

                entity.Property(e => e.F113)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1133).HasColumnType("money");

                entity.Property(e => e.F1135)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1186).HasColumnType("money");

                entity.Property(e => e.F1188).HasColumnType("money");

                entity.Property(e => e.F119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1194)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1195)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1196).HasColumnType("money");

                entity.Property(e => e.F1198).HasColumnType("money");

                entity.Property(e => e.F1201)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1203).HasColumnType("money");

                entity.Property(e => e.F1205).HasColumnType("money");

                entity.Property(e => e.F1208)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1210).HasColumnType("money");

                entity.Property(e => e.F1212).HasColumnType("money");

                entity.Property(e => e.F1216).HasColumnType("datetime");

                entity.Property(e => e.F1217).HasColumnType("datetime");

                entity.Property(e => e.F1218).HasColumnType("money");

                entity.Property(e => e.F122)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1220).HasColumnType("money");

                entity.Property(e => e.F1222).HasColumnType("money");

                entity.Property(e => e.F1224).HasColumnType("money");

                entity.Property(e => e.F1226).HasColumnType("money");

                entity.Property(e => e.F1229).HasColumnType("money");

                entity.Property(e => e.F1231).HasColumnType("money");

                entity.Property(e => e.F1233).HasColumnType("money");

                entity.Property(e => e.F1234).HasColumnType("datetime");

                entity.Property(e => e.F1235).HasColumnType("datetime");

                entity.Property(e => e.F129).HasColumnType("datetime");

                entity.Property(e => e.F130)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F133).HasColumnType("datetime");

                entity.Property(e => e.F136).HasColumnType("money");

                entity.Property(e => e.F137).HasColumnType("datetime");

                entity.Property(e => e.F138).HasColumnType("datetime");

                entity.Property(e => e.F139).HasColumnType("money");

                entity.Property(e => e.F140).HasColumnType("money");

                entity.Property(e => e.F144)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F145)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F146)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F148).HasColumnType("money");

                entity.Property(e => e.F164)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F166).HasColumnType("money");

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1714)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F175)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1768)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1770)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F179)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1799)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1800)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1805).HasColumnType("money");

                entity.Property(e => e.F1806).HasColumnType("money");

                entity.Property(e => e.F181).HasColumnType("money");

                entity.Property(e => e.F183).HasColumnType("datetime");

                entity.Property(e => e.F184).HasColumnType("datetime");

                entity.Property(e => e.F1885).HasColumnType("money");

                entity.Property(e => e.F1934).HasColumnType("money");

                entity.Property(e => e.F1935).HasColumnType("money");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F205).HasColumnType("money");

                entity.Property(e => e.F2119)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F221)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2569)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2571).HasColumnType("money");

                entity.Property(e => e.F2573).HasColumnType("money");

                entity.Property(e => e.F2577).HasColumnType("money");

                entity.Property(e => e.F2579)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2667)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2668)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2694)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2695)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2696)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F2744)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F33)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F34)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasColumnType("datetime");

                entity.Property(e => e.F36)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F37)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F41)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F42)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F43)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F59)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F63).HasColumnType("money");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfileTab>(entity =>
            {
                entity.HasKey(e => new { e.F1000, e.F2669, e.F2687, e.F2670 })
                    .HasName("PROFILE_TAB_P1000");

                entity.ToTable("PROFILE_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2669)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2687)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2670)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2671).IsUnicode(false);

                entity.Property(e => e.F2672)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2673)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2674)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2675)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2676)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2677)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2678)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2679)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2680)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2681)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2682)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2683)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2684)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2685)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2686)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubTab>(entity =>
            {
                entity.HasKey(e => new { e.F1912, e.F1000 })
                    .HasName("PUB_TAB_P1912");

                entity.ToTable("PUB_TAB");

                entity.Property(e => e.F1912)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1033)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F1914)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1915)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1916).HasColumnType("datetime");

                entity.Property(e => e.F1917).HasColumnType("datetime");

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");
            });

            modelBuilder.Entity<RbFields>(entity =>
            {
                entity.HasKey(e => new { e.F1452, e.F1453 })
                    .HasName("RB_FIELDS_P1452");

                entity.ToTable("RB_FIELDS");

                entity.Property(e => e.F1452)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1453)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1454)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1455)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1456)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1457)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1458)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1459)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1460)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2595)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RbJoins>(entity =>
            {
                entity.HasKey(e => new { e.F1461, e.F1462 })
                    .HasName("RB_JOINS_P1461");

                entity.ToTable("RB_JOINS");

                entity.Property(e => e.F1461)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1462)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1463)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1464)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F1465)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F1466)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RbTables>(entity =>
            {
                entity.HasKey(e => e.F1452)
                    .HasName("RB_TABLES_P1452");

                entity.ToTable("RB_TABLES");

                entity.Property(e => e.F1452)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1451)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RcpDetTab>(entity =>
            {
                entity.HasKey(e => e.F2907)
                    .HasName("RCP_DET_TAB_P2907");

                entity.ToTable("RCP_DET_TAB");

                entity.Property(e => e.F2907)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2909)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2910)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.F2911)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2912)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.F2913)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.F2914)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.F2915)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.F2916)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.F2917)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.F2918)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2919)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2922)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2923)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2924)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2925)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RcpItmTab>(entity =>
            {
                entity.HasKey(e => new { e.F2907, e.F2908 })
                    .HasName("RCP_ITM_TAB_P2907");

                entity.ToTable("RCP_ITM_TAB");

                entity.Property(e => e.F2907)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2920)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RcpTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F2784 })
                    .HasName("RCP_TAB_P01");

                entity.ToTable("RCP_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F2784)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReasonTab>(entity =>
            {
                entity.HasKey(e => e.F2772)
                    .HasName("REASON_TAB_P2772");

                entity.ToTable("REASON_TAB");

                entity.Property(e => e.F2772).ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2773)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RebateBat>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F902, e.F1000, e.F27, e.F1184 })
                    .HasName("REBATE_BAT_P01");

                entity.ToTable("REBATE_BAT");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1660)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1974)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F233).HasColumnType("money");

                entity.Property(e => e.F234).HasColumnType("datetime");

                entity.Property(e => e.F235).HasColumnType("datetime");

                entity.Property(e => e.F236)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecBat>(entity =>
            {
                entity.HasKey(e => e.F1032)
                    .HasName("REC_BAT_P1032");

                entity.ToTable("REC_BAT");

                entity.HasIndex(e => e.F27)
                    .HasName("REC_BAT_F27");

                entity.Property(e => e.F1032).ValueGeneratedNever();

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1652)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1653).HasColumnType("datetime");

                entity.Property(e => e.F1656)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1884).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1889)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1890)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2596).HasColumnType("datetime");

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2635).HasColumnType("money");

                entity.Property(e => e.F2636).HasColumnType("money");

                entity.Property(e => e.F2655)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2656)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2657).HasColumnType("datetime");

                entity.Property(e => e.F2658)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2659)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2710)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F334)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F335)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F336)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F337)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F338)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F339)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F340)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F341)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F342)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F343)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F344)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F345)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F352)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecHdr>(entity =>
            {
                entity.HasKey(e => e.F1032)
                    .HasName("REC_HDR_P1032");

                entity.ToTable("REC_HDR");

                entity.HasIndex(e => e.F27)
                    .HasName("REC_HDR_F27");

                entity.Property(e => e.F1032).ValueGeneratedNever();

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1652)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1653).HasColumnType("datetime");

                entity.Property(e => e.F1656)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1884).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1889)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1890)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2596).HasColumnType("datetime");

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2635).HasColumnType("money");

                entity.Property(e => e.F2636).HasColumnType("money");

                entity.Property(e => e.F2655)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2656)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2657).HasColumnType("datetime");

                entity.Property(e => e.F2658)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2659)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2710)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F334)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F335)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F336)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F337)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F338)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F339)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F340)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F341)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F342)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F343)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F344)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F345)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F352)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecHdrSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032 })
                    .HasName("REC_HDR_SAV_P1032");

                entity.ToTable("REC_HDR_SAV");

                entity.HasIndex(e => e.F27)
                    .HasName("REC_HDR_SAV_F27");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1264).HasColumnType("datetime");

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1652)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1653).HasColumnType("datetime");

                entity.Property(e => e.F1654).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1655).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1656)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1760).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1761).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1883).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1884).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1889)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1890)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2596).HasColumnType("datetime");

                entity.Property(e => e.F2598).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2599).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2633).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2634).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2635).HasColumnType("money");

                entity.Property(e => e.F2636).HasColumnType("money");

                entity.Property(e => e.F2655)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2656)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2657).HasColumnType("datetime");

                entity.Property(e => e.F2658)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2659)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2710)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F334)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F335)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F336)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F337)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F338)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F339)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F340)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F341)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F342)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F343)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F344)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F345)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F346).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F347).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F349).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F352)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecReg>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1101 })
                    .HasName("REC_REG_P1032");

                entity.ToTable("REC_REG");

                entity.HasIndex(e => e.F01)
                    .HasName("REC_REG_F01");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1069)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1070)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1071)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1086)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1121).HasColumnType("money");

                entity.Property(e => e.F1140).HasColumnType("money");

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F120).HasColumnType("money");

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1247)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1248)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1249).HasColumnType("money");

                entity.Property(e => e.F1250).HasColumnType("money");

                entity.Property(e => e.F1251).HasColumnType("money");

                entity.Property(e => e.F1252).HasColumnType("money");

                entity.Property(e => e.F151).HasColumnType("money");

                entity.Property(e => e.F156)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1595).HasColumnType("money");

                entity.Property(e => e.F1658).HasColumnType("money");

                entity.Property(e => e.F1659)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1660)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1661)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1662).HasColumnType("money");

                entity.Property(e => e.F1664).HasColumnType("money");

                entity.Property(e => e.F1666).HasColumnType("money");

                entity.Property(e => e.F1668)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1669).HasColumnType("money");

                entity.Property(e => e.F1671).HasColumnType("money");

                entity.Property(e => e.F1672).HasColumnType("money");

                entity.Property(e => e.F1673).HasColumnType("money");

                entity.Property(e => e.F1674).HasColumnType("money");

                entity.Property(e => e.F1675)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1676).HasColumnType("money");

                entity.Property(e => e.F1677)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1678).HasColumnType("money");

                entity.Property(e => e.F1680).HasColumnType("datetime");

                entity.Property(e => e.F1681).HasColumnType("money");

                entity.Property(e => e.F1682).HasColumnType("money");

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1771).HasColumnType("money");

                entity.Property(e => e.F1772).HasColumnType("money");

                entity.Property(e => e.F1773).HasColumnType("money");

                entity.Property(e => e.F1774).HasColumnType("money");

                entity.Property(e => e.F1775).HasColumnType("money");

                entity.Property(e => e.F1791)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1797).HasColumnType("money");

                entity.Property(e => e.F1815).HasColumnType("money");

                entity.Property(e => e.F186).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1899).HasColumnType("money");

                entity.Property(e => e.F1973)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1974)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1975)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1976)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F201).HasColumnType("money");

                entity.Property(e => e.F202).HasColumnType("datetime");

                entity.Property(e => e.F203).HasColumnType("datetime");

                entity.Property(e => e.F204)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F219).HasColumnType("datetime");

                entity.Property(e => e.F220)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F222)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F223)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F225).HasColumnType("money");

                entity.Property(e => e.F227).HasColumnType("datetime");

                entity.Property(e => e.F229).HasColumnType("datetime");

                entity.Property(e => e.F230).HasColumnType("datetime");

                entity.Property(e => e.F231)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F233).HasColumnType("money");

                entity.Property(e => e.F234).HasColumnType("datetime");

                entity.Property(e => e.F235).HasColumnType("datetime");

                entity.Property(e => e.F236)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2551).HasColumnType("money");

                entity.Property(e => e.F2552).HasColumnType("money");

                entity.Property(e => e.F2553).HasColumnType("money");

                entity.Property(e => e.F2554).HasColumnType("money");

                entity.Property(e => e.F2555).HasColumnType("money");

                entity.Property(e => e.F2556).HasColumnType("money");

                entity.Property(e => e.F2557).HasColumnType("money");

                entity.Property(e => e.F2558).HasColumnType("money");

                entity.Property(e => e.F2559).HasColumnType("money");

                entity.Property(e => e.F2560).HasColumnType("money");

                entity.Property(e => e.F2561).HasColumnType("money");

                entity.Property(e => e.F2562).HasColumnType("money");

                entity.Property(e => e.F2563).HasColumnType("money");

                entity.Property(e => e.F2564).HasColumnType("money");

                entity.Property(e => e.F2565).HasColumnType("money");

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2626).HasColumnType("money");

                entity.Property(e => e.F2627).HasColumnType("money");

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2709).HasColumnType("money");

                entity.Property(e => e.F2711).HasColumnType("money");

                entity.Property(e => e.F2712).HasColumnType("money");

                entity.Property(e => e.F2713).HasColumnType("money");

                entity.Property(e => e.F2714).HasColumnType("money");

                entity.Property(e => e.F2715).HasColumnType("money");

                entity.Property(e => e.F2716).HasColumnType("money");

                entity.Property(e => e.F2717).HasColumnType("money");

                entity.Property(e => e.F2718).HasColumnType("money");

                entity.Property(e => e.F2872).HasColumnType("money");

                entity.Property(e => e.F2873).HasColumnType("money");

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F90)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F92)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecRegSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032, e.F1101 })
                    .HasName("REC_REG_SAV_P1032");

                entity.ToTable("REC_REG_SAV");

                entity.HasIndex(e => e.F01)
                    .HasName("REC_REG_SAV_F01");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1003).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1069)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1070)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1071)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1086)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1121).HasColumnType("money");

                entity.Property(e => e.F1122).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1140).HasColumnType("money");

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F120).HasColumnType("money");

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1247)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1248)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1249).HasColumnType("money");

                entity.Property(e => e.F1250).HasColumnType("money");

                entity.Property(e => e.F1251).HasColumnType("money");

                entity.Property(e => e.F1252).HasColumnType("money");

                entity.Property(e => e.F1266).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1267).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F151).HasColumnType("money");

                entity.Property(e => e.F156)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1595).HasColumnType("money");

                entity.Property(e => e.F1657).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1658).HasColumnType("money");

                entity.Property(e => e.F1659)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1660)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1661)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1662).HasColumnType("money");

                entity.Property(e => e.F1663).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1664).HasColumnType("money");

                entity.Property(e => e.F1665).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1666).HasColumnType("money");

                entity.Property(e => e.F1667).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1668)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1669).HasColumnType("money");

                entity.Property(e => e.F1670).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1671).HasColumnType("money");

                entity.Property(e => e.F1672).HasColumnType("money");

                entity.Property(e => e.F1673).HasColumnType("money");

                entity.Property(e => e.F1674).HasColumnType("money");

                entity.Property(e => e.F1675)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1676).HasColumnType("money");

                entity.Property(e => e.F1677)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1678).HasColumnType("money");

                entity.Property(e => e.F1680).HasColumnType("datetime");

                entity.Property(e => e.F1681).HasColumnType("money");

                entity.Property(e => e.F1682).HasColumnType("money");

                entity.Property(e => e.F1683).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1684).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1732).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1771).HasColumnType("money");

                entity.Property(e => e.F1772).HasColumnType("money");

                entity.Property(e => e.F1773).HasColumnType("money");

                entity.Property(e => e.F1774).HasColumnType("money");

                entity.Property(e => e.F1775).HasColumnType("money");

                entity.Property(e => e.F1791)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1795).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1797).HasColumnType("money");

                entity.Property(e => e.F1815).HasColumnType("money");

                entity.Property(e => e.F186).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1899).HasColumnType("money");

                entity.Property(e => e.F19).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1918).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1919).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1920).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1973)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1974)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1975)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1976)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1977).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1978).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1979).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F20).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F201).HasColumnType("money");

                entity.Property(e => e.F202).HasColumnType("datetime");

                entity.Property(e => e.F203).HasColumnType("datetime");

                entity.Property(e => e.F204)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F219).HasColumnType("datetime");

                entity.Property(e => e.F220)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F222)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F223)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F224).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F225).HasColumnType("money");

                entity.Property(e => e.F226).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F227).HasColumnType("datetime");

                entity.Property(e => e.F228).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F229).HasColumnType("datetime");

                entity.Property(e => e.F230).HasColumnType("datetime");

                entity.Property(e => e.F231)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F233).HasColumnType("money");

                entity.Property(e => e.F234).HasColumnType("datetime");

                entity.Property(e => e.F235).HasColumnType("datetime");

                entity.Property(e => e.F236)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F237).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2551).HasColumnType("money");

                entity.Property(e => e.F2552).HasColumnType("money");

                entity.Property(e => e.F2553).HasColumnType("money");

                entity.Property(e => e.F2554).HasColumnType("money");

                entity.Property(e => e.F2555).HasColumnType("money");

                entity.Property(e => e.F2556).HasColumnType("money");

                entity.Property(e => e.F2557).HasColumnType("money");

                entity.Property(e => e.F2558).HasColumnType("money");

                entity.Property(e => e.F2559).HasColumnType("money");

                entity.Property(e => e.F2560).HasColumnType("money");

                entity.Property(e => e.F2561).HasColumnType("money");

                entity.Property(e => e.F2562).HasColumnType("money");

                entity.Property(e => e.F2563).HasColumnType("money");

                entity.Property(e => e.F2564).HasColumnType("money");

                entity.Property(e => e.F2565).HasColumnType("money");

                entity.Property(e => e.F2566).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2567).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2568).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F26)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F2626).HasColumnType("money");

                entity.Property(e => e.F2627).HasColumnType("money");

                entity.Property(e => e.F2628).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2629).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2666).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F270).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2709).HasColumnType("money");

                entity.Property(e => e.F2711).HasColumnType("money");

                entity.Property(e => e.F2712).HasColumnType("money");

                entity.Property(e => e.F2713).HasColumnType("money");

                entity.Property(e => e.F2714).HasColumnType("money");

                entity.Property(e => e.F2715).HasColumnType("money");

                entity.Property(e => e.F2716).HasColumnType("money");

                entity.Property(e => e.F2717).HasColumnType("money");

                entity.Property(e => e.F2718).HasColumnType("money");

                entity.Property(e => e.F2864).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2868).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2872).HasColumnType("money");

                entity.Property(e => e.F2873).HasColumnType("money");

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F327).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F328).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F329).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F38).HasColumnType("money");

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F64).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F67).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F70).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F75).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F90)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F92)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecTtl>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1034 })
                    .HasName("REC_TTL_P1032");

                entity.ToTable("REC_TTL");

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1093).HasColumnType("money");

                entity.Property(e => e.F1094).HasColumnType("money");

                entity.Property(e => e.F1095).HasColumnType("money");

                entity.Property(e => e.F1096).HasColumnType("money");

                entity.Property(e => e.F1097).HasColumnType("money");

                entity.Property(e => e.F1098).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RecTtlSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032, e.F1034 })
                    .HasName("REC_TTL_SAV_P1032");

                entity.ToTable("REC_TTL_SAV");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1093).HasColumnType("money");

                entity.Property(e => e.F1094).HasColumnType("money");

                entity.Property(e => e.F1095).HasColumnType("money");

                entity.Property(e => e.F1096).HasColumnType("money");

                entity.Property(e => e.F1097).HasColumnType("money");

                entity.Property(e => e.F1098).HasColumnType("money");

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F64).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F67).HasColumnType("numeric(20, 4)");
            });

            modelBuilder.Entity<RentTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1079, e.F1785 })
                    .HasName("RENT_TAB_P01");

                entity.ToTable("RENT_TAB");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1845).HasColumnType("datetime");

                entity.Property(e => e.F1846).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<ResTab>(entity =>
            {
                entity.HasKey(e => e.F170)
                    .HasName("RES_TAB_P170");

                entity.ToTable("RES_TAB");

                entity.Property(e => e.F170).ValueGeneratedNever();

                entity.Property(e => e.F1745)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1746)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1747)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1748)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1749)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1750)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1751)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1752)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1753)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1754)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1755)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1756)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1757)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1758)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1830)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1841)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RevExec>(entity =>
            {
                entity.HasKey(e => new { e.F3000, e.F3005, e.F3009, e.F3001 })
                    .HasName("REV_EXEC_P01");

                entity.ToTable("REV_EXEC");

                entity.Property(e => e.F3009).HasMaxLength(128);

                entity.Property(e => e.F3001).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RevHdr>(entity =>
            {
                entity.HasKey(e => new { e.F3005, e.F3009, e.F3004, e.F3003, e.F3001 })
                    .HasName("REV_HDR_P01");

                entity.ToTable("REV_HDR");

                entity.HasIndex(e => new { e.F3007, e.F3009, e.F3003 })
                    .HasName("REV_HDRX2");

                entity.HasIndex(e => new { e.F3009, e.F3007, e.F3003 })
                    .HasName("REV_HDR_X1");

                entity.Property(e => e.F3009).HasMaxLength(128);

                entity.Property(e => e.F3004).HasMaxLength(128);

                entity.Property(e => e.F3001).ValueGeneratedOnAdd();

                entity.Property(e => e.F3002)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RevList>(entity =>
            {
                entity.HasKey(e => new { e.F3000, e.F3009 })
                    .HasName("REV_LIST_P01");

                entity.ToTable("REV_LIST");

                entity.Property(e => e.F3009).HasMaxLength(128);

                entity.Property(e => e.F1039)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RevQueue>(entity =>
            {
                entity.HasKey(e => new { e.F3005, e.F3009, e.F3000, e.F3001 })
                    .HasName("REV_QUEUE_P01");

                entity.ToTable("REV_QUEUE");

                entity.Property(e => e.F3009).HasMaxLength(128);

                entity.Property(e => e.F3001).ValueGeneratedOnAdd();

                entity.Property(e => e.F3002)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.F3004)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RouteTab>(entity =>
            {
                entity.HasKey(e => e.F1697)
                    .HasName("ROUTE_TAB_P1697");

                entity.ToTable("ROUTE_TAB");

                entity.Property(e => e.F1697)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2893).HasColumnType("datetime");

                entity.Property(e => e.F2894)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F2902).HasColumnType("datetime");

                entity.Property(e => e.F2903).HasColumnType("datetime");

                entity.Property(e => e.F2904)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2905)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RpcTab>(entity =>
            {
                entity.HasKey(e => e.F18)
                    .HasName("RPC_TAB_P18");

                entity.ToTable("RPC_TAB");

                entity.Property(e => e.F18).ValueGeneratedNever();

                entity.Property(e => e.F1024)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1967)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RptClkD>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1185, e.F1056, e.F1057 })
                    .HasName("RPT_CLK_D_P254");

                entity.ToTable("RPT_CLK_D");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLK_D_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("RPT_CLK_D_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptClkF>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1185, e.F1056, e.F1057 })
                    .HasName("RPT_CLK_F_P254");

                entity.ToTable("RPT_CLK_F");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLK_F_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("RPT_CLK_F_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptClkM>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1185, e.F1056, e.F1057 })
                    .HasName("RPT_CLK_M_P254");

                entity.ToTable("RPT_CLK_M");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLK_M_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("RPT_CLK_M_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptClkN>(entity =>
            {
                entity.HasKey(e => new { e.F1034, e.F1185 })
                    .HasName("RPT_CLK_N_P1034");

                entity.ToTable("RPT_CLK_N");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptClkP>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1185, e.F1056, e.F1057 })
                    .HasName("RPT_CLK_P_P254");

                entity.ToTable("RPT_CLK_P");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLK_P_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("RPT_CLK_P_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptClkW>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1185, e.F1056, e.F1057 })
                    .HasName("RPT_CLK_W_P254");

                entity.ToTable("RPT_CLK_W");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLK_W_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("RPT_CLK_W_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptClkY>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1185, e.F1056, e.F1057 })
                    .HasName("RPT_CLK_Y_P254");

                entity.ToTable("RPT_CLK_Y");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLK_Y_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("RPT_CLK_Y_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltD>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F1056 })
                    .HasName("RPT_CLT_D_P254");

                entity.ToTable("RPT_CLT_D");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLT_D_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("RPT_CLT_D_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltF>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F1056 })
                    .HasName("RPT_CLT_F_P254");

                entity.ToTable("RPT_CLT_F");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLT_F_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("RPT_CLT_F_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltItmD>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F01, e.F1056 })
                    .HasName("RPT_CLT_ITM_D_P254");

                entity.ToTable("RPT_CLT_ITM_D");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltItmN>(entity =>
            {
                entity.HasKey(e => new { e.F1148, e.F01, e.F1034 })
                    .HasName("RPT_CLT_ITM_N_P1148");

                entity.ToTable("RPT_CLT_ITM_N");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltM>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F1056 })
                    .HasName("RPT_CLT_M_P254");

                entity.ToTable("RPT_CLT_M");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLT_M_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("RPT_CLT_M_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltN>(entity =>
            {
                entity.HasKey(e => new { e.F1148, e.F1034 })
                    .HasName("RPT_CLT_N_P1148");

                entity.ToTable("RPT_CLT_N");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltP>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F1056 })
                    .HasName("RPT_CLT_P_P254");

                entity.ToTable("RPT_CLT_P");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLT_P_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("RPT_CLT_P_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltW>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F1056 })
                    .HasName("RPT_CLT_W_P254");

                entity.ToTable("RPT_CLT_W");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLT_W_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("RPT_CLT_W_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptCltY>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F1148, e.F1056 })
                    .HasName("RPT_CLT_Y_P254");

                entity.ToTable("RPT_CLT_Y");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_CLT_Y_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("RPT_CLT_Y_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptDpt>(entity =>
            {
                entity.HasKey(e => new { e.F1031, e.F254, e.F1034, e.F03, e.F1056, e.F1057 })
                    .HasName("RPT_DPT_P1031");

                entity.ToTable("RPT_DPT");

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptFin>(entity =>
            {
                entity.HasKey(e => new { e.F1031, e.F254, e.F1034, e.F1056, e.F1057 })
                    .HasName("RPT_FIN_P1031");

                entity.ToTable("RPT_FIN");

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptHou>(entity =>
            {
                entity.HasKey(e => new { e.F1031, e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_HOU_P1031");

                entity.ToTable("RPT_HOU");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_HOU_F1034");

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmD>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_ITM_D_P254");

                entity.ToTable("RPT_ITM_D");

                entity.HasIndex(e => e.F01)
                    .HasName("RPT_ITM_D_F01");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_ITM_D_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmF>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_ITM_F_P254");

                entity.ToTable("RPT_ITM_F");

                entity.HasIndex(e => e.F01)
                    .HasName("RPT_ITM_F_F01");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_ITM_F_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmM>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_ITM_M_P254");

                entity.ToTable("RPT_ITM_M");

                entity.HasIndex(e => e.F01)
                    .HasName("RPT_ITM_M_F01");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_ITM_M_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmN>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1034, e.F1056 })
                    .HasName("RPT_ITM_N_P01");

                entity.ToTable("RPT_ITM_N");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F381).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmP>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_ITM_P_P254");

                entity.ToTable("RPT_ITM_P");

                entity.HasIndex(e => e.F01)
                    .HasName("RPT_ITM_P_F01");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_ITM_P_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmW>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_ITM_W_P254");

                entity.ToTable("RPT_ITM_W");

                entity.HasIndex(e => e.F01)
                    .HasName("RPT_ITM_W_F01");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_ITM_W_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptItmY>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1034, e.F01, e.F1056, e.F1057 })
                    .HasName("RPT_ITM_Y_P254");

                entity.ToTable("RPT_ITM_Y");

                entity.HasIndex(e => e.F01)
                    .HasName("RPT_ITM_Y_F01");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_ITM_Y_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptSub>(entity =>
            {
                entity.HasKey(e => new { e.F1031, e.F254, e.F1034, e.F04, e.F1056, e.F1057 })
                    .HasName("RPT_SUB_P1031");

                entity.ToTable("RPT_SUB");

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RptVnd>(entity =>
            {
                entity.HasKey(e => new { e.F1031, e.F254, e.F1034, e.F27, e.F1056 })
                    .HasName("RPT_VND_P1031");

                entity.ToTable("RPT_VND");

                entity.HasIndex(e => e.F1034)
                    .HasName("RPT_VND_F1034");

                entity.HasIndex(e => e.F27)
                    .HasName("RPT_VND_F27");

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<RunTab>(entity =>
            {
                entity.HasKey(e => new { e.F1102, e.F1000 })
                    .HasName("RUN_TAB_P1102");

                entity.ToTable("RUN_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1103)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1104)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1105).HasColumnType("datetime");

                entity.Property(e => e.F1107).HasColumnType("datetime");

                entity.Property(e => e.F1108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1109)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1110)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1111)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1112).HasColumnType("datetime");

                entity.Property(e => e.F1113)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalBat>(entity =>
            {
                entity.HasKey(e => e.F1032)
                    .HasName("SAL_BAT_P1032");

                entity.ToTable("SAL_BAT");

                entity.HasIndex(e => e.F1148)
                    .HasName("SAL_BAT_F1148");

                entity.Property(e => e.F1032).ValueGeneratedNever();

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1149)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1150)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1151)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1154)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1155)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1156)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1157)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1158)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1159)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1160)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1161)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1165).HasColumnType("money");

                entity.Property(e => e.F1167)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1170)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1171)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1172)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1173)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1242).HasColumnType("money");

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1271)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1272)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1273)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1274)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1277)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1287)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1288)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1295)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1504)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1520).HasColumnType("datetime");

                entity.Property(e => e.F1573)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1652)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1653).HasColumnType("datetime");

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1697)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1763)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1764)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2596).HasColumnType("datetime");

                entity.Property(e => e.F2614).HasColumnType("money");

                entity.Property(e => e.F2615)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2617).HasColumnType("money");

                entity.Property(e => e.F2618).HasColumnType("money");

                entity.Property(e => e.F2623)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2816)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F2889)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2904)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2934)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalDet>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1101, e.F2770 })
                    .HasName("SAL_DET_P1032");

                entity.ToTable("SAL_DET");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2771)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<SalDetSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032, e.F1101, e.F2770 })
                    .HasName("SAL_DET_SAV_P1032");

                entity.ToTable("SAL_DET_SAV");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2771)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F64).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<SalHdr>(entity =>
            {
                entity.HasKey(e => e.F1032)
                    .HasName("SAL_HDR_P1032");

                entity.ToTable("SAL_HDR");

                entity.HasIndex(e => e.F1148)
                    .HasName("SAL_HDR_F1148");

                entity.Property(e => e.F1032).ValueGeneratedNever();

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1149)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1150)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1151)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1154)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1155)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1156)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1157)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1158)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1159)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1160)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1161)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1165).HasColumnType("money");

                entity.Property(e => e.F1167)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1170)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1171)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1172)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1173)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1242).HasColumnType("money");

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1271)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1272)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1273)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1274)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1277)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1287)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1288)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1295)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1504)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1520).HasColumnType("datetime");

                entity.Property(e => e.F1573)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1652)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1653).HasColumnType("datetime");

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1697)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1763)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1764)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2596).HasColumnType("datetime");

                entity.Property(e => e.F2614).HasColumnType("money");

                entity.Property(e => e.F2615)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2617).HasColumnType("money");

                entity.Property(e => e.F2618).HasColumnType("money");

                entity.Property(e => e.F2623)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2816)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F2889)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2904)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2934)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalHdrSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032 })
                    .HasName("SAL_HDR_SAV_P1032");

                entity.ToTable("SAL_HDR_SAV");

                entity.HasIndex(e => e.F1148)
                    .HasName("SAL_HDR_SAV_F1148");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1035)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1068)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1127)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1149)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1150)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1151)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1154)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1155)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1156)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1157)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1158)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1159)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1160)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1161)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1164).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1165).HasColumnType("money");

                entity.Property(e => e.F1167)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1170)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1171)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1172)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1173)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1242).HasColumnType("money");

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1246).HasColumnType("datetime");

                entity.Property(e => e.F1254)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1255)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1271)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1272)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1273)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1274)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1277)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1287)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1288)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1295)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1504)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1520).HasColumnType("datetime");

                entity.Property(e => e.F1573)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1643)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1644)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1645)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1646)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1647)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1648)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1649)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1650)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1651)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1652)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1653).HasColumnType("datetime");

                entity.Property(e => e.F1654).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1655).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1692)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F1697)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1699).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1763)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1764)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1938).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2596).HasColumnType("datetime");

                entity.Property(e => e.F2598).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2599).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2614).HasColumnType("money");

                entity.Property(e => e.F2615)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2617).HasColumnType("money");

                entity.Property(e => e.F2618).HasColumnType("money");

                entity.Property(e => e.F2619).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2620).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2623)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2816)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2848)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F2889)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F2904)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2934)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.F76).HasColumnType("datetime");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalReg>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1101 })
                    .HasName("SAL_REG_P1032");

                entity.ToTable("SAL_REG");

                entity.HasIndex(e => e.F01)
                    .HasName("SAL_REG_F01");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1007).HasColumnType("money");

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1069)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1070)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1071)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1086)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F109)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F110)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F113)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1136)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F117)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1203).HasColumnType("money");

                entity.Property(e => e.F1205).HasColumnType("money");

                entity.Property(e => e.F1208)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1224).HasColumnType("money");

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1240).HasColumnType("money");

                entity.Property(e => e.F1241).HasColumnType("money");

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1263).HasColumnType("money");

                entity.Property(e => e.F149)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1595).HasColumnType("money");

                entity.Property(e => e.F160)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1715).HasColumnType("money");

                entity.Property(e => e.F1716).HasColumnType("money");

                entity.Property(e => e.F1719).HasColumnType("money");

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1720).HasColumnType("money");

                entity.Property(e => e.F1722).HasColumnType("money");

                entity.Property(e => e.F1723).HasColumnType("money");

                entity.Property(e => e.F1724).HasColumnType("money");

                entity.Property(e => e.F1726).HasColumnType("money");

                entity.Property(e => e.F1727).HasColumnType("money");

                entity.Property(e => e.F1728).HasColumnType("money");

                entity.Property(e => e.F1729).HasColumnType("money");

                entity.Property(e => e.F173)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1730).HasColumnType("money");

                entity.Property(e => e.F1733).HasColumnType("money");

                entity.Property(e => e.F1734).HasColumnType("money");

                entity.Property(e => e.F1741)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1742)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F175)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1805).HasColumnType("money");

                entity.Property(e => e.F1815).HasColumnType("money");

                entity.Property(e => e.F1833).HasColumnType("money");

                entity.Property(e => e.F1834).HasColumnType("money");

                entity.Property(e => e.F1932).HasColumnType("money");

                entity.Property(e => e.F1933).HasColumnType("money");

                entity.Property(e => e.F1934).HasColumnType("money");

                entity.Property(e => e.F1935).HasColumnType("money");

                entity.Property(e => e.F1936).HasColumnType("money");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2551).HasColumnType("money");

                entity.Property(e => e.F2552).HasColumnType("money");

                entity.Property(e => e.F2553).HasColumnType("money");

                entity.Property(e => e.F2554).HasColumnType("money");

                entity.Property(e => e.F2555).HasColumnType("money");

                entity.Property(e => e.F2608)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2610).HasColumnType("money");

                entity.Property(e => e.F2611).HasColumnType("money");

                entity.Property(e => e.F2612)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2614).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2744)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2745)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2746)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2752)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2753)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2869).HasColumnType("money");

                entity.Property(e => e.F2870).HasColumnType("money");

                entity.Property(e => e.F2871).HasColumnType("money");

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F43)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F60).HasColumnType("money");

                entity.Property(e => e.F61).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F83)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalRegSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032, e.F1101 })
                    .HasName("SAL_REG_SAV_P1032");

                entity.ToTable("SAL_REG_SAV");

                entity.HasIndex(e => e.F01)
                    .HasName("SAL_REG_SAV_F01");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F08)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1002).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1006).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1007).HasColumnType("money");

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F102)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1041)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1069)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1070)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1071)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1078).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1080).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1081)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.F1086)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F109)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F110)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F113)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1136)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1164).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F117)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1178).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1203).HasColumnType("money");

                entity.Property(e => e.F1204).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1205).HasColumnType("money");

                entity.Property(e => e.F1206).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1208)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1224).HasColumnType("money");

                entity.Property(e => e.F1225).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1240).HasColumnType("money");

                entity.Property(e => e.F1241).HasColumnType("money");

                entity.Property(e => e.F125)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1256).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1263).HasColumnType("money");

                entity.Property(e => e.F149)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1595).HasColumnType("money");

                entity.Property(e => e.F160)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F168).HasColumnType("money");

                entity.Property(e => e.F1683).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1684).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1691)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1699).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1712).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1715).HasColumnType("money");

                entity.Property(e => e.F1716).HasColumnType("money");

                entity.Property(e => e.F1717).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1719).HasColumnType("money");

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1720).HasColumnType("money");

                entity.Property(e => e.F1722).HasColumnType("money");

                entity.Property(e => e.F1723).HasColumnType("money");

                entity.Property(e => e.F1724).HasColumnType("money");

                entity.Property(e => e.F1725).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1726).HasColumnType("money");

                entity.Property(e => e.F1727).HasColumnType("money");

                entity.Property(e => e.F1728).HasColumnType("money");

                entity.Property(e => e.F1729).HasColumnType("money");

                entity.Property(e => e.F173)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1730).HasColumnType("money");

                entity.Property(e => e.F1732).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1733).HasColumnType("money");

                entity.Property(e => e.F1734).HasColumnType("money");

                entity.Property(e => e.F1739).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1740).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1741)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1742)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F175)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1789).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1803).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1805).HasColumnType("money");

                entity.Property(e => e.F1815).HasColumnType("money");

                entity.Property(e => e.F1833).HasColumnType("money");

                entity.Property(e => e.F1834).HasColumnType("money");

                entity.Property(e => e.F1835).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1861).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1863).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1864).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1888).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1924).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1925).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1926).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1927).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1928).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F1932).HasColumnType("money");

                entity.Property(e => e.F1933).HasColumnType("money");

                entity.Property(e => e.F1934).HasColumnType("money");

                entity.Property(e => e.F1935).HasColumnType("money");

                entity.Property(e => e.F1936).HasColumnType("money");

                entity.Property(e => e.F1938).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F24).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2551).HasColumnType("money");

                entity.Property(e => e.F2552).HasColumnType("money");

                entity.Property(e => e.F2553).HasColumnType("money");

                entity.Property(e => e.F2554).HasColumnType("money");

                entity.Property(e => e.F2555).HasColumnType("money");

                entity.Property(e => e.F2608)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2610).HasColumnType("money");

                entity.Property(e => e.F2611).HasColumnType("money");

                entity.Property(e => e.F2612)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2614).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F270).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2744)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2745)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2746)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2752)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2753)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F2860).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2865).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2866).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2867).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F2869).HasColumnType("money");

                entity.Property(e => e.F2870).HasColumnType("money");

                entity.Property(e => e.F2871).HasColumnType("money");

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F31).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F383)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.F43)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F50).HasColumnType("money");

                entity.Property(e => e.F60).HasColumnType("money");

                entity.Property(e => e.F61).HasColumnType("money");

                entity.Property(e => e.F64).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F67).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F83)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F903)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalTtl>(entity =>
            {
                entity.HasKey(e => new { e.F1032, e.F1034 })
                    .HasName("SAL_TTL_P1032");

                entity.ToTable("SAL_TTL");

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1093).HasColumnType("money");

                entity.Property(e => e.F1094).HasColumnType("money");

                entity.Property(e => e.F1095).HasColumnType("money");

                entity.Property(e => e.F1096).HasColumnType("money");

                entity.Property(e => e.F1097).HasColumnType("money");

                entity.Property(e => e.F1098).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<SalTtlSav>(entity =>
            {
                entity.HasKey(e => new { e.F1505, e.F1056, e.F1057, e.F1032, e.F1034 })
                    .HasName("SAL_TTL_SAV_P1032");

                entity.ToTable("SAL_TTL_SAV");

                entity.Property(e => e.F1505).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1067)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.F1093).HasColumnType("money");

                entity.Property(e => e.F1094).HasColumnType("money");

                entity.Property(e => e.F1095).HasColumnType("money");

                entity.Property(e => e.F1096).HasColumnType("money");

                entity.Property(e => e.F1097).HasColumnType("money");

                entity.Property(e => e.F1098).HasColumnType("money");

                entity.Property(e => e.F2890).HasColumnType("datetime");

                entity.Property(e => e.F64).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.F65).HasColumnType("money");

                entity.Property(e => e.F67).HasColumnType("numeric(20, 4)");
            });

            modelBuilder.Entity<SclCctDel>(entity =>
            {
                entity.HasKey(e => new { e.F2802, e.F1000 })
                    .HasName("SCL_CCT_DEL_P2802");

                entity.ToTable("SCL_CCT_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2803)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCctTab>(entity =>
            {
                entity.HasKey(e => new { e.F2802, e.F1000 })
                    .HasName("SCL_CCT_TAB_P2802");

                entity.ToTable("SCL_CCT_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2803)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCptDel>(entity =>
            {
                entity.HasKey(e => new { e.F2804, e.F1000 })
                    .HasName("SCL_CPT_DEL_P2804");

                entity.ToTable("SCL_CPT_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2805)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCptTab>(entity =>
            {
                entity.HasKey(e => new { e.F2804, e.F1000 })
                    .HasName("SCL_CPT_TAB_P2804");

                entity.ToTable("SCL_CPT_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2805)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCslDel>(entity =>
            {
                entity.HasKey(e => new { e.F2797, e.F2798, e.F1000 })
                    .HasName("SCL_CSL_DEL_P2797");

                entity.ToTable("SCL_CSL_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2795)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCslTab>(entity =>
            {
                entity.HasKey(e => new { e.F2797, e.F2798, e.F1000 })
                    .HasName("SCL_CSL_TAB_P2797");

                entity.ToTable("SCL_CSL_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2795)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCtxDel>(entity =>
            {
                entity.HasKey(e => new { e.F2793, e.F1000 })
                    .HasName("SCL_CTX_DEL_P2793");

                entity.ToTable("SCL_CTX_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2794)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.F2795)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclCtxTab>(entity =>
            {
                entity.HasKey(e => new { e.F2793, e.F1000 })
                    .HasName("SCL_CTX_TAB_P2793");

                entity.ToTable("SCL_CTX_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2794)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.F2795)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclDel>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("SCL_DEL_P01");

                entity.ToTable("SCL_DEL");

                entity.HasIndex(e => e.F1000)
                    .HasName("SCL_DEL_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("SCL_DEL_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("SCL_DEL_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1840)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1952)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F256)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F2581)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F2582)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F261).HasColumnType("money");

                entity.Property(e => e.F266)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F273)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F274)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F275)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2792)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2800)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2801)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2944)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2945)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclNutDel>(entity =>
            {
                entity.HasKey(e => new { e.F268, e.F1000 })
                    .HasName("SCL_NUT_DEL_P268");

                entity.ToTable("SCL_NUT_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F197)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F198)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F199)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F200)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2524)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F276)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F277)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2852)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2853)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2854)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2855)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2856)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2857)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2858)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2859)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclNutTab>(entity =>
            {
                entity.HasKey(e => new { e.F268, e.F1000 })
                    .HasName("SCL_NUT_TAB_P268");

                entity.ToTable("SCL_NUT_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F197)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F198)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F199)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F200)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2524)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F276)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F277)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2852)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2853)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2854)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2855)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2856)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2857)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2858)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2859)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclStoDel>(entity =>
            {
                entity.HasKey(e => new { e.F2952, e.F1000 })
                    .HasName("SCL_STO_DEL_P2952");

                entity.ToTable("SCL_STO_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2953)
                    .HasMaxLength(6000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclStoTab>(entity =>
            {
                entity.HasKey(e => new { e.F2952, e.F1000 })
                    .HasName("SCL_STO_TAB_P2952");

                entity.ToTable("SCL_STO_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2953)
                    .HasMaxLength(6000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclTab>(entity =>
            {
                entity.HasKey(e => new { e.F01, e.F1000 })
                    .HasName("SCL_TAB_P01");

                entity.ToTable("SCL_TAB");

                entity.HasIndex(e => e.F1000)
                    .HasName("SCL_TAB_F1000");

                entity.HasIndex(e => e.F1001)
                    .HasName("SCL_TAB_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("SCL_TAB_F902");

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1840)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1952)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F256)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F2581)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F2582)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.F261).HasColumnType("money");

                entity.Property(e => e.F266)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F273)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F274)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F275)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2792)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2800)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2801)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2944)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2945)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclTxtDel>(entity =>
            {
                entity.HasKey(e => new { e.F267, e.F1000 })
                    .HasName("SCL_TXT_DEL_P267");

                entity.ToTable("SCL_TXT_DEL");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1517)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1518)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1519)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1836)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1837)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1838)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1839)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1853)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1854)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1855)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1856)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1968)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1969)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1970)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1971)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1972)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F297)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SclTxtTab>(entity =>
            {
                entity.HasKey(e => new { e.F267, e.F1000 })
                    .HasName("SCL_TXT_TAB_P267");

                entity.ToTable("SCL_TXT_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1517)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1518)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1519)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1836)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1837)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1838)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1839)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1853)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1854)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1855)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1856)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1968)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1969)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1970)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1971)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F1972)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F297)
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SdpTab>(entity =>
            {
                entity.HasKey(e => e.F04)
                    .HasName("SDP_TAB_P04");

                entity.ToTable("SDP_TAB");

                entity.HasIndex(e => e.F03)
                    .HasName("SDP_TAB_F03");

                entity.Property(e => e.F04).ValueGeneratedNever();

                entity.Property(e => e.F100)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F101)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1022)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F104)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F108)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1120)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F114)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F115)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F121)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F124)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F150)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F172)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F177)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F178)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1785)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1893)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1967)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F239).HasColumnType("money");

                entity.Property(e => e.F240).HasColumnType("money");

                entity.Property(e => e.F241).HasColumnType("money");

                entity.Property(e => e.F242).HasColumnType("money");

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F78)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F79)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F80)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F81)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F82)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F88)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F96)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F97)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F98)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F99)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetupTab>(entity =>
            {
                entity.HasKey(e => new { e.F2956, e.F2968, e.F2957, e.F2958, e.F2959 })
                    .HasName("SETUP_TAB_P2956");

                entity.ToTable("SETUP_TAB");

                entity.Property(e => e.F2956)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2968)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2957)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2958)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2959)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2960)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2961).HasColumnType("xml");

                entity.Property(e => e.F2962).HasColumnType("xml");

                entity.Property(e => e.F2963).HasColumnType("xml");

                entity.Property(e => e.F2964).HasColumnType("datetime");

                entity.Property(e => e.F2965).HasColumnType("datetime");

                entity.Property(e => e.F2969)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F2970).HasColumnType("xml");

                entity.Property(e => e.F2976)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShfTab>(entity =>
            {
                entity.HasKey(e => new { e.F117, e.F1000 })
                    .HasName("SHF_TAB_P117");

                entity.ToTable("SHF_TAB");

                entity.Property(e => e.F117)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F116)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F118)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F25)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.F2839)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F95)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StdTab>(entity =>
            {
                entity.HasKey(e => e.F1056)
                    .HasName("STD_TAB_P1056");

                entity.ToTable("STD_TAB");

                entity.HasIndex(e => e.F1530)
                    .HasName("STD_TAB_F1530");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1530)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1531)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F1532)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F1533)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F1534)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F1535)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1536)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1537)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1538)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F1539)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1540)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1541)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1542)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1546).HasColumnType("datetime");

                entity.Property(e => e.F1547).HasColumnType("datetime");

                entity.Property(e => e.F1548)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1549)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1551)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2688)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2689)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2690)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2774)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2775)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2776)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2777)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.F2840)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2841)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F2849)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2850)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F2937)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoTab>(entity =>
            {
                entity.HasKey(e => e.F1000)
                    .HasName("STO_TAB_P1000");

                entity.ToTable("STO_TAB");

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1018)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1180)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1181)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1182)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2691)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysTab>(entity =>
            {
                entity.HasKey(e => e.F902)
                    .HasName("SYS_TAB_P902");

                entity.ToTable("SYS_TAB");

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1059)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1066)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1243)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.F1244)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.F1763)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1764)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F2589).HasColumnType("datetime");

                entity.Property(e => e.F2590).HasColumnType("datetime");

                entity.Property(e => e.F2874)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.F302)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F91)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TarTab>(entity =>
            {
                entity.HasKey(e => e.F06)
                    .HasName("TAR_TAB_P06");

                entity.ToTable("TAR_TAB");

                entity.Property(e => e.F06).ValueGeneratedNever();

                entity.Property(e => e.F1021)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskTab>(entity =>
            {
                entity.HasKey(e => e.F1822)
                    .HasName("TASK_TAB_P1822");

                entity.ToTable("TASK_TAB");

                entity.Property(e => e.F1822)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1184)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1245)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1675)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1676).HasColumnType("money");

                entity.Property(e => e.F1677)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.F1678).HasColumnType("money");

                entity.Property(e => e.F1680).HasColumnType("datetime");

                entity.Property(e => e.F1823)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1824)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1825)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.F1826).HasColumnType("datetime");

                entity.Property(e => e.F1828)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1829)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F2755).IsUnicode(false);

                entity.Property(e => e.F2756)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.F2758)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2759)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2760).HasColumnType("datetime");

                entity.Property(e => e.F2763)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2764).HasColumnType("datetime");
            });

            modelBuilder.Entity<TerTab>(entity =>
            {
                entity.HasKey(e => new { e.F1056, e.F1057 })
                    .HasName("TER_TAB_P1056");

                entity.ToTable("TER_TAB");

                entity.HasIndex(e => e.F1057)
                    .HasName("TER_TAB_F1057");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1058)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1125)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.F1169)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TlzTab>(entity =>
            {
                entity.HasKey(e => e.F1034)
                    .HasName("TLZ_TAB_P1034");

                entity.ToTable("TLZ_TAB");

                entity.HasIndex(e => e.F1128)
                    .HasName("TLZ_TAB_F1128");

                entity.HasIndex(e => e.F1129)
                    .HasName("TLZ_TAB_F1129");

                entity.HasIndex(e => e.F1147)
                    .HasName("TLZ_TAB_F1147");

                entity.HasIndex(e => e.F1179)
                    .HasName("TLZ_TAB_F1179");

                entity.Property(e => e.F1034).ValueGeneratedNever();

                entity.Property(e => e.F1039)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1048)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1128)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1129)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1130)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1131)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F1253)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1709)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1710)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1896)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1897)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrsClk>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F1185, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_CLK_P254");

                entity.ToTable("TRS_CLK");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_CLK_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_CLK_F1034");

                entity.HasIndex(e => e.F1185)
                    .HasName("TRS_CLK_F1185");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TrsClt>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F1148, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_CLT_P254");

                entity.ToTable("TRS_CLT");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_CLT_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_CLT_F1034");

                entity.HasIndex(e => e.F1148)
                    .HasName("TRS_CLT_F1148");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1148)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TrsDpt>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F03, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_DPT_P254");

                entity.ToTable("TRS_DPT");

                entity.HasIndex(e => e.F03)
                    .HasName("TRS_DPT_F03");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_DPT_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_DPT_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TrsFin>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_FIN_P254");

                entity.ToTable("TRS_FIN");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_FIN_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_FIN_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TrsItm>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F01, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_ITM_P254");

                entity.ToTable("TRS_ITM");

                entity.HasIndex(e => e.F01)
                    .HasName("TRS_ITM_F01");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_ITM_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_ITM_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F01)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F30).HasColumnType("money");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TrsLog>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F990 })
                    .HasName("TRS_LOG_P254");

                entity.ToTable("TRS_LOG");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F990)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrsSub>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F04, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_SUB_P254");

                entity.ToTable("TRS_SUB");

                entity.HasIndex(e => e.F04)
                    .HasName("TRS_SUB_F04");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_SUB_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_SUB_F1034");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TrsVnd>(entity =>
            {
                entity.HasKey(e => new { e.F254, e.F1056, e.F1057, e.F27, e.F1032, e.F1034, e.F1101 })
                    .HasName("TRS_VND_P254");

                entity.ToTable("TRS_VND");

                entity.HasIndex(e => e.F1032)
                    .HasName("TRS_VND_F1032");

                entity.HasIndex(e => e.F1034)
                    .HasName("TRS_VND_F1034");

                entity.HasIndex(e => e.F27)
                    .HasName("TRS_VND_F27");

                entity.Property(e => e.F254).HasColumnType("datetime");

                entity.Property(e => e.F1056)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1057)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1036)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1079)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F65).HasColumnType("money");
            });

            modelBuilder.Entity<TzsTab>(entity =>
            {
                entity.HasKey(e => e.F1179)
                    .HasName("TZS_TAB_P1179");

                entity.ToTable("TZS_TAB");

                entity.Property(e => e.F1179).ValueGeneratedNever();

                entity.Property(e => e.F1183)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UntTab>(entity =>
            {
                entity.HasKey(e => new { e.F23, e.F1786 })
                    .HasName("UNT_TAB_P23");

                entity.ToTable("UNT_TAB");

                entity.Property(e => e.F23)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F1786)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.F1503)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F2877)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2878)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorDel>(entity =>
            {
                entity.HasKey(e => e.F27)
                    .HasName("VENDOR_DEL_P27");

                entity.ToTable("VENDOR_DEL");

                entity.HasIndex(e => e.F1001)
                    .HasName("VENDOR_DEL_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("VENDOR_DEL_F902");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1656)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1779)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1882)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1884).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1889)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1890)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1891)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1948)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1949)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2597)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2602)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F2603)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2635).HasColumnType("money");

                entity.Property(e => e.F2658)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2710)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F334)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F335)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F336)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F337)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F338)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F339)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F340)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F341)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F342)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F343)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F344)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F345)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F350)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.F351)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F352)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F353)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F354)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F355)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F356)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F357)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F358)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F359)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorTab>(entity =>
            {
                entity.HasKey(e => e.F27)
                    .HasName("VENDOR_TAB_P27");

                entity.ToTable("VENDOR_TAB");

                entity.HasIndex(e => e.F1001)
                    .HasName("VENDOR_TAB_F1001");

                entity.HasIndex(e => e.F902)
                    .HasName("VENDOR_TAB_F902");

                entity.Property(e => e.F27)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1642)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.F1656)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1779)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1882)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.F1884).HasColumnType("money");

                entity.Property(e => e.F1887)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F1889)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F1890)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F1891)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F1948)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F1949)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F1964)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F1966)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F253).HasColumnType("datetime");

                entity.Property(e => e.F2597)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2602)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.F2603)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2630)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.F2635).HasColumnType("money");

                entity.Property(e => e.F2658)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F2660)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F2710)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F334)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F335)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F336)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F337)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F338)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F339)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F340)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F341)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F342)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.F343)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.F344)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F345)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F350)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.F351)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F352)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.F353)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F354)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F355)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F356)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F357)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F358)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F359)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F902)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WatchTab>(entity =>
            {
                entity.HasKey(e => new { e.F2734, e.F1101 })
                    .HasName("WATCH_TAB_P2734");

                entity.ToTable("WATCH_TAB");

                entity.Property(e => e.F2734)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.F1000)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F1031)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.F1823)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2735)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2736)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.F2737)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.F2739)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2740)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2741)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F2742)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
