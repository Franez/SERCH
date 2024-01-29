using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VisitasLibro6a
{
    public decimal UniLib6aCorr { get; set; }

    public DateTime? FechaHoraIngresoSistema { get; set; }

    public DateTime? FechaHoraSalidaSistema { get; set; }

    public DateTime? FechaHoraIngresoDigitado { get; set; }

    public DateTime? FechaHoraSalidaDigitada { get; set; }

    public string? DocumentoIngresa { get; set; }

    public string? NombreIngresa { get; set; }

    public string? PaternoIngresa { get; set; }

    public string? MaternoIngresa { get; set; }

    public string? NumDocPersonaQueVisita { get; set; }

    public string? IdPersonaQueVisita { get; set; }

    public string? NombrePersonaQueVisita { get; set; }

    public string? PaternoPersonaQueVisita { get; set; }

    public string? MaternoPersonaQueVisita { get; set; }

    public string? Asociacion { get; set; }

    public int RutFunIngresa { get; set; }

    public string? NombreFuncionario { get; set; }

    public string? PaternoFuncionario { get; set; }

    public string? MaternoFuncionario { get; set; }

    public string? Unidad { get; set; }

    public string? IdCuartel { get; set; }

    public string? MotivoVisita { get; set; }

    public string? Observación { get; set; }

    public string? ActivoEliminado { get; set; }

    public string? ConDiscapacidad { get; set; }
}
