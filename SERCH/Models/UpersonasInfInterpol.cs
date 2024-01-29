using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasInfInterpol
{
    public string UperId { get; set; } = null!;

    public short UperCorrInterpol { get; set; }

    public string? UinfInterpol { get; set; }

    public string? UperInfInterPolVig { get; set; }

    public string? UperInfInterPolPri { get; set; }
}
