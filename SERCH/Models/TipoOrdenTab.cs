using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoOrdenTab
{
    public short TipoOrdenCod { get; set; }

    public string TipoOrdenTabId { get; set; } = null!;

    public string? TipoOrdenTabDes { get; set; }

    public string? TipoOrdenTabVig { get; set; }

    public short? TipoOrdenTabOrd { get; set; }
}
