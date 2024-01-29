using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EstadoDecreto
{
    public DateTime FechaHoraEjecucion { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Unidad { get; set; }

    public string? Region { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaHoraIngresoSistema { get; set; }

    public string Estado { get; set; } = null!;

    public string Resultado { get; set; } = null!;

    public string? Delito { get; set; }

    public int? CodDelito { get; set; }

    public string? Ruc { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public string Evaluacion { get; set; } = null!;

    public string? Organismo { get; set; }

    public string? DetalleOrganismo { get; set; }

    public string VerbalEscrita { get; set; } = null!;

    public int? RutFun { get; set; }

    public string? NombreFun { get; set; }

    public string? PaternoFun { get; set; }

    public string? MaternoFun { get; set; }

    public DateTime? FechaInforme { get; set; }

    public DateTime? FechaEvaluacion { get; set; }

    public string SituacionDecreto { get; set; } = null!;

    public string Interoperatividad { get; set; } = null!;

    public decimal? NumeroFoco { get; set; }

    public string? Ddhh { get; set; }

    public string ConFirmaElectronica { get; set; } = null!;

    public DateTime? FechaFirmaElectronica { get; set; }

    public string TipoInstruccionParticular { get; set; } = null!;

    public string? NumeroDocumento { get; set; }

    public string? ComunaHecho { get; set; }

    public string? Fiscal { get; set; }

    public string? CierreDefinitivo { get; set; }
}
