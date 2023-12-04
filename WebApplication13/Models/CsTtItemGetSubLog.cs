using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtItemGetSubLog
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? SId { get; set; }

    public double? OldCount { get; set; }

    public double? UseCount { get; set; }

    public double? LeftCount { get; set; }

    public string? Uuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Cdate { get; set; }
}
