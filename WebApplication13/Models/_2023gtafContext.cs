using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication13.Models;

public partial class _2023gtafContext : DbContext
{
    public _2023gtafContext()
    {
    }

    public _2023gtafContext(DbContextOptions<_2023gtafContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CsTbCar> CsTbCars { get; set; }

    public virtual DbSet<CsTbCarBofa> CsTbCarBofas { get; set; }

    public virtual DbSet<CsTbCarStop> CsTbCarStops { get; set; }

    public virtual DbSet<CsTbCarType> CsTbCarTypes { get; set; }

    public virtual DbSet<CsTbCarTypeSub> CsTbCarTypeSubs { get; set; }

    public virtual DbSet<CsTbMenu> CsTbMenus { get; set; }

    public virtual DbSet<CsTbOliCard> CsTbOliCards { get; set; }

    public virtual DbSet<CsTbOliCardDe> CsTbOliCardDes { get; set; }

    public virtual DbSet<CsTbOliCardGet> CsTbOliCardGets { get; set; }

    public virtual DbSet<CsTbOliType> CsTbOliTypes { get; set; }

    public virtual DbSet<CsTbSet> CsTbSets { get; set; }

    public virtual DbSet<CsTcFixItemSub> CsTcFixItemSubs { get; set; }

    public virtual DbSet<CsTcManufacturer> CsTcManufacturers { get; set; }

    public virtual DbSet<CsTrPermission> CsTrPermissions { get; set; }

    public virtual DbSet<CsTrPermissionUser> CsTrPermissionUsers { get; set; }

    public virtual DbSet<CsTtExport> CsTtExports { get; set; }

    public virtual DbSet<CsTtExportUser> CsTtExportUsers { get; set; }

    public virtual DbSet<CsTtItemGet> CsTtItemGets { get; set; }

    public virtual DbSet<CsTtItemGetSub> CsTtItemGetSubs { get; set; }

    public virtual DbSet<CsTtItemGetSubLog> CsTtItemGetSubLogs { get; set; }

    public virtual DbSet<CsTtMaintainance> CsTtMaintainances { get; set; }

    public virtual DbSet<CsTtMaintainanceFa> CsTtMaintainanceFas { get; set; }

    public virtual DbSet<CsTtMaintainanceSet> CsTtMaintainanceSets { get; set; }

    public virtual DbSet<CsTtMaintainanceSub> CsTtMaintainanceSubs { get; set; }

    public virtual DbSet<CsTtOccurrence> CsTtOccurrences { get; set; }

    public virtual DbSet<CsTtOilMain> CsTtOilMains { get; set; }

    public virtual DbSet<CsTtOilSub> CsTtOilSubs { get; set; }

    public virtual DbSet<CsTtPurchase> CsTtPurchases { get; set; }

    public virtual DbSet<CsTtTransfer> CsTtTransfers { get; set; }

    public virtual DbSet<CsTtVender> CsTtVenders { get; set; }

    public virtual DbSet<CsTtwebserviceLog> CsTtwebserviceLogs { get; set; }

    public virtual DbSet<TbCar> TbCars { get; set; }

    public virtual DbSet<TbCarRecord> TbCarRecords { get; set; }

    public virtual DbSet<TbEmp> TbEmps { get; set; }

    public virtual DbSet<TbItemCode> TbItemCodes { get; set; }

    public virtual DbSet<TbItemType> TbItemTypes { get; set; }

    public virtual DbSet<TbSystemUnique> TbSystemUniques { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TcDept> TcDepts { get; set; }

    public virtual DbSet<TrPermission> TrPermissions { get; set; }

    public virtual DbSet<Tt> Tts { get; set; }

    public virtual DbSet<TtLog> TtLogs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CsTbCar>(entity =>
        {
            entity.ToTable("CS_tbCar");

            entity.HasIndex(e => e.Dept, "IDX_CAR_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnyRiskDate)
                .HasComment("任意險到期日")
                .HasColumnType("datetime")
                .HasColumnName("anyRiskDate");
            entity.Property(e => e.BodyNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("車身號碼")
                .HasColumnName("bodyNumber");
            entity.Property(e => e.Brand)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("車機品牌")
                .HasColumnName("brand");
            entity.Property(e => e.BrandId)
                .HasComment("電信品牌ID")
                .HasColumnName("brandId");
            entity.Property(e => e.BuyDate)
                .HasComment("購置日期")
                .HasColumnType("datetime")
                .HasColumnName("buyDate");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("車牌")
                .HasColumnName("car_licence");
            entity.Property(e => e.CarWeight)
                .HasComment("車重")
                .HasColumnName("carWeight");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Chk1).HasColumnName("chk1");
            entity.Property(e => e.Chk2).HasColumnName("chk2");
            entity.Property(e => e.Chk3).HasColumnName("chk3");
            entity.Property(e => e.Chk4).HasColumnName("chk4");
            entity.Property(e => e.CompulsoryInsuranceDate)
                .HasComment("強制險到期日")
                .HasColumnType("datetime")
                .HasColumnName("compulsoryInsuranceDate");
            entity.Property(e => e.Cost)
                .HasComment("購置價格(費用)")
                .HasColumnName("cost");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Cylinder)
                .HasComment("汽缸排氣量")
                .HasColumnName("cylinder");
            entity.Property(e => e.Dept)
                .HasComment("區別")
                .HasColumnName("dept");
            entity.Property(e => e.Driver)
                .HasMaxLength(50)
                .HasColumnName("driver");
            entity.Property(e => e.DriverId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("driverID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("editDate");
            entity.Property(e => e.EditId)
                .HasMaxLength(50)
                .HasColumnName("editId");
            entity.Property(e => e.EditTime).HasColumnName("editTime");
            entity.Property(e => e.EndUseDate)
                .HasComment("車輛歸屬日期迄")
                .HasColumnType("datetime")
                .HasColumnName("endUseDate");
            entity.Property(e => e.EngineNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("引擎號碼")
                .HasColumnName("engineNumber");
            entity.Property(e => e.EpPeriod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("環保期數")
                .HasColumnName("epPeriod");
            entity.Property(e => e.EpPeriodId)
                .HasComment("環保期數ID")
                .HasColumnName("epPeriodId");
            entity.Property(e => e.Flag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.FrontTireNum)
                .HasComment("前輪輪數")
                .HasColumnName("frontTireNum");
            entity.Property(e => e.FrontTireSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("前輪尺寸")
                .HasColumnName("frontTireSize");
            entity.Property(e => e.FrontTireSizeId)
                .HasComment("前輪尺寸ID")
                .HasColumnName("frontTireSizeId");
            entity.Property(e => e.FuelTax)
                .HasComment("燃料稅")
                .HasColumnName("fuelTax");
            entity.Property(e => e.InsideSystem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("是否已納入清潔車即時衛星\r\n定位便民查詢及管理系統")
                .HasColumnName("insideSystem");
            entity.Property(e => e.IsFuelTax)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("是否繳納燃料稅")
                .HasColumnName("isFuelTax");
            entity.Property(e => e.IsLicenseTax)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("是否繳納牌照稅")
                .HasColumnName("isLicenseTax");
            entity.Property(e => e.IsMachine)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("是否機具")
                .HasColumnName("isMachine");
            entity.Property(e => e.Keeper)
                .HasMaxLength(50)
                .HasComment("保管人")
                .HasColumnName("keeper");
            entity.Property(e => e.LicenseDate)
                .HasComment("發照日期")
                .HasColumnType("datetime")
                .HasColumnName("licenseDate");
            entity.Property(e => e.LicenseTax)
                .HasComment("牌照稅")
                .HasColumnName("licenseTax");
            entity.Property(e => e.LicenseType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("牌照類別")
                .HasColumnName("licenseType");
            entity.Property(e => e.LicenseTypeId)
                .HasComment("牌照類別ID")
                .HasColumnName("licenseTypeId");
            entity.Property(e => e.MakeYearMonth)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("出廠年月")
                .HasColumnName("makeYearMonth");
            entity.Property(e => e.Memo)
                .HasMaxLength(300)
                .HasComment("備註")
                .HasColumnName("memo");
            entity.Property(e => e.MileToMaintain)
                .HasComment("每次需保養的公里數")
                .HasColumnName("mileToMaintain");
            entity.Property(e => e.MonthlyFee)
                .HasComment("月租費")
                .HasColumnName("monthlyFee");
            entity.Property(e => e.NewVehicleNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("車輛編號(新)")
                .HasColumnName("newVehicleNo");
            entity.Property(e => e.Num)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("財產編號")
                .HasColumnName("num");
            entity.Property(e => e.OldVehicleNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("車輛編號(舊)")
                .HasColumnName("oldVehicleNo");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasComment("來源")
                .HasColumnName("origin");
            entity.Property(e => e.OtherItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("其他附屬設備")
                .HasColumnName("otherItem");
            entity.Property(e => e.Passenger)
                .HasComment("乘客人數(不含司機)")
                .HasColumnName("passenger");
            entity.Property(e => e.Pic1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("前")
                .HasColumnName("pic1");
            entity.Property(e => e.Pic2)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("後")
                .HasColumnName("pic2");
            entity.Property(e => e.Pic3)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("左")
                .HasColumnName("pic3");
            entity.Property(e => e.Pic4)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("右")
                .HasColumnName("pic4");
            entity.Property(e => e.Pic5)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("行車執照照片")
                .HasColumnName("pic5");
            entity.Property(e => e.Power)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("能源種類")
                .HasColumnName("power");
            entity.Property(e => e.PowerId)
                .HasComment("能源種類ID")
                .HasColumnName("powerId");
            entity.Property(e => e.PreStatus).HasColumnName("pre_status");
            entity.Property(e => e.RearTireNum)
                .HasComment("後輪輪數")
                .HasColumnName("rearTireNum");
            entity.Property(e => e.RearTireSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("後輪尺寸")
                .HasColumnName("rearTireSize");
            entity.Property(e => e.RearTireSizeId)
                .HasComment("後輪尺寸ID")
                .HasColumnName("rearTireSizeId");
            entity.Property(e => e.ScrapDate)
                .HasComment("報廢日期")
                .HasColumnType("datetime")
                .HasColumnName("scrapDate");
            entity.Property(e => e.Source)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("購置經費來源")
                .HasColumnName("source");
            entity.Property(e => e.SourceId)
                .HasComment("購置經費來源ID")
                .HasColumnName("sourceId");
            entity.Property(e => e.StartUseDate)
                .HasComment("開始使用日期")
                .HasColumnType("datetime")
                .HasColumnName("startUseDate");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("使用狀況")
                .HasColumnName("status");
            entity.Property(e => e.StatusId)
                .HasComment("使用狀況ID")
                .HasColumnName("statusId");
            entity.Property(e => e.StopTime)
                .HasColumnType("datetime")
                .HasColumnName("stop_time");
            entity.Property(e => e.TelNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("門號")
                .HasColumnName("telNumber");
            entity.Property(e => e.Telecom)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("電信業者")
                .HasColumnName("telecom");
            entity.Property(e => e.TelecomId)
                .HasComment("電信ID")
                .HasColumnName("telecomId");
            entity.Property(e => e.TransferInDate)
                .HasColumnType("datetime")
                .HasColumnName("transferInDate");
            entity.Property(e => e.TransferOutDate)
                .HasColumnType("datetime")
                .HasColumnName("transferOutDate");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
            entity.Property(e => e.Urea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("是否需添加尿素")
                .HasColumnName("urea");
            entity.Property(e => e.Usage)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("主要用途")
                .HasColumnName("usage");
            entity.Property(e => e.UsageId)
                .HasComment("主要用途ID")
                .HasColumnName("usageId");
            entity.Property(e => e.Using)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("使用人")
                .HasColumnName("using");
            entity.Property(e => e.Uuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uuser");
            entity.Property(e => e.VehicleBudgetKindId)
                .HasComment("預算車輛種類ID")
                .HasColumnName("vehicleBudgetKindId");
            entity.Property(e => e.VehicleColor)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("顏色")
                .HasColumnName("vehicleColor");
            entity.Property(e => e.VehicleColorId)
                .HasComment("顏色ID")
                .HasColumnName("vehicleColorId");
            entity.Property(e => e.VehicleKindId)
                .HasComment("主種類")
                .HasColumnName("vehicleKindId");
            entity.Property(e => e.VehicleKindId2)
                .HasComment("次種類")
                .HasColumnName("vehicleKindId2");
            entity.Property(e => e.VehicleKindM).HasColumnName("vehicleKindM");
            entity.Property(e => e.VehicleLoad)
                .HasComment("載重")
                .HasColumnName("vehicleLoad");
            entity.Property(e => e.VehicleMake)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("廠牌")
                .HasColumnName("vehicleMake");
            entity.Property(e => e.VehicleMakeId)
                .HasComment("廠牌ID")
                .HasColumnName("vehicleMakeId");
            entity.Property(e => e.VehicleModel)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("車身式樣")
                .HasColumnName("vehicleModel");
            entity.Property(e => e.VehicleModelId)
                .HasComment("車身式樣ID")
                .HasColumnName("vehicleModelId");
            entity.Property(e => e.VehicleRegistKindId)
                .HasComment("行照車輛種類ID")
                .HasColumnName("vehicleRegistKindId");
            entity.Property(e => e.VehicleVolume)
                .HasComment("容積(立方數)")
                .HasColumnName("vehicleVolume");
            entity.Property(e => e.VehicleWeight)
                .HasComment("總重")
                .HasColumnName("vehicleWeight");
            entity.Property(e => e.VerifyDate)
                .HasComment("審核日期")
                .HasColumnType("datetime")
                .HasColumnName("verifyDate");
            entity.Property(e => e.VerifyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("審核人員ID")
                .HasColumnName("verifyId");
            entity.Property(e => e.VerifyStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("審核結果")
                .HasColumnName("verifyStatus");
            entity.Property(e => e.VerifyTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComment("審核時間")
                .HasColumnName("verifyTime");
            entity.Property(e => e.WorkArea)
                .HasMaxLength(50)
                .HasComment("作業廠址")
                .HasColumnName("workArea");
        });

        modelBuilder.Entity<CsTbCarBofa>(entity =>
        {
            entity.ToTable("CS_tbCarBofa");

            entity.HasIndex(e => e.Dept, "IDX_CARBOFA_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Chk)
                .HasDefaultValue(0)
                .HasColumnName("chk");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.NewVehicleNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("newVehicleNo");
            entity.Property(e => e.Rdate).HasColumnType("datetime");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("reason");
            entity.Property(e => e.Sdate).HasColumnType("datetime");
            entity.Property(e => e.Snum)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<CsTbCarStop>(entity =>
        {
            entity.ToTable("CS_tbCarStop");

            entity.HasIndex(e => e.Dept, "IDX_CARSTOP_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.Memo)
                .HasMaxLength(200)
                .HasColumnName("memo");
            entity.Property(e => e.NewVehicleNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("newVehicleNo");
            entity.Property(e => e.StopTime)
                .HasColumnType("datetime")
                .HasColumnName("stop_time");
        });

        modelBuilder.Entity<CsTbCarType>(entity =>
        {
            entity.ToTable("CS_tbCarType");

            entity.Property(e => e.Id)
                .HasComment("自動編碼")
                .HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasComment("建立日期")
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("建立人員")
                .HasColumnName("cuser");
            entity.Property(e => e.MMemo)
                .HasMaxLength(50)
                .HasComment("備註")
                .HasColumnName("m_memo");
            entity.Property(e => e.MName)
                .HasMaxLength(50)
                .HasComment("車輛/機具種類名稱")
                .HasColumnName("m_name");
            entity.Property(e => e.MNum)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("車輛/機具種類代碼")
                .HasColumnName("m_num");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasComment("1:車輛 2:機具")
                .HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasComment("更新日期")
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("更新人員")
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTbCarTypeSub>(entity =>
        {
            entity.ToTable("CS_tbCarTypeSub");

            entity.Property(e => e.Id)
                .HasComment("自動編碼")
                .HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasComment("建立日期")
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("建立人員")
                .HasColumnName("cuser");
            entity.Property(e => e.MId)
                .HasComment("對應CS_tbCarType.id")
                .HasColumnName("m_id");
            entity.Property(e => e.NeedVolume)
                .HasDefaultValue(0)
                .HasColumnName("needVolume");
            entity.Property(e => e.SMemo)
                .HasMaxLength(50)
                .HasComment("備註")
                .HasColumnName("s_memo");
            entity.Property(e => e.SName)
                .HasMaxLength(50)
                .HasComment("名稱")
                .HasColumnName("s_name");
            entity.Property(e => e.SNum)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("編號")
                .HasColumnName("s_num");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.Udate)
                .HasComment("更新日期")
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("更新人員")
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTbMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK_twMenu_1");

            entity.ToTable("CS_tbMenu", tb => tb.HasComment("網站目錄"));

            entity.Property(e => e.MenuId)
                .HasComment("pk")
                .HasColumnName("menu_id");
            entity.Property(e => e.Cdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.MenuClass)
                .HasDefaultValue(1)
                .HasComment("所屬階層")
                .HasColumnName("menu_class");
            entity.Property(e => e.MenuIcon)
                .HasMaxLength(2000)
                .HasComment("功能icon")
                .HasColumnName("menu_icon");
            entity.Property(e => e.MenuImage)
                .HasMaxLength(50)
                .HasColumnName("menu_image");
            entity.Property(e => e.MenuLastId)
                .HasComment("上一階選單id ")
                .HasColumnName("menu_LastId");
            entity.Property(e => e.MenuName)
                .HasMaxLength(30)
                .HasComment("選單名稱")
                .HasColumnName("menu_name");
            entity.Property(e => e.MenuSort)
                .HasComment("排序")
                .HasColumnName("menu_sort");
            entity.Property(e => e.MenuStatus)
                .HasDefaultValue(true)
                .HasComment("1.啟用(預設) 0.關閉")
                .HasColumnName("menu_status");
            entity.Property(e => e.MenuUrl)
                .HasMaxLength(100)
                .HasComment("預設連結")
                .HasColumnName("menu_url");
        });

        modelBuilder.Entity<CsTbOliCard>(entity =>
        {
            entity.ToTable("CS_tbOliCard");

            entity.HasIndex(e => e.Dept, "IDX_OliCard_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.Keep)
                .HasMaxLength(20)
                .HasColumnName("keep");
            entity.Property(e => e.Num)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num");
            entity.Property(e => e.ScrapeDate)
                .HasColumnType("datetime")
                .HasColumnName("scrape_date");
            entity.Property(e => e.TAmount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("t_amount");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.UseDate)
                .HasColumnType("datetime")
                .HasColumnName("use_date");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTbOliCardDe>(entity =>
        {
            entity.ToTable("CS_tbOliCardDe");

            entity.HasIndex(e => e.Dept, "IDX_OliCardDe_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.OliDate)
                .HasColumnType("datetime")
                .HasColumnName("oli_date");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTbOliCardGet>(entity =>
        {
            entity.ToTable("CS_tbOliCardGet");

            entity.HasIndex(e => e.Dept, "IDX_OliCardGet_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.Last)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("last");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.Old)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("old");
            entity.Property(e => e.OliDate)
                .HasColumnType("datetime")
                .HasColumnName("oli_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTbOliType>(entity =>
        {
            entity.ToTable("CS_tbOliType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<CsTbSet>(entity =>
        {
            entity.ToTable("CS_tbSet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EVal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("e_val");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.RId).HasColumnName("r_id");
            entity.Property(e => e.SVal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("s_val");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTcFixItemSub>(entity =>
        {
            entity.ToTable("CS_tcFixItemSub");

            entity.HasIndex(e => e.Dept, "IDX_FixItemSub_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.CodeName)
                .HasMaxLength(20)
                .HasColumnName("code_name");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.Inventory)
                .HasComment("庫存數量")
                .HasColumnName("inventory");
            entity.Property(e => e.InventorySafe)
                .HasComment("安全庫存數量")
                .HasColumnName("inventory_safe");
            entity.Property(e => e.Place)
                .HasMaxLength(50)
                .HasColumnName("place");
            entity.Property(e => e.Sort).HasColumnName("sort");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasComment("單位")
                .HasColumnName("unit");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTcManufacturer>(entity =>
        {
            entity.ToTable("CS_tcManufacturer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .HasColumnName("cuser");
            entity.Property(e => e.Note)
                .HasMaxLength(200)
                .HasColumnName("note");
            entity.Property(e => e.PId).HasColumnName("P_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .HasColumnName("uuser");
            entity.Property(e => e.Vendor)
                .HasMaxLength(50)
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<CsTrPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_trPermissionGroup");

            entity.ToTable("CS_trPermission");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.UserNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_No");
            entity.Property(e => e.UserRole).HasColumnName("User_Role");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTrPermissionUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CS_trPermissionGroup");

            entity.ToTable("CS_trPermissionUser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.UserNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_No");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ttExport");

            entity.ToTable("CS_ttExport");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("e_name");
            entity.Property(e => e.Fixed)
                .HasDefaultValue(true)
                .HasColumnName("fixed");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Sort).HasColumnName("sort");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<CsTtExportUser>(entity =>
        {
            entity.ToTable("CS_ttExportUser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EId).HasColumnName("e_id");
            entity.Property(e => e.Sort).HasColumnName("sort");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("user_no");
        });

        modelBuilder.Entity<CsTtItemGet>(entity =>
        {
            entity.ToTable("CS_ttItemGet");

            entity.HasIndex(e => e.Dept, "IDX_ItemGet_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("in_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("reason");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtItemGetSub>(entity =>
        {
            entity.ToTable("CS_ttItemGetSub");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.LeftCount).HasColumnName("left_count");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.OldCount).HasColumnName("old_count");
            entity.Property(e => e.People)
                .HasMaxLength(20)
                .HasColumnName("people");
            entity.Property(e => e.SId).HasColumnName("s_id");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");
            entity.Property(e => e.UseCount).HasColumnName("use_count");
            entity.Property(e => e.VId).HasColumnName("v_id");
        });

        modelBuilder.Entity<CsTtItemGetSubLog>(entity =>
        {
            entity.ToTable("CS_ttItemGetSubLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.LeftCount).HasColumnName("left_count");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.OldCount).HasColumnName("old_count");
            entity.Property(e => e.SId).HasColumnName("s_id");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.UseCount).HasColumnName("use_count");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtMaintainance>(entity =>
        {
            entity.ToTable("CS_ttMaintainance");

            entity.HasIndex(e => e.Dept, "IDX_Maintainance_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(30)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("in_date");
            entity.Property(e => e.MNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("m_num");
            entity.Property(e => e.Mileage)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("mileage");
            entity.Property(e => e.Num1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num1");
            entity.Property(e => e.Num2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num2");
            entity.Property(e => e.OldValue).HasColumnName("old_value");
            entity.Property(e => e.OutDate)
                .HasColumnType("datetime")
                .HasColumnName("out_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(400)
                .HasColumnName("reason");
            entity.Property(e => e.Timemin).HasColumnName("timemin");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Type1).HasColumnName("type1");
            entity.Property(e => e.Type2).HasColumnName("type2");
            entity.Property(e => e.Type3).HasColumnName("type3");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
            entity.Property(e => e.Vender).HasColumnName("vender");
        });

        modelBuilder.Entity<CsTtMaintainanceFa>(entity =>
        {
            entity.ToTable("CS_ttMaintainanceFa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtMaintainanceSet>(entity =>
        {
            entity.ToTable("CS_ttMaintainanceSet");

            entity.HasIndex(e => e.Dept, "IDX_MaintainanceSet_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.SetYear)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("set_year");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
            entity.Property(e => e.VId).HasColumnName("v_id");
        });

        modelBuilder.Entity<CsTtMaintainanceSub>(entity =>
        {
            entity.ToTable("CS_ttMaintainanceSub");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("cost");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.Memo)
                .HasMaxLength(500)
                .HasColumnName("memo");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Num)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<CsTtOccurrence>(entity =>
        {
            entity.ToTable("CS_ttOccurrence");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("in_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .HasColumnName("reason");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtOilMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CS_ttOliMain");

            entity.ToTable("CS_ttOilMain");

            entity.HasIndex(e => e.Dept, "IDX_OilMain_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(20)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.EId).HasColumnName("e_id");
            entity.Property(e => e.EngineOilNum)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("engineOilNum");
            entity.Property(e => e.Memo)
                .HasMaxLength(200)
                .HasColumnName("memo");
            entity.Property(e => e.Mileage)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("mileage");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("month");
            entity.Property(e => e.Num)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("num");
            entity.Property(e => e.Num1)
                .HasMaxLength(50)
                .HasColumnName("num1");
            entity.Property(e => e.Num2)
                .HasMaxLength(50)
                .HasColumnName("num2");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalMileage)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
            entity.Property(e => e.Year)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<CsTtOilSub>(entity =>
        {
            entity.ToTable("CS_ttOilSub");

            entity.HasIndex(e => e.Dept, "IDX_OilSub_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(20)
                .HasColumnName("car_licence");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("cost");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Date1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date1");
            entity.Property(e => e.Date2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date2");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.ImportType).HasColumnName("import_type");
            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("in_date");
            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.Num)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("num");
            entity.Property(e => e.Oiltype).HasColumnName("oiltype");
            entity.Property(e => e.Station)
                .HasMaxLength(20)
                .HasColumnName("station");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("total");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtPurchase>(entity =>
        {
            entity.ToTable("CS_ttPurchase");

            entity.HasIndex(e => e.Dept, "IDX_Purchase_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("cost");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("in_date");
            entity.Property(e => e.LastCount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("last_count");
            entity.Property(e => e.Note)
                .HasMaxLength(200)
                .HasColumnName("note");
            entity.Property(e => e.OldAmount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("old_amount");
            entity.Property(e => e.SId).HasColumnName("s_id");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .HasColumnName("uuser");
            entity.Property(e => e.VId).HasColumnName("V_id");
        });

        modelBuilder.Entity<CsTtTransfer>(entity =>
        {
            entity.ToTable("CS_ttTransfer");

            entity.HasIndex(e => new { e.Odept, e.Ndept }, "IDX_Purchase_DEPT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.MId).HasColumnName("m_id");
            entity.Property(e => e.Ndept).HasColumnName("ndept");
            entity.Property(e => e.Odept).HasColumnName("odept");
            entity.Property(e => e.Transfer)
                .HasColumnType("datetime")
                .HasColumnName("transfer");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<CsTtVender>(entity =>
        {
            entity.ToTable("CS_ttVender");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addr)
                .HasMaxLength(50)
                .HasColumnName("addr");
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("area");
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Code)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .HasColumnName("contact");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Flag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Memo)
                .HasMaxLength(200)
                .HasColumnName("memo");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone2");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
            entity.Property(e => e.VatNum)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("vatNum");
        });

        modelBuilder.Entity<CsTtwebserviceLog>(entity =>
        {
            entity.ToTable("CS_ttwebservice_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FunctionName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("function_name");
            entity.Property(e => e.ReqData).HasColumnName("req_data");
            entity.Property(e => e.ReqDatetime)
                .HasColumnType("datetime")
                .HasColumnName("req_datetime");
            entity.Property(e => e.ReqIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("req_ip");
            entity.Property(e => e.ReqUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("req_user");
            entity.Property(e => e.RespData).HasColumnName("resp_data");
            entity.Property(e => e.RespDatetime)
                .HasColumnType("datetime")
                .HasColumnName("resp_datetime");
        });

        modelBuilder.Entity<TbCar>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK_tbCar_1");

            entity.ToTable("tbCar");

            entity.Property(e => e.CarId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("car_id");
            entity.Property(e => e.AreaType)
                .HasDefaultValue(0)
                .HasComment("(0無1北屯東2北屯西)")
                .HasColumnName("area_type");
            entity.Property(e => e.AreaType2)
                .HasDefaultValueSql("('0')")
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("area_type2");
            entity.Property(e => e.BackStatus).HasColumnName("Back_Status");
            entity.Property(e => e.BreakStatus).HasColumnName("Break_Status");
            entity.Property(e => e.CarAssort)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("0000")
                .HasColumnName("Car_Assort");
            entity.Property(e => e.CarInDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("Car_In_Date");
            entity.Property(e => e.CarIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Car_IP");
            entity.Property(e => e.CarLicence)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("car_licence");
            entity.Property(e => e.CarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("car_no");
            entity.Property(e => e.CarTel)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("car_tel");
            entity.Property(e => e.CarType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("car_type");
            entity.Property(e => e.CarType1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("_car_type");
            entity.Property(e => e.CarkitType)
                .HasDefaultValue((byte)2)
                .HasColumnName("carkit_type");
            entity.Property(e => e.Carnote)
                .HasMaxLength(500)
                .HasComment("車管備註")
                .HasColumnName("carnote");
            entity.Property(e => e.Compressor).HasColumnName("compressor");
            entity.Property(e => e.Container)
                .HasMaxLength(200)
                .HasComment("容積")
                .HasColumnName("container");
            entity.Property(e => e.ContainerNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("_container_no");
            entity.Property(e => e.ContainerSpec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("_container_spec");
            entity.Property(e => e.Corp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("corp");
            entity.Property(e => e.Course)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CourseArrow)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("?")
                .IsFixedLength()
                .HasColumnName("_course_arrow");
            entity.Property(e => e.Custodian)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("custodian");
            entity.Property(e => e.Delaytime)
                .HasDefaultValue(0)
                .HasColumnName("delaytime");
            entity.Property(e => e.Dept)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("dept");
            entity.Property(e => e.DeptName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("_dept_name");
            entity.Property(e => e.DfssId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Dfss_id");
            entity.Property(e => e.DirectionLight).HasColumnName("direction_light");
            entity.Property(e => e.DispDt)
                .HasColumnType("smalldatetime")
                .HasColumnName("disp_dt");
            entity.Property(e => e.DispDt2)
                .HasColumnType("smalldatetime")
                .HasColumnName("disp_dt2");
            entity.Property(e => e.Door1).HasColumnName("door1");
            entity.Property(e => e.Door2).HasColumnName("door2");
            entity.Property(e => e.Door3).HasColumnName("door3");
            entity.Property(e => e.DragCar)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("drag_car");
            entity.Property(e => e.Driver)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("driver");
            entity.Property(e => e.Dt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dt");
            entity.Property(e => e.DvrId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Dvr_id");
            entity.Property(e => e.Edt)
                .HasColumnType("datetime")
                .HasColumnName("edt");
            entity.Property(e => e.EmpName)
                .HasMaxLength(12)
                .HasColumnName("_emp_name");
            entity.Property(e => e.EmpTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("_emp_tel");
            entity.Property(e => e.Fcavg)
                .HasDefaultValue(5.0)
                .HasColumnName("fcavg");
            entity.Property(e => e.Icontype)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("01");
            entity.Property(e => e.Io1).HasColumnName("IO1");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("_IP");
            entity.Property(e => e.LastDt)
                .HasColumnType("datetime")
                .HasColumnName("last_dt");
            entity.Property(e => e.LastMileage)
                .HasDefaultValue(0)
                .HasColumnName("Last_mileage");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("last_status");
            entity.Property(e => e.Mileages)
                .HasDefaultValue(0)
                .HasColumnName("mileages");
            entity.Property(e => e.Movecar).HasColumnName("movecar");
            entity.Property(e => e.Movecartxt)
                .HasMaxLength(200)
                .HasColumnName("movecartxt");
            entity.Property(e => e.NodeCaption)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("_node_caption");
            entity.Property(e => e.NodeId).HasColumnName("node_id");
            entity.Property(e => e.NodeId2).HasColumnName("node_id2");
            entity.Property(e => e.Notetxt)
                .HasColumnType("ntext")
                .HasColumnName("notetxt");
            entity.Property(e => e.Notinxls)
                .HasDefaultValue(0)
                .HasComment("車機清冊排除(1是0否)")
                .HasColumnName("notinxls");
            entity.Property(e => e.Oldcar).HasColumnName("oldcar");
            entity.Property(e => e.Oldcartxt)
                .HasMaxLength(200)
                .HasColumnName("oldcartxt");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("_order_no");
            entity.Property(e => e.Pointnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("判斷是否有踩清運點用")
                .HasColumnName("pointnumber");
            entity.Property(e => e.Port).HasColumnName("_PORT");
            entity.Property(e => e.R1).HasMaxLength(1);
            entity.Property(e => e.R2).HasMaxLength(1);
            entity.Property(e => e.R3).HasMaxLength(1);
            entity.Property(e => e.R4).HasMaxLength(1);
            entity.Property(e => e.R5).HasMaxLength(1);
            entity.Property(e => e.R6).HasMaxLength(1);
            entity.Property(e => e.R7).HasMaxLength(1);
            entity.Property(e => e.RcvSeq02).HasColumnName("rcv_seq02");
            entity.Property(e => e.Rectype).HasColumnName("rectype");
            entity.Property(e => e.Remark).HasMaxLength(400);
            entity.Property(e => e.ReplacecarId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("replacecar_id");
            entity.Property(e => e.Rfid1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RFID_1");
            entity.Property(e => e.Rfid2)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RFID_2");
            entity.Property(e => e.Rfid3)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RFID_3");
            entity.Property(e => e.Rfid4)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RFID_4");
            entity.Property(e => e.Rfid5)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RFID_5");
            entity.Property(e => e.Rfid6)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RFID_6");
            entity.Property(e => e.RouteId).HasColumnName("route_id");
            entity.Property(e => e.RouteNode).HasColumnName("route_node");
            entity.Property(e => e.RouteStatus).HasColumnName("route_status");
            entity.Property(e => e.Sdt)
                .HasColumnType("datetime")
                .HasColumnName("sdt");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)100)
                .HasColumnName("status");
            entity.Property(e => e.Status2).HasColumnName("status2");
            entity.Property(e => e.StatusDescr)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("???")
                .HasColumnName("_status_descr");
            entity.Property(e => e.StatusSeq).HasColumnName("_status_seq");
            entity.Property(e => e.Stay).HasDefaultValue(0);
            entity.Property(e => e.SuNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Su_No");
            entity.Property(e => e.TailLicence)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("_tail_licence");
            entity.Property(e => e.Temperature).HasDefaultValue(0.0);
            entity.Property(e => e.Temperature1).HasDefaultValue(0.0);
            entity.Property(e => e.Tractor).HasColumnName("tractor");
            entity.Property(e => e.UTel)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("U_Tel");
            entity.Property(e => e.Uptime)
                .HasColumnType("datetime")
                .HasColumnName("uptime");
            entity.Property(e => e.Usetype)
                .HasMaxLength(200)
                .HasComment("使用狀態")
                .HasColumnName("usetype");
            entity.Property(e => e.Value1)
                .HasDefaultValue(0)
                .HasColumnName("value1");
            entity.Property(e => e.Value2)
                .HasDefaultValue(0)
                .HasColumnName("value2");
            entity.Property(e => e.Value3)
                .HasDefaultValue(0)
                .HasColumnName("value3");
            entity.Property(e => e.Value4).HasColumnName("value4");
            entity.Property(e => e.VideoCount).HasColumnName("video_count");
            entity.Property(e => e.Voltage).HasDefaultValue(0.0);
            entity.Property(e => e.WCaption)
                .HasMaxLength(60)
                .HasColumnName("wCaption");
            entity.Property(e => e.WSpeed).HasColumnName("wSPEED");
            entity.Property(e => e.Warning).HasColumnName("warning");
            entity.Property(e => e.WarningDescr)
                .HasMaxLength(50)
                .HasColumnName("warning_descr");
            entity.Property(e => e.Wdriver)
                .HasMaxLength(10)
                .HasColumnName("wdriver");
            entity.Property(e => e.Wdt)
                .HasColumnType("datetime")
                .HasColumnName("wdt");
            entity.Property(e => e.WebCamSip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("WebCam_SIP");
            entity.Property(e => e.WgsX)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("wgs_x");
            entity.Property(e => e.WgsY)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("wgs_y");
            entity.Property(e => e.WindowStatus).HasColumnName("Window_Status");
            entity.Property(e => e.Wx)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("wx");
            entity.Property(e => e.Wy)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("wy");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
        });

        modelBuilder.Entity<TbCarRecord>(entity =>
        {
            entity.HasKey(e => new { e.CarLicence, e.Dt });

            entity.ToTable("tbCarRecord");

            entity.Property(e => e.CarLicence)
                .HasMaxLength(10)
                .HasColumnName("car_licence");
            entity.Property(e => e.Dt)
                .HasColumnType("datetime")
                .HasColumnName("dt");
            entity.Property(e => e.Avgspeed).HasColumnName("avgspeed");
            entity.Property(e => e.Corp)
                .HasMaxLength(10)
                .HasColumnName("corp");
            entity.Property(e => e.Dept)
                .HasMaxLength(10)
                .HasColumnName("dept");
            entity.Property(e => e.Disconnect)
                .HasComment("斷訊")
                .HasColumnName("disconnect");
            entity.Property(e => e.DisconnectShutdown)
                .HasComment("斷訊/關機")
                .HasColumnName("disconnect_shutdown");
            entity.Property(e => e.EndDt)
                .HasColumnType("datetime")
                .HasColumnName("end_dt");
            entity.Property(e => e.Hispeed).HasColumnName("hispeed");
            entity.Property(e => e.HiwayKm).HasColumnName("hiway_km");
            entity.Property(e => e.InsideShutdown)
                .HasComment("場內關機")
                .HasColumnName("inside_shutdown");
            entity.Property(e => e.OusideShutdown)
                .HasComment("場外關機")
                .HasColumnName("ouside_shutdown");
            entity.Property(e => e.OusideStop)
                .HasComment("在外暫停")
                .HasColumnName("ouside_stop");
            entity.Property(e => e.Overspeed).HasColumnName("overspeed");
            entity.Property(e => e.Overspeed0)
                .HasComment("超速30秒以下")
                .HasColumnName("overspeed0");
            entity.Property(e => e.Overspeed120)
                .HasComment("超速120秒以上")
                .HasColumnName("overspeed120");
            entity.Property(e => e.Overspeed30)
                .HasComment("超速30秒以上")
                .HasColumnName("overspeed30");
            entity.Property(e => e.Overspeed60)
                .HasComment("超速60秒以上")
                .HasColumnName("overspeed60");
            entity.Property(e => e.ParkingTime).HasColumnName("parking_time");
            entity.Property(e => e.RunKm).HasColumnName("run_km ");
            entity.Property(e => e.RunTime).HasColumnName("run_time");
            entity.Property(e => e.RunTime2)
                .HasComment("區隊圍籬外行駛時間")
                .HasColumnName("run_time2");
            entity.Property(e => e.StartDt)
                .HasColumnType("datetime")
                .HasColumnName("start_dt");
            entity.Property(e => e.StopCount).HasColumnName("stop_count");
            entity.Property(e => e.StrandCount).HasColumnName("strand_count");
        });

        modelBuilder.Entity<TbEmp>(entity =>
        {
            entity.HasKey(e => new { e.SuNo, e.EmpId });

            entity.ToTable("tbEmp");

            entity.Property(e => e.SuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Su_No");
            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Emp_ID");
            entity.Property(e => e.Adderss2)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Admin).HasColumnName("admin");
            entity.Property(e => e.Assurance)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("assurance");
            entity.Property(e => e.Bailoutliaison)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Birthday).HasColumnType("smalldatetime");
            entity.Property(e => e.Blood)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Brokerage)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("brokerage");
            entity.Property(e => e.CarMan)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CarNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("car_no");
            entity.Property(e => e.CardId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Card_id");
            entity.Property(e => e.Cardno)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Carmunber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cdate)
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Corp)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuser");
            entity.Property(e => e.Dept)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Dri).HasColumnName("dri");
            entity.Property(e => e.Education)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("Emp_name");
            entity.Property(e => e.EmpTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Emp_tel");
            entity.Property(e => e.EmpType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Emp_Type");
            entity.Property(e => e.Experience)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("experience");
            entity.Property(e => e.ExperienceDateS).HasColumnType("smalldatetime");
            entity.Property(e => e.FaceDetect)
                .IsUnicode(false)
                .HasComment("人臉");
            entity.Property(e => e.Finger)
                .IsUnicode(false)
                .HasComment("指紋");
            entity.Property(e => e.Fingerprint)
                .HasDefaultValue(false)
                .HasComment("是否有指紋")
                .HasColumnName("fingerprint");
            entity.Property(e => e.Fosteramount)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Height)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("hire_date");
            entity.Property(e => e.Idcardno).HasMaxLength(100);
            entity.Property(e => e.Job)
                .HasMaxLength(200)
                .HasColumnName("job");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.Leave).HasDefaultValue(false);
            entity.Property(e => e.Leaveofficedate).HasColumnType("smalldatetime");
            entity.Property(e => e.LiaisonTel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Liaisonaddress)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Lic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lic");
            entity.Property(e => e.Licence)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("licence");
            entity.Property(e => e.Line)
                .HasMaxLength(200)
                .HasColumnName("line");
            entity.Property(e => e.Marriage)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.Pid)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Rem).HasMaxLength(200);
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Sex).HasDefaultValue(false);
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Takeofficedate).HasColumnType("smalldatetime");
            entity.Property(e => e.Tel1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tel2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uuser");
            entity.Property(e => e.Weight)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Year)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<TbItemCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbItemCodes_1");

            entity.ToTable("tbItemCodes");

            entity.Property(e => e.Id)
                .HasComment("自動編碼")
                .HasColumnName("id");
            entity.Property(e => e.ActiveFlag)
                .HasDefaultValue(true)
                .HasComment("啟用狀態")
                .HasColumnName("active_flag");
            entity.Property(e => e.Cdate)
                .HasComment("建立時間")
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("建立者")
                .HasColumnName("cuser");
            entity.Property(e => e.Descript)
                .HasMaxLength(30)
                .HasComment("描述")
                .HasColumnName("descript");
            entity.Property(e => e.ItemName)
                .HasMaxLength(30)
                .HasComment("名稱")
                .HasColumnName("item_name");
            entity.Property(e => e.ItemNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("編號")
                .HasColumnName("item_no");
            entity.Property(e => e.ItemTypeid)
                .HasComment("對應tbItemType.id")
                .HasColumnName("item_typeid");
            entity.Property(e => e.Sort)
                .HasComment("排序")
                .HasColumnName("sort");
            entity.Property(e => e.Udate)
                .HasComment("更新時間")
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("更新者")
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<TbItemType>(entity =>
        {
            entity.ToTable("tbItemType");

            entity.Property(e => e.Id)
                .HasComment("自動編碼")
                .HasColumnName("id");
            entity.Property(e => e.Cdate)
                .HasComment("建立時間")
                .HasColumnType("datetime")
                .HasColumnName("cdate");
            entity.Property(e => e.Cuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("建立者")
                .HasColumnName("cuser");
            entity.Property(e => e.Memo)
                .HasMaxLength(50)
                .HasComment("備註")
                .HasColumnName("memo");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasComment("代碼名稱")
                .HasColumnName("name");
            entity.Property(e => e.No)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("編號")
                .HasColumnName("no");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasComment("刪除狀態")
                .HasColumnName("status");
            entity.Property(e => e.Udate)
                .HasComment("更新時間")
                .HasColumnType("datetime")
                .HasColumnName("udate");
            entity.Property(e => e.Uuser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("更新者")
                .HasColumnName("uuser");
        });

        modelBuilder.Entity<TbSystemUnique>(entity =>
        {
            entity.HasKey(e => e.SuNo).HasName("PK__tbSystemUnique__1FF8A574");

            entity.ToTable("tbSystemUnique");

            entity.Property(e => e.SuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Su_No");
            entity.Property(e => e.InsDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("ins_date");
            entity.Property(e => e.SuAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Su_Address");
            entity.Property(e => e.SuCno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Su_CNo");
            entity.Property(e => e.SuDea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Su_Dea");
            entity.Property(e => e.SuFax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Su_Fax");
            entity.Property(e => e.SuFutile)
                .HasDefaultValue(false)
                .HasColumnName("Su_Futile");
            entity.Property(e => e.SuIndustryType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("00")
                .HasColumnName("Su_IndustryType");
            entity.Property(e => e.SuLicKey)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Su_LicKey");
            entity.Property(e => e.SuMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Su_Mail");
            entity.Property(e => e.SuMan1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Su_Man1");
            entity.Property(e => e.SuMan1Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Su_Man1Tel");
            entity.Property(e => e.SuName)
                .HasMaxLength(100)
                .HasColumnName("Su_Name");
            entity.Property(e => e.SuPostalNo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Su_PostalNo");
            entity.Property(e => e.SuTel1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Su_Tel1");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => new { e.SuNo, e.UserNo });

            entity.ToTable("tbUser");

            entity.Property(e => e.SuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Su_No");
            entity.Property(e => e.UserNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_No");
            entity.Property(e => e.Alertsend)
                .HasDefaultValue(0)
                .HasColumnName("alertsend");
            entity.Property(e => e.AppChk)
                .HasDefaultValue(0)
                .HasComment("app登入設定")
                .HasColumnName("app_chk");
            entity.Property(e => e.Createtime)
                .HasDefaultValueSql("(dateadd(hour,(8),getdate()))")
                .HasComment("建立時間")
                .HasColumnType("datetime")
                .HasColumnName("createtime");
            entity.Property(e => e.Dept)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("dept");
            entity.Property(e => e.Email)
                .HasMaxLength(1000)
                .HasDefaultValue("")
                .HasColumnName("email");
            entity.Property(e => e.Finallogintime)
                .HasComment("最後一次登入時間")
                .HasColumnType("datetime")
                .HasColumnName("finallogintime");
            entity.Property(e => e.Firstlogin)
                .HasDefaultValue(0)
                .HasComment("預設密碼未登入過0，已登入過1")
                .HasColumnName("firstlogin");
            entity.Property(e => e.GroupType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("0000")
                .HasColumnName("Group_Type");
            entity.Property(e => e.Level)
                .HasDefaultValue(0)
                .HasColumnName("level");
            entity.Property(e => e.Locktime)
                .HasComment("鎖定可登入時間(要大於此時間才能再重試)")
                .HasColumnType("datetime")
                .HasColumnName("locktime");
            entity.Property(e => e.Loginerrorcount)
                .HasDefaultValue(0)
                .HasComment("登入錯誤次數")
                .HasColumnName("loginerrorcount");
            entity.Property(e => e.Passwordexpire)
                .HasDefaultValueSql("(dateadd(month,(3),dateadd(hour,(8),getdate())))")
                .HasComment("密碼到期時間")
                .HasColumnType("datetime")
                .HasColumnName("passwordexpire");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Name");
            entity.Property(e => e.UserPwd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("1234")
                .HasColumnName("User_Pwd");
            entity.Property(e => e.UserTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Tel");
            entity.Property(e => e.WebAlertStatus)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.WebChk)
                .HasDefaultValue(1)
                .HasComment("後台登入設定")
                .HasColumnName("web_chk");
        });

        modelBuilder.Entity<TcDept>(entity =>
        {
            entity.HasKey(e => new { e.SuNo, e.Corp, e.Dept });

            entity.ToTable("tcDept");

            entity.Property(e => e.SuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Su_No");
            entity.Property(e => e.Corp).HasMaxLength(20);
            entity.Property(e => e.Dept).HasMaxLength(20);
            entity.Property(e => e.CarSystem)
                .HasComment("車管區隊 1:是 2:否")
                .HasColumnName("car_system");
            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.Memo)
                .HasMaxLength(50)
                .HasColumnName("memo");
            entity.Property(e => e.ReportVisible)
                .HasDefaultValue(true)
                .HasComment("報表中心是否顯示");
            entity.Property(e => e.Uploadtime)
                .HasColumnType("datetime")
                .HasColumnName("uploadtime");
            entity.Property(e => e.UploadtimeHoliday)
                .HasColumnType("datetime")
                .HasColumnName("uploadtimeHoliday");
        });

        modelBuilder.Entity<TrPermission>(entity =>
        {
            entity.HasKey(e => new { e.SuNo, e.UserNo, e.Corp, e.Dept });

            entity.ToTable("trPermission");

            entity.Property(e => e.SuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Su_No");
            entity.Property(e => e.UserNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_no");
            entity.Property(e => e.Corp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("corp");
            entity.Property(e => e.Dept)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("dept");
        });

        modelBuilder.Entity<Tt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tt");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TtLog>(entity =>
        {
            entity.HasKey(e => new { e.LogDt, e.SuNo, e.UserNo });

            entity.ToTable("ttLog");

            entity.Property(e => e.LogDt)
                .HasDefaultValueSql("(dateadd(hour,(8),getdate()))")
                .HasColumnType("datetime")
                .HasColumnName("log_dt");
            entity.Property(e => e.SuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("su_no");
            entity.Property(e => e.UserNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_no");
            entity.Property(e => e.HostIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("host_ip");
            entity.Property(e => e.HostName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("(host_name())")
                .HasColumnName("host_name");
            entity.Property(e => e.LogEvent)
                .HasDefaultValue((byte)1)
                .HasColumnName("log_event");
            entity.Property(e => e.LogType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("log_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
