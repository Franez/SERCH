using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DetenidosTodo
{
    public DateTime FechaHoraExtraccion { get; set; }

    public string? InpPerId { get; set; }

    public string FolioInternoDecreto { get; set; } = null!;

    public string? RegionUnidad { get; set; }

    public string IdUnidad { get; set; } = null!;

    public string? Unidad { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaIngresoSistema { get; set; }

    public DateTime? FechaEvaluacion { get; set; }

    public short IdOrden { get; set; }

    public string? Orden { get; set; }

    public string? Resultado { get; set; }

    public int? CodDelito { get; set; }

    public string? Delito { get; set; }

    public string? ApePat { get; set; }

    public string? ApellMat { get; set; }

    public string? Nombre { get; set; }

    public string Documento { get; set; } = null!;

    public string? Dv { get; set; }

    public string? TipoDoc { get; set; }

    public string? Sexo { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public short? CodPaisNac { get; set; }

    public string? Nacionalidad { get; set; }

    public string? AsistenciaConsular { get; set; }

    public short? CodCondicion { get; set; }

    public string? Condicion { get; set; }

    public string? LecturaDeDerechos { get; set; }

    public string? IdiomaLecturaDederecho { get; set; }

    public string MedProtecMenor { get; set; } = null!;

    public string MenorDirigidoA { get; set; } = null!;

    public string? RelacionConMenor { get; set; }

    public string? NombrePersonaRetiraMenor { get; set; }

    public string DirContactoMenor { get; set; } = null!;

    public string? AntecedentesDentencion { get; set; }

    public string CircunstanciaDetencion { get; set; } = null!;

    public string? InpPerDetRegCod { get; set; }

    public string? PresentaLesionesDetencion { get; set; }

    public string? LesionesDetencion { get; set; }

    public DateTime? FechaDetencion { get; set; }

    public short HoraDetencion { get; set; }

    public DateTime? TiempoDetencion { get; set; }

    public short MinDetencion { get; set; }

    public string? DirExactaDetencion { get; set; }

    public string? CodComuDet { get; set; }

    public string? RegionDetencion { get; set; }

    public string? ComunaDetencion { get; set; }

    public string? CodCalleDet { get; set; }

    public string? CalleDetencion { get; set; }

    public string? NroDireccionDet { get; set; }

    public string? NroParcelaDeptoDet { get; set; }

    public string? LugarDetencion { get; set; }

    public int? CodMotDetencion { get; set; }

    public string? MotDetencion { get; set; }

    public string EstadoDetencion { get; set; } = null!;

    public short? CodContexto { get; set; }

    public string? GrupoContexto { get; set; }

    public short? CodDetContexto { get; set; }

    public string? DetalleContexto { get; set; }

    public string? Profesion { get; set; }

    public string? Escolaridad { get; set; }

    public string? EstadoCivil { get; set; }

    public string? ComunaPersona { get; set; }
}
