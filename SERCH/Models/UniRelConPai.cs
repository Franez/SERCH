using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniRelConPai
{
    public string InpFolio { get; set; } = null!;

    public short UniCodContPai { get; set; }

    public short UniDetCodConPai { get; set; }
}
