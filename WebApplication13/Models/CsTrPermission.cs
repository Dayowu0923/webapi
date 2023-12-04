using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTrPermission
{
    public int Id { get; set; }

    public int? MenuId { get; set; }

    public int? UserRole { get; set; }

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }

    public string? UserNo { get; set; }
}
