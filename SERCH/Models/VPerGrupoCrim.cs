using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VPerGrupoCrim
{
    public string? NombreIntegrante { get; set; }

    public string? Documento { get; set; }

    public string? ObsDelpein { get; set; }

    public DateTime? FechaInscriPein { get; set; }

    public string? Jerarquia { get; set; }

    public string? NombreGrupo { get; set; }

    public string? TipoOrg { get; set; }

    public string RegionOrganizacion { get; set; } = null!;

    public string ProvinciaOrganizacion { get; set; } = null!;

    public string? ComunaOrganizacion { get; set; }

    public string? FuncionarioInscribe { get; set; }

    public string? RutFunInscribe { get; set; }

    public string? UnidadFuncionario { get; set; }
}
