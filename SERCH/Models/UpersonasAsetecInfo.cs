using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasAsetecInfo
{
    public string UperId { get; set; } = null!;

    public short UperAsetecFolio { get; set; }

    public string? UperAsetecInfo { get; set; }

    public DateTime? UperAsetecFec { get; set; }

    public string? UperAsetecInfVig { get; set; }
}
