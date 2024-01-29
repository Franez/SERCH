using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasObservacione
{
    public string UperId { get; set; } = null!;

    public short UperObsNro { get; set; }

    public string? UperObsTxt { get; set; }

    public string? UperObsFunIns { get; set; }

    public DateTime? UperObsFecIns { get; set; }

    public string? UperObsIpins { get; set; }

    public string? UperObsFunUpd { get; set; }

    public DateTime? UperObsFecUpd { get; set; }

    public string? UperObsIpupd { get; set; }
}
