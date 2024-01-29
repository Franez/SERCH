using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class MorfologiaDetalle
{
    public short MorfCod { get; set; }

    public short MorfDetCod { get; set; }

    public string? MorfDetDes { get; set; }

    public short? MorfDetVig { get; set; }
}
