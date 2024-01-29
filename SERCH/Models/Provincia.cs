using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Provincia
{
    public string ProviCod { get; set; } = null!;

    public string ProviDes { get; set; } = null!;

    public string Regcod { get; set; } = null!;

    public short? ProviVigCod { get; set; }
}
