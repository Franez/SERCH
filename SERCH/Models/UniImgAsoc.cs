using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UniImgAsoc
{
    public string InpFolio { get; set; } = null!;

    public short UniImgFol { get; set; }

    public string? UniImgDsc { get; set; }

    public byte[]? UniImgImg { get; set; }

    public string? UniImgEti { get; set; }

    public string? UniImgOri { get; set; }

    public short? UniImgAlt { get; set; }

    public short? UniImgAnc { get; set; }
}
