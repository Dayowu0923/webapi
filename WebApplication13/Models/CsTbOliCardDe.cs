using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbOliCardDe
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? Dept { get; set; }

    public DateTime? OliDate { get; set; }

    public int? Type { get; set; }

    public decimal? Amount { get; set; }

    public double? Price { get; set; }

    public double? Total { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
