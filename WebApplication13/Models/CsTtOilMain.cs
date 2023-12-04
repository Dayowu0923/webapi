using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtOilMain
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Month { get; set; }

    public int? Dept { get; set; }

    public int? CarId { get; set; }

    public string? CarLicence { get; set; }

    public string? Num1 { get; set; }

    public string? Num2 { get; set; }

    public decimal? Mileage { get; set; }

    public decimal? TotalMileage { get; set; }

    public decimal? Num { get; set; }

    public decimal? Total { get; set; }

    public string? Memo { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public decimal? EngineOilNum { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public int? EId { get; set; }
}
