using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniAudiWsDen
{
    public decimal UniAudiWsDenFolio { get; set; }

    public decimal? UniAudiWsDenRa { get; set; }

    public decimal? UniAudiWsDenRo { get; set; }

    public short UniAudiWsDenEst { get; set; }

    public short UniAudiWsDenDd { get; set; }

    public short UniAudiWsDenMm { get; set; }

    public short UniAudiWsDenAa { get; set; }

    public short UniAudiWsDenHh { get; set; }

    public short UniAudiWsDenMin { get; set; }

    public short UniAudiWsDenSs { get; set; }

    public DateTime UniAudiWsDenDate { get; set; }

    public string? UniAudiWsDenXml { get; set; }
}
