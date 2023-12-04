using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbSet
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public string? Name { get; set; }

    public decimal? SVal { get; set; }

    public decimal? EVal { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public int? RId { get; set; }
}
