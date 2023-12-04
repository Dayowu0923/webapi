using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTcManufacturer
{
    public int Id { get; set; }

    public string? Vendor { get; set; }

    public string? Note { get; set; }

    public string? Uuser { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public DateTime? Cdate { get; set; }

    public bool? Status { get; set; }

    public int? PId { get; set; }
}
