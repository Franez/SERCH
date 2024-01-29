using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VistaNna
{
    public string FolioInterno { get; set; } = null!;

    public string? FolioNacional { get; set; }

    public DateTime? FechaDenuncia { get; set; }

    public DateTime? HoraDenuncia { get; set; }

    public string? InpInfoF4nna { get; set; }

    public string? InpInfoF3nna { get; set; }

    public string? NomProtecNna { get; set; }

    public string? NomAcomNna { get; set; }

    public string? Region { get; set; }

    public string? Unidad { get; set; }

    public string Ciudad { get; set; } = null!;

    public int CodDelito { get; set; }

    public string? Delito { get; set; }

    public string? CondicionPersona { get; set; }

    public string? NumDocDenun { get; set; }

    public string? NombreDenunciante { get; set; }

    public string? _1ApellidoDenunciante { get; set; }

    public string? _2ApellidoDenunciante { get; set; }

    public string? Sexo { get; set; }

    public short? Edad { get; set; }

    public string? Relato { get; set; }
}
