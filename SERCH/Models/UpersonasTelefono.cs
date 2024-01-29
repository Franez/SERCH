using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasTelefono
{
    public string UperId { get; set; } = null!;

    public string UperTipTel { get; set; } = null!;

    public string UperCodAreaTel { get; set; } = null!;

    public string UperNumTel { get; set; } = null!;

    public string? UperFonoVig { get; set; }

    public string? UperFonoPrin { get; set; }

    public int? UperFonPaiTel { get; set; }
}
