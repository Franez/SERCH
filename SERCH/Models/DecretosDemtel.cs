using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DecretosDemtel
{
    public string? RegionUnidad { get; set; }

    public string? Unidad { get; set; }

    public string? Jefatura { get; set; }

    public string? Prefectura { get; set; }

    public string? Decreto { get; set; }

    public string? Delito { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string Evaluacion { get; set; } = null!;

    public DateTime? FechaInforme { get; set; }

    public DateTime? FechaRealEvaluacion { get; set; }

    public DateTime? FechaUltimoEndoso { get; set; }

    public string ConSinResultado { get; set; } = null!;

    public DateTime? FechaHoraIngresoSistema { get; set; }

    public string VerbalEscrita { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string TipoInstruccion { get; set; } = null!;

    public DateTime? FechaDocumento { get; set; }

    public int RutFuncionario { get; set; }

    public string? NombreFuncionario { get; set; }

    public string? XmlIntercep { get; set; }
}
