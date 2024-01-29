using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class GesAuditoriaUnidade
{
    public int IdmovGesaud { get; set; }

    public DateTime? FechaGesaud { get; set; }

    public string? GesunicodGesaud { get; set; }

    public string? GesunidesGesaud { get; set; }

    public string? Gesunicodcompleto { get; set; }

    public string? MovoldGesaud { get; set; }

    public string? MovnewGesaud { get; set; }

    public string? UserGesaud { get; set; }
}
