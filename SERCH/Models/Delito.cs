using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Delito
{
    public int DelCod { get; set; }

    public string? DelDes { get; set; }

    public short? DelVigFlag { get; set; }

    public string? DelExptxt { get; set; }

    public short? DelPresDes { get; set; }

    public short? DelMayConSoc { get; set; }

    public short? DelIntPol { get; set; }

    public string? DelIngMont { get; set; }

    public string? DelNna { get; set; }

    public string? DelDdhh { get; set; }
}
