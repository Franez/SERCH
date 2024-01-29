using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VLibro6a
{
    public decimal Correlativo { get; set; }

    public string? Uperid { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaIngresoReal { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public DateTime? FechaEgresoReal { get; set; }

    public string? PersonaVisitante { get; set; }

    public string? PApell1 { get; set; }

    public string? PApell2 { get; set; }

    public string? PDocumento { get; set; }

    public string? PDv { get; set; }

    public short? Edad { get; set; }

    public string? UperSexo { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Motivo { get; set; }

    public string? Discapacidad { get; set; }

    public string? Visitado { get; set; }

    public string? VApell1 { get; set; }

    public string? VApell2 { get; set; }

    public string? VDocumento { get; set; }

    public string? VDv { get; set; }

    public string? Observaciones { get; set; }

    public string? IdCuartel { get; set; }

    public string? FuncionarioIngresa { get; set; }

    public string? FuniApe1 { get; set; }

    public string? FuniApe2 { get; set; }

    public int? FuniRut { get; set; }

    public string? FuncionarioSalida { get; set; }

    public string? FunsApe1 { get; set; }

    public string? FunsApe2 { get; set; }

    public int? FusRut { get; set; }
}
