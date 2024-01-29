using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HisEnvioDec
{
    public string FolioInterno { get; set; } = null!;

    public short CorrEnvDev { get; set; }

    public DateTime? FechaHoraEnvDev { get; set; }

    public string? Estado { get; set; }

    public int RutEjecuta { get; set; }

    public string? NombreEjecuta { get; set; }

    public string? PaternoEjecuta { get; set; }

    public string? MaternoEjecuta { get; set; }
}
