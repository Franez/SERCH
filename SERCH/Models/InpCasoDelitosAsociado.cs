using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoDelitosAsociado
{
    public string InpFolio { get; set; } = null!;

    public int InpDelCod { get; set; }

    public string? InpDelPrin { get; set; }

    public string? InpModOpeDelAso { get; set; }

    public string? InpModOpeCirDet { get; set; }
}
