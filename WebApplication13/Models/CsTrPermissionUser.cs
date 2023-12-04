using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class CsTrPermissionUser
{
    public int Id { get; set; }

    public int? MenuId { get; set; }

    public string UserNo { get; set; } = null!;

    public DateTime? Udate { get; set; }

    public string? Uuser { get; set; }
}
