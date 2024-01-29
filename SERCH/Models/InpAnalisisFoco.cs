using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpAnalisisFoco
{
    public string InpFolio { get; set; } = null!;

    public string InpFolioAnalisis { get; set; } = null!;

    public DateTime InpAnalisisDate { get; set; }

    public DateTime InpAnalisisDateSistema { get; set; }

    public short InpAnalisisVig { get; set; }

    public string InpAnalisisTitu { get; set; } = null!;

    public string? InpAnalisisEscrito { get; set; }

    public short InpAnalisisYear { get; set; }
}
