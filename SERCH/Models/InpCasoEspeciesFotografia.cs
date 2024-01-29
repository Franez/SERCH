using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoEspeciesFotografia
{
    public string Inpfolio { get; set; } = null!;

    public decimal Inpespfolio { get; set; }

    public decimal Inpespfotocorr { get; set; }

    public byte[]? Inpespfoto { get; set; }

    public DateTime? Inpespfotofch { get; set; }

    public string? Inpespfotovig { get; set; }
}
