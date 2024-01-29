using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAtnMigPaiAnte
{
    public string UperId { get; set; } = null!;

    public short UperCorrAntM { get; set; }

    public short UperAnMgCrPai { get; set; }

    public short? UperAntMigCodPai { get; set; }

    public DateTime? UperAntMigFecIni { get; set; }

    public DateTime? UperAntMigFecFin { get; set; }

    public string? UperAntMigForma { get; set; }
}
