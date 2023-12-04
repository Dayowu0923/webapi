using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbOliCard
{
    public int Id { get; set; }

    public int? Dept { get; set; }

    public string? Num { get; set; }

    public decimal? TAmount { get; set; }

    public DateTime? UseDate { get; set; }

    public DateTime? ScrapeDate { get; set; }

    public int? Type { get; set; }

    public string? Keep { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
