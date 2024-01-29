using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UperSolicitude
{
    public decimal NroSolicitud { get; set; }

    public int? UperFpregunta { get; set; }

    public string? UperFuncionS { get; set; }

    public string? UperfuncionR { get; set; }

    public int? UperFrespuesta { get; set; }

    public short? UperEstSoli { get; set; }

    public DateTime? UperFePregunta { get; set; }

    public DateTime? UperFeRespuesta { get; set; }
}
