using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Plebicito2022Decreto
{
    public string? RegionUnidad { get; set; }

    public string? Unidad { get; set; }

    public string? Jefatura { get; set; }

    public string? Prefectura { get; set; }

    public string? Decreto { get; set; }

    public string? Delito { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string Evaluacion { get; set; } = null!;

    public DateTime? FechaEvaluacion { get; set; }

    public string ConSinResultado { get; set; } = null!;

    public DateTime? FechaHoraIngresoSistema { get; set; }

    public string VerbalEscrita { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? HoraRecepcion { get; set; }

    public string EstadoDecreto { get; set; } = null!;
}
