using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTtwebserviceLog
{
    public int Id { get; set; }

    public string? FunctionName { get; set; }

    public string? ReqIp { get; set; }

    public DateTime? ReqDatetime { get; set; }

    public string? ReqData { get; set; }

    public string? ReqUser { get; set; }

    public string? RespData { get; set; }

    public DateTime? RespDatetime { get; set; }
}
