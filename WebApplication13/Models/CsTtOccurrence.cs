using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtOccurrence
{
    public int Id { get; set; }

    public string? CarLicence { get; set; }

    public int? CarId { get; set; }

    public string? EmpId { get; set; }

    public DateTime? InDate { get; set; }

    public int? Amount { get; set; }

    public string? Reason { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
