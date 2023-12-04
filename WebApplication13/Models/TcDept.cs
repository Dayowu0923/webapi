using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TcDept
{
    public string SuNo { get; set; } = null!;

    public string Corp { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public DateTime? Uploadtime { get; set; }

    public DateTime? UploadtimeHoliday { get; set; }

    /// <summary>
    /// 報表中心是否顯示
    /// </summary>
    public bool? ReportVisible { get; set; }

    /// <summary>
    /// 車管區隊 1:是 2:否
    /// </summary>
    public int? CarSystem { get; set; }

    public string? Memo { get; set; }
}
