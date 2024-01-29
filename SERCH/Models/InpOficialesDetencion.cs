using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpOficialesDetencion
{
    public string InpFolio { get; set; } = null!;

    public short InpPerFolio { get; set; }

    public int InpOfiDetRut { get; set; }

    public string? InpPerDetId { get; set; }

    public string? InpOfiUniCod { get; set; }

    public short? InpOfiFunTipo { get; set; }
}
