using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasFoto
{
    public string UperId { get; set; } = null!;

    public short UperFotoId { get; set; }

    public byte[]? UperFotoImg { get; set; }

    public string? UperFotoUsuCod { get; set; }

    public short? FisUbiCod { get; set; }

    public short? UperFotoFront { get; set; }

    public DateTime? UperFotoFecIns { get; set; }

    public string? UperFotoWrkIns { get; set; }

    public string? UperFotoUsuUpd { get; set; }

    public DateTime? UperFotoFecUpd { get; set; }

    public string? UperFotoWrkUpd { get; set; }

    public string? UperFotoPrin { get; set; }

    public string? UperFotoVig { get; set; }
}
