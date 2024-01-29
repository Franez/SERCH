using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoDrogasDelAso
{
    public string InpFolio { get; set; } = null!;

    public short DrogCod { get; set; }

    public decimal InpDrogFolio { get; set; }

    public int InpDroDelAso { get; set; }
}
