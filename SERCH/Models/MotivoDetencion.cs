using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class MotivoDetencion
{
    public int MotDetCod { get; set; }

    public string? MotDetDes { get; set; }

    public short? MotDetFla { get; set; }

    public short? MotDetOa { get; set; }

    public string? MotDetVig { get; set; }
}
