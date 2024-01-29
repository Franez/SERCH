using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class VistaPersona
{
    public string UperId { get; set; } = null!;

    public string? UperNbrCom { get; set; }

    public string? UperApePat { get; set; }

    public string? UperApeMat { get; set; }

    public string? UperNomBus { get; set; }

    public string? UperPatBus { get; set; }

    public string? UperMatBus { get; set; }

    public string? UperInvConPatMat { get; set; }

    public string? UperConPatMat { get; set; }

    public string? UperNacCiuDes { get; set; }

    public short? UperNacPaiCod { get; set; }

    public DateTime? UperFchNac { get; set; }

    public string? UperSexo { get; set; }

    public string? EscoCod { get; set; }
}
