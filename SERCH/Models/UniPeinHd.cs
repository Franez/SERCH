using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniPeinHd
{
    public string Peinhdid { get; set; } = null!;

    public int Peinhdcde { get; set; }

    public decimal Peinhdfol { get; set; }

    public string? Peinhddde { get; set; }

    public int? PeintotalDenun { get; set; }

    public int? PeintotalDenunYVict { get; set; }

    public int? PeintotalDete { get; set; }

    public int? PeintotalEmpa { get; set; }

    public int? PeintotalFalle { get; set; }

    public int? PeintotalImpu { get; set; }

    public int? PeintotalMenor { get; set; }

    public int? PeintotalTesti { get; set; }

    public int? PeintotalVict { get; set; }

    public short? Peinpercond { get; set; }
}
