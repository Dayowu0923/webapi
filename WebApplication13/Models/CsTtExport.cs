using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtExport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? EName { get; set; }

    public int Length { get; set; }

    public bool? Fixed { get; set; }

    public int? Sort { get; set; }

    public int? Type { get; set; }
}
