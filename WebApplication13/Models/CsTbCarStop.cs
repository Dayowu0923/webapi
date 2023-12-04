using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTbCarStop
{
    public int Id { get; set; }

    public int? MId { get; set; }

    public DateTime? StopTime { get; set; }

    public string? Memo { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public string? CarLicence { get; set; }

    public string? NewVehicleNo { get; set; }

    public int? Dept { get; set; }
}
