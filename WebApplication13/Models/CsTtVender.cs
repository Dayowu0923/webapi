using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtVender
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Addr { get; set; }

    public string? Area { get; set; }

    public string? Contact { get; set; }

    public string? VatNum { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Flag { get; set; }

    public string? Memo { get; set; }

    public int? Status { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
