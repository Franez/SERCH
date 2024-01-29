using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoDelito
{
    public short TipDelCod { get; set; }

    public string? TipDelDes { get; set; }

    public short? TipDelVig { get; set; }
}
