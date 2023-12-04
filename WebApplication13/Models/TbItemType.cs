using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbItemType
{
    /// <summary>
    /// 自動編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 編號
    /// </summary>
    public string? No { get; set; }

    /// <summary>
    /// 代碼名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime? Udate { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? Cdate { get; set; }

    /// <summary>
    /// 更新者
    /// </summary>
    public string? Uuser { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? Cuser { get; set; }

    /// <summary>
    /// 刪除狀態
    /// </summary>
    public bool? Status { get; set; }
}
