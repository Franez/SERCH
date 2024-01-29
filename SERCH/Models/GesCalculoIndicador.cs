using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesCalculoIndicador
{
    public short GesIndCod { get; set; }

    public int GesMedCod { get; set; }

    public string? GesIndMedCal { get; set; }

    public short? GesMedIndActivo { get; set; }
}
