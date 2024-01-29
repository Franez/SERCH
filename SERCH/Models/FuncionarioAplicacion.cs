using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class FuncionarioAplicacion
{
    public int PerFunRut { get; set; }

    public short ApliNro { get; set; }

    public short? ApliFunPerfil { get; set; }

    public short? ApliFunActivo { get; set; }

    public string? ApliFunPerOf { get; set; }
}
