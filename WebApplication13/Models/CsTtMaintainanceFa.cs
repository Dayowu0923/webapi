using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtMaintainanceFa
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? Type { get; set; }

    public string? Name { get; set; }

    public string? Unit { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
