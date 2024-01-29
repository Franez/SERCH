using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoSsDetalle
{
    public string InpFolio { get; set; } = null!;

    public short InpSsfolio { get; set; }

    public short InpSucfolio { get; set; }

    public int InpSsperFunRut { get; set; }

    public short? InpSsperFunCargo { get; set; }

    public string? InpSsperFunUniCod { get; set; }

    public short? InpSsperFunTipo { get; set; }

    public string? InpSsperFunFinTrab { get; set; }

    public string? InpSsperFunFinTrabMot { get; set; }

    public string? InpSsperFunFinTrabMotDes { get; set; }
}
