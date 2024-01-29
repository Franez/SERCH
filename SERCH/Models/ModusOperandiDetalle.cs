using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ModusOperandiDetalle
{
    public short ModOpCod { get; set; }

    public short ModOpDetCod { get; set; }

    public string? ModOpDetDes { get; set; }

    public short? ModOpDetVig { get; set; }
}
