using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VDrogas15Dia
{
    public DateTime FechaHoraExtraccion { get; set; }

    public string FolioInterno { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public string? FolioNacional { get; set; }

    public string? Decreto { get; set; }

    public DateTime? FechaInforme { get; set; }

    public string CodUnidad { get; set; } = null!;

    public string CodRegion { get; set; } = null!;

    public string? Region { get; set; }

    public string? Unidad { get; set; }

    public string? CodJefatura { get; set; }

    public string Jefatura { get; set; } = null!;

    public string? CodPrefectura { get; set; }

    public string Prefectura { get; set; } = null!;

    public string? Droga { get; set; }

    public string? UnidadMedida { get; set; }

    public string? Estado { get; set; }

    public decimal? Nue { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? Avaluo { get; set; }

    public string? Delito { get; set; }

    public short? Ovoide { get; set; }

    public string? PaisOrigen { get; set; }

    public string? PaisDestino { get; set; }

    public string? OcultamientoDroga { get; set; }

    public string? ComunaHecho { get; set; }

    public DateTime? FechaAccionDroga { get; set; }
}
