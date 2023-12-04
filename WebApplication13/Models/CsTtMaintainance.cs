using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtMaintainance
{
    public int Id { get; set; }

    public int? Dept { get; set; }

    public int? Type1 { get; set; }

    public int? CarId { get; set; }

    public string? CarLicence { get; set; }

    public int? Type2 { get; set; }

    public int? Type3 { get; set; }

    public string? MNum { get; set; }

    public int? Vender { get; set; }

    public DateTime? InDate { get; set; }

    public DateTime? OutDate { get; set; }

    public decimal? Mileage { get; set; }

    public string? Reason { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public string? Num1 { get; set; }

    public string? Num2 { get; set; }

    public double? Total { get; set; }

    public int? OldValue { get; set; }

    public int? Timemin { get; set; }
}
