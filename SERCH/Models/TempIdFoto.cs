using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TempIdFoto
{
    public int TempFunCod { get; set; }

    public DateTime TempFecCon { get; set; }

    public string TempFotoUperId { get; set; } = null!;
}
