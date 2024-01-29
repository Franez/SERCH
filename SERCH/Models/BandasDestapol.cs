using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class BandasDestapol
{
    public string UperId { get; set; } = null!;

    public string? NombreIntegrante { get; set; }

    public string Documento { get; set; } = null!;

    public string? Dv { get; set; }

    public string PaiGen { get; set; } = null!;

    public string? ObsDelpein { get; set; }

    public DateTime? FechaInscriPein { get; set; }

    public string? Jerarquia { get; set; }

    public int GrupoCrimCodMa { get; set; }

    public int GrupoCrimAsoCodM { get; set; }

    public string? NombreGrupo { get; set; }

    public string? TipoOrg { get; set; }

    public string RegionOrganizacion { get; set; } = null!;

    public string ProvinciaOrganizacion { get; set; } = null!;

    public string? ComunaOrganizacion { get; set; }

    public string PaisOrganizacion { get; set; } = null!;

    public string? FuncionarioInscribe { get; set; }

    public string? RutFunInscribe { get; set; }

    public string? UnidadFuncionario { get; set; }

    public DateTime? FechaIngresoGrupoCriminal { get; set; }

    public int? CodDelitoGrupoCriminal { get; set; }

    public string? DelitoGrupoCriminal { get; set; }

    public string EstadoBanda { get; set; } = null!;

    public short? VigenciaAsociación { get; set; }
}
