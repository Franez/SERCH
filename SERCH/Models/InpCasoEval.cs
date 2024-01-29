using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCasoEval
{
    public int InpCodigo { get; set; }

    public string InpFolio { get; set; } = null!;

    public short? InpEval { get; set; }

    public string? InpComentario { get; set; }

    public int? InpRutEvaluador { get; set; }

    public int? InpRutFuncionario { get; set; }

    public DateTime? InpFechaEval { get; set; }

    public string? InpUniIngCodEval { get; set; }

    public DateTime? InpFechaDenuncia { get; set; }

    public short? InpTipoDenuncia { get; set; }

    public short? InpEvaResDes { get; set; }

    public string? InpTipoResOrDa { get; set; }

    public string? InpEnvioBud { get; set; }

    public string? InpEvalResul { get; set; }

    public DateTime? InpFecReaEval { get; set; }
}
