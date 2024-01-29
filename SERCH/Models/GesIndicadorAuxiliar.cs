using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesIndicadorAuxiliar
{
    public short GesAuxIndCod { get; set; }

    public short GesAuxForNro { get; set; }

    public short? GesAuxAsoIni { get; set; }

    public short? GesAuxForTipo { get; set; }

    public int? GesAuxDesCod { get; set; }

    public decimal? GesAuxForCons { get; set; }

    public short? GesAuxAsoCie { get; set; }

    public short? GesAuxParForTipo { get; set; }
}
