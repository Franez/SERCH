using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniIngresoUrl
{
    public int PerFunRut { get; set; }

    public DateTime Uniurlhora { get; set; }

    public string Uniurl { get; set; } = null!;

    public string? ApePatInicio { get; set; }

    public string? ApeMatInicio { get; set; }

    public string? NombreInicio { get; set; }

    public short? GradoInicio { get; set; }

    public string? UnidadInicio { get; set; }

    public string? DvInicio { get; set; }

    public short? VariableNumerica { get; set; }

    public short? UniDiaPro { get; set; }

    public short? UniMesPro { get; set; }

    public short? UniAnoPro { get; set; }

    public short? UniHoraPro { get; set; }

    public short? UniMinPro { get; set; }

    public short? UniSecPro { get; set; }

    public string? UniRemoteWrk { get; set; }
}
