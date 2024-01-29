using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecSsMod
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

    public string? Perfil { get; set; }

    public string? FuncionOfan { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public int? CodDelito { get; set; }

    public string? Delito { get; set; }

    public string SituacionDecreto { get; set; } = null!;

    public string Interoperatividad { get; set; } = null!;

    public decimal? NumeroFoco { get; set; }

    public short? AñoFoco { get; set; }

    public string? Ddhh { get; set; }

    public string SitioDelSuceso { get; set; } = null!;

    public string? CodRegion { get; set; }

    public string? Region { get; set; }

    public string? CodComunaSs { get; set; }

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

    public string? LatitudSs { get; set; }

    public string? LongitudSs { get; set; }

    public short? CodFormContacto { get; set; }

    public string? FormaDeContacto { get; set; }

    public short? CodCantImputados { get; set; }

    public string? CantidadImputados { get; set; }

    public short? CodGenero { get; set; }

    public string? Genero { get; set; }

    public short? CodRangoEtario { get; set; }

    public string? RangoEtario { get; set; }

    public short? CodPuntoAcceso { get; set; }

    public string? PuntoAcceso { get; set; }

    public short? CodMedHerramientas { get; set; }

    public string? MediosOHerramientas { get; set; }

    public short? CodTransporte { get; set; }

    public string? TransporteUsado { get; set; }

    public short? CodModalidad { get; set; }

    public string? Modalidad { get; set; }

    public string? SelloPersonal { get; set; }

    public string? AccionesPrevias { get; set; }

    public string? FenomenoDelictual { get; set; }

    public string? DescFenomenoDelictual { get; set; }

    public string? Tag { get; set; }
}
