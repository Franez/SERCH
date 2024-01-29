using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Asociacione
{
    public short AsoTipCod { get; set; }

    public string? AsoTipDes { get; set; }

    public string? AsoInvDes { get; set; }

    public short? AsoNomSup { get; set; }

    public short? AsoPadres { get; set; }

    public short? AsoMadre { get; set; }

    public short? AsoConyuge { get; set; }

    public short? AsoConviviente { get; set; }

    public short? AsoCodFun { get; set; }
}
