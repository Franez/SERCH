using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomFiscale
{
    public string HomFisId { get; set; } = null!;

    public string? HomFisPaterno { get; set; }

    public string? HomFisMaterno { get; set; }

    public string? HomFisNombres { get; set; }

    public string? HomFisConcat { get; set; }

    public string? HomFisFono1 { get; set; }

    public string? HomFisFono2 { get; set; }

    public string? HomFisFono3 { get; set; }

    public short? HomFisVig { get; set; }
}
