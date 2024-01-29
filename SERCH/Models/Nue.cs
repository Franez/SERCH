using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Nue
{
    public string FolioInterno { get; set; } = null!;

    public short FolioEvidencia { get; set; }

    public DateTime? FechaEvidencia { get; set; }

    public string? NUE1 { get; set; }

    public string? DondeFueLevantada { get; set; }

    public short? FolioEspecie { get; set; }

    public string? FamEspecie { get; set; }

    public string? DetEspecie { get; set; }

    public string? DescEspecie { get; set; }

    public string? NSerie { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Valor { get; set; }

    public decimal? FolioDroga { get; set; }

    public string? TipoDrogra { get; set; }

    public decimal? CantidadDroga { get; set; }

    public decimal? ValorDroga { get; set; }

    public DateTime? FechaAccionDroga { get; set; }

    public string EstadoDroga { get; set; } = null!;

    public short? FolioArma { get; set; }

    public string? EstadoArma { get; set; }

    public string? FamiliaArma { get; set; }

    public string? DescTipoArma { get; set; }

    public string? Modelo { get; set; }

    public short? CantidadArma { get; set; }

    public decimal? AvalúoArma { get; set; }

    public string? SerieArma { get; set; }
}
