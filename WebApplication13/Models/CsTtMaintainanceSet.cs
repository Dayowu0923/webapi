using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtMaintainanceSet
{
    public int Id { get; set; }

    public int? Dept { get; set; }

    public string? SetYear { get; set; }

    public int? Total { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public int? VId { get; set; }
}
