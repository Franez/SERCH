using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VDecretosDestapolSolo
{
    public string InpFolio { get; set; } = null!;

    public string? Decreto { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public TimeSpan? HoraRecepcion { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public string? Delito { get; set; }

    public string? FamiliaOrganismo { get; set; }

    public string? Organismo { get; set; }

    public string? CausaORuc { get; set; }

    public string? Unidad { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int? RutFunACargo { get; set; }

    public string? NombreFunACargo { get; set; }

    public string? Resultado { get; set; }

    public DateTime? FechaInformada { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? TipoInsOTramite { get; set; }
}
