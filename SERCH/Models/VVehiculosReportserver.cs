using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VVehiculosReportserver
{
    public long? RowNum { get; set; }

    public string InpFolio { get; set; } = null!;

    public short InpEspFolio { get; set; }

    public string? Ppu { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? FechaIngreso { get; set; }
}
