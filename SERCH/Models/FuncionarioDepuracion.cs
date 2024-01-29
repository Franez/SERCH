using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class FuncionarioDepuracion
{
    public int PerFunRut { get; set; }

    public short DepEncNro { get; set; }

    public string? DepEncId { get; set; }

    public DateTime? DepEncFecHora { get; set; }

    public short? DepEncTipo { get; set; }

    public string? DepEncObs { get; set; }
}
