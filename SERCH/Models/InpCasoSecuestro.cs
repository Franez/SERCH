using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoSecuestro
{
    public int InpSecNro { get; set; }

    public string InpFolio { get; set; } = null!;

    public string? InpSecuMedio { get; set; }

    public DateTime? InpSecuFecha { get; set; }

    public DateTime? InpSecuHora { get; set; }

    public decimal? InpSecuFono { get; set; }

    public string? InpSecuContenido { get; set; }

    public short InpSecuVigencia { get; set; }

    public decimal? InpSecuDenNro { get; set; }

    public short? InpSecuTipoOrdenCod { get; set; }
}
