using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbCarRecord
{
    public string CarLicence { get; set; } = null!;

    public DateTime Dt { get; set; }

    public string? Corp { get; set; }

    public string? Dept { get; set; }

    public DateTime? StartDt { get; set; }

    public DateTime? EndDt { get; set; }

    public double? RunKm { get; set; }

    public double? HiwayKm { get; set; }

    public int? Overspeed { get; set; }

    public int? RunTime { get; set; }

    public int? ParkingTime { get; set; }

    public int? StrandCount { get; set; }

    public int? Hispeed { get; set; }

    public double? Avgspeed { get; set; }

    public int? StopCount { get; set; }

    /// <summary>
    /// 在外暫停
    /// </summary>
    public int OusideStop { get; set; }

    /// <summary>
    /// 場外關機
    /// </summary>
    public int OusideShutdown { get; set; }

    /// <summary>
    /// 場內關機
    /// </summary>
    public int InsideShutdown { get; set; }

    /// <summary>
    /// 斷訊
    /// </summary>
    public int Disconnect { get; set; }

    /// <summary>
    /// 斷訊/關機
    /// </summary>
    public int DisconnectShutdown { get; set; }

    /// <summary>
    /// 超速30秒以上
    /// </summary>
    public int Overspeed30 { get; set; }

    /// <summary>
    /// 超速120秒以上
    /// </summary>
    public int Overspeed120 { get; set; }

    /// <summary>
    /// 超速30秒以下
    /// </summary>
    public int Overspeed0 { get; set; }

    /// <summary>
    /// 超速60秒以上
    /// </summary>
    public int Overspeed60 { get; set; }

    /// <summary>
    /// 區隊圍籬外行駛時間
    /// </summary>
    public int? RunTime2 { get; set; }
}
