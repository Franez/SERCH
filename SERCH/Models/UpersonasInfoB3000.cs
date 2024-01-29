using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasInfoB3000
{
    public string UperId { get; set; } = null!;

    public short UperCorrB3 { get; set; }

    public string? UperInfVigB3 { get; set; }

    public string? UperInfoB3 { get; set; }
}
