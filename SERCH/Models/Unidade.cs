using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Unidade
{
    public string UnidadCod { get; set; } = null!;

    public string UnidadDes { get; set; } = null!;

    public string Regcod { get; set; } = null!;

    public int? UnidadSupRut { get; set; }

    public short? UnidadEsp { get; set; }
}
