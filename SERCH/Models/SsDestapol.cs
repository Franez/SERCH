using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class SsDestapol
{
    public short SsFolio { get; set; }

    public string FolioInternoDecreto { get; set; } = null!;

    public string? Decreto { get; set; }

    public DateTime? FechaIngresoSistema { get; set; }

    public string SitioDelSuceso { get; set; } = null!;

    public string? CodRegion { get; set; }

    public string? Region { get; set; }

    public string? Provincia { get; set; }

    public string? CodComuna { get; set; }

    public string? Comuna { get; set; }

    public string? Sector { get; set; }

    public string? Lugar { get; set; }

    public string? CodCalle { get; set; }

    public string? Calle { get; set; }

    public string? NroDireccion { get; set; }

    public string? NroParcelaDepto { get; set; }

    public string? CalleAlternativa { get; set; }

    public string? CodCalleIntersecta { get; set; }

    public string? CalleIntersecta { get; set; }

    public short? CodLugar { get; set; }

    public string? LugarNombre { get; set; }

    public short? CodLugarDet { get; set; }

    public string? LugarDet { get; set; }

    public string TipoLugar { get; set; } = null!;

    public string? Delito { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }
}
