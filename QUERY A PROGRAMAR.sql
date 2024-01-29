
SELECT TOP(10) InpFolio AS "FOLIO INTERNO", 
Case 
  when CASO.TipoOrdenCod <> 5 then InpRelatoHecho 
  when CASO.TipoOrdenCod =  5 then InpObs
End as RELATO, TIPO.TipoOrdenDes AS "DECRETO", caso.InpFchInforme AS "FECHA INFORME", 
caso.InpFecReaIng AS "FECHA INGRESO SISTEMA", UNI.GesGenUniDes AS "UNIDAD", REG.RegNom AS "REGION UNIDAD",
CASE
  WHEN caso.InpTipoOri = 1 THEN caso.InpOrgCausa
  ELSE caso.InpOrgCausaVer
END AS "RUC"
FROM inp_caso caso
JOIN Tipo_Orden TIPO ON caso.TipoOrdenCod = TIPO.TipoOrdenCod 
JOIN Ges_Unidad_Generica UNI ON caso.InpUniIngCod = UNI.GesGenUniCod 
JOIN Regiones REG ON REG.Regcod = UNI.GesGenRegCod 
WHERE (CONTAINS( caso.InpRelatoHecho , 'Calle Ogana' )  and caso.TipoOrdenCod <> 5) or
      (CONTAINS( caso.InpObs, 'Coyhaique')  and caso.TipoOrdenCod = 5) 


-- REGIONES 
SELECT Regcod, RegNom FROM Regiones

-- UNIDADES
SELECT GesGenUniCod, GesGenUniDes FROM Ges_Unidad_Generica WHERE GesGenActivo = 1

-- DECRETOS
SELECT TipoOrdenCod, TipoOrdenDes FROM Tipo_Orden 