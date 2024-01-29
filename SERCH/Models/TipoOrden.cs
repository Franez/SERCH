using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoOrden
{
    public short TipoOrdenCod { get; set; }

    public string? TipoOrdenDes { get; set; }

    public short? TipoOrdenVig { get; set; }

    public short? TipoOrdenInf { get; set; }

    public short? TipoOrdenDen { get; set; }

    public short? TipoOrdenDeten { get; set; }

    public short? TipoOrdenExhorto { get; set; }

    public short? TipoOrdenMinCod { get; set; }
}
