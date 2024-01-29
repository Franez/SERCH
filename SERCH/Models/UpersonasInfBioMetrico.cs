using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UpersonasInfBioMetrico
{
    public string UperId { get; set; } = null!;

    public short UperCorrBio { get; set; }

    public string? UinfBiometrico { get; set; }

    public string? UperInfBioVig { get; set; }
}
