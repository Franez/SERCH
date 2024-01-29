using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoConclusione
{
    public string InpFolio { get; set; } = null!;

    public short InpClcFolio { get; set; }

    public string? InpClcTexto { get; set; }

    public string? InpClcCorrDel { get; set; }

    public int? InpClcFunfirma1 { get; set; }

    public int? InpClcFunfirma2 { get; set; }

    public int? InpClcFunfirma3 { get; set; }
}
