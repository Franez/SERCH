using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasViaje
{
    public string UperId { get; set; } = null!;

    public short UperViaNro { get; set; }

    public string? UperViaVig { get; set; }

    public string? UperViaDes { get; set; }
}
