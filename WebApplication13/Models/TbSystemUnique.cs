using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbSystemUnique
{
    public string SuNo { get; set; } = null!;

    public string? SuName { get; set; }

    public string? SuCno { get; set; }

    public string? SuPostalNo { get; set; }

    public string? SuAddress { get; set; }

    public string? SuTel1 { get; set; }

    public string? SuMan1 { get; set; }

    public string? SuMan1Tel { get; set; }

    public string? SuFax { get; set; }

    public string? SuMail { get; set; }

    public string? SuDea { get; set; }

    public string? SuLicKey { get; set; }

    public string? SuIndustryType { get; set; }

    public bool? SuFutile { get; set; }

    public DateTime? InsDate { get; set; }
}
