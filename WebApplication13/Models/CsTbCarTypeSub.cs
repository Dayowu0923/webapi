using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbCarTypeSub
{
    /// <summary>
    /// 自動編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 對應CS_tbCarType.id
    /// </summary>
    public int? MId { get; set; }

    /// <summary>
    /// 編號
    /// </summary>
    public string? SNum { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    public string? SName { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? SMemo { get; set; }

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

    public int? Status { get; set; }

    public int? NeedVolume { get; set; }
}
