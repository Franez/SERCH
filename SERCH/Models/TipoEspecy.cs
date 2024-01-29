using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoEspecy
{
    public short TipoEspCod { get; set; }

    public string? TipoEspDes { get; set; }

    public short? TipoEspArmas { get; set; }

    public short? TipoEspVig { get; set; }

    public short? TipoEspVigencia { get; set; }

    public short? TipoEspCodMp { get; set; }
}
