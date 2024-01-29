using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasDomicilio
{
    public string UperId { get; set; } = null!;

    public short UperDomNro { get; set; }

    public string? UperDomComCod { get; set; }

    public string? UperDomRegCod { get; set; }

    public string? UperDomPrvCod { get; set; }

    public string? UperDomVilCod { get; set; }

    public string? UperDomCalleCod { get; set; }

    public short? UperDomCalleTipo { get; set; }

    public string? UperDomExt { get; set; }

    public string? UperDomCalleDes { get; set; }

    public string? UperDomCalleNro { get; set; }

    public string? UperDomDptoNro { get; set; }

    public short? UperDomTipo { get; set; }

    public string? UperDomUsuIns { get; set; }

    public string? UperDomUsuUpd { get; set; }

    public DateTime? UperDomFecIns { get; set; }

    public DateTime? UperDomFecUpd { get; set; }

    public string? UperDomWrkIns { get; set; }

    public string? UperDomWrkUpd { get; set; }

    public short? UperDomAplIns { get; set; }

    public short? UperDomAplUpd { get; set; }

    public string? UperLugTrab { get; set; }

    public string? UperDomPrin { get; set; }

    public string? UperDomVig { get; set; }

    public string? UperDomCompPer { get; set; }

    public short? UperTipBcd { get; set; }

    public string? UperNroBcd { get; set; }

    public short? UperTipVillPob { get; set; }

    public string UperDesVillPob { get; set; } = null!;

    public string? UperBlockDep { get; set; }

    public short? UperCodTpCalle { get; set; }

    public string? UperDomPerLat { get; set; }

    public string? UperDomPerLong { get; set; }
}
