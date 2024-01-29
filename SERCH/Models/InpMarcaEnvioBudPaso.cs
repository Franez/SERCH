using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpMarcaEnvioBudPaso
{
    public string InpFolio { get; set; } = null!;

    public short InpEnvioTry { get; set; }

    public DateTime? InpMarcaFecha { get; set; }

    public string? InpEnvioError { get; set; }

    public string? InpEnvioXml { get; set; }

    public string? InpEnvioMsg { get; set; }

    public string? InpEnvioBud { get; set; }

    public string? InpEnvioResp { get; set; }
}
