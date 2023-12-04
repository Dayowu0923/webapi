using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtTransfer
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public int? Odept { get; set; }

    public int? Ndept { get; set; }

    public DateTime? Transfer { get; set; }

    public DateTime? Cdate { get; set; }

    public DateTime? Udate { get; set; }

    public string? Cuser { get; set; }

    public string? Uuser { get; set; }
}
