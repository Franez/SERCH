using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniRegPerNinv
{
    public decimal UperCorrNind { get; set; }

    public DateTime? UperFchReg { get; set; }

    public byte[]? UperFotoPnind { get; set; }

    public string? UperFotoPnindGxi { get; set; }

    public string? UperNomSupPnind { get; set; }

    public string? UperPatSupPnind { get; set; }

    public string? UperMatupPnind { get; set; }

    public short? UperNacSupPnind { get; set; }

    public short? UperRedadSupPnind { get; set; }

    public short? UperTpeloSupPnind { get; set; }

    public short? UpeContexSupPnind { get; set; }

    public string? UperLatSupPnind { get; set; }

    public string? UperLongitudSupPnind { get; set; }

    public string UpeContexDesSupPnind { get; set; } = null!;

    public string? UperSexoSupPnind { get; set; }

    public decimal? UperAlturaSupPnind { get; set; }

    public int? UperFunIngpPnind { get; set; }
}
