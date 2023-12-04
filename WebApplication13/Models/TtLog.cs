using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TtLog
{
    public DateTime LogDt { get; set; }

    public string SuNo { get; set; } = null!;

    public string UserNo { get; set; } = null!;

    public byte LogEvent { get; set; }

    public string HostName { get; set; } = null!;

    public string? HostIp { get; set; }

    public string? LogType { get; set; }
}
