using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EncargosGepolxdr
{
    public string? Rut { get; set; }

    public string? Dv { get; set; }

    public string? Nombre { get; set; }

    public string Paterno { get; set; } = null!;

    public string? Materno { get; set; }

    public string? Sexo { get; set; }

    public string? AntAsetec { get; set; }

    public string? Nacionalidad { get; set; }

    public string? AntDepinfi { get; set; }

    public string? AntJenaex { get; set; }

    public string? AntEncargo { get; set; }

    public short CorrEncargo { get; set; }

    public DateTime? FechaHoraIngresoEncargo { get; set; }

    public string? TipoEncargo { get; set; }

    public string? DescEncargo { get; set; }

    public string? DelitoEncargo { get; set; }

    public string? OrganismoGeneraEncargo { get; set; }
}
