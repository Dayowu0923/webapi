using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbCarBofa
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public string? CarLicence { get; set; }

    public string? NewVehicleNo { get; set; }

    public int? Dept { get; set; }

    public int? Status { get; set; }

    public string? Reason { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public int? Chk { get; set; }

    public DateTime? Rdate { get; set; }

    public DateTime? Sdate { get; set; }

    public string? Snum { get; set; }
}
