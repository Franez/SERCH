using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Gxa0024
{
    public decimal AudiWsDeCod { get; set; }

    public string AudiWsDeInst { get; set; } = null!;

    public string AudiWsDeRutC { get; set; } = null!;

    public short AudiWsDeService { get; set; }

    public string AudiWsDeRut { get; set; } = null!;

    public DateTime AudiWsDeFecha { get; set; }

    public short AudiWsDeDia { get; set; }

    public short AudiWsDeMes { get; set; }

    public short AudiWsDeAno { get; set; }

    public short AudiWsDeHh { get; set; }

    public short AudiWsDeMm { get; set; }

    public short AudiWsDeSs { get; set; }

    public string? AudiWsDeXml { get; set; }

    public string? AudiWsDeRuc { get; set; }

    public short? AudiWsPais { get; set; }

    public string? AudiWsSexo { get; set; }

    public short? AudiWsCodFault { get; set; }

    public string? AudiWsDesFault { get; set; }
}
