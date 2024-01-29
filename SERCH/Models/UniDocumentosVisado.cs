using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniDocumentosVisado
{
    public string InpFolio { get; set; } = null!;

    public short DocVisNro { get; set; }

    public int? DocVisRut { get; set; }

    public DateTime? DocVisFec { get; set; }

    public string? DocVisHor { get; set; }

    public DateTime? DocVisFho { get; set; }

    public short? DocVisUlt { get; set; }

    public string? DocVisCom { get; set; }

    public short? DocVisCal { get; set; }
}
