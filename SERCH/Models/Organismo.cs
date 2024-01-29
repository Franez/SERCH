using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class Organismo
{
    public short OrgCod { get; set; }

    public string OrgDes { get; set; } = null!;

    public short? OrgDesFlgCar { get; set; }
}
