using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniCausasAsociada
{
    public string InpFolio { get; set; } = null!;

    public short UnicauNro { get; set; }

    public string? UnicauRuc { get; set; }

    public DateTime? UnicauFec { get; set; }

    public int? UnicauDel { get; set; }

    public string? UniTipOrdPen { get; set; }
}
