using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTcFixItemSub
{
    public int Id { get; set; }

    public int? Dept { get; set; }

    public string? CodeName { get; set; }

    public string? Place { get; set; }

    public bool? Status { get; set; }

    /// <summary>
    /// 庫存數量
    /// </summary>
    public double? Inventory { get; set; }

    /// <summary>
    /// 安全庫存數量
    /// </summary>
    public double? InventorySafe { get; set; }

    /// <summary>
    /// 單位
    /// </summary>
    public string? Unit { get; set; }

    public string? Uuser { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public DateTime? Cdate { get; set; }

    public int? Sort { get; set; }
}
