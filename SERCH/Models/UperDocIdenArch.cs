using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperDocIdenArch
{
    public string UperId { get; set; } = null!;

    public short UperDocIdenNro { get; set; }

    public byte[] UperDocIdenArch1 { get; set; } = null!;

    public string UperDocIdenNom { get; set; } = null!;

    public string UperDocIdenExt { get; set; } = null!;
}
