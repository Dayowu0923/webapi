using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

/// <summary>
/// 網站目錄
/// </summary>
public partial class CsTbMenu
{
    /// <summary>
    /// pk
    /// </summary>
    public int MenuId { get; set; }

    /// <summary>
    /// 選單名稱
    /// </summary>
    public string MenuName { get; set; } = null!;

    /// <summary>
    /// 預設連結
    /// </summary>
    public string? MenuUrl { get; set; }

    /// <summary>
    /// 所屬階層
    /// </summary>
    public int MenuClass { get; set; }

    /// <summary>
    /// 上一階選單id 
    /// </summary>
    public int MenuLastId { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int MenuSort { get; set; }

    /// <summary>
    /// 1.啟用(預設) 0.關閉
    /// </summary>
    public bool MenuStatus { get; set; }

    /// <summary>
    /// 功能icon
    /// </summary>
    public string? MenuIcon { get; set; }

    public string? MenuImage { get; set; }

    public DateTime? Cdate { get; set; }
}
