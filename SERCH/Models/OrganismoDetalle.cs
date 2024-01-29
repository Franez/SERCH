using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class OrganismoDetalle
{
    public short OrgCod { get; set; }

    public int OrgDetNro { get; set; }

    public string? OrgDetDes { get; set; }

    public string? OrgDetComCod { get; set; }

    public string? Regcod { get; set; }

    public string? OrgDetCodArea { get; set; }

    public string? OrgDetDirCalle { get; set; }

    public string? OrgDetDirNro { get; set; }

    public string? OrgDetEmail { get; set; }

    public int? OrgDetDestad { get; set; }

    public short? OrgDetCodRegFis { get; set; }

    public string? OrgDetNumOrg { get; set; }

    public string? OrgDetVig { get; set; }

    public string OrgDetDesNum { get; set; } = null!;
}
