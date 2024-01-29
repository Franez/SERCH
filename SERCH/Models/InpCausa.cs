using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCausa
{
    public string? Identificador { get; set; }

    public DateTime Fecha { get; set; }

    public string Vigente { get; set; } = null!;

    public short? OrganismoId { get; set; }

    public int? OrganismoDetalleId { get; set; }
}
