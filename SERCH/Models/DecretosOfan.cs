using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosOfan
{
    public string FolioInterno { get; set; } = null!;

    public string? Delito { get; set; }

    public DateTime? FechaHecho { get; set; }

    public DateTime? HoeaHecho { get; set; }

    public string? Comuna { get; set; }

    public string? Organismo { get; set; }

    public string? OrganismoDetalle { get; set; }

    public int? RutFunEndosado { get; set; }

    public string? NombreFunEndosado { get; set; }

    public DateTime? FechaDecreto { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Ruc { get; set; }

    public decimal? NumeroFoco { get; set; }

    public short? AñoFoco { get; set; }

    public string? Unidad { get; set; }

    public short? InterO { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaIngresoSistema { get; set; }

    public DateTime? FechaInforme { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public string? TipoDecreto { get; set; }

    public string? RegionPolicial { get; set; }

    public string? EstadoOfan { get; set; }

    public string? PerfilOfan { get; set; }

    public DateTime? FechaRealEvaluacion { get; set; }

    public string SituacionDecreto { get; set; } = null!;

    public string Interoperatividad { get; set; } = null!;

    public string? FiscalDenunciante { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public string ConFirmaElectronica { get; set; } = null!;

    public DateTime? FechaFirmaElectronica { get; set; }

    public string Seguridad { get; set; } = null!;

    public string? TipoInstruccion { get; set; }

    public string SituacionDecreto1 { get; set; } = null!;

    public short? CodTipoInsOTramite { get; set; }

    public string? TipoInsOTramite { get; set; }

    public string EstadoDecreto { get; set; } = null!;

    public DateTime? FechaVencimiento { get; set; }
}
