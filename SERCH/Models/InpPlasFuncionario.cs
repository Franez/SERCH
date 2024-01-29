using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpPlasFuncionario
{
    public int InpPlasfolio { get; set; }

    public int InpPlasparFunRut { get; set; }

    public string InpPlasparFunUni { get; set; } = null!;

    public string? InpIdCarroPol { get; set; }
}
