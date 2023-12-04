using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtItemGetSub
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? SId { get; set; }

    public string? People { get; set; }

    public double? OldCount { get; set; }

    public double? UseCount { get; set; }

    public double? LeftCount { get; set; }

    public string? Unit { get; set; }

    public int? VId { get; set; }

    public double? Cost { get; set; }

    public int? Total { get; set; }

    public double? Amount { get; set; }
}
