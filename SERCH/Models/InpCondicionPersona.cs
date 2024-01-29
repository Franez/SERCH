using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCondicionPersona
{
    public short UperCondCod { get; set; }

    public string? UperCondDes { get; set; }

    public short? UperCondVig { get; set; }

    public short? UperCondDenuncia { get; set; }

    public short? UperCondVictima { get; set; }

    public short? UperConDenImp { get; set; }

    public short? UperConDenTestigo { get; set; }

    public short? UperConEmpadrona { get; set; }

    public short? UperCondMinPub { get; set; }
}
