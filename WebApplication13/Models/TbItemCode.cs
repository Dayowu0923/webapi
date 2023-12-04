using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbItemCode
{
    /// <summary>
    /// 自動編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 對應tbItemType.id
    /// </summary>
    public int? ItemTypeid { get; set; }

    /// <summary>
    /// 編號
    /// </summary>
    public string? ItemNo { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Descript { get; set; }

    /// <summary>
    /// 啟用狀態
    /// </summary>
    public bool? ActiveFlag { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? Sort { get; set; }

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
}
