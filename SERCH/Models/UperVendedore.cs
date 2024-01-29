using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperVendedore
{
    public string UperVenId { get; set; } = null!;

    public string? UperVenTipDoc { get; set; }

    public decimal? UperVenRut { get; set; }

    public string? UperVenDv { get; set; }

    public string? UperVenNombre { get; set; }

    public string? UperVenApePat { get; set; }

    public string? UperVenApeMat { get; set; }

    public short? UperVenTipo { get; set; }

    public string? UperVenDir { get; set; }

    public string? UperVenIdEnc { get; set; }

    public string? UperVenCom { get; set; }

    public short? UperVenRutInv { get; set; }
}
