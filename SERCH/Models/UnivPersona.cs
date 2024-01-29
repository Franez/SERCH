using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class UnivPersona
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

    public string? EstCivCod { get; set; }

    public DateTime? UperFunUpdFch { get; set; }

    public int? UperFunUpd { get; set; }

    public DateTime? UperFunInsFch { get; set; }

    public int? UperFunIns { get; set; }

    public short? UperFlgIng { get; set; }

    public short? UperPaiCodPar { get; set; }

    public short? UperFlgEnc { get; set; }

    public string? UperNomIngreso { get; set; }

    public DateTime? UperFecDef { get; set; }

    public string? UperReinci { get; set; }

    public short? UperVigencia { get; set; }

    public short UperEdad { get; set; }

    public short? UperFlgFil { get; set; }

    public string? UperFonoUno { get; set; }

    public string? UperFonoDos { get; set; }

    public short? UperFlgFis { get; set; }

    public short UperClaTipDel { get; set; }

    public string UperLugNac { get; set; } = null!;

    public short TenSexCod { get; set; }

    public byte[] UperFot01 { get; set; } = null!;

    public decimal UperHisUltLinDpe { get; set; }

    public decimal UperHisUltLinDir { get; set; }

    public decimal UperHisUltLinMor { get; set; }

    public short UperFlgUpd { get; set; }

    public string UperDepFolio { get; set; } = null!;

    public short UperFlgFun { get; set; }

    public short UperFlgRes { get; set; }

    public short UperFlgDep { get; set; }

    public short UperFlgInf { get; set; }

    public short UperFlgTad { get; set; }

    public short UperFlgVia { get; set; }

    public short UperFlgHom { get; set; }

    public short UperFlgNar { get; set; }

    public short UperFlgSin { get; set; }

    public short UperFlgEva { get; set; }

    public short UperFlgDen { get; set; }

    public short UperFlgRecFoto { get; set; }

    public short UperFlgInt { get; set; }

    public short UperAntPol { get; set; }

    public short UperTarCtrl { get; set; }

    public string UperEstFlg { get; set; } = null!;

    public short? UperRegActua { get; set; }

    public string? UperEstCom { get; set; }

    public string? UperCargGub { get; set; }

    public string? UperNomPatSup { get; set; }

    public string? UperNomMatSup { get; set; }

    public string? UperPrefPer { get; set; }

    public string? UperEtniaPer { get; set; }

    public string? UperGenPer { get; set; }
}
