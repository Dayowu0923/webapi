using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtItemGet
{
    public int Id { get; set; }

    public DateTime? InDate { get; set; }

    public int? Type { get; set; }

    public int? CarId { get; set; }

    public string? CarLicence { get; set; }

    public int? Dept { get; set; }

    public string? Reason { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
