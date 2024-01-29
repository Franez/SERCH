using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpSsFoto
{
    public string InpFolio { get; set; } = null!;

    public short InpSucfolio { get; set; }

    public short InpSsfotoId { get; set; }

    public byte[] InpSsfotos { get; set; } = null!;
}
