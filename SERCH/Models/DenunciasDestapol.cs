using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DenunciasDestapol
{
    public string FolioInternoDecreto { get; set; } = null!;

    public string? FolioUnicoNacional { get; set; }

    public string? CodUnidad { get; set; }

    public string? Unidad { get; set; }

    public string? RegionUnidad { get; set; }

    public decimal? NumDenuncia { get; set; }

    public DateTime? FechaHoraIngSistema { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public TimeSpan? HoraRecepcion { get; set; }

    public DateTime? FechaHecho1 { get; set; }

    public DateTime? FechaHecho2 { get; set; }

    public TimeSpan? HoraHecho1 { get; set; }

    public TimeSpan? HoraHecho2 { get; set; }

    public int? CodComunaDestapol { get; set; }

    public string? CodComuna { get; set; }

    public string? ComunaHecho { get; set; }

    public string? CalleHecho { get; set; }

    public string? Numero { get; set; }

    public string? VillaPob { get; set; }

    public string? NumDepto { get; set; }

    public string? DireccionInexacta { get; set; }

    public string? LugarHecho { get; set; }

    public string? DetalleLugarHecho { get; set; }

    public string? LatitudHecho { get; set; }

    public string? LongitudHecho { get; set; }

    public int? RutEvaluador { get; set; }

    public DateTime? FecEval { get; set; }

    public DateTime? FechaRealEvaluacion { get; set; }

    public string Evaluacion { get; set; } = null!;

    public string Resultado { get; set; } = null!;

    public string? DescripcionResultado { get; set; }

    public short? CodDecreto { get; set; }

    public string? Decreto { get; set; }

    public string TipoDecreto { get; set; } = null!;

    public string TipoInstruccionParticular { get; set; } = null!;

    public short? CodTipoInsOTramite { get; set; }

    public string? TipoInsOTramite { get; set; }

    public string? NumDoc { get; set; }

    public string? NumCausaORuc { get; set; }

    public short? CodOrganismo { get; set; }

    public string? Organismo { get; set; }

    public int? CodDetalleOrganusmo { get; set; }

    public string? DetalleOrganismo { get; set; }

    public string? Fiscal { get; set; }

    public int? RutFunACargo { get; set; }

    public string? NombreFunACargo { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public int? CodDelito { get; set; }

    public string? Delito { get; set; }

    public short? Interoperatividad { get; set; }

    public decimal? NumeroFoco { get; set; }
}
