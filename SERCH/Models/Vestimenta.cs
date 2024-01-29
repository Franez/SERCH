using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Vestimenta
{
    public short VestCod { get; set; }

    public string? VestDes { get; set; }

    public string VestVig { get; set; } = null!;
}
