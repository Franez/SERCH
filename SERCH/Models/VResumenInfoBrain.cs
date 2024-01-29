using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VResumenInfoBrain
{
    public string? Unidad { get; set; }

    public int? FuncionariosBrain { get; set; }

    public string? CodRegion { get; set; }

    public string? Region { get; set; }

    public DateTime? FechaIngresoSistema { get; set; }

    public string? Decreto { get; set; }

    public int? CantidadInformes { get; set; }

    public int? CantidadActas { get; set; }

    public int? CantDiligenciasPersonales { get; set; }

    public int? CantDiligencias { get; set; }

    public int? CantPideCuenta { get; set; }

    public int? CantAmpliaciones { get; set; }

    public int? CantDecInformados { get; set; }

    public int? CantDecDiasVencidos { get; set; }

    public int? PromDecDiasVencidos { get; set; }

    public int? CantDecVencidos { get; set; }

    public int? CantMinutosTrabajados { get; set; }

    public int? PromedioMinutosTrabajados { get; set; }
}
