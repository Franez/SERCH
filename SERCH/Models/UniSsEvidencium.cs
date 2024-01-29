using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniSsEvidencium
{
    public string InpFolio { get; set; } = null!;

    public short InpSucfolio { get; set; }

    public short InpSsfolio { get; set; }

    public short InpEspFolio { get; set; }

    public decimal? InpSsevidencias { get; set; }

    public DateTime? InpSsevidFecha { get; set; }

    public string? InpSsevidNue { get; set; }

    public string? InpSsevidLevantada { get; set; }

    public string? InpSsevidSolPeritaje { get; set; }

    public decimal? InpEspCant { get; set; }

    public string? InpEspTxt { get; set; }

    public string? InpEspCod { get; set; }

    public short? InpEspStatus { get; set; }

    public short? InpEspTipo { get; set; }
}
