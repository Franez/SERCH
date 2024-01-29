using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasInfDatBu
{
    public string UperId { get; set; } = null!;

    public short UperCorrDatBus { get; set; }

    public string? UinfDatBus { get; set; }

    public string? UperInfDatBusVig { get; set; }
}
