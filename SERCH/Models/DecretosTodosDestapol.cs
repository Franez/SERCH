using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosTodosDestapol
{
    public string FolioInternoDecreto { get; set; } = null!;

    public string? FolioUnicoNacional { get; set; }

    public string CodUnidad { get; set; } = null!;

    public string? Unidad { get; set; }

    public string? RegionUnidad { get; set; }

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

    public string? Vif { get; set; }

    public string? Resultado { get; set; }

    public short CodDecreto { get; set; }

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

    public string? PerfilBrain { get; set; }

    public string? NombreFunACargo { get; set; }

    public string? FuncionOfan { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public int? CodDelito { get; set; }

    public string? Delito { get; set; }

    public string? Cierre { get; set; }

    public DateTime? FecEval { get; set; }

    public DateTime? FecReaEval { get; set; }

    public string? ResultadoOrden { get; set; }

    public string SituacionDecreto { get; set; } = null!;

    public string Interoperatividad { get; set; } = null!;

    public decimal? NumeroFoco { get; set; }

    public string? Ddhh { get; set; }

    public string ConFirmaElectronica { get; set; } = null!;

    public DateTime? FechaFirmaElectronica { get; set; }

    public string? TipoDocumentoDecreto { get; set; }

    public string? Origen { get; set; }

    public string Seguridad { get; set; } = null!;

    public string? FolioIntPd { get; set; }

    public string SituacionDecreto1 { get; set; } = null!;

    public string EstadoDecreto { get; set; } = null!;

    public int? RutFunIngDec { get; set; }

    public string? NombreFunIngDec { get; set; }

    public string? PerfilFunIng { get; set; }

    public string? FuncionOfanFunIng { get; set; }

    public string? UnidadFuncionarioIngresa { get; set; }

    public string SituacionEndoso { get; set; } = null!;
}
