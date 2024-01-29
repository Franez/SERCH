using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Herramienta
{
    public string HerrCod { get; set; } = null!;

    public string? HerrDes { get; set; }

    public short? HerrMarCod { get; set; }

    public short? HerrTipo { get; set; }

    public byte[]? HerrFoto { get; set; }

    public string? HerrModelo { get; set; }

    public short? HerTipoCod { get; set; }

    public string HerTipoDes { get; set; } = null!;
}
