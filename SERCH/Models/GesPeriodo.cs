using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesPeriodo
{
    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public short? GesPerActivo { get; set; }

    public DateTime? GesPerFecActivacion { get; set; }

    public int? GesPerFunIns { get; set; }

    public int? GesPerFunCer { get; set; }

    public DateTime? GesPerFecCierre { get; set; }

    public DateTime? GesPerFecProceso { get; set; }
}
