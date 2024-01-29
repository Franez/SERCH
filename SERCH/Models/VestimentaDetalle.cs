using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VestimentaDetalle
{
    public short VestCod { get; set; }

    public short VestCorr { get; set; }

    public string? VestDetDes { get; set; }

    public string? VestDetVig { get; set; }
}
