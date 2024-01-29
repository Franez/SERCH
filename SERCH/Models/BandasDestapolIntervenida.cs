using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class BandasDestapolIntervenida
{
    public string UperId { get; set; } = null!;

    public string? NombreIntegrante { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public string Documento { get; set; } = null!;

    public string? Dv { get; set; }

    public string PaiGen { get; set; } = null!;

    public string? ObsDelpein { get; set; }

    public DateTime? FechaInscriPein { get; set; }

    public string? Jerarquia { get; set; }

    public string? NombreGrupo { get; set; }

    public string? TipoOrg { get; set; }

    public string RegionOrganizacion { get; set; } = null!;

    public string ProvinciaOrganizacion { get; set; } = null!;

    public string? ComunaOrganizacion { get; set; }

    public string PaisOrganizacion { get; set; } = null!;

    public string? FuncionarioInscribe { get; set; }

    public string? RutFunInscribe { get; set; }

    public string? UnidadFuncionario { get; set; }

    public string? CondicionIntervenida { get; set; }

    public string? Delito { get; set; }

    public string InpFolio { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? UnidadIntervino { get; set; }
}
