using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class ExtInfractor
{
    public string FolioInterno { get; set; } = null!;

    public DateTime? FechaIngresoSistema { get; set; }

    public string Organismo { get; set; } = null!;

    public string? DetalleOranismo { get; set; }

    public string? Infracción { get; set; }

    public string? DelitoInfracción { get; set; }

    public string? Facultades { get; set; }

    public string? ModalidadInfracción { get; set; }

    public string? TipoDenuncia { get; set; }

    public string? MedioDenuncia { get; set; }

    public string? Autoridad { get; set; }

    public string? Condicion { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nombre { get; set; }

    public string? _1Apellido { get; set; }

    public string? _2Apellido { get; set; }

    public string? Nacionalidad { get; set; }

    public string Sexo { get; set; } = null!;

    public string? DomicilioCompleto { get; set; }

    public string? Region { get; set; }

    public string? Comuna { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public string? Depto { get; set; }

    public string? Block { get; set; }

    public string? DomicilioEnElExtranjero { get; set; }

    public string? LugarNacimiento { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Escolaridad { get; set; }

    public string? AntMigratorio { get; set; }

    public string? LugarIngreso { get; set; }

    public DateTime? FechaIngresoFechaEstimada { get; set; }

    public DateTime? FechaIntentoEgreso { get; set; }

    public string? CondicionIngreso { get; set; }

    public string? CondResidencia { get; set; }

    public string? TipoVisa { get; set; }

    public string? AutoridadOtorgante { get; set; }

    public string? NumeroResolución { get; set; }

    public DateTime? FechaResolución { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? NTimbreMigratorio { get; set; }

    public string? NombreEmpleados { get; set; }

    public string? NombreDueñoReside { get; set; }

    public string? CiudadDestino { get; set; }

    public string? MedioTransporte { get; set; }

    public string? VictimaDe { get; set; }

    public string? Acompañante { get; set; }

    public string? Relacion { get; set; }

    public string? DivisaPagado { get; set; }

    public decimal? DineroPagado { get; set; }

    public string? AQuienLePago { get; set; }

    public string? IngresoPorFlagrancia { get; set; }

    public string? DetalleFlagrancia { get; set; }

    public short? CantidadMenores { get; set; }

    public string? IngresaDocumentado { get; set; }

    public string? AcompañadoParejaConyugue { get; set; }

    public string? VinculoEnElPais { get; set; }

    public string? Diligencias { get; set; }

    public string? MedidasDeControl { get; set; }

    public string? ResultadoDeLaInvestigacion { get; set; }

    public string? EnAusencia { get; set; }

    public string? Formulario { get; set; }

    public string? IdPersona { get; set; }
}
