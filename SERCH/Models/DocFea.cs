using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class DocFea
{
    public DateTime FechaHoraEjecucion { get; set; }

    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Unidad { get; set; }

    public string? Region { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaHoraIngresoSistema { get; set; }

    public string Estado { get; set; } = null!;

    public string Resultado { get; set; } = null!;

    public string? Delito { get; set; }

    public string Evaluacion { get; set; } = null!;

    public string? Organismo { get; set; }

    public string? DetalleOrganismo { get; set; }

    public int? RutFun { get; set; }

    public string? NombreFun { get; set; }

    public string? PaternoFun { get; set; }

    public string? MaternoFun { get; set; }

    public DateTime? FechaFirmaElectronica { get; set; }
}
