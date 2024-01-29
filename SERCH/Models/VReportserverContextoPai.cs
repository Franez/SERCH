using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VReportserverContextoPai
{
    public string FolioInterno { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public short CodContexto { get; set; }

    public string? GrupoContexto { get; set; }

    public short CodDetContexto { get; set; }

    public string? DetalleContexto { get; set; }
}
