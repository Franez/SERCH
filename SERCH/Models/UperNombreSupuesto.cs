using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperNombreSupuesto
{
    public string UperId { get; set; } = null!;

    public short UperSupNomId { get; set; }

    public string? UsupApePat { get; set; }

    public string? UsupApeMat { get; set; }

    public string? UsupNomCom { get; set; }

    public string UperNomSupVig { get; set; } = null!;

    public string UperNomSupPrim { get; set; } = null!;
}
