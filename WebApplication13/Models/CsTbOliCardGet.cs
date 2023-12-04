using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbOliCardGet
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? CarId { get; set; }

    public int? Dept { get; set; }

    public DateTime? OliDate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Old { get; set; }

    public decimal? Last { get; set; }

    public string? Reason { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public string? Uuser { get; set; }

    public DateTime? Udate { get; set; }

    public int? Type { get; set; }

    public string? CarLicence { get; set; }
}
