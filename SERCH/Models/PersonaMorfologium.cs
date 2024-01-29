using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class PersonaMorfologium
{
    public string FolioInterno { get; set; } = null!;

    public string? Decreto { get; set; }

    public string? Ruc { get; set; }

    public string? Delito { get; set; }

    public int RutFuncionario { get; set; }

    public string? NombreFuncionario { get; set; }

    public string? Unidad { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string? Persona { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Condicion { get; set; }

    public string? NumeroTel { get; set; }

    public string? Email { get; set; }

    public string? Apodo { get; set; }

    public string? Domicilio { get; set; }

    public string? MarcaVehiculo { get; set; }

    public string? TipoVehiculo { get; set; }

    public string? PatenteVehiculo { get; set; }

    public string? Tatuaje { get; set; }

    public string? UbicacionTatuaje { get; set; }

    public string? TipoAlteración { get; set; }

    public string? TipoCicatriz { get; set; }

    public string? UbucacionCicatriz { get; set; }

    public string? TipoDiligencia { get; set; }

    public string? ObsDiligencia { get; set; }

    public string? DiligenciaSobreLaPersona { get; set; }

    public string? TipoRedSoc { get; set; }

    public string? UsuarioNick { get; set; }

    public string? Url { get; set; }

    public string? OtraRedSocial { get; set; }

    public string IdPersona { get; set; } = null!;

    public string TipoDomicilio { get; set; } = null!;

    public string? Region { get; set; }

    public string? Provincia { get; set; }

    public string? Comuna { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public string? Depto { get; set; }

    public string? CasaDepto { get; set; }

    public string? Escolaridad { get; set; }

    public string? Profesion { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Etnia { get; set; }

    public string Genero { get; set; } = null!;

    public string Sexo { get; set; } = null!;
}
