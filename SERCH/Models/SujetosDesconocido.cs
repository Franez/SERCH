using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class SujetosDesconocido
{
    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Condicion { get; set; }

    public string? Delito { get; set; }

    public string? Ruc { get; set; }

    public string? ComunaDelito { get; set; }

    public string? Unidad { get; set; }

    public short? AlturaInicial { get; set; }

    public short? AlturaFinal { get; set; }

    public string? Sexo { get; set; }

    public string? TipoCabeza { get; set; }

    public string? Apodo { get; set; }

    public string? RangoEdad { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Cabello { get; set; }

    public string? ColorCabello { get; set; }

    public string? TipoCara { get; set; }

    public string? Profesion { get; set; }

    public string? ColorOjos { get; set; }

    public string? Contextura { get; set; }

    public string? TipoVoz { get; set; }

    public string? TipoFrente { get; set; }

    public string? TipoPiel { get; set; }

    public string? TipoNariz { get; set; }

    public string? TipoOrdeja { get; set; }

    public string? TipoMenton { get; set; }

    public string? TipoBoca { get; set; }

    public string? NombreSupuesto { get; set; }

    public string? PaternoSupuesto { get; set; }

    public string? MaternoSupuesto { get; set; }

    public string? Cicatriz { get; set; }

    public string? TipoTatuaje { get; set; }

    public string? Vestimenta { get; set; }

    public string? DetalleVestimenta { get; set; }

    public string? ObsVestimenta { get; set; }

    public string? IdPersona { get; set; }
}
