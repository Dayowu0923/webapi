using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtPurchase
{
    public int Id { get; set; }

    public DateTime? InDate { get; set; }

    public int? Dept { get; set; }

    public decimal? OldAmount { get; set; }

    public decimal? Amount { get; set; }

    public decimal? LastCount { get; set; }

    public decimal? Cost { get; set; }

    public int? Total { get; set; }

    public int? SId { get; set; }

    public int? VId { get; set; }

    public string? Uuser { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Note { get; set; }
}
