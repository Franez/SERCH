using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ArmasDestapol
{
    public string FolioInternoDecreto { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Region { get; set; }

    public string CodUnidad { get; set; } = null!;

    public string? Unidad { get; set; }

    public string? Ruc { get; set; }

    public string? Rit { get; set; }

    public string? Rol { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaInformada { get; set; }

    public string? CerradoInforme { get; set; }

    public int? CodDelito { get; set; }

    public string? Delito { get; set; }

    public short? CodEstado { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaIncautacion { get; set; }

    public DateTime? HoraIncautacion { get; set; }

    public short Folioarma { get; set; }

    public string Recuperada { get; set; } = null!;

    public string Modificada { get; set; } = null!;

    public string? Modificacion { get; set; }

    public string? TipoInfraccion { get; set; }

    public string EstadoSerie { get; set; } = null!;

    public string? Serie { get; set; }

    public string? OcultamientoArma { get; set; }

    public short? Cantidad { get; set; }

    public decimal? Avaluo { get; set; }

    public string? Moneda { get; set; }

    public string ArmaFiscal { get; set; } = null!;

    public string? Institucion { get; set; }

    public string CunnoBancoPruebasChile { get; set; } = null!;

    public string ConsultadoDgmn { get; set; } = null!;

    public string Inscrita { get; set; } = null!;

    public short? CodTipoarma { get; set; }

    public string? TipoArma { get; set; }

    public short? CodFamiliaarma { get; set; }

    public string? FamiliaArma { get; set; }

    public short? CodMarcarma { get; set; }

    public string? MarcaArma { get; set; }

    public short? CodCalibre { get; set; }

    public string? Calibre { get; set; }

    public short? CodPaisarma { get; set; }

    public string? PaisArma { get; set; }

    public string? ModeloArma { get; set; }

    public string? RutDuenno { get; set; }

    public string? NombreDuenno { get; set; }

    public string? CalleDuenno { get; set; }

    public string? ComunaDuenno { get; set; }

    public string? NumDirDuenno { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public TimeSpan? HoraRecepcion { get; set; }

    public DateTime? FechaInformeFechaEvaluacion { get; set; }

    public DateTime? FechaInforme { get; set; }

    public DateTime? FechaEndoso { get; set; }

    public DateTime? FechaIngresoSistema { get; set; }

    public string? ComunaDecreto { get; set; }

    public DateTime? FechaIngresoArma { get; set; }

    public int? RutFuncionarioIngresaArma { get; set; }

    public string? FuncionarioIngresaArma { get; set; }
}
