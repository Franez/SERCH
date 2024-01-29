using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncTipoDocumento
{
    public string EncTipDocCod { get; set; } = null!;

    public string? EncTipDocDes { get; set; }

    public short? EncTipDocVig { get; set; }

    public short? EncTipDocOrdVer { get; set; }

    public short? EncTipDocFteInp { get; set; }

    public short? EncTipDocCan { get; set; }
}
