using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoSecuestroExigencium
{
    public int InpSecNro { get; set; }

    public string InpFolio { get; set; } = null!;

    public int InpSecuExigenId { get; set; }

    public string? InpSecuExigenTipo { get; set; }

    public decimal? InpSecuExigenCant { get; set; }

    public string? InpSecuExigenDetalle { get; set; }
}
