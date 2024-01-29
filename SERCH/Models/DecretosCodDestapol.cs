using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosCodDestapol
{
    public string FolioInternoDecreto { get; set; } = null!;

    public string? FolioUnicoNacional { get; set; }

    public string? CodUnidad { get; set; }

    public decimal? NumDenuncia { get; set; }

    public TimeSpan? HoraRecepcion { get; set; }

    public DateTime? FechaHecho1 { get; set; }

    public DateTime? FechaHecho2 { get; set; }

    public TimeSpan? HoraHecho1 { get; set; }

    public TimeSpan? HoraHecho2 { get; set; }

    public string? CodComuna { get; set; }

    public string? CalleHecho { get; set; }

    public string? Numero { get; set; }

    public string? VillaPob { get; set; }

    public string? NumDepto { get; set; }

    public string? DireccionInexacta { get; set; }

    public string? LatitudHecho { get; set; }

    public string? LongitudHecho { get; set; }

    public short? CodDecreto { get; set; }

    public DateTime? FecEval { get; set; }

    public string TipoDecreto { get; set; } = null!;

    public short? CodOrganismo { get; set; }

    public string TipoInstruccionParticular { get; set; } = null!;

    public string? NumDoc { get; set; }

    public string? NumCausaORuc { get; set; }

    public int? CodDetalleOrganismo { get; set; }

    public int? CodDelito { get; set; }

    public short? Interoperatividad { get; set; }

    public decimal? NumeroFoco { get; set; }
}
