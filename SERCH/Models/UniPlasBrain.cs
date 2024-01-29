using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniPlasBrain
{
    public string UniPlasUperId { get; set; } = null!;

    public int UniPlasAno { get; set; }

    public decimal UniPlasCorre { get; set; }

    public DateTime? UniPlasFecha { get; set; }

    public DateTime? UniPlasHora { get; set; }

    public string? UniPlasCarro { get; set; }

    public string? UniPlasCalle { get; set; }

    public string? UniPlasNroArteria { get; set; }

    public string? UniPlasConCalleInt { get; set; }

    public decimal? UniPlasFrenteNro { get; set; }

    public short? UniPlasTipoServ { get; set; }

    public short? UniPlasUestado { get; set; }

    public string? UniPlasComuna { get; set; }

    public string? UniPlasProvincias { get; set; }

    public string? UniPlasRegion { get; set; }

    public short UniPlasVig { get; set; }

    public int UniPlasFunRut { get; set; }

    public string? UniPlasWrkIns { get; set; }

    public DateTime? UniPlasInsFec { get; set; }

    public int? UniPlasFunCar { get; set; }

    public string? UniPlasUnidad { get; set; }

    public string? UniPlasObs { get; set; }

    public string? UniPlasLat { get; set; }

    public string? UniPlasLong { get; set; }

    public string? UniPlasCalleCod { get; set; }
}
