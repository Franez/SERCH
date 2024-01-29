using System;
using System.Collections.Generic;

namespace SERCH.Models;

public partial class InpCaso
{
    public string InpFolio { get; set; } = null!;

    public DateTime? InpFecha { get; set; }

    public short? InpAnio { get; set; }

    public short? InpMes { get; set; }

    public short? InpStatus { get; set; }

    public short? InpTipoOri { get; set; }

    public string? InpSafito { get; set; }

    public DateTime? InpFecCita { get; set; }

    public short? InpDenunTipo { get; set; }

    public string? InpDenunAsoc { get; set; }

    public short? TipoOrdenCod { get; set; }

    public DateTime? InpFecRecep { get; set; }

    public DateTime? InpHoraRecep { get; set; }

    public string? InpUniIngCod { get; set; }

    public string? InpTipDocIng { get; set; }

    public string? InpNroDoc { get; set; }

    public short? InpOrgCod { get; set; }

    public int? InpOrgDetCod { get; set; }

    public short? InpExhOrgCod { get; set; }

    public int? InpExhOrgDetCod { get; set; }

    public string? InpDenId { get; set; }

    public string? InpOrgCausa { get; set; }

    public string? InpOrgRit { get; set; }

    public short? TipDelCod { get; set; }

    public int? DelCod { get; set; }

    public short? InpParteFlag { get; set; }

    public string? InpObs { get; set; }

    public string? InpDetalle { get; set; }

    public short? InpCitAsiste { get; set; }

    public short? InpCitJuiSenCond { get; set; }

    public int? InpFunIngDocBus { get; set; }

    public string? InpFunIng { get; set; }

    public string? InpFunUpd { get; set; }

    public DateTime? InpFecReaIng { get; set; }

    public DateTime? InpFecReaUpd { get; set; }

    public decimal? InpInvFolio { get; set; }

    public string? InpWrkIng { get; set; }

    public string? InpWrkUpd { get; set; }

    public decimal? InpEspTotAva { get; set; }

    public short? InpFlagEspecies { get; set; }

    public short? InpPideCtaPlaDia { get; set; }

    public DateTime? InpPideCtaFecFin { get; set; }

    public short? InpResEndoso { get; set; }

    public DateTime? InpResFecVen { get; set; }

    public string? InpResAmpliacion { get; set; }

    public string? InpResExhorto { get; set; }

    public string? InpResPideCta { get; set; }

    public DateTime? InpResFecCancel { get; set; }

    public string? InpResDecAsoc { get; set; }

    public int? InpResPlasasoc { get; set; }

    public decimal? InpResParteNro { get; set; }

    public string? InpResParteLet { get; set; }

    public int? InpResFunParte { get; set; }

    public DateTime? InpFecRecepVer { get; set; }

    public DateTime? InpHoraRecepVer { get; set; }

    public string? InpTipDocIngVer { get; set; }

    public short? TipDelCodVer { get; set; }

    public int? DelCodVer { get; set; }

    public short? InpOrgCodVer { get; set; }

    public int? InpOrgDetCodVer { get; set; }

    public string? InpOrgCausaVer { get; set; }

    public string? InpOrgRitVer { get; set; }

    public string? InpDenIdver { get; set; }

    public string? InpDetalleVer { get; set; }

    public string? InpObsVer { get; set; }

    public string? InpRelatoHecho { get; set; }


    public DateTime? InpEndFecDoc { get; set; }

    public string? InpTieneFacul { get; set; }

    public string? InpModOpeGen { get; set; }

    public string? InpDenunTipoOtr { get; set; }

    public short? UniInsParcod { get; set; }

    public int? InpFunEndAct { get; set; }

    public DateTime? InpFchUltEndo { get; set; }

    public string? InpRepreDenPdi { get; set; }

    public int? InpRepreRutDen { get; set; }

    public string? InpRepreCorreo { get; set; }

    public string? InpRepreDomi { get; set; }

    public string? InpRepreTelf { get; set; }

    public string? InpRepreNomPdi { get; set; }

    public int? InpRepreRutPdi { get; set; }

    public string? InpRepreDomUn { get; set; }

    public short? InpPerGuber { get; set; }

    public short? OrgCodGubCaso { get; set; }

    public int? OrgDetNroGubCaso { get; set; }

    public string? CargoGub { get; set; }

    public DateTime? FchIngInstGub { get; set; }

    public short? ApoyoEstatal { get; set; }

    public string? InpNomDenun { get; set; }

    public string? InpAppDenun { get; set; }

    public string? InpApmDenun { get; set; }

    public string? InpRutDenun { get; set; }

    public string? InpDivDenun { get; set; }

    public string? InpTipDocDenun { get; set; }

    public short? InpPaisDenun { get; set; }

    public string? InpDebHacDil { get; set; }

    public string? InpProAdoUni { get; set; }

    public string? InpObsPerPro { get; set; }

    public DateTime? InpFecHecho1 { get; set; }

    public DateTime? InpFecHecho2 { get; set; }

    public DateTime? InpHorHecho1 { get; set; }

    public DateTime? InpHorHecho2 { get; set; }

    public string? InpDenTieAnt { get; set; }

    public decimal? InpDenNroDen { get; set; }

    public string? InpDenLetDen { get; set; }

    public string? InpDenDenAno { get; set; }

    public string? InpDenNroAut { get; set; }

    public string? InpDenDirExa { get; set; }

    public string? InpDenComCod { get; set; }

    public string? InpDenCalleCod { get; set; }

    public string? InpDenDirNro { get; set; }

    public string? InpDenDirNpd { get; set; }

    public string? InpDenLugDel { get; set; }

    public short? UniLugCod { get; set; }

    public short? UniLdeCod { get; set; }

    public string? UniIdtem { get; set; }

    public decimal? InpDenNro { get; set; }

    public string? InpDenSw { get; set; }

    public DateTime? InpFecCom { get; set; }

    public DateTime? InpHoraCom { get; set; }

    public string? InpComFis { get; set; }

    public string? InpNoComObs { get; set; }

    public int? InpFolioAso { get; set; }

    public string? InpTipoAso { get; set; }

    public string? InpDenUniPri { get; set; }

    public short? InpConPer { get; set; }

    public string? InpDenDirLong { get; set; }

    public string? InpDenDirLat { get; set; }

    public string? Inpdenlugar { get; set; }

    public string? InpIncDatGubInf { get; set; }

    public string? InpDenCalleDesAux { get; set; }

    public string? InpCodInstrucVer { get; set; }

    public byte[]? InpDocDecreto { get; set; }

    public string? InpOrdInvCierreDef { get; set; }

    public short InpTipoInsPar { get; set; }

    public string? InpUniAlmaIngCod { get; set; }

    public short? InpDenEnvMin { get; set; }

    public string? InpDocDecretoNom { get; set; }

    public string? InpDocDecretoExt { get; set; }

    public string? InpDenVillaPob { get; set; }

    public string? InpTipDelFlag { get; set; }

    public string? InpResulVif { get; set; }

    public string? InpSugVif { get; set; }

    public short? InpResulSecu { get; set; }

    public string? InpOtrLugCon { get; set; }

    public string? InpDepCondIlu { get; set; }

    public string? InpDenPerSeg { get; set; }

    public string? InpDenCamSeg { get; set; }

    public string? InpDenAlaSeg { get; set; }

    public string? InpDenCerPer { get; set; }

    public string? InpDenOtrMedSeg { get; set; }

    public string? InpDenConFlujPea { get; set; }

    public string? InpDenConTranVeh { get; set; }

    public string? InpDenExtCseg { get; set; }

    public string? InpMotSinEndo { get; set; }

    public string? InpOrgRol { get; set; }

    public string? InpFacExt { get; set; }

    public short? InpInfExtCod { get; set; }

    public string? InpUniCreaDoc { get; set; }

    public string? InpDenunVif { get; set; }

    public string? InpEvalResulcaso { get; set; }

    public string? InpTipOrdExtena { get; set; }

    public string? InpTipReso { get; set; }

    public string? InpFolUniNac { get; set; }

    public string? InpConFecHraDel { get; set; }

    public DateTime? InpFchInforme { get; set; }

    public string? InpFolSisPjud { get; set; }

    public decimal? InpMonAdeu { get; set; }

    public decimal? InpFoco { get; set; }

    public decimal? InpMonCan { get; set; }

    public string? InpDenRegCod { get; set; }

    public short? InpInterO { get; set; }

    public string? InpInfoF4nna { get; set; }

    public string? InpInfoF3nna { get; set; }

    public string? InpFolMinPub { get; set; }

    public string? NomProtecNna { get; set; }

    public string? NomAcomNna { get; set; }

    public short? InpDecOfan { get; set; }

    public string? InpEsEiv { get; set; }

    public short? InpAnnoFoco { get; set; }

    public string? InpDecRelDdhh { get; set; }

    public string? InpDenTuri { get; set; }

    public decimal? InpDenPaiRecTuri { get; set; }

    public DateTime? InpFecFirEle { get; set; }

    public string? InpHashDoc { get; set; }

    public string? InpModInfra { get; set; }

    public short? InpDeriva { get; set; }

    public string? InpTpDenunExt { get; set; }

    public string? InpMedDenunExt { get; set; }

    public string? InpAutOtDenunExt { get; set; }

    public string? InpInfIntercep { get; set; }

    public string? InpDenunAusencia { get; set; }

    public string? InpFormDecExtInf { get; set; }

    public string? InpDenun21057 { get; set; }

    public string? InpPrcSanExp { get; set; }

    public short? InpNumNotPrcSanExt { get; set; }

    public string? InpIdFolMp { get; set; }
}
