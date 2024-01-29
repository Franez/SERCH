using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasCancelacionDetalle
{
    public string UperId { get; set; } = null!;

    public short UperCanAntNro { get; set; }

    public short UperCanAntDetNro { get; set; }

    public short? UperCanAntCla { get; set; }

    public short? UperCanAntEncFol { get; set; }

    public string? UperCanAntUniDet { get; set; }

    public decimal? UperCanAntParDet { get; set; }

    public short? UperCanAntStatus { get; set; }

    public DateTime? UperCanAntRevFec { get; set; }
}
