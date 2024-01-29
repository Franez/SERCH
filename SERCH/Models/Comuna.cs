using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Comuna
{
    public string ComCod { get; set; } = null!;

    public string? ComDes { get; set; }

    public string? ComPrvCod { get; set; }

    public int? ComMinCod { get; set; }

    public short? ComVigCod { get; set; }

    public int? ComDestadCod { get; set; }

    public short? ComCodComunMp { get; set; }
}
