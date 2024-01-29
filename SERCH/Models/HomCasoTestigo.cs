using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class HomCasoTestigo
{
    public short HomAno { get; set; }

    public int HomFolio { get; set; }

    public short HomTesNro { get; set; }

    public short? HomTesRec { get; set; }

    public string? HomTesId { get; set; }

    public int? HomTesFunRut { get; set; }

    public DateTime? HomTesFecEmp { get; set; }

    public DateTime? HomTesHrsIni { get; set; }

    public DateTime? HomTesHrsFin { get; set; }

    public string? HomTesDec { get; set; }
}
