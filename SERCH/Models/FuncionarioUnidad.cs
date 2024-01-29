using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class FuncionarioUnidad
{
    public int PerFunRut { get; set; }

    public string PerUnidadIngreso { get; set; } = null!;

    public DateTime? PerUniFecIng { get; set; }

    public short? PerUnidadActiva { get; set; }
}
