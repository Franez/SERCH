using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class EspeciesJenanco
{
    public DateTime FechaHoraExtraccion { get; set; }

    public string Folio { get; set; } = null!;

    public string? TipoOrden { get; set; }

    public DateTime? FechaEvaluacion { get; set; }

    public string CodUnidad { get; set; } = null!;

    public string? Unidad { get; set; }

    public string? RegionUnidad { get; set; }

    public string? Delito { get; set; }

    public string? EstadoEspecie { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Serie { get; set; }

    public short? CodigoEspecie { get; set; }

    public string? TipoEspecie { get; set; }

    public string? CodigoDetEspecie { get; set; }

    public string? TipoDetalle { get; set; }

    public DateTime? FechaIncautacion { get; set; }

    public TimeSpan? HoraIncautacion { get; set; }

    public string? Detalle { get; set; }

    public string? Medida { get; set; }

    public decimal? Valor { get; set; }

    public string? UniEspSdtingEnc { get; set; }

    public string? UniEspSdtcanEnc { get; set; }

    public short? Inpeval { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public TimeSpan? HoraRecepcion { get; set; }

    public string? MonDes { get; set; }
}
