using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbEmp
{
    public string SuNo { get; set; } = null!;

    public string EmpId { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? Corp { get; set; }

    public string? Dept { get; set; }

    public string? EmpType { get; set; }

    public bool? Sex { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Idcardno { get; set; }

    public string? Marriage { get; set; }

    public string? Height { get; set; }

    public string? Weight { get; set; }

    public string? Blood { get; set; }

    public DateTime? Takeofficedate { get; set; }

    public string? Education { get; set; }

    public bool? Leave { get; set; }

    public DateTime? Leaveofficedate { get; set; }

    public string? Cardno { get; set; }

    public string? Fosteramount { get; set; }

    public string? Address1 { get; set; }

    public string? Tel1 { get; set; }

    public string? Carmunber { get; set; }

    public string? Adderss2 { get; set; }

    public string? CarMan { get; set; }

    public string? Tel2 { get; set; }

    public string? Bailoutliaison { get; set; }

    public string? Liaisonaddress { get; set; }

    public string? LiaisonTel { get; set; }

    public decimal? Brokerage { get; set; }

    public DateTime? ExperienceDateS { get; set; }

    public string? Pid { get; set; }

    public string? Rem { get; set; }

    public string? EmpTel { get; set; }

    public string? Job { get; set; }

    /// <summary>
    /// 人臉
    /// </summary>
    public string? FaceDetect { get; set; }

    /// <summary>
    /// 指紋
    /// </summary>
    public string? Finger { get; set; }

    /// <summary>
    /// 是否有指紋
    /// </summary>
    public bool? Fingerprint { get; set; }

    public string? CarNo { get; set; }

    public string? Experience { get; set; }

    public string? Assurance { get; set; }

    public string? Licence { get; set; }

    public double? Salary { get; set; }

    public string? CardId { get; set; }

    public bool? Admin { get; set; }

    public DateTime? Cdate { get; set; }

    public string? Cuser { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public DateTime? HireDate { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Lic { get; set; }

    public string? Line { get; set; }

    public int? JobId { get; set; }

    public string? Year { get; set; }

    public int? Dri { get; set; }
}
