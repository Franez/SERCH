using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EndososBrainOfan
{
    public string Folio { get; set; } = null!;

    public short NumeroEndoso { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaRegistroEndoso { get; set; }

    public short? DiasPlazo { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int RutFuncionarioEndosador { get; set; }

    public string? NomrbeFuncionarioEndosador { get; set; }

    public string? SubPerfilAsignador { get; set; }

    public string? UnidadFunEndosa { get; set; }

    public int RutFuncionarioRecibeEndoso { get; set; }

    public string? NomrbeFuncionarioRecibeEndoso { get; set; }

    public string? SubPerfilReceptor { get; set; }

    public string? UnidadFunRecibe { get; set; }

    public string? EstadoEndoso { get; set; }

    public DateTime? FechaDoc { get; set; }

    public DateTime? FechaRecepción { get; set; }

    public DateTime? FechaIngresoSistema { get; set; }

    public DateTime? FechaEvaluacion { get; set; }

    public DateTime? FechaInforme { get; set; }

    public string? Decreto { get; set; }

    public string? RegionUnidad { get; set; }

    public string? Ruc { get; set; }

    public string? TipoMovimiento { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public string? HoraMovimiento { get; set; }
}
