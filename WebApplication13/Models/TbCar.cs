using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbCar
{
    public string SuNo { get; set; } = null!;

    public string CarId { get; set; } = null!;

    public string CarTel { get; set; } = null!;

    public string? UTel { get; set; }

    public string Corp { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string CarNo { get; set; } = null!;

    public string CarLicence { get; set; } = null!;

    public string? CarType { get; set; }

    public DateTime? DispDt { get; set; }

    public DateTime? DispDt2 { get; set; }

    public DateTime Dt { get; set; }

    public double X { get; set; }

    public double Y { get; set; }

    public byte Status { get; set; }

    public int? Status2 { get; set; }

    public int? Value1 { get; set; }

    public int? Value2 { get; set; }

    public int? Value3 { get; set; }

    public int? Value4 { get; set; }

    public int? Mileages { get; set; }

    public int? RcvSeq02 { get; set; }

    public int? NodeId { get; set; }

    public bool Tractor { get; set; }

    public byte Warning { get; set; }

    public DateTime? Wdt { get; set; }

    public string? WarningDescr { get; set; }

    public int? WSpeed { get; set; }

    public string? WCaption { get; set; }

    public string? Wx { get; set; }

    public string? Wy { get; set; }

    public string? Wdriver { get; set; }

    public DateTime? Sdt { get; set; }

    public DateTime? Edt { get; set; }

    public byte CarkitType { get; set; }

    public string? Custodian { get; set; }

    public int? RouteId { get; set; }

    public int? RouteNode { get; set; }

    public byte? RouteStatus { get; set; }

    public string? DragCar { get; set; }

    public string? CarAssort { get; set; }

    public string? Driver { get; set; }

    public string? Course { get; set; }

    public bool Car20 { get; set; }

    public byte? Sat { get; set; }

    public bool? Io1 { get; set; }

    public string? WgsX { get; set; }

    public string? WgsY { get; set; }

    public string? LastStatus { get; set; }

    public DateTime? LastDt { get; set; }

    public int? LastMileage { get; set; }

    public string? DeptName { get; set; }

    public string? CarType1 { get; set; }

    public string CourseArrow { get; set; } = null!;

    public string? StatusDescr { get; set; }

    public byte StatusSeq { get; set; }

    public string? NodeCaption { get; set; }

    public string? EmpName { get; set; }

    public string? EmpTel { get; set; }

    public string? TailLicence { get; set; }

    public string? ContainerNo { get; set; }

    public string? ContainerSpec { get; set; }

    public string? OrderNo { get; set; }

    public string? Ip { get; set; }

    public int? Port { get; set; }

    public DateTime? CarInDate { get; set; }

    public string? WebCamSip { get; set; }

    public string? CarIp { get; set; }

    public string? Icontype { get; set; }

    public int? Stay { get; set; }

    public double? Temperature { get; set; }

    public double? Temperature1 { get; set; }

    public bool? BreakStatus { get; set; }

    public bool? WindowStatus { get; set; }

    public bool? BackStatus { get; set; }

    public bool? Door1 { get; set; }

    public bool? Door2 { get; set; }

    public bool? Door3 { get; set; }

    public bool? DirectionLight { get; set; }

    public bool? Compressor { get; set; }

    public string Rfid1 { get; set; } = null!;

    public string Rfid2 { get; set; } = null!;

    public string Rfid3 { get; set; } = null!;

    public string Rfid4 { get; set; } = null!;

    public string Rfid5 { get; set; } = null!;

    public string Rfid6 { get; set; } = null!;

    public double? Voltage { get; set; }

    public int? Rectype { get; set; }

    public string? ReplacecarId { get; set; }

    public double? Fcavg { get; set; }

    public string? Remark { get; set; }

    public int? Delaytime { get; set; }

    public int? Oldcar { get; set; }

    public int? Movecar { get; set; }

    public string? Oldcartxt { get; set; }

    public string? Movecartxt { get; set; }

    public string? DvrId { get; set; }

    public int? VideoCount { get; set; }

    public string? DfssId { get; set; }

    public string? Notetxt { get; set; }

    /// <summary>
    /// (0無1北屯東2北屯西)
    /// </summary>
    public int? AreaType { get; set; }

    public string? R1 { get; set; }

    public string? R2 { get; set; }

    public string? R3 { get; set; }

    public string? R4 { get; set; }

    public string? R5 { get; set; }

    public string? R6 { get; set; }

    public string? R7 { get; set; }

    public int? NodeId2 { get; set; }

    public decimal? AreaType2 { get; set; }

    /// <summary>
    /// 判斷是否有踩清運點用
    /// </summary>
    public string? Pointnumber { get; set; }

    /// <summary>
    /// 容積
    /// </summary>
    public string? Container { get; set; }

    /// <summary>
    /// 使用狀態
    /// </summary>
    public string? Usetype { get; set; }

    /// <summary>
    /// 車管備註
    /// </summary>
    public string? Carnote { get; set; }

    public DateTime? Uptime { get; set; }

    /// <summary>
    /// 車機清冊排除(1是0否)
    /// </summary>
    public int? Notinxls { get; set; }
}
