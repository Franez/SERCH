using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasDocumento
{
    public string UperId { get; set; } = null!;

    public string UperDocTipo { get; set; } = null!;

    public string UperDocNro { get; set; } = null!;

    public short UperDocPaiEmi { get; set; }

    public string? UperDocDv { get; set; }

    public DateTime? UperDocFecEmi { get; set; }

    public DateTime? UperDocFecVen { get; set; }

    public string? UperDocUsuIns { get; set; }

    public string? UperDocWrkIns { get; set; }

    public DateTime? UperDocFecIns { get; set; }

    public short? UperDocAplIns { get; set; }

    public short? UperDocAplUpd { get; set; }

    public string? UperDocUsuUpd { get; set; }

    public string? UperDocWrkUpd { get; set; }

    public DateTime? UperDocFecUpd { get; set; }

    public string? UperDocPrin { get; set; }

    public string? UperDocVig { get; set; }

    public string? UperDocSexo { get; set; }

    public string? UperDocAnt { get; set; }
}
