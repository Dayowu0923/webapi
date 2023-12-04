using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbCarType
{
    /// <summary>
    /// 自動編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 1:車輛 2:機具
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// 車輛/機具種類代碼
    /// </summary>
    public string? MNum { get; set; }

    /// <summary>
    /// 車輛/機具種類名稱
    /// </summary>
    public string? MName { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? MMemo { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? Cdate { get; set; }

    /// <summary>
    /// 更新日期
    /// </summary>
    public DateTime? Udate { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? Cuser { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public string? Uuser { get; set; }

    public int Status { get; set; }
}
