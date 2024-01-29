using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DelitosHistorico
{
    public int DelCod { get; set; }

    public short DelHisCod { get; set; }

    public string? DelHisMinCod { get; set; }

    public string? DelHisDes { get; set; }

    public DateTime? DelHisFecIni { get; set; }

    public DateTime? DelHisFecFin { get; set; }
}
