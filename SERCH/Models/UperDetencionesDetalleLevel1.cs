using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperDetencionesDetalleLevel1
{
    public string UperId { get; set; } = null!;

    public string UperUniDet { get; set; } = null!;

    public decimal UperUniParte { get; set; }

    public short UperNroDel { get; set; }

    public int? UperDelCod { get; set; }

    public int? UperTribDel { get; set; }

    public string? UperDelRuc { get; set; }

    public string? UperDelRit { get; set; }

    public DateTime? UperDelFecCau { get; set; }

    public short? UperDelOrgCod { get; set; }

    public int? UperDelOrgDetCod { get; set; }

    public short? UperDelPart { get; set; }

    public int? UperDelMotivo { get; set; }

    public string? UperDelObs { get; set; }
}
