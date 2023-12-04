using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtOilSub
{
    public int Id { get; set; }

    public int? Mid { get; set; }

    public int? Dept { get; set; }

    public string? CarLicence { get; set; }

    public string? Date1 { get; set; }

    public string? Date2 { get; set; }

    public DateTime? InDate { get; set; }

    public string? Station { get; set; }

    public int? Oiltype { get; set; }

    public decimal? Num { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Total { get; set; }

    public int? ImportType { get; set; }

    public DateTime? Cdate { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public string? Cuser { get; set; }
}
