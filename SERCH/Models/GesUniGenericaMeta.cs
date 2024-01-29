using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesUniGenericaMeta
{
    public string GesGenUniCod { get; set; } = null!;

    public short GesUniAno { get; set; }

    public short GesUniMes { get; set; }

    public short MetasCod { get; set; }

    public int? GesUniMetaIns { get; set; }

    public DateTime? GesUniMetaFecIns { get; set; }
}
