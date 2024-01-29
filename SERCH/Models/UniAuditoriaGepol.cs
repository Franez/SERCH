using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAuditoriaGepol
{
    public string AudGepidp { get; set; } = null!;

    public int AudGepfun { get; set; }

    public DateTime AudGepfec { get; set; }

    public string AudGephor { get; set; } = null!;

    public string? AudGepip { get; set; }
}
