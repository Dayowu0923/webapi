using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtMaintainanceSub
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? Type { get; set; }

    public string? Num { get; set; }

    public string? Name { get; set; }

    public string? Unit { get; set; }

    public decimal? Amount { get; set; }

    public decimal Cost { get; set; }

    public int? Total { get; set; }

    public string? Memo { get; set; }
}
