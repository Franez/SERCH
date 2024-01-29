using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesMetasMaestro
{
    public short MetasCod { get; set; }

    public string? MetasDes { get; set; }

    public short? MetasActivas { get; set; }

    public decimal? MetasPond { get; set; }

    public short? MetasTipo { get; set; }

    public string? MetasTxtExpl { get; set; }
}
