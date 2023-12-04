using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbCar
{
    public int Id { get; set; }

    /// <summary>
    /// 區別
    /// </summary>
    public int? Dept { get; set; }

    /// <summary>
    /// 來源
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// 財產編號
    /// </summary>
    public string? Num { get; set; }

    /// <summary>
    /// 出廠年月
    /// </summary>
    public string? MakeYearMonth { get; set; }

    /// <summary>
    /// 是否機具
    /// </summary>
    public string? IsMachine { get; set; }

    /// <summary>
    /// 購置日期
    /// </summary>
    public DateTime? BuyDate { get; set; }

    /// <summary>
    /// 開始使用日期
    /// </summary>
    public DateTime? StartUseDate { get; set; }

    /// <summary>
    /// 車輛歸屬日期迄
    /// </summary>
    public DateTime? EndUseDate { get; set; }

    /// <summary>
    /// 作業廠址
    /// </summary>
    public string? WorkArea { get; set; }

    /// <summary>
    /// 車輛編號(新)
    /// </summary>
    public string? NewVehicleNo { get; set; }

    /// <summary>
    /// 車輛編號(舊)
    /// </summary>
    public string? OldVehicleNo { get; set; }

    /// <summary>
    /// 主種類
    /// </summary>
    public int? VehicleKindId { get; set; }

    /// <summary>
    /// 次種類
    /// </summary>
    public int? VehicleKindId2 { get; set; }

    public int? VehicleKindM { get; set; }

    /// <summary>
    /// 顏色
    /// </summary>
    public string? VehicleColor { get; set; }

    /// <summary>
    /// 能源種類
    /// </summary>
    public string? Power { get; set; }

    /// <summary>
    /// 使用狀況
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 環保期數
    /// </summary>
    public string? EpPeriod { get; set; }

    /// <summary>
    /// 主要用途
    /// </summary>
    public string? Usage { get; set; }

    /// <summary>
    /// 廠牌
    /// </summary>
    public string? VehicleMake { get; set; }

    /// <summary>
    /// 報廢日期
    /// </summary>
    public DateTime? ScrapDate { get; set; }

    /// <summary>
    /// 保管人
    /// </summary>
    public string? Keeper { get; set; }

    /// <summary>
    /// 使用人
    /// </summary>
    public string? Using { get; set; }

    /// <summary>
    /// 車牌
    /// </summary>
    public string? CarLicence { get; set; }

    /// <summary>
    /// 車身式樣
    /// </summary>
    public string? VehicleModel { get; set; }

    /// <summary>
    /// 汽缸排氣量
    /// </summary>
    public double? Cylinder { get; set; }

    /// <summary>
    /// 載重
    /// </summary>
    public double? VehicleLoad { get; set; }

    /// <summary>
    /// 總重
    /// </summary>
    public double? VehicleWeight { get; set; }

    /// <summary>
    /// 容積(立方數)
    /// </summary>
    public double? VehicleVolume { get; set; }

    /// <summary>
    /// 乘客人數(不含司機)
    /// </summary>
    public double? Passenger { get; set; }

    /// <summary>
    /// 購置價格(費用)
    /// </summary>
    public double? Cost { get; set; }

    /// <summary>
    /// 購置經費來源
    /// </summary>
    public string? Source { get; set; }

    /// <summary>
    /// 發照日期
    /// </summary>
    public DateTime? LicenseDate { get; set; }

    /// <summary>
    /// 引擎號碼
    /// </summary>
    public string? EngineNumber { get; set; }

    /// <summary>
    /// 車身號碼
    /// </summary>
    public string? BodyNumber { get; set; }

    /// <summary>
    /// 其他附屬設備
    /// </summary>
    public string? OtherItem { get; set; }

    /// <summary>
    /// 是否需添加尿素
    /// </summary>
    public string? Urea { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// 前
    /// </summary>
    public string? Pic1 { get; set; }

    /// <summary>
    /// 後
    /// </summary>
    public string? Pic2 { get; set; }

    /// <summary>
    /// 左
    /// </summary>
    public string? Pic3 { get; set; }

    /// <summary>
    /// 右
    /// </summary>
    public string? Pic4 { get; set; }

    /// <summary>
    /// 電信業者
    /// </summary>
    public string? Telecom { get; set; }

    /// <summary>
    /// 門號
    /// </summary>
    public string? TelNumber { get; set; }

    /// <summary>
    /// 車機品牌
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// 月租費
    /// </summary>
    public double? MonthlyFee { get; set; }

    /// <summary>
    /// 車重
    /// </summary>
    public double? CarWeight { get; set; }

    /// <summary>
    /// 是否已納入清潔車即時衛星
    /// 定位便民查詢及管理系統
    /// </summary>
    public string? InsideSystem { get; set; }

    public string? Flag { get; set; }

    public string? EditId { get; set; }

    public DateTime? EditDate { get; set; }

    public int? EditTime { get; set; }

    public int? UnitId { get; set; }

    /// <summary>
    /// 顏色ID
    /// </summary>
    public int? VehicleColorId { get; set; }

    /// <summary>
    /// 車身式樣ID
    /// </summary>
    public int? VehicleModelId { get; set; }

    /// <summary>
    /// 能源種類ID
    /// </summary>
    public int? PowerId { get; set; }

    /// <summary>
    /// 使用狀況ID
    /// </summary>
    public int? StatusId { get; set; }

    /// <summary>
    /// 環保期數ID
    /// </summary>
    public int? EpPeriodId { get; set; }

    /// <summary>
    /// 購置經費來源ID
    /// </summary>
    public int? SourceId { get; set; }

    /// <summary>
    /// 主要用途ID
    /// </summary>
    public int? UsageId { get; set; }

    /// <summary>
    /// 廠牌ID
    /// </summary>
    public int? VehicleMakeId { get; set; }

    /// <summary>
    /// 電信ID
    /// </summary>
    public int? TelecomId { get; set; }

    /// <summary>
    /// 電信品牌ID
    /// </summary>
    public int? BrandId { get; set; }

    /// <summary>
    /// 是否繳納燃料稅
    /// </summary>
    public string? IsFuelTax { get; set; }

    /// <summary>
    /// 是否繳納牌照稅
    /// </summary>
    public string? IsLicenseTax { get; set; }

    /// <summary>
    /// 燃料稅
    /// </summary>
    public double? FuelTax { get; set; }

    /// <summary>
    /// 牌照稅
    /// </summary>
    public double? LicenseTax { get; set; }

    /// <summary>
    /// 牌照類別
    /// </summary>
    public string? LicenseType { get; set; }

    /// <summary>
    /// 前輪尺寸
    /// </summary>
    public string? FrontTireSize { get; set; }

    /// <summary>
    /// 後輪尺寸
    /// </summary>
    public string? RearTireSize { get; set; }

    /// <summary>
    /// 牌照類別ID
    /// </summary>
    public int? LicenseTypeId { get; set; }

    /// <summary>
    /// 前輪尺寸ID
    /// </summary>
    public int? FrontTireSizeId { get; set; }

    /// <summary>
    /// 後輪尺寸ID
    /// </summary>
    public int? RearTireSizeId { get; set; }

    /// <summary>
    /// 前輪輪數
    /// </summary>
    public double? FrontTireNum { get; set; }

    /// <summary>
    /// 後輪輪數
    /// </summary>
    public double? RearTireNum { get; set; }

    public DateTime? TransferInDate { get; set; }

    public DateTime? TransferOutDate { get; set; }

    /// <summary>
    /// 行車執照照片
    /// </summary>
    public string? Pic5 { get; set; }

    /// <summary>
    /// 每次需保養的公里數
    /// </summary>
    public double? MileToMaintain { get; set; }

    /// <summary>
    /// 審核結果
    /// </summary>
    public string? VerifyStatus { get; set; }

    /// <summary>
    /// 審核人員ID
    /// </summary>
    public string? VerifyId { get; set; }

    /// <summary>
    /// 審核日期
    /// </summary>
    public DateTime? VerifyDate { get; set; }

    /// <summary>
    /// 審核時間
    /// </summary>
    public string? VerifyTime { get; set; }

    /// <summary>
    /// 行照車輛種類ID
    /// </summary>
    public int? VehicleRegistKindId { get; set; }

    /// <summary>
    /// 預算車輛種類ID
    /// </summary>
    public int? VehicleBudgetKindId { get; set; }

    /// <summary>
    /// 強制險到期日
    /// </summary>
    public DateTime? CompulsoryInsuranceDate { get; set; }

    /// <summary>
    /// 任意險到期日
    /// </summary>
    public DateTime? AnyRiskDate { get; set; }

    public DateTime? Udate { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Uuser { get; set; }

    public string? Cuser { get; set; }

    public int? Chk1 { get; set; }

    public int? Chk2 { get; set; }

    public int? Chk3 { get; set; }

    public int? Chk4 { get; set; }

    public DateTime? StopTime { get; set; }

    public string? DriverId { get; set; }

    public int? PreStatus { get; set; }

    public string? Driver { get; set; }
}
