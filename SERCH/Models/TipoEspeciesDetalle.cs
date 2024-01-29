using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class TipoEspeciesDetalle
{
    public short TipoEspCod { get; set; }

    public string TipoEspDetCod { get; set; } = null!;

    public string? TipoEspDetDes { get; set; }

    public short? TipoEspDetVig { get; set; }

    public short? TipoEspDetVigBrain { get; set; }

    public short? TipoEspDetCodMp { get; set; }
}
