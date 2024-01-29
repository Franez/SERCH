using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SERCH.Models;

public partial class BrainContext : DbContext
{
    public BrainContext()
    {
    }

    public BrainContext(DbContextOptions<BrainContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccesoUnidadesInteligencium> AccesoUnidadesInteligencia { get; set; }

    public virtual DbSet<AccionEncargo> AccionEncargos { get; set; }

    public virtual DbSet<Antiguedade> Antiguedades { get; set; }

    public virtual DbSet<ApliPerfil> ApliPerfils { get; set; }

    public virtual DbSet<Aplicacione> Aplicaciones { get; set; }

    public virtual DbSet<Apodo> Apodos { get; set; }

    public virtual DbSet<ApodosDestapol> ApodosDestapols { get; set; }

    public virtual DbSet<Arma> Armas { get; set; }

    public virtual DbSet<ArmasAltomando> ArmasAltomandos { get; set; }

    public virtual DbSet<ArmasDestapol> ArmasDestapols { get; set; }

    public virtual DbSet<ArmasJenanco> ArmasJenancos { get; set; }

    public virtual DbSet<ArmasPmJenage> ArmasPmJenages { get; set; }

    public virtual DbSet<AsoPeroPbi> AsoPeroPbis { get; set; }

    public virtual DbSet<AsoPrinDh> AsoPrinDhs { get; set; }

    public virtual DbSet<Asociacione> Asociaciones { get; set; }

    public virtual DbSet<AsociacionesDoc> AsociacionesDocs { get; set; }

    public virtual DbSet<AsociacionesPersona> AsociacionesPersonas { get; set; }

    public virtual DbSet<AudiWsDePdi> AudiWsDePdis { get; set; }

    public virtual DbSet<AuditoriaGepolBrain> AuditoriaGepolBrains { get; set; }

    public virtual DbSet<AuxPjud> AuxPjuds { get; set; }

    public virtual DbSet<Avanzadum> Avanzada { get; set; }

    public virtual DbSet<BandasDestapol> BandasDestapols { get; set; }

    public virtual DbSet<BandasDestapolIntervenida> BandasDestapolIntervenidas { get; set; }

    public virtual DbSet<BasePersona> BasePersonas { get; set; }

    public virtual DbSet<Calle> Calles { get; set; }

    public virtual DbSet<CalleComNiv> CalleComNivs { get; set; }

    public virtual DbSet<CalleComuna> CalleComunas { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CargoGrado> CargoGrados { get; set; }

    public virtual DbSet<CarrosPoliciale> CarrosPoliciales { get; set; }

    public virtual DbSet<Ciudadcomun> Ciudadcomuns { get; set; }

    public virtual DbSet<Ciudade> Ciudades { get; set; }

    public virtual DbSet<ColorCabello> ColorCabellos { get; set; }

    public virtual DbSet<ColorOjo> ColorOjos { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Comuna> Comunas { get; set; }

    public virtual DbSet<ConclusionesCaso> ConclusionesCasos { get; set; }

    public virtual DbSet<CondicionIngreso> CondicionIngresos { get; set; }

    public virtual DbSet<ContextoPai> ContextoPais { get; set; }

    public virtual DbSet<Contextura> Contexturas { get; set; }

    public virtual DbSet<DecSsMod> DecSsMods { get; set; }

    public virtual DbSet<DecretosAltomando> DecretosAltomandos { get; set; }

    public virtual DbSet<DecretosCodDestapol> DecretosCodDestapols { get; set; }

    public virtual DbSet<DecretosDemtel> DecretosDemtels { get; set; }

    public virtual DbSet<DecretosDestapol> DecretosDestapols { get; set; }

    public virtual DbSet<DecretosDetalle11> DecretosDetalle11s { get; set; }

    public virtual DbSet<DecretosDetapolGeo> DecretosDetapolGeos { get; set; }

    public virtual DbSet<DecretosEliminado> DecretosEliminados { get; set; }

    public virtual DbSet<DecretosMe> DecretosMes { get; set; }

    public virtual DbSet<DecretosOfan> DecretosOfans { get; set; }

    public virtual DbSet<DecretosPersonaBasico> DecretosPersonaBasicos { get; set; }

    public virtual DbSet<DecretosPmJenage> DecretosPmJenages { get; set; }

    public virtual DbSet<DecretosRelato> DecretosRelatos { get; set; }

    public virtual DbSet<DecretosTodosDestapol> DecretosTodosDestapols { get; set; }

    public virtual DbSet<DelPd> DelPds { get; set; }

    public virtual DbSet<Delito> Delitos { get; set; }

    public virtual DbSet<DelitoAsociacion> DelitoAsociacions { get; set; }

    public virtual DbSet<DelitoInternacional> DelitoInternacionals { get; set; }

    public virtual DbSet<DelitosHistorico> DelitosHistoricos { get; set; }

    public virtual DbSet<DelitosHistoricosPmjenage> DelitosHistoricosPmjenages { get; set; }

    public virtual DbSet<DenunciasDestapol> DenunciasDestapols { get; set; }

    public virtual DbSet<DestapolUnidadesBrain> DestapolUnidadesBrains { get; set; }

    public virtual DbSet<DetaleDrogas11> DetaleDrogas11s { get; set; }

    public virtual DbSet<DetalleArmas11> DetalleArmas11s { get; set; }

    public virtual DbSet<DetalleArmasMe> DetalleArmasMes { get; set; }

    public virtual DbSet<DetalleEspecies11> DetalleEspecies11s { get; set; }

    public virtual DbSet<DetalleEspeciesMe> DetalleEspeciesMes { get; set; }

    public virtual DbSet<DetenidosAltomando> DetenidosAltomandos { get; set; }

    public virtual DbSet<DetenidosReportserver> DetenidosReportservers { get; set; }

    public virtual DbSet<DetenidosReportserverIngresado> DetenidosReportserverIngresados { get; set; }

    public virtual DbSet<DetenidosTodo> DetenidosTodos { get; set; }

    public virtual DbSet<DineroAltomando> DineroAltomandos { get; set; }

    public virtual DbSet<DocFea> DocFeas { get; set; }

    public virtual DbSet<DrogasAltomando> DrogasAltomandos { get; set; }

    public virtual DbSet<DrogasPmJenage> DrogasPmJenages { get; set; }

    public virtual DbSet<DrogasplantaAltomando> DrogasplantaAltomandos { get; set; }

    public virtual DbSet<DuraccionEncargo> DuraccionEncargos { get; set; }

    public virtual DbSet<Electrodomestico> Electrodomesticos { get; set; }

    public virtual DbSet<EncAuditoriaIng> EncAuditoriaIngs { get; set; }

    public virtual DbSet<EncEncargo> EncEncargos { get; set; }

    public virtual DbSet<EncPersonaConsultum> EncPersonaConsulta { get; set; }

    public virtual DbSet<EncRelacionDocEnc> EncRelacionDocEncs { get; set; }

    public virtual DbSet<EncTemplateCancelacion> EncTemplateCancelacions { get; set; }

    public virtual DbSet<EncTipoDocumento> EncTipoDocumentos { get; set; }

    public virtual DbSet<EncargosGepolxdr> EncargosGepolxdrs { get; set; }

    public virtual DbSet<EncargosInt> EncargosInts { get; set; }

    public virtual DbSet<EndososBrain> EndososBrains { get; set; }

    public virtual DbSet<EndososBrainOfan> EndososBrainOfans { get; set; }

    public virtual DbSet<Enfermedade> Enfermedades { get; set; }

    public virtual DbSet<Escolaridad> Escolaridads { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<EspecialidadDelito> EspecialidadDelitos { get; set; }

    public virtual DbSet<EspecialidadDirecPersona> EspecialidadDirecPersonas { get; set; }

    public virtual DbSet<EspecialidadPerito> EspecialidadPeritos { get; set; }

    public virtual DbSet<EspeciesDestapol> EspeciesDestapols { get; set; }

    public virtual DbSet<EspeciesJenanco> EspeciesJenancos { get; set; }

    public virtual DbSet<EspeciesPmJenage> EspeciesPmJenages { get; set; }

    public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }

    public virtual DbSet<EstadoDecreto> EstadoDecretos { get; set; }

    public virtual DbSet<ExtInfractor> ExtInfractors { get; set; }

    public virtual DbSet<ExtranjeroInfractorXUnidad> ExtranjeroInfractorXUnidads { get; set; }

    public virtual DbSet<FenomenosDecreto> FenomenosDecretos { get; set; }

    public virtual DbSet<FisUbicacion> FisUbicacions { get; set; }

    public virtual DbSet<FisUbicacionImagencoordenadum> FisUbicacionImagencoordenada { get; set; }

    public virtual DbSet<FoliosUnidad> FoliosUnidads { get; set; }

    public virtual DbSet<FuncionarioAplicacion> FuncionarioAplicacions { get; set; }

    public virtual DbSet<FuncionarioDepuracion> FuncionarioDepuracions { get; set; }

    public virtual DbSet<FuncionarioUnidad> FuncionarioUnidads { get; set; }

    public virtual DbSet<FuncionariosBrain> FuncionariosBrains { get; set; }

    public virtual DbSet<FuncionariosDomicilio> FuncionariosDomicilios { get; set; }

    public virtual DbSet<FuncionariosFoto> FuncionariosFotos { get; set; }

    public virtual DbSet<GesAdministracion> GesAdministracions { get; set; }

    public virtual DbSet<GesAgrupacionDescriptor> GesAgrupacionDescriptors { get; set; }

    public virtual DbSet<GesArea> GesAreas { get; set; }

    public virtual DbSet<GesAreasPonderacion> GesAreasPonderacions { get; set; }

    public virtual DbSet<GesAreasPonderacionMeta> GesAreasPonderacionMetas { get; set; }

    public virtual DbSet<GesAuditoriaConsultum> GesAuditoriaConsulta { get; set; }

    public virtual DbSet<GesAuditoriaUnidade> GesAuditoriaUnidades { get; set; }

    public virtual DbSet<GesCalculoIndicador> GesCalculoIndicadors { get; set; }

    public virtual DbSet<GesCategoria> GesCategorias { get; set; }

    public virtual DbSet<GesCategoriasInforme> GesCategoriasInformes { get; set; }

    public virtual DbSet<GesDescriptorAgrupado> GesDescriptorAgrupados { get; set; }

    public virtual DbSet<GesDescriptorGrupo> GesDescriptorGrupos { get; set; }

    public virtual DbSet<GesDireccion> GesDireccions { get; set; }

    public virtual DbSet<GesGrupoDescriptor> GesGrupoDescriptors { get; set; }

    public virtual DbSet<GesIndicadorAuxiliar> GesIndicadorAuxiliars { get; set; }

    public virtual DbSet<GesIndicadorAuxiliar1> GesIndicadorAuxiliar1s { get; set; }

    public virtual DbSet<GesIndicadorCategorium> GesIndicadorCategoria { get; set; }

    public virtual DbSet<GesIndicadorStandarPromedi1> GesIndicadorStandarPromedi1s { get; set; }

    public virtual DbSet<GesIndicadorStandarPromedi2> GesIndicadorStandarPromedi2s { get; set; }

    public virtual DbSet<GesIndicadorTemplate> GesIndicadorTemplates { get; set; }

    public virtual DbSet<GesIndicadore> GesIndicadores { get; set; }

    public virtual DbSet<GesIndicadoresArea> GesIndicadoresAreas { get; set; }

    public virtual DbSet<GesIndicadoresClasificacion> GesIndicadoresClasificacions { get; set; }

    public virtual DbSet<GesIndicadoresEspecialidad> GesIndicadoresEspecialidads { get; set; }

    public virtual DbSet<GesIndicadoresExcepcion> GesIndicadoresExcepcions { get; set; }

    public virtual DbSet<GesJefaturaDireccion> GesJefaturaDireccions { get; set; }

    public virtual DbSet<GesJefaturaPolicial> GesJefaturaPolicials { get; set; }

    public virtual DbSet<GesJefaturaUnidad> GesJefaturaUnidads { get; set; }

    public virtual DbSet<GesMedida> GesMedidas { get; set; }

    public virtual DbSet<GesMetasArea> GesMetasAreas { get; set; }

    public virtual DbSet<GesMetasDetalle> GesMetasDetalles { get; set; }

    public virtual DbSet<GesMetasMaestro> GesMetasMaestros { get; set; }

    public virtual DbSet<GesMetasPonderacione> GesMetasPonderaciones { get; set; }

    public virtual DbSet<GesMetasPonderacionesInd> GesMetasPonderacionesInds { get; set; }

    public virtual DbSet<GesPeriodo> GesPeriodos { get; set; }

    public virtual DbSet<GesPeriodoUnidad> GesPeriodoUnidads { get; set; }

    public virtual DbSet<GesPrefecturaPolicial> GesPrefecturaPolicials { get; set; }

    public virtual DbSet<GesPrefecturaRegion> GesPrefecturaRegions { get; set; }

    public virtual DbSet<GesPrefecturaUnidad> GesPrefecturaUnidads { get; set; }

    public virtual DbSet<GesRegionDireccion> GesRegionDireccions { get; set; }

    public virtual DbSet<GesRegionPolicial> GesRegionPolicials { get; set; }

    public virtual DbSet<GesSeccionPolicial> GesSeccionPolicials { get; set; }

    public virtual DbSet<GesTipoIndicador> GesTipoIndicadors { get; set; }

    public virtual DbSet<GesUniAuditorium> GesUniAuditoria { get; set; }

    public virtual DbSet<GesUniCalculoIndicadoresDe> GesUniCalculoIndicadoresDes { get; set; }

    public virtual DbSet<GesUniDescriptore> GesUniDescriptores { get; set; }

    public virtual DbSet<GesUniDescriptoresAuditorium> GesUniDescriptoresAuditoria { get; set; }

    public virtual DbSet<GesUniDescriptoresDiario> GesUniDescriptoresDiarios { get; set; }

    public virtual DbSet<GesUniGenericaMeta> GesUniGenericaMetas { get; set; }

    public virtual DbSet<GesUniIndCalculoDe> GesUniIndCalculoDes { get; set; }

    public virtual DbSet<GesUniIndicadore> GesUniIndicadores { get; set; }

    public virtual DbSet<GesUniMetasIndicadore> GesUniMetasIndicadores { get; set; }

    public virtual DbSet<GesUnidadDepartamento> GesUnidadDepartamentos { get; set; }

    public virtual DbSet<GesUnidadDescripcion> GesUnidadDescripcions { get; set; }

    public virtual DbSet<GesUnidadFusionadum> GesUnidadFusionada { get; set; }

    public virtual DbSet<GesUnidadGenerica> GesUnidadGenericas { get; set; }

    public virtual DbSet<GesUnidadGenerica1> GesUnidadGenericas1 { get; set; }

    public virtual DbSet<GrupoCriminalMaestro> GrupoCriminalMaestros { get; set; }

    public virtual DbSet<Gxa0024> Gxa0024s { get; set; }

    public virtual DbSet<HechosGeo> HechosGeos { get; set; }

    public virtual DbSet<Herramienta> Herramientas { get; set; }

    public virtual DbSet<HisEnvioDec> HisEnvioDecs { get; set; }

    public virtual DbSet<Hoja1> Hoja1s { get; set; }

    public virtual DbSet<HomCaso> HomCasos { get; set; }

    public virtual DbSet<HomCasoEvidencia> HomCasoEvidencias { get; set; }

    public virtual DbSet<HomCasoFiscale> HomCasoFiscales { get; set; }

    public virtual DbSet<HomCasoFoto> HomCasoFotos { get; set; }

    public virtual DbSet<HomCasoFuncionario> HomCasoFuncionarios { get; set; }

    public virtual DbSet<HomCasoImputado> HomCasoImputados { get; set; }

    public virtual DbSet<HomCasoMemo> HomCasoMemos { get; set; }

    public virtual DbSet<HomCasoMemoDist> HomCasoMemoDists { get; set; }

    public virtual DbSet<HomCasoTestigo> HomCasoTestigos { get; set; }

    public virtual DbSet<HomCasoVictima> HomCasoVictimas { get; set; }

    public virtual DbSet<HomFiscale> HomFiscales { get; set; }

    public virtual DbSet<HomGrupoFuncionario> HomGrupoFuncionarios { get; set; }

    public virtual DbSet<HomGrupoTrabajo> HomGrupoTrabajos { get; set; }

    public virtual DbSet<HomModalidadHomicidio> HomModalidadHomicidios { get; set; }

    public virtual DbSet<HomMovilHomicidio> HomMovilHomicidios { get; set; }

    public virtual DbSet<HomTipoHomicidio> HomTipoHomicidios { get; set; }

    public virtual DbSet<HomUnidade> HomUnidades { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<Infraccione> Infracciones { get; set; }

    public virtual DbSet<InfractoresBrain> InfractoresBrains { get; set; }

    public virtual DbSet<InpAmpliacionPlazo> InpAmpliacionPlazos { get; set; }

    public virtual DbSet<InpAnalisisFoco> InpAnalisisFocos { get; set; }

    public virtual DbSet<InpCarpetaDetalle> InpCarpetaDetalles { get; set; }

    public virtual DbSet<InpCarpetaInvestigacion> InpCarpetaInvestigacions { get; set; }

    public virtual DbSet<InpCaso> InpCasos { get; set; }

    public virtual DbSet<InpCasoAbandono> InpCasoAbandonos { get; set; }

    public virtual DbSet<InpCasoArma> InpCasoArmas { get; set; }

    public virtual DbSet<InpCasoConclusione> InpCasoConclusiones { get; set; }

    public virtual DbSet<InpCasoDelitosAsociado> InpCasoDelitosAsociados { get; set; }

    public virtual DbSet<InpCasoDiligencia> InpCasoDiligencias { get; set; }

    public virtual DbSet<InpCasoDroga> InpCasoDrogas { get; set; }

    public virtual DbSet<InpCasoDrogasDelAso> InpCasoDrogasDelAsos { get; set; }

    public virtual DbSet<InpCasoEndoso> InpCasoEndosos { get; set; }

    public virtual DbSet<InpCasoEspeciesDelAso> InpCasoEspeciesDelAsos { get; set; }

    public virtual DbSet<InpCasoEspeciesFotografia> InpCasoEspeciesFotografias { get; set; }

    public virtual DbSet<InpCasoEspecy> InpCasoEspecies { get; set; }

    public virtual DbSet<InpCasoEval> InpCasoEvals { get; set; }

    public virtual DbSet<InpCasoFuncionario> InpCasoFuncionarios { get; set; }

    public virtual DbSet<InpCasoOrdRelacion> InpCasoOrdRelacions { get; set; }

    public virtual DbSet<InpCasoSecuestro> InpCasoSecuestros { get; set; }

    public virtual DbSet<InpCasoSecuestroExigencium> InpCasoSecuestroExigencia { get; set; }

    public virtual DbSet<InpCasoSs> InpCasoSses { get; set; }

    public virtual DbSet<InpCasoSsDetalle> InpCasoSsDetalles { get; set; }

    public virtual DbSet<InpCasoVehiculo> InpCasoVehiculos { get; set; }

    public virtual DbSet<InpCausa> InpCausas { get; set; }

    public virtual DbSet<InpCharla> InpCharlas { get; set; }

    public virtual DbSet<InpCondicionPersona> InpCondicionPersonas { get; set; }

    public virtual DbSet<InpControlIdentidad> InpControlIdentidads { get; set; }

    public virtual DbSet<InpGrupoDelito> InpGrupoDelitos { get; set; }

    public virtual DbSet<InpMarcaEnvioBud> InpMarcaEnvioBuds { get; set; }

    public virtual DbSet<InpMarcaEnvioBudPaso> InpMarcaEnvioBudPasos { get; set; }

    public virtual DbSet<InpModusOperandi> InpModusOperandis { get; set; }

    public virtual DbSet<InpNumeradorDocumento> InpNumeradorDocumentos { get; set; }

    public virtual DbSet<InpOcularSitioSuceso> InpOcularSitioSucesos { get; set; }

    public virtual DbSet<InpOficialesDetencion> InpOficialesDetencions { get; set; }

    public virtual DbSet<InpPeritajeProTecDelAso> InpPeritajeProTecDelAsos { get; set; }

    public virtual DbSet<InpPeritajeProcTec> InpPeritajeProcTecs { get; set; }

    public virtual DbSet<InpPersonasDelito> InpPersonasDelitos { get; set; }

    public virtual DbSet<InpPersonasImplicada> InpPersonasImplicadas { get; set; }

    public virtual DbSet<InpPersonasModu> InpPersonasModus { get; set; }

    public virtual DbSet<InpPersonasVestimenta> InpPersonasVestimentas { get; set; }

    public virtual DbSet<InpPideCuentum> InpPideCuenta { get; set; }

    public virtual DbSet<InpPla> InpPlas { get; set; }

    public virtual DbSet<InpPlasCarro> InpPlasCarros { get; set; }

    public virtual DbSet<InpPlasComuna> InpPlasComunas { get; set; }

    public virtual DbSet<InpPlasConsultado> InpPlasConsultados { get; set; }

    public virtual DbSet<InpPlasFuncionario> InpPlasFuncionarios { get; set; }

    public virtual DbSet<InpReconocimientoDetalle> InpReconocimientoDetalles { get; set; }

    public virtual DbSet<InpReconocimientoFotografico> InpReconocimientoFotograficos { get; set; }

    public virtual DbSet<InpReportespbi> InpReportespbis { get; set; }

    public virtual DbSet<InpSs> InpSses { get; set; }

    public virtual DbSet<InpSsFoto> InpSsFotos { get; set; }

    public virtual DbSet<InpSsdelAso> InpSsdelAsos { get; set; }

    public virtual DbSet<InstrumentosMusicale> InstrumentosMusicales { get; set; }

    public virtual DbSet<InsumoComputacionale> InsumoComputacionales { get; set; }

    public virtual DbSet<IpPai> IpPais { get; set; }

    public virtual DbSet<JerarquiaCriminal> JerarquiaCriminals { get; set; }

    public virtual DbSet<JoyPiedra> JoyPiedras { get; set; }

    public virtual DbSet<Joya> Joyas { get; set; }

    public virtual DbSet<LogEnvDatMp> LogEnvDatMps { get; set; }

    public virtual DbSet<LugarSuceso> LugarSucesos { get; set; }

    public virtual DbSet<MarcaArma> MarcaArmas { get; set; }

    public virtual DbSet<MarcaElectronica> MarcaElectronicas { get; set; }

    public virtual DbSet<MarcaHerramientum> MarcaHerramienta { get; set; }

    public virtual DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }

    public virtual DbSet<MarcasVestimenta> MarcasVestimentas { get; set; }

    public virtual DbSet<MarcosAux> MarcosAuxes { get; set; }

    public virtual DbSet<MaterialesConstruccion> MaterialesConstruccions { get; set; }

    public virtual DbSet<Mese> Meses { get; set; }

    public virtual DbSet<Metale> Metales { get; set; }

    public virtual DbSet<ModusDestapol> ModusDestapols { get; set; }

    public virtual DbSet<ModusOperandi> ModusOperandis { get; set; }

    public virtual DbSet<ModusOperandiDetalle> ModusOperandiDetalles { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<MorfologiaDetalle> MorfologiaDetalles { get; set; }

    public virtual DbSet<Morfologium> Morfologia { get; set; }

    public virtual DbSet<MotivoDetencion> MotivoDetencions { get; set; }

    public virtual DbSet<NominaDefinitivaInhabilitadosEnChile> NominaDefinitivaInhabilitadosEnChiles { get; set; }

    public virtual DbSet<NominaDefinitivaInhabilitadosEnElExtranjero> NominaDefinitivaInhabilitadosEnElExtranjeros { get; set; }

    public virtual DbSet<Nue> Nues { get; set; }

    public virtual DbSet<OaVigentesGepol> OaVigentesGepols { get; set; }

    public virtual DbSet<OcultamientoDroga> OcultamientoDrogas { get; set; }

    public virtual DbSet<Odontograma> Odontogramas { get; set; }

    public virtual DbSet<OrdenAlfa> OrdenAlfas { get; set; }

    public virtual DbSet<Organismo> Organismos { get; set; }

    public virtual DbSet<OrganismoDetalle> OrganismoDetalles { get; set; }

    public virtual DbSet<OrganismoGuberDetalle> OrganismoGuberDetalles { get; set; }

    public virtual DbSet<OrganismosGuber> OrganismosGubers { get; set; }

    public virtual DbSet<PadronElectoralDefinitivoEnChile> PadronElectoralDefinitivoEnChiles { get; set; }

    public virtual DbSet<PadronElectoralDefinitivoEnExtranjero> PadronElectoralDefinitivoEnExtranjeros { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<ParSinapro> ParSinapros { get; set; }

    public virtual DbSet<ParticipacionDelito> ParticipacionDelitos { get; set; }

    public virtual DbSet<PasoEvidenciaacopiadum> PasoEvidenciaacopiada { get; set; }

    public virtual DbSet<PerFuncionario> PerFuncionarios { get; set; }

    public virtual DbSet<PerMovSolicitud> PerMovSolicituds { get; set; }

    public virtual DbSet<PersoRelPbi> PersoRelPbis { get; set; }

    public virtual DbSet<PersonaMorfologium> PersonaMorfologia { get; set; }

    public virtual DbSet<PersonasAsoDestapol> PersonasAsoDestapols { get; set; }

    public virtual DbSet<PersonasBrainSimple> PersonasBrainSimples { get; set; }

    public virtual DbSet<PersonasDestapol> PersonasDestapols { get; set; }

    public virtual DbSet<PersonasDetalle11> PersonasDetalle11s { get; set; }

    public virtual DbSet<PersonasDetalleMe> PersonasDetalleMes { get; set; }

    public virtual DbSet<PersonasPmJenage> PersonasPmJenages { get; set; }

    public virtual DbSet<PersonasSimplificadum> PersonasSimplificada { get; set; }

    public virtual DbSet<Pla> Plas { get; set; }

    public virtual DbSet<Plebicito2022Decreto> Plebicito2022Decretos { get; set; }

    public virtual DbSet<Plebicito2022Persona> Plebicito2022Personas { get; set; }

    public virtual DbSet<PresuntaDesgracium> PresuntaDesgracia { get; set; }

    public virtual DbSet<PresuntasDesgracia> PresuntasDesgracias { get; set; }

    public virtual DbSet<Profesione> Profesiones { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<ProvinciaComuna> ProvinciaComunas { get; set; }

    public virtual DbSet<ReconocimientoDetalle> ReconocimientoDetalles { get; set; }

    public virtual DbSet<ReconocimientoFoto> ReconocimientoFotos { get; set; }

    public virtual DbSet<RedesSocialesPersona> RedesSocialesPersonas { get; set; }

    public virtual DbSet<Regione> Regiones { get; set; }

    public virtual DbSet<ResumenEstadistico> ResumenEstadisticos { get; set; }

    public virtual DbSet<ResumenEstadisticoDelito> ResumenEstadisticoDelitos { get; set; }

    public virtual DbSet<ResumenEstadisticoDroga> ResumenEstadisticoDrogas { get; set; }

    public virtual DbSet<ResumenEstadisticoEspecie> ResumenEstadisticoEspecies { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<RucPalasqlo> RucPalasqlos { get; set; }

    public virtual DbSet<RutIndultado> RutIndultados { get; set; }

    public virtual DbSet<SebaAux01> SebaAux01s { get; set; }

    public virtual DbSet<SebaAux05> SebaAux05s { get; set; }

    public virtual DbSet<Siglo> Siglos { get; set; }

    public virtual DbSet<Ss11> Ss11s { get; set; }

    public virtual DbSet<Ss11Me> Ss11Mes { get; set; }

    public virtual DbSet<SsDestapol> SsDestapols { get; set; }

    public virtual DbSet<SsOfan> SsOfans { get; set; }

    public virtual DbSet<StatusVigencium> StatusVigencia { get; set; }

    public virtual DbSet<SujetosDesconocido> SujetosDesconocidos { get; set; }

    public virtual DbSet<TagOfan> TagOfans { get; set; }

    public virtual DbSet<Telefonium> Telefonia { get; set; }

    public virtual DbSet<TempIdFoto> TempIdFotos { get; set; }

    public virtual DbSet<TendenciasSexuale> TendenciasSexuales { get; set; }

    public virtual DbSet<TinpActa> TinpActas { get; set; }

    public virtual DbSet<TipoAlteracionFisica> TipoAlteracionFisicas { get; set; }

    public virtual DbSet<TipoAmputacion> TipoAmputacions { get; set; }

    public virtual DbSet<TipoArma> TipoArmas { get; set; }

    public virtual DbSet<TipoBoca> TipoBocas { get; set; }

    public virtual DbSet<TipoCabello1> TipoCabello1s { get; set; }

    public virtual DbSet<TipoCabeza> TipoCabezas { get; set; }

    public virtual DbSet<TipoCalle> TipoCalles { get; set; }

    public virtual DbSet<TipoCara> TipoCaras { get; set; }

    public virtual DbSet<TipoCicatriz> TipoCicatrizs { get; set; }

    public virtual DbSet<TipoCliente> TipoClientes { get; set; }

    public virtual DbSet<TipoDelincuente> TipoDelincuentes { get; set; }

    public virtual DbSet<TipoDelito> TipoDelitos { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoDroga> TipoDrogas { get; set; }

    public virtual DbSet<TipoElectrodomestico> TipoElectrodomesticos { get; set; }

    public virtual DbSet<TipoEncargo> TipoEncargos { get; set; }

    public virtual DbSet<TipoEspecialidadPolicial> TipoEspecialidadPolicials { get; set; }

    public virtual DbSet<TipoEspeciesDetalle> TipoEspeciesDetalles { get; set; }

    public virtual DbSet<TipoEspecy> TipoEspecies { get; set; }

    public virtual DbSet<TipoFrente> TipoFrentes { get; set; }

    public virtual DbSet<TipoHerramientum> TipoHerramienta { get; set; }

    public virtual DbSet<TipoInstrumento> TipoInstrumentos { get; set; }

    public virtual DbSet<TipoInsumo> TipoInsumos { get; set; }

    public virtual DbSet<TipoMaterial> TipoMaterials { get; set; }

    public virtual DbSet<TipoMenton> TipoMentons { get; set; }

    public virtual DbSet<TipoNariz> TipoNarizs { get; set; }

    public virtual DbSet<TipoOrden> TipoOrdens { get; set; }

    public virtual DbSet<TipoOrdenTab> TipoOrdenTabs { get; set; }

    public virtual DbSet<TipoOreja> TipoOrejas { get; set; }

    public virtual DbSet<TipoOrganismoDelictual> TipoOrganismoDelictuals { get; set; }

    public virtual DbSet<TipoPiel> TipoPiels { get; set; }

    public virtual DbSet<TipoResistencium> TipoResistencia { get; set; }

    public virtual DbSet<TipoTatuaje> TipoTatuajes { get; set; }

    public virtual DbSet<TipoUnidadPolicial> TipoUnidadPolicials { get; set; }

    public virtual DbSet<TipoVillaPobla> TipoVillaPoblas { get; set; }

    public virtual DbSet<TipoVisa> TipoVisas { get; set; }

    public virtual DbSet<TipoVoz> TipoVozs { get; set; }

    public virtual DbSet<TiposVehiculo> TiposVehiculos { get; set; }

    public virtual DbSet<TotalSsConcu> TotalSsConcus { get; set; }

    public virtual DbSet<UniAbrirDocumento> UniAbrirDocumentos { get; set; }

    public virtual DbSet<UniAno> UniAnos { get; set; }

    public virtual DbSet<UniAntecedente> UniAntecedentes { get; set; }

    public virtual DbSet<UniAtnMigPaiAnte> UniAtnMigPaiAntes { get; set; }

    public virtual DbSet<UniAudiGepol> UniAudiGepols { get; set; }

    public virtual DbSet<UniAudiInterpol> UniAudiInterpols { get; set; }

    public virtual DbSet<UniAudiWsDen> UniAudiWsDens { get; set; }

    public virtual DbSet<UniAudiWsEstado> UniAudiWsEstados { get; set; }

    public virtual DbSet<UniAuditaMovimiento> UniAuditaMovimientos { get; set; }

    public virtual DbSet<UniAuditoria2> UniAuditoria2s { get; set; }

    public virtual DbSet<UniAuditoriaFicha> UniAuditoriaFichas { get; set; }

    public virtual DbSet<UniAuditoriaGepol> UniAuditoriaGepols { get; set; }

    public virtual DbSet<UniAuditorium> UniAuditoria { get; set; }

    public virtual DbSet<UniBarrioPrioritario> UniBarrioPrioritarios { get; set; }

    public virtual DbSet<UniCalibreArma> UniCalibreArmas { get; set; }

    public virtual DbSet<UniCalle> UniCalles { get; set; }

    public virtual DbSet<UniCalxTpArma> UniCalxTpArmas { get; set; }

    public virtual DbSet<UniCargaApp> UniCargaApps { get; set; }

    public virtual DbSet<UniCausasAsociada> UniCausasAsociadas { get; set; }

    public virtual DbSet<UniConFall> UniConFalls { get; set; }

    public virtual DbSet<UniConPai> UniConPais { get; set; }

    public virtual DbSet<UniContadorVisita> UniContadorVisitas { get; set; }

    public virtual DbSet<UniDelConclu> UniDelConclus { get; set; }

    public virtual DbSet<UniDelGruopCrim> UniDelGruopCrims { get; set; }

    public virtual DbSet<UniDelResev> UniDelResevs { get; set; }

    public virtual DbSet<UniDelitosAsociado> UniDelitosAsociados { get; set; }

    public virtual DbSet<UniDescriptorDelito> UniDescriptorDelitos { get; set; }

    public virtual DbSet<UniDetConPai> UniDetConPais { get; set; }

    public virtual DbSet<UniDiligenciaPersona> UniDiligenciaPersonas { get; set; }

    public virtual DbSet<UniDiligenciasDocumento> UniDiligenciasDocumentos { get; set; }

    public virtual DbSet<UniDiligenciasDocumentosDelA> UniDiligenciasDocumentosDelAs { get; set; }

    public virtual DbSet<UniDocumentosVisado> UniDocumentosVisados { get; set; }

    public virtual DbSet<UniEntDesDro> UniEntDesDros { get; set; }

    public virtual DbSet<UniEstadosEspecie> UniEstadosEspecies { get; set; }

    public virtual DbSet<UniFenDel> UniFenDels { get; set; }

    public virtual DbSet<UniFolUniNac> UniFolUniNacs { get; set; }

    public virtual DbSet<UniFolioDenuncium> UniFolioDenuncia { get; set; }

    public virtual DbSet<UniFunOtrDili> UniFunOtrDilis { get; set; }

    public virtual DbSet<UniFuncionarioUnidad> UniFuncionarioUnidads { get; set; }

    public virtual DbSet<UniGooglemap> UniGooglemaps { get; set; }

    public virtual DbSet<UniHisEnvDev> UniHisEnvDevs { get; set; }

    public virtual DbSet<UniImgAsoc> UniImgAsocs { get; set; }

    public virtual DbSet<UniInfExt> UniInfExts { get; set; }

    public virtual DbSet<UniInfxDec> UniInfxDecs { get; set; }

    public virtual DbSet<UniIngresoArmasNew> UniIngresoArmasNews { get; set; }

    public virtual DbSet<UniIngresoUrl> UniIngresoUrls { get; set; }

    public virtual DbSet<UniInstFiscal> UniInstFiscals { get; set; }

    public virtual DbSet<UniInstruccionVerbal> UniInstruccionVerbals { get; set; }

    public virtual DbSet<UniJ> UniJs { get; set; }

    public virtual DbSet<UniJefaturasPeritaje> UniJefaturasPeritajes { get; set; }

    public virtual DbSet<UniLetrasTilde> UniLetrasTildes { get; set; }

    public virtual DbSet<UniLib6a> UniLib6as { get; set; }

    public virtual DbSet<UniLogOrdPjud> UniLogOrdPjuds { get; set; }

    public virtual DbSet<UniLugar> UniLugars { get; set; }

    public virtual DbSet<UniLugarDetalle> UniLugarDetalles { get; set; }

    public virtual DbSet<UniMarcaArma> UniMarcaArmas { get; set; }

    public virtual DbSet<UniMarxTpArma> UniMarxTpArmas { get; set; }

    public virtual DbSet<UniMedDrog> UniMedDrogs { get; set; }

    public virtual DbSet<UniMedxTipoEsp> UniMedxTipoEsps { get; set; }

    public virtual DbSet<UniMensaje> UniMensajes { get; set; }

    public virtual DbSet<UniMenu> UniMenus { get; set; }

    public virtual DbSet<UniModeloArma> UniModeloArmas { get; set; }

    public virtual DbSet<UniModusOperandiCondSuj> UniModusOperandiCondSujs { get; set; }

    public virtual DbSet<UniModusOperandiDelAso> UniModusOperandiDelAsos { get; set; }

    public virtual DbSet<UniModusOperandiLenSuj> UniModusOperandiLenSujs { get; set; }

    public virtual DbSet<UniMotivounidad> UniMotivounidads { get; set; }

    public virtual DbSet<UniNoticia> UniNoticias { get; set; }

    public virtual DbSet<UniNumeroCorrelativo> UniNumeroCorrelativos { get; set; }

    public virtual DbSet<UniOcultamientoArma> UniOcultamientoArmas { get; set; }

    public virtual DbSet<UniOtrosAntecedente> UniOtrosAntecedentes { get; set; }

    public virtual DbSet<UniOtrosDocumento> UniOtrosDocumentos { get; set; }

    public virtual DbSet<UniOtrosDocumentosAdjunto> UniOtrosDocumentosAdjuntos { get; set; }

    public virtual DbSet<UniPargen> UniPargens { get; set; }

    public virtual DbSet<UniPeinHd> UniPeinHds { get; set; }

    public virtual DbSet<UniPeinMo> UniPeinMos { get; set; }

    public virtual DbSet<UniPeinRp> UniPeinRps { get; set; }

    public virtual DbSet<UniPgmParametro> UniPgmParametros { get; set; }

    public virtual DbSet<UniPlasBrain> UniPlasBrains { get; set; }

    public virtual DbSet<UniPortalNoticia> UniPortalNoticias { get; set; }

    public virtual DbSet<UniRangoEdad> UniRangoEdads { get; set; }

    public virtual DbSet<UniRegPerNinv> UniRegPerNinvs { get; set; }

    public virtual DbSet<UniRegTel> UniRegTels { get; set; }

    public virtual DbSet<UniRegTelUniDetReg> UniRegTelUniDetRegs { get; set; }

    public virtual DbSet<UniRegistroSeguridad> UniRegistroSeguridads { get; set; }

    public virtual DbSet<UniRelConPai> UniRelConPais { get; set; }

    public virtual DbSet<UniRelFenDel> UniRelFenDels { get; set; }

    public virtual DbSet<UniRelPlasConPai> UniRelPlasConPais { get; set; }

    public virtual DbSet<UniRuta> UniRutas { get; set; }

    public virtual DbSet<UniSeguridadAuditoriaFolio> UniSeguridadAuditoriaFolios { get; set; }

    public virtual DbSet<UniSeguridadAuditorium> UniSeguridadAuditoria { get; set; }

    public virtual DbSet<UniSeguridadPersona> UniSeguridadPersonas { get; set; }

    public virtual DbSet<UniSelInfInt> UniSelInfInts { get; set; }

    public virtual DbSet<UniSsEvidencium> UniSsEvidencia { get; set; }

    public virtual DbSet<UniSsPeritaje> UniSsPeritajes { get; set; }

    public virtual DbSet<UniTag> UniTags { get; set; }

    public virtual DbSet<UniTipoArma> UniTipoArmas { get; set; }

    public virtual DbSet<UniTipoDip> UniTipoDips { get; set; }

    public virtual DbSet<UniTipoInsParticular> UniTipoInsParticulars { get; set; }

    public virtual DbSet<UniTipoParticipacion> UniTipoParticipacions { get; set; }

    public virtual DbSet<UniTipoResidencium> UniTipoResidencia { get; set; }

    public virtual DbSet<UniTpoCambioUnidadFun> UniTpoCambioUnidadFuns { get; set; }

    public virtual DbSet<UniTrabCom> UniTrabComs { get; set; }

    public virtual DbSet<UniUnidadPeritaje> UniUnidadPeritajes { get; set; }

    public virtual DbSet<UnidadCarroPolicial> UnidadCarroPolicials { get; set; }

    public virtual DbSet<UnidadDotacionMensual> UnidadDotacionMensuals { get; set; }

    public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; }

    public virtual DbSet<Unidade> Unidades { get; set; }

    public virtual DbSet<UnivPersona> UnivPersonas { get; set; }

    public virtual DbSet<UperAmputacione> UperAmputaciones { get; set; }

    public virtual DbSet<UperApodo> UperApodos { get; set; }

    public virtual DbSet<UperAuditoria> UperAuditorias { get; set; }

    public virtual DbSet<UperCicatrice> UperCicatrices { get; set; }

    public virtual DbSet<UperDanCor> UperDanCors { get; set; }

    public virtual DbSet<UperDetencionesDetalleLevel1> UperDetencionesDetalleLevel1s { get; set; }

    public virtual DbSet<UperDetencionesLevel1> UperDetencionesLevel1s { get; set; }

    public virtual DbSet<UperDocIdenArch> UperDocIdenArches { get; set; }

    public virtual DbSet<UperEspecialidad> UperEspecialidads { get; set; }

    public virtual DbSet<UperHisMorfologico> UperHisMorfologicos { get; set; }

    public virtual DbSet<UperNombreSupuesto> UperNombreSupuestos { get; set; }

    public virtual DbSet<UperRedSoc> UperRedSocs { get; set; }

    public virtual DbSet<UperSolApeFic> UperSolApeFics { get; set; }

    public virtual DbSet<UperSolicitude> UperSolicitudes { get; set; }

    public virtual DbSet<UperTatuaje> UperTatuajes { get; set; }

    public virtual DbSet<UperVendedore> UperVendedores { get; set; }

    public virtual DbSet<UpersonasAntMig> UpersonasAntMigs { get; set; }

    public virtual DbSet<UpersonasAsetecInfo> UpersonasAsetecInfos { get; set; }

    public virtual DbSet<UpersonasAsociacione> UpersonasAsociaciones { get; set; }

    public virtual DbSet<UpersonasCancelacion> UpersonasCancelacions { get; set; }

    public virtual DbSet<UpersonasCancelacionDetalle> UpersonasCancelacionDetalles { get; set; }

    public virtual DbSet<UpersonasDocumento> UpersonasDocumentos { get; set; }

    public virtual DbSet<UpersonasDomicilio> UpersonasDomicilios { get; set; }

    public virtual DbSet<UpersonasEmail> UpersonasEmails { get; set; }

    public virtual DbSet<UpersonasEnfermedade> UpersonasEnfermedades { get; set; }

    public virtual DbSet<UpersonasEstablecimiento> UpersonasEstablecimientos { get; set; }

    public virtual DbSet<UpersonasFoto> UpersonasFotos { get; set; }

    public virtual DbSet<UpersonasGrupoCriminal> UpersonasGrupoCriminals { get; set; }

    public virtual DbSet<UpersonasHuella> UpersonasHuellas { get; set; }

    public virtual DbSet<UpersonasInfBioMetrico> UpersonasInfBioMetricos { get; set; }

    public virtual DbSet<UpersonasInfDatBu> UpersonasInfDatBus { get; set; }

    public virtual DbSet<UpersonasInfGepol> UpersonasInfGepols { get; set; }

    public virtual DbSet<UpersonasInfInterpol> UpersonasInfInterpols { get; set; }

    public virtual DbSet<UpersonasInfoB3000> UpersonasInfoB3000s { get; set; }

    public virtual DbSet<UpersonasObservacione> UpersonasObservaciones { get; set; }

    public virtual DbSet<UpersonasOdontograma> UpersonasOdontogramas { get; set; }

    public virtual DbSet<UpersonasProfesione> UpersonasProfesiones { get; set; }

    public virtual DbSet<UpersonasProgReha> UpersonasProgRehas { get; set; }

    public virtual DbSet<UpersonasTelefono> UpersonasTelefonos { get; set; }

    public virtual DbSet<UpersonasVehiculo> UpersonasVehiculos { get; set; }

    public virtual DbSet<UpersonasViaje> UpersonasViajes { get; set; }

    public virtual DbSet<VDecretosDestapolSolo> VDecretosDestapolSolos { get; set; }

    public virtual DbSet<VDestapolDatosPersonalesBrain> VDestapolDatosPersonalesBrains { get; set; }

    public virtual DbSet<VDeteFoto> VDeteFotos { get; set; }

    public virtual DbSet<VDrogas15Dia> VDrogas15Dias { get; set; }

    public virtual DbSet<VDrogasDestapol> VDrogasDestapols { get; set; }

    public virtual DbSet<VEspacioBd> VEspacioBds { get; set; }

    public virtual DbSet<VHechosGeo> VHechosGeos { get; set; }

    public virtual DbSet<VInpModusoperandi> VInpModusoperandis { get; set; }

    public virtual DbSet<VLibro6a> VLibro6as { get; set; }

    public virtual DbSet<VLock> VLocks { get; set; }

    public virtual DbSet<VMorfoPeinDestapol> VMorfoPeinDestapols { get; set; }

    public virtual DbSet<VPerGrupoCrim> VPerGrupoCrims { get; set; }

    public virtual DbSet<VPersonasDestapolSola> VPersonasDestapolSolas { get; set; }

    public virtual DbSet<VReportserverConcurrencia> VReportserverConcurrencias { get; set; }

    public virtual DbSet<VReportserverContextoPai> VReportserverContextoPais { get; set; }

    public virtual DbSet<VReportserverDroga> VReportserverDrogas { get; set; }

    public virtual DbSet<VResumenInfoBrain> VResumenInfoBrains { get; set; }

    public virtual DbSet<VVehiculosReportserver> VVehiculosReportservers { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<VehiculosAltomando> VehiculosAltomandos { get; set; }

    public virtual DbSet<VehiculosPieza> VehiculosPiezas { get; set; }

    public virtual DbSet<Vestimenta> Vestimentas { get; set; }

    public virtual DbSet<VestimentaDetalle> VestimentaDetalles { get; set; }

    public virtual DbSet<ViaTransporte> ViaTransportes { get; set; }

    public virtual DbSet<Villa> Villas { get; set; }

    public virtual DbSet<VillaPoblacion> VillaPoblacions { get; set; }

    public virtual DbSet<VisitasLibro6a> VisitasLibro6as { get; set; }

    public virtual DbSet<VistaNna> VistaNnas { get; set; }

    public virtual DbSet<VistaNnaSinFor> VistaNnaSinFors { get; set; }

    public virtual DbSet<VistaPersona> VistaPersonas { get; set; }

    public virtual DbSet<VistaVif> VistaVifs { get; set; }

    public virtual DbSet<Wscodigorechazobud> Wscodigorechazobuds { get; set; }

    public virtual DbSet<Wsinstitucionesbud> Wsinstitucionesbuds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=braindb2; Database=BRAIN; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True; Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AccesoUnidadesInteligencium>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.PgmNombre }).HasName("PK__Acceso_u__B92C5FF606CDD04E");

            entity.ToTable("Acceso_unidades_inteligencia");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PgmNombre)
                .HasMaxLength(31)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AccionEncargo>(entity =>
        {
            entity.HasKey(e => e.AccEncCod).HasName("PK__Accion_E__0AD80A217B271378");

            entity.ToTable("Accion_Encargo");

            entity.Property(e => e.AccEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AccEncDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Antiguedade>(entity =>
        {
            entity.HasKey(e => e.AntObjCod).HasName("PK__Antigued__4307A2D0623B6A1D");

            entity.HasIndex(e => e.AntColCod, "IANTIGUEDADES1");

            entity.HasIndex(e => e.AntObjPaiOri, "IANTIGUEDADES3");

            entity.Property(e => e.AntObjCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AntObjAutor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AntObjDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.AntObjObs)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApliPerfil>(entity =>
        {
            entity.HasKey(e => e.AplPerfCod).HasName("PK__ApliPerf__D12D172337C60D64");

            entity.ToTable("ApliPerfil");

            entity.Property(e => e.AplPerfCod).ValueGeneratedNever();
            entity.Property(e => e.AplPerfDes)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Aplicacione>(entity =>
        {
            entity.HasKey(e => e.PolApliNro).HasName("PK__Aplicaci__D76863A6742FFD26");

            entity.Property(e => e.PolApliNro).ValueGeneratedNever();
            entity.Property(e => e.PolApliDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PolApliExcelPath)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Apodo>(entity =>
        {
            entity.HasKey(e => e.ApoCod).HasName("PK__Apodos__CA2DA1737227B923");

            entity.HasIndex(e => e.ApoDes, "IAPODOS1");

            entity.HasIndex(e => e.ApoCod, "IAPODOS2").IsDescending();

            entity.Property(e => e.ApoCod).ValueGeneratedNever();
            entity.Property(e => e.ApoDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ApoVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ApodosDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("APODOS_DESTAPOL");

            entity.Property(e => e.Apodo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("APODO");
            entity.Property(e => e.Calle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nro");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO");
            entity.Property(e => e.Reg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOCUMENTO");
        });

        modelBuilder.Entity<Arma>(entity =>
        {
            entity.HasKey(e => e.ArmCod).HasName("PK__Armas__738A299155AB7606");

            entity.HasIndex(e => e.MarArmCod, "IARMAS1");

            entity.HasIndex(e => e.TipArmCod, "IARMAS2");

            entity.HasIndex(e => e.ArmPaiCod, "IARMAS3");

            entity.HasIndex(e => e.ArmPeriodo, "IARMAS4");

            entity.Property(e => e.ArmCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArmDes)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ArmModelo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ArmasAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARMAS_ALTOMANDO");

            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.MesAño)
                .HasColumnType("date")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.TipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("tipo_arma");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad");
        });

        modelBuilder.Entity<ArmasDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARMAS_DESTAPOL");

            entity.Property(e => e.ArmaFiscal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ARMA_FISCAL");
            entity.Property(e => e.Avaluo)
                .HasColumnType("money")
                .HasColumnName("AVALUO");
            entity.Property(e => e.Calibre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("calibre");
            entity.Property(e => e.CalleDuenno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_DUENNO");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.CerradoInforme)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodCalibre).HasColumnName("cod_calibre");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodEstado).HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodFamiliaarma).HasColumnName("cod_familiaarma");
            entity.Property(e => e.CodMarcarma).HasColumnName("cod_marcarma");
            entity.Property(e => e.CodPaisarma).HasColumnName("cod_paisarma");
            entity.Property(e => e.CodTipoarma).HasColumnName("cod_tipoarma");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaDecreto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA DECRETO");
            entity.Property(e => e.ComunaDuenno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_DUENNO");
            entity.Property(e => e.ConsultadoDgmn)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CONSULTADO_DGMN");
            entity.Property(e => e.CunnoBancoPruebasChile)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CUNNO_BANCO_PRUEBAS_CHILE");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.EstadoSerie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO_SERIE");
            entity.Property(e => e.FamiliaArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("familia_arma");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaIncautacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INCAUTACION");
            entity.Property(e => e.FechaInformada)
                .HasColumnType("datetime")
                .HasColumnName("fecha_Informada");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaInformeFechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME/ FECHA EVALUACION");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaIngresoArma)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO ARMA");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.Folioarma).HasColumnName("folioarma");
            entity.Property(e => e.FuncionarioIngresaArma)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("FUNCIONARIO INGRESA ARMA");
            entity.Property(e => e.HoraIncautacion)
                .HasColumnType("datetime")
                .HasColumnName("HORA_INCAUTACION");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Inscrita)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INSCRITA");
            entity.Property(e => e.Institucion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.MarcaArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("marca_arma");
            entity.Property(e => e.ModeloArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("modelo_arma");
            entity.Property(e => e.Modificacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MODIFICACION");
            entity.Property(e => e.Modificada)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("MODIFICADA");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MONEDA");
            entity.Property(e => e.NombreDuenno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DUENNO");
            entity.Property(e => e.NumDirDuenno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DIR_DUENNO");
            entity.Property(e => e.OcultamientoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCULTAMIENTO_ARMA");
            entity.Property(e => e.PaisArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pais_arma");
            entity.Property(e => e.Recuperada)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("RECUPERADA");
            entity.Property(e => e.Region)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Rit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIT");
            entity.Property(e => e.Rol)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ROL");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutDuenno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RUT_DUENNO");
            entity.Property(e => e.RutFuncionarioIngresaArma).HasColumnName("RUT FUNCIONARIO INGRESA ARMA");
            entity.Property(e => e.Serie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIE");
            entity.Property(e => e.TipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("tipo_arma");
            entity.Property(e => e.TipoInfraccion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO_INFRACCION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<ArmasJenanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARMAS_JENANCO");

            entity.Property(e => e.ArmaFiscal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ARMA_FISCAL");
            entity.Property(e => e.Avaluo)
                .HasColumnType("money")
                .HasColumnName("AVALUO");
            entity.Property(e => e.Calibre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("calibre");
            entity.Property(e => e.CalleDuenno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_DUENNO");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.CerradoInforme)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodCalibre).HasColumnName("cod_calibre");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodEstado).HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodFamiliaarma).HasColumnName("cod_familiaarma");
            entity.Property(e => e.CodMarcarma).HasColumnName("cod_marcarma");
            entity.Property(e => e.CodPaisarma).HasColumnName("cod_paisarma");
            entity.Property(e => e.CodTipoarma).HasColumnName("cod_tipoarma");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaDuenno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_DUENNO");
            entity.Property(e => e.ConsultadoDgmn)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CONSULTADO_DGMN");
            entity.Property(e => e.CunnoBancoPruebasChile)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CUNNO_BANCO_PRUEBAS_CHILE");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.EstadoSerie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO_SERIE");
            entity.Property(e => e.FamiliaArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("familia_arma");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaHoraExtraccion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EXTRACCION");
            entity.Property(e => e.FechaIncautacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INCAUTACION");
            entity.Property(e => e.FechaInformada)
                .HasColumnType("datetime")
                .HasColumnName("fecha_Informada");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaInformeFechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME/ FECHA EVALUACION");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.Folioarma).HasColumnName("folioarma");
            entity.Property(e => e.HoraIncautacion)
                .HasColumnType("datetime")
                .HasColumnName("HORA_INCAUTACION");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Inscrita)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INSCRITA");
            entity.Property(e => e.Institucion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.MarcaArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("marca_arma");
            entity.Property(e => e.ModeloArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("modelo_arma");
            entity.Property(e => e.Modificacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MODIFICACION");
            entity.Property(e => e.Modificada)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("MODIFICADA");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MONEDA");
            entity.Property(e => e.NombreDuenno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DUENNO");
            entity.Property(e => e.NumDirDuenno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DIR_DUENNO");
            entity.Property(e => e.OcultamientoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OCULTAMIENTO_ARMA");
            entity.Property(e => e.PaisArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pais_arma");
            entity.Property(e => e.Recuperada)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("RECUPERADA");
            entity.Property(e => e.Region)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Rit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIT");
            entity.Property(e => e.Rol)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ROL");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutDuenno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RUT_DUENNO");
            entity.Property(e => e.Serie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIE");
            entity.Property(e => e.TipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("tipo_arma");
            entity.Property(e => e.TipoInfraccion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO_INFRACCION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<ArmasPmJenage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARMAS_PM_JENAGES");

            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Detalle)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DETALLE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ARMA");
        });

        modelBuilder.Entity<AsoPeroPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aso_pero_PBI");

            entity.Property(e => e.UperAsoAplIns).HasColumnName("UPerAsoAplIns");
            entity.Property(e => e.UperAsoAplUpd).HasColumnName("UPerAsoAplUpd");
            entity.Property(e => e.UperAsoFecIni)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIni");
            entity.Property(e => e.UperAsoFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIns");
            entity.Property(e => e.UperAsoFecTer)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecTer");
            entity.Property(e => e.UperAsoFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecUpd");
            entity.Property(e => e.UperAsoObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UPerAsoObs");
            entity.Property(e => e.UperAsoPri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoPri");
            entity.Property(e => e.UperAsoSec)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoSec");
            entity.Property(e => e.UperAsoUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAsoUsuIns");
            entity.Property(e => e.UperAsoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAsoUsuUpd");
            entity.Property(e => e.UperAsoVigencia).HasColumnName("UPerAsoVigencia");
            entity.Property(e => e.UperAsoWrkStIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAsoWrkStIns");
            entity.Property(e => e.UperAsoWrkStUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAsoWrkStUpd");
        });

        modelBuilder.Entity<AsoPrinDh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ASO_PRIN_DH");

            entity.Property(e => e.Asopri)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ASOPRI");
            entity.Property(e => e.UperAsoFecIni)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIni");
            entity.Property(e => e.UperAsoPri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoPri");
        });

        modelBuilder.Entity<Asociacione>(entity =>
        {
            entity.HasKey(e => e.AsoTipCod).HasName("PK__Asociaci__5889E1DB3B969E48");

            entity.Property(e => e.AsoTipCod).ValueGeneratedNever();
            entity.Property(e => e.AsoInvDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.AsoTipDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AsociacionesDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ASOCIACIONES_DOC");

            entity.Property(e => e.Asopri)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ASOPRI");
            entity.Property(e => e.Asosec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ASOSEC");
            entity.Property(e => e.UperAsoPri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoPri");
            entity.Property(e => e.UperAsoSec)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoSec");
        });

        modelBuilder.Entity<AsociacionesPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("asociaciones_personas");

            entity.Property(e => e.Asociacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ASOCIACION");
            entity.Property(e => e.AsociacionInv)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ASOCIACION INV");
            entity.Property(e => e.Completo1)
                .HasMaxLength(230)
                .IsUnicode(false)
                .HasColumnName("COMPLETO 1");
            entity.Property(e => e.Completo2)
                .HasMaxLength(230)
                .IsUnicode(false)
                .HasColumnName("COMPLETO 2");
            entity.Property(e => e.Dv1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv1");
            entity.Property(e => e.Dv2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv2");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NAC.");
            entity.Property(e => e.FechaNacAso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NAC. ASO.");
            entity.Property(e => e.FotoPerso1)
                .HasMaxLength(115)
                .IsUnicode(false)
                .HasColumnName("FOTO PERSO 1");
            entity.Property(e => e.FotoPerso2)
                .HasMaxLength(115)
                .IsUnicode(false)
                .HasColumnName("FOTO PERSO 2");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.IdPersonaAso)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA ASO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.NacionalidadAso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD ASO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreAso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE ASO");
            entity.Property(e => e.Run1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RUN1");
            entity.Property(e => e.Run2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RUN2");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._1ApellidoAso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO ASO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
            entity.Property(e => e._2ApellidoAso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO ASO");
        });

        modelBuilder.Entity<AudiWsDePdi>(entity =>
        {
            entity.HasKey(e => e.AudiWsDeCod).HasName("PK__AudiWsDe__8D1C8E747B9C14C4");

            entity.ToTable("AudiWsDePDI");

            entity.HasIndex(e => e.AudiWsDeCod, "UAUDIWSDEPDI1")
                .IsDescending()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.AudiWsDeFecha, e.AudiWsDeService }, "UAUDIWSDEPDI2")
                .IsDescending(true, false)
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.AudiWsDeService, e.AudiWsDeFecha }, "UAUDIWSDEPDI3")
                .IsDescending(false, true)
                .HasFillFactor(100);

            entity.Property(e => e.AudiWsDeCod)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(15, 0)");
            entity.Property(e => e.AudiWsDeFecha).HasColumnType("datetime");
            entity.Property(e => e.AudiWsDeHh).HasColumnName("AudiWsDeHH");
            entity.Property(e => e.AudiWsDeInst)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsDeMm).HasColumnName("AudiWsDeMM");
            entity.Property(e => e.AudiWsDeRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AudiWsDeRUC");
            entity.Property(e => e.AudiWsDeRut)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsDeRutC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsDeSs).HasColumnName("AudiWsDeSS");
            entity.Property(e => e.AudiWsDeXml)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("AudiWsDeXML");
            entity.Property(e => e.AudiWsDesFault)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsSexo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AuditoriaGepolBrain>(entity =>
        {
            entity.HasKey(e => new { e.Agbperfunrut, e.AgbrutPersona, e.Agbhora }).HasName("PK__Auditori__71CA9ADD42C2BEC4");

            entity.ToTable("Auditoria_Gepol_Brain");

            entity.HasIndex(e => new { e.Agbperfunrut, e.Agbhora }, "IAUDITORIA_GEPOL_BRAINI").IsDescending(false, true);

            entity.HasIndex(e => new { e.AgbrutPersona, e.Agbhora }, "IAUDITORIA_GEPOL_BRAINII").IsDescending(false, true);

            entity.HasIndex(e => new { e.Agbperfunrut, e.AgbrutPersona, e.Agbhh }, "IAUDITORIA_GEPOL_BRAINIII").IsDescending(false, false, true);

            entity.Property(e => e.Agbperfunrut).HasColumnName("AGBPerfunrut");
            entity.Property(e => e.AgbrutPersona).HasColumnName("AGBRutPersona");
            entity.Property(e => e.Agbhora)
                .HasColumnType("datetime")
                .HasColumnName("AGBHora");
            entity.Property(e => e.Agbano).HasColumnName("AGBAno");
            entity.Property(e => e.Agbdia).HasColumnName("AGBDia");
            entity.Property(e => e.Agbhh).HasColumnName("AGBHH");
            entity.Property(e => e.Agbmes).HasColumnName("AGBMes");
            entity.Property(e => e.Agbmm).HasColumnName("AGBMM");
            entity.Property(e => e.Agbss).HasColumnName("AGBSS");
            entity.Property(e => e.AgbtpoConsulta).HasColumnName("AGBTpoConsulta");
        });

        modelBuilder.Entity<AuxPjud>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aux_pjud");

            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.Folio)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO");
            entity.Property(e => e.FolioInternoBrain)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_BRAIN");
            entity.Property(e => e.IdOd)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ID_OD");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.SecuenciaOd)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SECUENCIA_OD");
        });

        modelBuilder.Entity<Avanzadum>(entity =>
        {
            entity.HasKey(e => e.Avacod).HasName("PK__AVANZADA__716E367A4B02FF0A");

            entity.ToTable("AVANZADA");

            entity.HasIndex(e => e.Viacod, "IAVANZADA");

            entity.HasIndex(e => e.Ciucod, "IAVANZADA3");

            entity.Property(e => e.Avacod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AVACOD");
            entity.Property(e => e.Avades)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AVADES");
            entity.Property(e => e.Avaprod).HasColumnName("AVAPROD");
            entity.Property(e => e.Avavigencia).HasColumnName("AVAVIGENCIA");
            entity.Property(e => e.Ciucod).HasColumnName("CIUCOD");
            entity.Property(e => e.Viacod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIACOD");
        });

        modelBuilder.Entity<BandasDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bandas_destapol");

            entity.Property(e => e.CodDelitoGrupoCriminal).HasColumnName("COD. DELITO GRUPO CRIMINAL");
            entity.Property(e => e.ComunaOrganizacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_organizacion");
            entity.Property(e => e.DelitoGrupoCriminal)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO GRUPO CRIMINAL");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.EstadoBanda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO BANDA");
            entity.Property(e => e.FechaIngresoGrupoCriminal)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO GRUPO CRIMINAL");
            entity.Property(e => e.FechaInscriPein)
                .HasColumnType("date")
                .HasColumnName("fecha_inscri_pein");
            entity.Property(e => e.FuncionarioInscribe)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("funcionario_inscribe");
            entity.Property(e => e.Jerarquia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jerarquia");
            entity.Property(e => e.NombreGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_grupo");
            entity.Property(e => e.NombreIntegrante)
                .HasMaxLength(92)
                .IsUnicode(false)
                .HasColumnName("nombre_integrante");
            entity.Property(e => e.ObsDelpein)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obs_delpein");
            entity.Property(e => e.PaiGen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaisOrganizacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pais_organizacion");
            entity.Property(e => e.ProvinciaOrganizacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("provincia_organizacion");
            entity.Property(e => e.RegionOrganizacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_organizacion");
            entity.Property(e => e.RutFunInscribe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rut_fun_inscribe");
            entity.Property(e => e.TipoOrg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_org");
            entity.Property(e => e.UnidadFuncionario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad_funcionario");
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.VigenciaAsociación).HasColumnName("VIGENCIA ASOCIACIÓN");
        });

        modelBuilder.Entity<BandasDestapolIntervenida>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bandas_destapol_Intervenidas");

            entity.Property(e => e.Apellido1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido2");
            entity.Property(e => e.ComunaOrganizacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_organizacion");
            entity.Property(e => e.CondicionIntervenida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("decreto");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("delito");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.FechaInscriPein)
                .HasColumnType("date")
                .HasColumnName("fecha_inscri_pein");
            entity.Property(e => e.FuncionarioInscribe)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("funcionario_inscribe");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Jerarquia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jerarquia");
            entity.Property(e => e.NombreGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_grupo");
            entity.Property(e => e.NombreIntegrante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_integrante");
            entity.Property(e => e.ObsDelpein)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obs_delpein");
            entity.Property(e => e.PaiGen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaisOrganizacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pais_organizacion");
            entity.Property(e => e.ProvinciaOrganizacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("provincia_organizacion");
            entity.Property(e => e.RegionOrganizacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_organizacion");
            entity.Property(e => e.RutFunInscribe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rut_fun_inscribe");
            entity.Property(e => e.TipoOrg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_org");
            entity.Property(e => e.UnidadFuncionario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad_funcionario");
            entity.Property(e => e.UnidadIntervino)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Unidad_intervino");
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
        });

        modelBuilder.Entity<BasePersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BASE_PERSONAS");

            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NAC.");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.Id)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Nacional)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONAL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM DOC.");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
        });

        modelBuilder.Entity<Calle>(entity =>
        {
            entity.HasKey(e => e.CalleCod).HasName("PK__Calles__A2A83E5924E8431A");

            entity.HasIndex(e => e.CalleDes, "ICALLES2");

            entity.Property(e => e.CalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CalleDes)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CalleComNiv>(entity =>
        {
            entity.HasKey(e => new { e.ComCod, e.CalleCod }).HasName("PK__CalleCom__0BBA790528B8D3FE");

            entity.ToTable("CalleComNiv");

            entity.HasIndex(e => e.CalleCod, "ICALLECOMNIV1");

            entity.Property(e => e.ComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CalleComuna>(entity =>
        {
            entity.HasKey(e => new { e.ComCod, e.CalleCod, e.TipCalleCod }).HasName("PK__Calle_Co__31106F6018826C35");

            entity.ToTable("Calle_Comuna");

            entity.HasIndex(e => e.ComCalleConCat, "ICALLENOMBRE");

            entity.HasIndex(e => e.TipCalleCod, "ICALLE_COMUNA1");

            entity.Property(e => e.ComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ComCalleConCat)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.CargoCod).HasName("PK__Cargos__3C758C054D163005");

            entity.Property(e => e.CargoCod).ValueGeneratedNever();
            entity.Property(e => e.CargoDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CargoSia).HasColumnName("CargoSIA");
        });

        modelBuilder.Entity<CargoGrado>(entity =>
        {
            entity.HasKey(e => new { e.CargoCod, e.CarGraCod }).HasName("PK__CargoGra__0E577EE151DAE522");

            entity.ToTable("CargoGrado");

            entity.Property(e => e.CarGraDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CarrosPoliciale>(entity =>
        {
            entity.HasKey(e => e.CarrPolId).HasName("PK__Carros_P__64BE6E64768259EC");

            entity.ToTable("Carros_Policiales");

            entity.HasIndex(e => e.MarVehCod, "ICARROS_POLICIALES1");

            entity.HasIndex(e => e.ColCod, "ICARROS_POLICIALES2");

            entity.HasIndex(e => e.TvhCod, "ICARROS_POLICIALES3");

            entity.HasIndex(e => e.CarrPolInvCorr, "ICARRO_INV_FOLIO").IsDescending();

            entity.HasIndex(e => e.CarrPolNroBien, "ICARRO_NRO_BIEN").IsUnique();

            entity.HasIndex(e => e.CarrPolPat, "ICARRO_PATENTE");

            entity.Property(e => e.CarrPolId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CarrPolID");
            entity.Property(e => e.CarrPolDes)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.CarrPolModelo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CarrPolNroBien).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.CarrPolNroCha)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CarrPolNroMot)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CarrPolNroVin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CarrPolNroVIN");
            entity.Property(e => e.CarrPolPat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CarrPolSigla)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TvhCod).HasColumnName("tvhCod");
        });

        modelBuilder.Entity<Ciudadcomun>(entity =>
        {
            entity.HasKey(e => new { e.Ciucod, e.Comcod }).HasName("PK__CIUDADCO__18FD8B037C569DC9");

            entity.ToTable("CIUDADCOMUN");

            entity.Property(e => e.Ciucod)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("CIUCOD");
            entity.Property(e => e.Comcod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMCOD");
        });

        modelBuilder.Entity<Ciudade>(entity =>
        {
            entity.HasKey(e => e.Ciucod).HasName("PK__Ciudades__E48F365F791ECF75");

            entity.HasIndex(e => e.Regcod, "ICIUDADES1");

            entity.Property(e => e.Ciucod)
                .ValueGeneratedNever()
                .HasColumnName("CIUCOD");
            entity.Property(e => e.CiuProvCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ciunom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Regcod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ColorCabello>(entity =>
        {
            entity.HasKey(e => e.ColCabCod).HasName("PK__Color_Ca__27057382345F90D4");

            entity.ToTable("Color_Cabello");

            entity.Property(e => e.ColCabCod).ValueGeneratedNever();
            entity.Property(e => e.ColCabDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColorOjo>(entity =>
        {
            entity.HasKey(e => e.ColOjoCod).HasName("PK__Color_Oj__C0A02A612CBE6F0C");

            entity.ToTable("Color_Ojos");

            entity.Property(e => e.ColOjoCod).ValueGeneratedNever();
            entity.Property(e => e.ColOjoDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Colore>(entity =>
        {
            entity.HasKey(e => e.ColCod).HasName("PK__Colores__B9D0E34B5A502F92");

            entity.HasIndex(e => e.ColDes, "ICOLORESDES").IsUnique();

            entity.Property(e => e.ColCod).ValueGeneratedNever();
            entity.Property(e => e.ColDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comuna>(entity =>
        {
            entity.HasKey(e => e.ComCod).HasName("PK__Comuna__8190FAE016300F6F");

            entity.ToTable("Comuna");

            entity.Property(e => e.ComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ComCodComunMp).HasColumnName("ComCodComunMP");
            entity.Property(e => e.ComDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ComPrvCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ConclusionesCaso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CONCLUSIONES_CASO");

            entity.Property(e => e.Conclusion)
                .IsUnicode(false)
                .HasColumnName("CONCLUSION");
            entity.Property(e => e.CondicionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION PERSONA");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.Folio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM. DOC.");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO");
            entity.Property(e => e.Relato)
                .IsUnicode(false)
                .HasColumnName("RELATO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<CondicionIngreso>(entity =>
        {
            entity.HasKey(e => e.Coningcod).HasName("PK__CONDICIO__B03B1B59463E49ED");

            entity.ToTable("CONDICION_INGRESO");

            entity.Property(e => e.Coningcod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONINGCOD");
            entity.Property(e => e.Coningdes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONINGDES");
        });

        modelBuilder.Entity<ContextoPai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CONTEXTO_PAIS");

            entity.Property(e => e.CodContexto).HasColumnName("COD. CONTEXTO");
            entity.Property(e => e.CodDetContexto).HasColumnName("COD. DET. CONTEXTO");
            entity.Property(e => e.DetalleContexto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLE CONTEXTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.GrupoContexto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUPO CONTEXTO");
        });

        modelBuilder.Entity<Contextura>(entity =>
        {
            entity.HasKey(e => e.ConTexCod).HasName("PK__Contextu__7DB749EC392445F1");

            entity.Property(e => e.ConTexCod).ValueGeneratedNever();
            entity.Property(e => e.ConTexDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DecSsMod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DEC_SS_MOD");

            entity.Property(e => e.AccionesPrevias).HasColumnName("ACCIONES PREVIAS");
            entity.Property(e => e.AñoFoco).HasColumnName("AÑO FOCO");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAlternativa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTERNATIVA");
            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.CalleIntersecta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_INTERSECTA");
            entity.Property(e => e.CantidadImputados)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CANTIDAD IMPUTADOS");
            entity.Property(e => e.CodCalle)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE");
            entity.Property(e => e.CodCalleIntersecta)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_INTERSECTA");
            entity.Property(e => e.CodCantImputados).HasColumnName("COD_CANT_IMPUTADOS");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodComunaDestapol).HasColumnName("COD_COMUNA_DESTAPOL");
            entity.Property(e => e.CodComunaSs)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA_SS");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganusmo).HasColumnName("COD_DETALLE_ORGANUSMO");
            entity.Property(e => e.CodFormContacto).HasColumnName("COD_FORM_CONTACTO");
            entity.Property(e => e.CodGenero).HasColumnName("COD_GENERO");
            entity.Property(e => e.CodLugar).HasColumnName("COD_LUGAR");
            entity.Property(e => e.CodLugarDet).HasColumnName("COD_LUGAR_DET");
            entity.Property(e => e.CodMedHerramientas).HasColumnName("COD_MED_HERRAMIENTAS");
            entity.Property(e => e.CodModalidad).HasColumnName("COD_MODALIDAD");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodPuntoAcceso).HasColumnName("COD_PUNTO_ACCESO");
            entity.Property(e => e.CodRangoEtario).HasColumnName("COD_RANGO_ETARIO");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_REGION");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.CodTransporte).HasColumnName("COD_TRANSPORTE");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_HECHO");
            entity.Property(e => e.Ddhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDHH");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DescFenomenoDelictual)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC. FENOMENO DELICTUAL");
            entity.Property(e => e.DescripcionResultado)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_RESULTADO");
            entity.Property(e => e.DetalleLugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_LUGAR_HECHO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_ORGANISMO");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENDOSO");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FechaHoraIngSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA_ING_SISTEMA");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REAL_EVALUACION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.FenomenoDelictual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FENOMENO DELICTUAL");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.FormaDeContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FORMA DE CONTACTO");
            entity.Property(e => e.FuncionOfan)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FUNCION_OFAN");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Interoperatividad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INTEROPERATIVIDAD");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LatitudSs)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_SS");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.LongitudSs)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_SS");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LUGAR");
            entity.Property(e => e.LugarDet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DET");
            entity.Property(e => e.LugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_HECHO");
            entity.Property(e => e.LugarNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_NOMBRE");
            entity.Property(e => e.MediosOHerramientas)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEDIOS O HERRAMIENTAS");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODALIDAD");
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.NroDireccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION");
            entity.Property(e => e.NroParcelaDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDenuncia)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NUM_DENUNCIA");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.PuntoAcceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PUNTO ACCESO");
            entity.Property(e => e.RangoEtario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RANGO ETARIO");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_unidad");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.RutEvaluador).HasColumnName("RUT_EVALUADOR");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.Sector)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.SelloPersonal)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SELLO PERSONAL");
            entity.Property(e => e.SitioDelSuceso)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SITIO_DEL_SUCESO");
            entity.Property(e => e.SituacionDecreto)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("SITUACION_DECRETO");
            entity.Property(e => e.Tag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.TipoLugar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_LUGAR");
            entity.Property(e => e.TransporteUsado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TRANSPORTE USADO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<DecretosAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_ALTOMANDO");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_region");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("decreto");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad");
        });

        modelBuilder.Entity<DecretosCodDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_COD_DESTAPOL");

            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganismo).HasColumnName("COD_DETALLE_ORGANISMO");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Interoperatividad).HasColumnName("INTEROPERATIVIDAD");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDenuncia)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NUM_DENUNCIA");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("NUMERO_FOCO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<DecretosDemtel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_DEMTEL");

            entity.Property(e => e.ConSinResultado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CON / SIN RESULTADO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOCUMENTO");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA REAL EVALUACION");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FechaUltimoEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ULTIMO ENDOSO");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.NombreFuncionario)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE FUNCIONARIO");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.RutFuncionario).HasColumnName("RUT FUNCIONARIO");
            entity.Property(e => e.TipoInstruccion)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO INSTRUCCION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VerbalEscrita)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VERBAL / ESCRITA");
            entity.Property(e => e.XmlIntercep)
                .IsUnicode(false)
                .HasColumnName("XML INTERCEP");
        });

        modelBuilder.Entity<DecretosDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_DESTAPOL");

            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodComunaDestapol).HasColumnName("COD_COMUNA_DESTAPOL");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganusmo).HasColumnName("COD_DETALLE_ORGANUSMO");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_HECHO");
            entity.Property(e => e.Ddhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDHH");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Deriva)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionResultado)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_RESULTADO");
            entity.Property(e => e.DetalleLugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_LUGAR_HECHO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_ORGANISMO");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.EsVif)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("esVIF");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENDOSO");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FechaHoraIngSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA_ING_SISTEMA");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REAL_EVALUACION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.FuncionOfan)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FUNCION_OFAN");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.LugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_HECHO");
            entity.Property(e => e.MaternoEvaluador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO EVALUADOR");
            entity.Property(e => e.NombreEvaluador)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE EVALUADOR");
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDenuncia)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NUM_DENUNCIA");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.PaternoEvaluador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO EVALUADOR");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_unidad");
            entity.Property(e => e.Relato)
                .IsUnicode(false)
                .HasColumnName("RELATO");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.RiesgoVif)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("riesgoVIF");
            entity.Property(e => e.RutEvaluador).HasColumnName("RUT_EVALUADOR");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.SituacionInteroperatividad)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("situacionInteroperatividad");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<DecretosDetalle11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_DETALLE_11");

            entity.Property(e => e.ConSinResultado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CON / SIN RESULTADO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA EVALUACION");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VerbalEscrita)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VERBAL / ESCRITA");
        });

        modelBuilder.Entity<DecretosDetapolGeo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("decretos_detapol_geo");

            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodComunaDestapol).HasColumnName("COD_COMUNA_DESTAPOL");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganusmo).HasColumnName("COD_DETALLE_ORGANUSMO");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_HECHO");
            entity.Property(e => e.Ddhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDHH");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DescripcionResultado)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_RESULTADO");
            entity.Property(e => e.DetalleLugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_LUGAR_HECHO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_ORGANISMO");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENDOSO");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FechaHoraIngSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA_ING_SISTEMA");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REAL_EVALUACION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.FuncionOfan)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FUNCION_OFAN");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Interoperatividad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INTEROPERATIVIDAD");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.LugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_HECHO");
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDenuncia)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NUM_DENUNCIA");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_unidad");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.RutEvaluador).HasColumnName("RUT_EVALUADOR");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.SituacionDecreto)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("SITUACION_DECRETO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<DecretosEliminado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_ELIMINADOS");

            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA MOVIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.FolioNacionalUnidad)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO NACIONAL/UNIDAD");
            entity.Property(e => e.HoraMovimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HORA MOVIMIENTO");
            entity.Property(e => e.Motivo)
                .IsUnicode(false)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.NombreEjecuta)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE EJECUTA");
            entity.Property(e => e.NombreIngresa)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE INGRESA");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutEjecuta).HasColumnName("RUT EJECUTA");
            entity.Property(e => e.RutIngresa).HasColumnName("RUT INGRESA");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TIPO MOVIMIENTO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.UnidadIngresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD INGRESA");
        });

        modelBuilder.Entity<DecretosMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_MES");

            entity.Property(e => e.ConSinResultado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CON / SIN RESULTADO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA EVALUACION");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VerbalEscrita)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VERBAL / ESCRITA");
        });

        modelBuilder.Entity<DecretosOfan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_OFAN");

            entity.Property(e => e.AñoFoco).HasColumnName("AÑO FOCO");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.ConFirmaElectronica)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CON FIRMA ELECTRONICA");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.EstadoDecreto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO DECRETO");
            entity.Property(e => e.EstadoOfan)
                .HasMaxLength(57)
                .IsUnicode(false)
                .HasColumnName("ESTADO OFAN");
            entity.Property(e => e.FechaDecreto)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DECRETO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaFirmaElectronica)
                .HasColumnType("datetime")
                .HasColumnName("FECHA FIRMA ELECTRONICA");
            entity.Property(e => e.FechaHecho)
                .HasColumnType("datetime")
                .HasColumnName("FECHA HECHO");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA REAL EVALUACION");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.FiscalDenunciante)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL/DENUNCIANTE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.HoeaHecho)
                .HasColumnType("datetime")
                .HasColumnName("HOEA HECHO");
            entity.Property(e => e.InterO).HasColumnName("INTER O.");
            entity.Property(e => e.Interoperatividad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INTEROPERATIVIDAD");
            entity.Property(e => e.NombreFunEndosado)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE FUN ENDOSADO");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("NUMERO FOCO");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.OrganismoDetalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORGANISMO DETALLE");
            entity.Property(e => e.PerfilOfan)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PERFIL OFAN");
            entity.Property(e => e.RegionPolicial)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Region_policial");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutFunEndosado).HasColumnName("RUT FUN ENDOSADO");
            entity.Property(e => e.Seguridad)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEGURIDAD");
            entity.Property(e => e.SituacionDecreto)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SITUACION_DECRETO");
            entity.Property(e => e.SituacionDecreto1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SITUACION DECRETO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Tipo_decreto");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO INSTRUCCION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DecretosPersonaBasico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_PERSONA_BASICO");

            entity.Property(e => e.ComunaDetencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA DETENCION");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleContexto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLE CONTEXTO");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DETENCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.GrupoContexto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUPO CONTEXTO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA DETENCION");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.MotivoDetencion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MOTIVO DETENCION");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM. DOCUMENTO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoOrden)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO ORDEN");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
        });

        modelBuilder.Entity<DecretosPmJenage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_PM_JENAGES");

            entity.Property(e => e.ConSinResultado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CON / SIN RESULTADO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOCUMENTO");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA REAL EVALUACION");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FechaUltimoEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ULTIMO ENDOSO");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.NombreFuncionario)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE FUNCIONARIO");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.RutFuncionario).HasColumnName("RUT FUNCIONARIO");
            entity.Property(e => e.TipoInstruccion)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO INSTRUCCION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VerbalEscrita)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VERBAL / ESCRITA");
        });

        modelBuilder.Entity<DecretosRelato>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_RELATOS");

            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOCUMENTO");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME ");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Relato)
                .IsUnicode(false)
                .HasColumnName("RELATO");
        });

        modelBuilder.Entity<DecretosTodosDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DECRETOS_TODOS_DESTAPOL");

            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.Cierre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CIERRE");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodComunaDestapol).HasColumnName("COD_COMUNA_DESTAPOL");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganusmo).HasColumnName("COD_DETALLE_ORGANUSMO");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_HECHO");
            entity.Property(e => e.ConFirmaElectronica)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CON FIRMA ELECTRONICA");
            entity.Property(e => e.Ddhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDHH");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleLugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_LUGAR_HECHO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_ORGANISMO");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.EstadoDecreto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO DECRETO");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FecReaEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REA_EVAL");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENDOSO");
            entity.Property(e => e.FechaFirmaElectronica)
                .HasColumnType("datetime")
                .HasColumnName("FECHA FIRMA ELECTRONICA");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FechaHoraIngSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA_ING_SISTEMA");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioIntPd)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INT. PD");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.FuncionOfan)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FUNCION OFAN");
            entity.Property(e => e.FuncionOfanFunIng)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FUNCION OFAN FUN. ING.");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Interoperatividad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INTEROPERATIVIDAD");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.LugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_HECHO");
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.NombreFunIngDec)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE FUN. ING. DEC.");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Origen)
                .HasMaxLength(107)
                .IsUnicode(false)
                .HasColumnName("ORIGEN");
            entity.Property(e => e.PerfilBrain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL BRAIN");
            entity.Property(e => e.PerfilFunIng)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL FUN. ING");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_unidad");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESULTADO");
            entity.Property(e => e.ResultadoOrden)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("RESULTADO_ORDEN");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.RutFunIngDec).HasColumnName("RUT FUN. ING. DEC.");
            entity.Property(e => e.Seguridad)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEGURIDAD");
            entity.Property(e => e.SituacionDecreto)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SITUACION_DECRETO");
            entity.Property(e => e.SituacionDecreto1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SITUACION DECRETO");
            entity.Property(e => e.SituacionEndoso)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SITUACION ENDOSO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoDocumentoDecreto)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("TIPO DOCUMENTO DECRETO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.UnidadFuncionarioIngresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD FUNCIONARIO INGRESA");
            entity.Property(e => e.Vif)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("VIF");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<DelPd>(entity =>
        {
            entity.HasKey(e => e.UniDelCodPd).HasName("PK__DelPD__FA80D4B0585CFA28");

            entity.ToTable("DelPD");

            entity.Property(e => e.UniDelCodPd)
                .ValueGeneratedNever()
                .HasColumnName("UniDelCodPD");
        });

        modelBuilder.Entity<Delito>(entity =>
        {
            entity.HasKey(e => e.DelCod).HasName("PK__Delitos__E428749A06EDCBDF");

            entity.HasIndex(e => new { e.DelCod, e.DelVigFlag }, "IDELITOS1").IsDescending(true, false);

            entity.HasIndex(e => new { e.DelVigFlag, e.DelDes }, "IDELITOS2");

            entity.Property(e => e.DelCod).ValueGeneratedNever();
            entity.Property(e => e.DelDdhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DelDDHH");
            entity.Property(e => e.DelDes)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DelExptxt)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DelIngMont)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DelNna)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DelNNA");
        });

        modelBuilder.Entity<DelitoAsociacion>(entity =>
        {
            entity.HasKey(e => new { e.TipDelCod, e.DelCod }).HasName("PK__Delito_A__FC23EE9A32C16125");

            entity.ToTable("Delito_Asociacion");

            entity.HasIndex(e => e.DelCod, "DELITO_ASOCIACION1");
        });

        modelBuilder.Entity<DelitoInternacional>(entity =>
        {
            entity.HasKey(e => e.DelIntCod).HasName("PK__Delito_I__283915127CDA51C0");

            entity.ToTable("Delito_Internacional");

            entity.Property(e => e.DelIntCod).ValueGeneratedNever();
            entity.Property(e => e.DelIntDes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<DelitosHistorico>(entity =>
        {
            entity.HasKey(e => new { e.DelCod, e.DelHisCod }).HasName("PK__Delitos___99FB3C86534E2C48");

            entity.ToTable("Delitos_Historico");

            entity.Property(e => e.DelHisDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelHisFecFin).HasColumnType("datetime");
            entity.Property(e => e.DelHisFecIni).HasColumnType("datetime");
            entity.Property(e => e.DelHisMinCod)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DelitosHistoricosPmjenage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("delitos_historicos_PMJENAGES");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Deito)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("deito");
            entity.Property(e => e.Dmcs)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dmcs");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Situacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("situacion");
        });

        modelBuilder.Entity<DenunciasDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DENUNCIAS_DESTAPOL");

            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodComunaDestapol).HasColumnName("COD_COMUNA_DESTAPOL");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganusmo).HasColumnName("COD_DETALLE_ORGANUSMO");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_HECHO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DescripcionResultado)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_RESULTADO");
            entity.Property(e => e.DetalleLugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_LUGAR_HECHO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_ORGANISMO");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENDOSO");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FechaHoraIngSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA_ING_SISTEMA");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REAL_EVALUACION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Interoperatividad).HasColumnName("interoperatividad");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.LugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_HECHO");
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDenuncia)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NUM_DENUNCIA");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_unidad");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.RutEvaluador).HasColumnName("RUT_EVALUADOR");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<DestapolUnidadesBrain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DESTAPOL_UNIDADES_BRAIN");

            entity.Property(e => e.Funcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FUNCION");
            entity.Property(e => e.Gesgenunicod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GESGENUNICOD");
            entity.Property(e => e.Gesgenunides)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GESGENUNIDES");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.Region)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DetaleDrogas11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETALE_DROGAS_11");

            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.DecReto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEC RETO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoDroga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO DROGA");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNIDAD MEDIDA");
        });

        modelBuilder.Entity<DetalleArmas11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETALLE_ARMAS_11");

            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Detalle)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DETALLE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ARMA");
        });

        modelBuilder.Entity<DetalleArmasMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETALLE_ARMAS_MES");

            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Detalle)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DETALLE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ARMA");
        });

        modelBuilder.Entity<DetalleEspecies11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETALLE_ESPECIES_11");

            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.EstadoEspecie)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO ESPECIE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoEspecie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ESPECIE");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNIDAD MEDIDA");
            entity.Property(e => e.Valor)
                .HasColumnType("money")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<DetalleEspeciesMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETALLE_ESPECIES_MES");

            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.EstadoEspecie)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO ESPECIE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoEspecie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ESPECIE");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNIDAD MEDIDA");
            entity.Property(e => e.Valor)
                .HasColumnType("money")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<DetenidosAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETENIDOS_ALTOMANDO");

            entity.Property(e => e.CantidadPersona).HasColumnName("CANTIDAD PERSONA");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.MesAño)
                .HasColumnType("date")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DetenidosReportserver>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETENIDOS_REPORTSERVER");

            entity.Property(e => e.AntecedentesDentencion)
                .IsUnicode(false)
                .HasColumnName("ANTECEDENTES_DENTENCION");
            entity.Property(e => e.ApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.ApellMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apell_mat");
            entity.Property(e => e.AsistenciaConsular)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ASISTENCIA_CONSULAR");
            entity.Property(e => e.CalleDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_DETENCION");
            entity.Property(e => e.CircunstanciaDetencion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSTANCIA_DETENCION");
            entity.Property(e => e.CodCalleDet)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_DET");
            entity.Property(e => e.CodComuDet)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMU_DET");
            entity.Property(e => e.CodCondicion).HasColumnName("COD_CONDICION");
            entity.Property(e => e.CodContexto).HasColumnName("COD. CONTEXTO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetContexto).HasColumnName("COD. DET. CONTEXTO");
            entity.Property(e => e.CodMotDetencion).HasColumnName("COD_MOT_DETENCION");
            entity.Property(e => e.CodPaisNac).HasColumnName("COD_PAIS_NAC");
            entity.Property(e => e.ComunaDetencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_DETENCION");
            entity.Property(e => e.ComunaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA PERSONA");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleContexto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLE CONTEXTO");
            entity.Property(e => e.DirContactoMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DIR_CONTACTO_MENOR");
            entity.Property(e => e.DirExactaDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DIR_EXACTA_DETENCION");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADO CIVIL");
            entity.Property(e => e.EstadoDetencion)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ESTADO_DETENCION");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DETENCION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EVALUACION");
            entity.Property(e => e.FechaHoraExtraccion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EXTRACCION");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO_SISTEMA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("folio_interno_decreto");
            entity.Property(e => e.GrupoContexto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUPO CONTEXTO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA_DETENCION");
            entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID_UNIDAD");
            entity.Property(e => e.IdiomaLecturaDederecho)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IDIOMA_LECTURA_DEDERECHO");
            entity.Property(e => e.InpPerDetRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPerID");
            entity.Property(e => e.LecturaDeDerechos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LECTURA_DE_DERECHOS");
            entity.Property(e => e.LesionesDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LESIONES_DETENCION");
            entity.Property(e => e.LugarDetencion)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DETENCION");
            entity.Property(e => e.MedProtecMenor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MED_PROTEC_MENOR");
            entity.Property(e => e.MenorDirigidoA)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("MENOR_DIRIGIDO_A");
            entity.Property(e => e.MinDetencion).HasColumnName("MIN_DETENCION");
            entity.Property(e => e.MotDetencion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MOT_DETENCION");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombrePersonaRetiraMenor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE_PERSONA_RETIRA_MENOR");
            entity.Property(e => e.NroDireccionDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION_DET");
            entity.Property(e => e.NroParcelaDeptoDet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO_DET");
            entity.Property(e => e.Orden)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ORDEN");
            entity.Property(e => e.PresentaLesionesDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRESENTA_LESIONES_DETENCION");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.RegionDetencion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_detencion");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.RelacionConMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RELACION_CON_MENOR");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESULTADO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TiempoDetencion)
                .HasColumnType("datetime")
                .HasColumnName("tiempo_detencion");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DetenidosReportserverIngresado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETENIDOS_REPORTSERVER_INGRESADOS");

            entity.Property(e => e.AntecedentesDentencion)
                .IsUnicode(false)
                .HasColumnName("ANTECEDENTES_DENTENCION");
            entity.Property(e => e.ApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.ApellMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apell_mat");
            entity.Property(e => e.AsistenciaConsular)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ASISTENCIA_CONSULAR");
            entity.Property(e => e.CalleDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_DETENCION");
            entity.Property(e => e.CircunstanciaDetencion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSTANCIA_DETENCION");
            entity.Property(e => e.CodCalleDet)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_DET");
            entity.Property(e => e.CodComuDet)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMU_DET");
            entity.Property(e => e.CodCondicion).HasColumnName("COD_CONDICION");
            entity.Property(e => e.CodContexto).HasColumnName("COD. CONTEXTO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetContexto).HasColumnName("COD. DET. CONTEXTO");
            entity.Property(e => e.CodMotDetencion).HasColumnName("COD_MOT_DETENCION");
            entity.Property(e => e.CodPaisNac).HasColumnName("COD_PAIS_NAC");
            entity.Property(e => e.ComunaDetencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_DETENCION");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleContexto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLE CONTEXTO");
            entity.Property(e => e.DirContactoMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DIR_CONTACTO_MENOR");
            entity.Property(e => e.DirExactaDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DIR_EXACTA_DETENCION");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.EstadoDetencion)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ESTADO_DETENCION");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DETENCION");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO_SISTEMA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("folio_interno_decreto");
            entity.Property(e => e.GrupoContexto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUPO CONTEXTO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA_DETENCION");
            entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID_UNIDAD");
            entity.Property(e => e.IdiomaLecturaDederecho)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IDIOMA_LECTURA_DEDERECHO");
            entity.Property(e => e.InpPerDetRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPerID");
            entity.Property(e => e.LecturaDeDerechos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LECTURA_DE_DERECHOS");
            entity.Property(e => e.LesionesDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LESIONES_DETENCION");
            entity.Property(e => e.LugarDetencion)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DETENCION");
            entity.Property(e => e.MedProtecMenor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MED_PROTEC_MENOR");
            entity.Property(e => e.MenorDirigidoA)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("MENOR_DIRIGIDO_A");
            entity.Property(e => e.MinDetencion).HasColumnName("MIN_DETENCION");
            entity.Property(e => e.MotDetencion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MOT_DETENCION");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombrePersonaRetiraMenor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE_PERSONA_RETIRA_MENOR");
            entity.Property(e => e.NroDireccionDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION_DET");
            entity.Property(e => e.NroParcelaDeptoDet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO_DET");
            entity.Property(e => e.Orden)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ORDEN");
            entity.Property(e => e.PresentaLesionesDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRESENTA_LESIONES_DETENCION");
            entity.Property(e => e.RegionDetencion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_detencion");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.RelacionConMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RELACION_CON_MENOR");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESULTADO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TiempoDetencion)
                .HasColumnType("datetime")
                .HasColumnName("tiempo_detencion");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DetenidosTodo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DETENIDOS_TODOS");

            entity.Property(e => e.AntecedentesDentencion)
                .IsUnicode(false)
                .HasColumnName("ANTECEDENTES_DENTENCION");
            entity.Property(e => e.ApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.ApellMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apell_mat");
            entity.Property(e => e.AsistenciaConsular)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ASISTENCIA_CONSULAR");
            entity.Property(e => e.CalleDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_DETENCION");
            entity.Property(e => e.CircunstanciaDetencion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSTANCIA_DETENCION");
            entity.Property(e => e.CodCalleDet)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_DET");
            entity.Property(e => e.CodComuDet)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMU_DET");
            entity.Property(e => e.CodCondicion).HasColumnName("COD_CONDICION");
            entity.Property(e => e.CodContexto).HasColumnName("COD. CONTEXTO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetContexto).HasColumnName("COD. DET. CONTEXTO");
            entity.Property(e => e.CodMotDetencion).HasColumnName("COD_MOT_DETENCION");
            entity.Property(e => e.CodPaisNac).HasColumnName("COD_PAIS_NAC");
            entity.Property(e => e.ComunaDetencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_DETENCION");
            entity.Property(e => e.ComunaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA PERSONA");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleContexto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLE CONTEXTO");
            entity.Property(e => e.DirContactoMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DIR_CONTACTO_MENOR");
            entity.Property(e => e.DirExactaDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DIR_EXACTA_DETENCION");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADO CIVIL");
            entity.Property(e => e.EstadoDetencion)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ESTADO_DETENCION");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DETENCION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EVALUACION");
            entity.Property(e => e.FechaHoraExtraccion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EXTRACCION");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO_SISTEMA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("folio_interno_decreto");
            entity.Property(e => e.GrupoContexto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUPO CONTEXTO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA_DETENCION");
            entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID_UNIDAD");
            entity.Property(e => e.IdiomaLecturaDederecho)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IDIOMA_LECTURA_DEDERECHO");
            entity.Property(e => e.InpPerDetRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPerID");
            entity.Property(e => e.LecturaDeDerechos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LECTURA_DE_DERECHOS");
            entity.Property(e => e.LesionesDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LESIONES_DETENCION");
            entity.Property(e => e.LugarDetencion)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DETENCION");
            entity.Property(e => e.MedProtecMenor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MED_PROTEC_MENOR");
            entity.Property(e => e.MenorDirigidoA)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("MENOR_DIRIGIDO_A");
            entity.Property(e => e.MinDetencion).HasColumnName("MIN_DETENCION");
            entity.Property(e => e.MotDetencion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MOT_DETENCION");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombrePersonaRetiraMenor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE_PERSONA_RETIRA_MENOR");
            entity.Property(e => e.NroDireccionDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION_DET");
            entity.Property(e => e.NroParcelaDeptoDet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO_DET");
            entity.Property(e => e.Orden)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ORDEN");
            entity.Property(e => e.PresentaLesionesDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRESENTA_LESIONES_DETENCION");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.RegionDetencion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_detencion");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.RelacionConMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RELACION_CON_MENOR");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESULTADO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TiempoDetencion)
                .HasColumnType("datetime")
                .HasColumnName("tiempo_detencion");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DineroAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DINERO_ALTOMANDO");

            entity.Property(e => e.AvaluoClp)
                .HasColumnType("money")
                .HasColumnName("AVALUO CLP");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.Especie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ESPECIE");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.MesAño)
                .HasColumnType("date")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DocFea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DOC_FEA");

            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORGANISMO");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaFirmaElectronica)
                .HasColumnType("datetime")
                .HasColumnName("FECHA FIRMA ELECTRONICA");
            entity.Property(e => e.FechaHoraEjecucion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EJECUCION");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.MaternoFun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO FUN");
            entity.Property(e => e.NombreFun)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE FUN");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.PaternoFun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO FUN");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.RutFun).HasColumnName("RUT FUN");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DrogasAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DROGAS_ALTOMANDO");

            entity.Property(e => e.Avaluo)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("AVALUO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.Droga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DROGA");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Medida)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MEDIDA");
            entity.Property(e => e.MesAño)
                .HasColumnType("date")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DrogasPmJenage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DROGAS_PM_JENAGES");

            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.DecReto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEC RETO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoDroga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO DROGA");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNIDAD MEDIDA");
        });

        modelBuilder.Entity<DrogasplantaAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DROGASPLANTA_ALTOMANDO");

            entity.Property(e => e.Avaluo)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("AVALUO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.Droga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DROGA");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Medida)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MEDIDA");
            entity.Property(e => e.MesAño)
                .HasColumnType("date")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<DuraccionEncargo>(entity =>
        {
            entity.HasKey(e => e.DurEncCod).HasName("PK__Duraccio__1FEECC1201D41107");

            entity.ToTable("Duraccion_Encargo");

            entity.Property(e => e.DurEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DurEncDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Electrodomestico>(entity =>
        {
            entity.HasKey(e => e.ElecCod).HasName("PK__Electrod__89F434992043898E");

            entity.HasIndex(e => e.ColCod, "IELECTRODOMESTICOS1");

            entity.HasIndex(e => e.MarcElecCod, "IELECTRODOMESTICOS2");

            entity.HasIndex(e => e.ElecFamCod, "IELECTRODOMESTICOS3");

            entity.Property(e => e.ElecCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ElecDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ElecModelo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipElecDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EncAuditoriaIng>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.EncAudFolio }).HasName("PK__Enc_Audi__675789F70A9E6132");

            entity.ToTable("Enc_Auditoria_Ing");

            entity.HasIndex(e => e.EncAudUperId, "IENC_AUDI_ID");

            entity.Property(e => e.EncAudFolio).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.EncAudAccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncAudFunHrs).HasColumnType("datetime");
            entity.Property(e => e.EncAudIpIng)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EncAudUperId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EncAudWrkIng)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EncEncargo>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.EncFolio }).HasName("PK__Enc_Enca__97A262F75DE0C954");

            entity.ToTable("Enc_Encargos");

            entity.HasIndex(e => e.EncDelCod, "IENC_ENCARGOS1");

            entity.HasIndex(e => new { e.EncOrgCod, e.EncOrgGenEnc }, "IENC_ENCARGOS13");

            entity.HasIndex(e => e.AccEncCod, "IENC_ENCARGOS2");

            entity.HasIndex(e => e.DurEncCod, "IENC_ENCARGOS3");

            entity.HasIndex(e => new { e.TipEncCod, e.EncDocIngEnc }, "IENC_ENCARGOS5");

            entity.HasIndex(e => e.EncUniCod, "IENC_ENCARGOS9");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.AccEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DurEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncCausaFec).HasColumnType("datetime");
            entity.Property(e => e.EncCausaNro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EncCumCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncDebeCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncDetCal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncDocFolio).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.EncDocGenEnc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncDocIngEnc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncDocOficio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EncEfecCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncFecEnc).HasColumnType("datetime");
            entity.Property(e => e.EncFunTimeIng)
                .HasColumnType("datetime")
                .HasColumnName("EncFunTimeINg");
            entity.Property(e => e.EncIndexConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.EncIndexInvConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.EncObs)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EncRitNro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EncUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncVigencia).HasColumnName("Enc_Vigencia");
            entity.Property(e => e.EstEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EstEncDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TipEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EncPersonaConsultum>(entity =>
        {
            entity.HasKey(e => new { e.EncPerConcat, e.EncPerId }).HasName("PK__Enc_Pers__25DD98C60E6EF216");

            entity.ToTable("Enc_Persona_Consulta");

            entity.HasIndex(e => e.EncPerConcat, "PERSONADESC").IsDescending();

            entity.HasIndex(e => new { e.EncPerPaternoCon, e.EncPerNombreCon }, "PERSONAPATNOM");

            entity.Property(e => e.EncPerConcat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.EncPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EncPerID");
            entity.Property(e => e.EncPerDepFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.EncPerDniDv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ENcPerDniDV");
            entity.Property(e => e.EncPerDniNro)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EncPerFecNacCon).HasColumnType("datetime");
            entity.Property(e => e.EncPerMaternoCon)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EncPerNombreCon)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EncPerPaternoCon)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EncPerSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EncRelacionDocEnc>(entity =>
        {
            entity.HasKey(e => new { e.TipEncCod, e.EncTipDocCod }).HasName("PK__Enc_Rela__426BA6B37909C0DC");

            entity.ToTable("Enc_RelacionDocEnc");

            entity.HasIndex(e => e.EncTipDocCod, "IENC_RELACIONDOCENC1");

            entity.Property(e => e.TipEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncTipDocCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EncTemplateCancelacion>(entity =>
        {
            entity.HasKey(e => e.EncCanTemNro).HasName("PK__Enc_Temp__1537E1882F10CBD2");

            entity.ToTable("Enc_Template_Cancelacion");

            entity.HasIndex(e => new { e.EncCanTemOrgCod, e.EncCanTemOrgDetCod }, "IENC_TEMPLATE_CANCELACION1");

            entity.HasIndex(e => e.EncCanTemFecIns, "IENC_TEMPLATE_CANTIME_INV").IsDescending();

            entity.Property(e => e.EncCanTemNro).ValueGeneratedNever();
            entity.Property(e => e.EncCanTemDes)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.EncCanTemDocCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncCanTemFecDoc).HasColumnType("datetime");
            entity.Property(e => e.EncCanTemFecIns).HasColumnType("datetime");
            entity.Property(e => e.EncCanTemNroDoc).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.EncCanTemUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EncTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.EncTipDocCod).HasName("PK__Enc_Tipo__DE67CA910BE78B26");

            entity.ToTable("Enc_Tipo_Documento");

            entity.Property(e => e.EncTipDocCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncTipDocDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EncargosGepolxdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ENCARGOS_gepolxdr");

            entity.Property(e => e.AntAsetec)
                .HasMaxLength(1)
                .HasColumnName("ANT. ASETEC");
            entity.Property(e => e.AntDepinfi)
                .HasMaxLength(1)
                .HasColumnName("ANT. DEPINFI");
            entity.Property(e => e.AntEncargo)
                .HasMaxLength(1)
                .HasColumnName("ANT. ENCARGO");
            entity.Property(e => e.AntJenaex)
                .HasMaxLength(1)
                .HasColumnName("ANT. JENAEX");
            entity.Property(e => e.CorrEncargo).HasColumnName("CORR. ENCARGO");
            entity.Property(e => e.DelitoEncargo)
                .HasMaxLength(100)
                .HasColumnName("DELITO ENCARGO");
            entity.Property(e => e.DescEncargo)
                .HasMaxLength(100)
                .HasColumnName("DESC. ENCARGO");
            entity.Property(e => e.Dv)
                .HasMaxLength(2)
                .HasColumnName("DV");
            entity.Property(e => e.FechaHoraIngresoEncargo)
                .HasColumnType("smalldatetime")
                .HasColumnName("FECHA HORA INGRESO ENCARGO");
            entity.Property(e => e.Materno)
                .HasMaxLength(20)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.OrganismoGeneraEncargo)
                .HasMaxLength(100)
                .HasColumnName("ORGANISMO GENERA ENCARGO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(20)
                .HasColumnName("PATERNO");
            entity.Property(e => e.Rut)
                .HasMaxLength(20)
                .HasColumnName("RUT");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoEncargo)
                .HasMaxLength(100)
                .HasColumnName("TIPO ENCARGO");
        });

        modelBuilder.Entity<EncargosInt>(entity =>
        {
            entity.HasKey(e => e.IntTipEncCod).HasName("PK__Encargos__61021E54789FAC88");

            entity.ToTable("Encargos_Int");

            entity.Property(e => e.IntTipEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IntTipEncDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EndososBrain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ENDOSOS_BRAIN");

            entity.Property(e => e.DiasPlazo).HasColumnName("DIAS PLAZO");
            entity.Property(e => e.EstadoEndoso)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("ESTADO ENDOSO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.NombreAsigna)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE ASIGNA");
            entity.Property(e => e.NombreRecibe)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE RECIBE");
            entity.Property(e => e.NumeroEndoso).HasColumnName("NUMERO ENDOSO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.PerfilAsigna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL ASIGNA");
            entity.Property(e => e.PerfilRecibe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL RECIBE");
            entity.Property(e => e.ProcesoOfanAsigna)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PROCESO OFAN ASIGNA");
            entity.Property(e => e.ProcesoOfanRecibe)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PROCESO OFAN RECIBE");
            entity.Property(e => e.RutAsigna).HasColumnName("RUT ASIGNA");
            entity.Property(e => e.RutRecibe).HasColumnName("RUT RECIBE");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<EndososBrainOfan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ENDOSOS_BRAIN_OFAN");

            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.DiasPlazo).HasColumnName("DIAS PLAZO");
            entity.Property(e => e.EstadoEndoso)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("ESTADO ENDOSO");
            entity.Property(e => e.FechaDoc)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOC");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA EVALUACION");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA MOVIMIENTO");
            entity.Property(e => e.FechaRecepción)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCIÓN");
            entity.Property(e => e.FechaRegistroEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA REGISTRO ENDOSO");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.Folio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO");
            entity.Property(e => e.HoraMovimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HORA MOVIMIENTO");
            entity.Property(e => e.NomrbeFuncionarioEndosador)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMRBE FUNCIONARIO ENDOSADOR");
            entity.Property(e => e.NomrbeFuncionarioRecibeEndoso)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMRBE FUNCIONARIO RECIBE ENDOSO");
            entity.Property(e => e.NumeroEndoso).HasColumnName("NUMERO ENDOSO");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutFuncionarioEndosador).HasColumnName("RUT FUNCIONARIO ENDOSADOR");
            entity.Property(e => e.RutFuncionarioRecibeEndoso).HasColumnName("RUT FUNCIONARIO RECIBE ENDOSO");
            entity.Property(e => e.SubPerfilAsignador)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SUB PERFIL ASIGNADOR");
            entity.Property(e => e.SubPerfilReceptor)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SUB PERFIL RECEPTOR");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO MOVIMIENTO");
            entity.Property(e => e.UnidadFunEndosa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD FUN. ENDOSA");
            entity.Property(e => e.UnidadFunRecibe)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD FUN. RECIBE");
        });

        modelBuilder.Entity<Enfermedade>(entity =>
        {
            entity.HasKey(e => e.EnfCod).HasName("PK__Enfermed__9960BBE42DC7A1DE");

            entity.HasIndex(e => e.EnfCod, "IENFERMEDADES1").IsDescending();

            entity.Property(e => e.EnfCod).ValueGeneratedNever();
            entity.Property(e => e.EnfDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Escolaridad>(entity =>
        {
            entity.HasKey(e => e.EscoCod).HasName("PK__Escolari__E4AA82A029F710FA");

            entity.ToTable("Escolaridad");

            entity.Property(e => e.EscoCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EscoDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.EspCod).HasName("PK__Especial__F16E379B46693276");

            entity.ToTable("Especialidad");

            entity.Property(e => e.EspCod).ValueGeneratedNever();
            entity.Property(e => e.EspDes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EspecialidadDelito>(entity =>
        {
            entity.HasKey(e => e.EspDelCod).HasName("PK__Especial__94ECE569523A0C7E");

            entity.ToTable("Especialidad_Delito");

            entity.Property(e => e.EspDelCod).ValueGeneratedNever();
            entity.Property(e => e.EspDelDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EspDelDesDef)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EspecialidadDirecPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ESPECIALIDAD_DIREC_PERSONA");

            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.EspecialidadDelictual)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESPECIALIDAD DELICTUAL");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
        });

        modelBuilder.Entity<EspecialidadPerito>(entity =>
        {
            entity.HasKey(e => e.EspPeriCod).HasName("PK__Especial__F1C89EC70955373E");

            entity.ToTable("Especialidad_Peritos");

            entity.Property(e => e.EspPeriCod).ValueGeneratedNever();
            entity.Property(e => e.EspPeriDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EspeciesDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("especies_destapol");

            entity.Property(e => e.Cantidad).HasColumnType("money");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoDetEspecie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("delito");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoEspecie)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Evaluacion");
            entity.Property(e => e.FechaIncautacion)
                .HasColumnType("date")
                .HasColumnName("fecha_incautacion");
            entity.Property(e => e.Folio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.HoraIncautacion).HasColumnName("hora_incautacion");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Inpeval).HasColumnName("inpeval");
            entity.Property(e => e.Medida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonDes)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Region_unidad");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipo_detalle");
            entity.Property(e => e.TipoEspecie)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipoOrden)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UniEspSdtcanEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTCanEnc");
            entity.Property(e => e.UniEspSdtingEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTIngEnc");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("money");
        });

        modelBuilder.Entity<EspeciesJenanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ESPECIES_JENANCO");

            entity.Property(e => e.Cantidad).HasColumnType("money");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoDetEspecie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("delito");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoEspecie)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Evaluacion");
            entity.Property(e => e.FechaHoraExtraccion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EXTRACCION");
            entity.Property(e => e.FechaIncautacion)
                .HasColumnType("date")
                .HasColumnName("fecha_incautacion");
            entity.Property(e => e.Folio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.HoraIncautacion).HasColumnName("hora_incautacion");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Inpeval).HasColumnName("inpeval");
            entity.Property(e => e.Medida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonDes)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Region_unidad");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipo_detalle");
            entity.Property(e => e.TipoEspecie)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipoOrden)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UniEspSdtcanEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTCanEnc");
            entity.Property(e => e.UniEspSdtingEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTIngEnc");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("money");
        });

        modelBuilder.Entity<EspeciesPmJenage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ESPECIES_PM_JENAGES");

            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.EstadoEspecie)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO ESPECIE");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.TipoEspecie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ESPECIE");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNIDAD MEDIDA");
            entity.Property(e => e.Valor)
                .HasColumnType("money")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<EstadoCivil>(entity =>
        {
            entity.HasKey(e => e.EstCivCod).HasName("PK__Estado_C__98D53BD112B48446");

            entity.ToTable("Estado_Civil");

            entity.Property(e => e.EstCivCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EstCivDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EstCivVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EstadoDecreto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ESTADO_DECRETOS");

            entity.Property(e => e.CierreDefinitivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CIERRE DEFINITIVO");
            entity.Property(e => e.CodDelito).HasColumnName("COD. DELITO");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA HECHO");
            entity.Property(e => e.ConFirmaElectronica)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CON FIRMA ELECTRONICA");
            entity.Property(e => e.Ddhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDHH");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORGANISMO");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ENDOSO");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA EVALUACION");
            entity.Property(e => e.FechaFirmaElectronica)
                .HasColumnType("datetime")
                .HasColumnName("FECHA FIRMA ELECTRONICA");
            entity.Property(e => e.FechaHoraEjecucion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EJECUCION");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Interoperatividad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INTEROPERATIVIDAD");
            entity.Property(e => e.MaternoFun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO FUN");
            entity.Property(e => e.NombreFun)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE FUN");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.PaternoFun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO FUN");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutFun).HasColumnName("RUT FUN");
            entity.Property(e => e.SituacionDecreto)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("SITUACION_DECRETO");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VerbalEscrita)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VERBAL / ESCRITA");
        });

        modelBuilder.Entity<ExtInfractor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EXT_INFRACTOR");

            entity.Property(e => e.AQuienLePago)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("A QUIEN LE PAGO");
            entity.Property(e => e.AcompañadoParejaConyugue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACOMPAÑADO PAREJA / CONYUGUE");
            entity.Property(e => e.Acompañante)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ACOMPAÑANTE");
            entity.Property(e => e.AntMigratorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ANT. MIGRATORIO");
            entity.Property(e => e.Autoridad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUTORIDAD");
            entity.Property(e => e.AutoridadOtorgante)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AUTORIDAD OTORGANTE");
            entity.Property(e => e.Block)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BLOCK");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CantidadMenores).HasColumnName("CANTIDAD MENORES");
            entity.Property(e => e.CiudadDestino)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CIUDAD DESTINO");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.CondResidencia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COND. RESIDENCIA");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.CondicionIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONDICION INGRESO");
            entity.Property(e => e.DelitoInfracción)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO INFRACCIÓN");
            entity.Property(e => e.Depto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("DEPTO");
            entity.Property(e => e.DetalleFlagrancia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE FLAGRANCIA");
            entity.Property(e => e.DetalleOranismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORANISMO");
            entity.Property(e => e.Diligencias)
                .IsUnicode(false)
                .HasColumnName("DILIGENCIAS");
            entity.Property(e => e.DineroPagado)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("DINERO PAGADO");
            entity.Property(e => e.DivisaPagado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIVISA PAGADO");
            entity.Property(e => e.DomicilioCompleto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO COMPLETO");
            entity.Property(e => e.DomicilioEnElExtranjero)
                .HasMaxLength(500)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DOMICILIO EN EL EXTRANJERO");
            entity.Property(e => e.EnAusencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN AUSENCIA");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADO CIVIL");
            entity.Property(e => e.Facultades)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FACULTADES");
            entity.Property(e => e.FechaIngresoFechaEstimada)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO / FECHA ESTIMADA");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FechaIntentoEgreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INTENTO EGRESO");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NACIMIENTO");
            entity.Property(e => e.FechaResolución)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RESOLUCIÓN");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA VENCIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Formulario)
                .IsUnicode(false)
                .HasColumnName("FORMULARIO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID. PERSONA");
            entity.Property(e => e.Infracción)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INFRACCIÓN");
            entity.Property(e => e.IngresaDocumentado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INGRESA DOCUMENTADO");
            entity.Property(e => e.IngresoPorFlagrancia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INGRESO POR FLAGRANCIA");
            entity.Property(e => e.LugarIngreso)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LUGAR INGRESO");
            entity.Property(e => e.LugarNacimiento)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("LUGAR NACIMIENTO");
            entity.Property(e => e.MedidasDeControl)
                .IsUnicode(false)
                .HasColumnName("MEDIDAS DE CONTROL");
            entity.Property(e => e.MedioDenuncia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MEDIO DENUNCIA");
            entity.Property(e => e.MedioTransporte)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MEDIO TRANSPORTE");
            entity.Property(e => e.ModalidadInfracción)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MODALIDAD INFRACCIÓN");
            entity.Property(e => e.NTimbreMigratorio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("N° TIMBRE MIGRATORIO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreDueñoReside)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NOMBRE DUEÑO RESIDE");
            entity.Property(e => e.NombreEmpleados)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NOMBRE EMPLEADOS");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.NumeroResolución)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO RESOLUCIÓN");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Relacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RELACION");
            entity.Property(e => e.ResultadoDeLaInvestigacion)
                .IsUnicode(false)
                .HasColumnName("RESULTADO DE LA INVESTIGACION");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoDenuncia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO DENUNCIA");
            entity.Property(e => e.TipoVisa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO VISA");
            entity.Property(e => e.VictimaDe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VICTIMA DE");
            entity.Property(e => e.VinculoEnElPais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VINCULO EN EL PAIS");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
        });

        modelBuilder.Entity<ExtranjeroInfractorXUnidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EXTRANJERO_INFRACTOR_X_UNIDAD");

            entity.Property(e => e.Ano).HasColumnName("ANO");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_MATERNO");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_PATERNO");
            entity.Property(e => e.CiudadDeNacimiento)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CIUDAD_DE_NACIMIENTO");
            entity.Property(e => e.DigitoVerificador)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DIGITO_VERIFICADOR");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INFORME");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID_PERSONA");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_COMPLETO");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            entity.Property(e => e.Pais)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PAIS");
            entity.Property(e => e.PaisDeEmision)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAIS_DE_EMISION");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOCUMENTO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<FenomenosDecreto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FENOMENOS_DECRETOS");

            entity.Property(e => e.Fenomeno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FENOMENO");
            entity.Property(e => e.Folio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO");
        });

        modelBuilder.Entity<FisUbicacion>(entity =>
        {
            entity.HasKey(e => e.Fisubicod).HasName("PK__FIS_UBIC__A617D6E4B4156CF7");

            entity.ToTable("FIS_UBICACION");

            entity.Property(e => e.Fisubicod)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("FISUBICOD");
            entity.Property(e => e.Fisubides)
                .HasMaxLength(60)
                .HasColumnName("FISUBIDES");
            entity.Property(e => e.Fisubipicruta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FISUBIPICRUTA");
        });

        modelBuilder.Entity<FisUbicacionImagencoordenadum>(entity =>
        {
            entity.HasKey(e => new { e.Fisubicod, e.Fiscoorcod }).HasName("PK__FIS_UBIC__A272ED97E769CA04");

            entity.ToTable("FIS_UBICACION_IMAGENCOORDENADA");

            entity.Property(e => e.Fisubicod)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("FISUBICOD");
            entity.Property(e => e.Fiscoorcod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FISCOORCOD");
            entity.Property(e => e.Fisubicoordes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FISUBICOORDES");
        });

        modelBuilder.Entity<FoliosUnidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FOLIOS_UNIDAD");

            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.FolioNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO NACIONAL");
            entity.Property(e => e.FolioUnidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FOLIO UNIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.RutFuncionario).HasColumnName("RUT FUNCIONARIO");
            entity.Property(e => e.TipoOrden)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO ORDEN");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<FuncionarioAplicacion>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.ApliNro }).HasName("PK__Funciona__FDD9963F78008E0A");

            entity.ToTable("Funcionario_Aplicacion");

            entity.HasIndex(e => e.ApliNro, "IFUNCIONARIO_APLICACION2");

            entity.Property(e => e.ApliFunPerOf)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FuncionarioDepuracion>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.DepEncNro }).HasName("PK__Funciona__1FB22269239F1926");

            entity.ToTable("Funcionario_Depuracion");

            entity.Property(e => e.DepEncFecHora).HasColumnType("datetime");
            entity.Property(e => e.DepEncId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DepEncID");
            entity.Property(e => e.DepEncObs)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FuncionarioUnidad>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.PerUnidadIngreso }).HasName("PK__Funciona__0CDE21D20742D19A");

            entity.ToTable("Funcionario_Unidad");

            entity.HasIndex(e => e.PerUnidadIngreso, "IFUNCIONARIO_UNIDAD2");

            entity.Property(e => e.PerUnidadIngreso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerUniFecIng).HasColumnType("datetime");
        });

        modelBuilder.Entity<FuncionariosBrain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FUNCIONARIOS_BRAIN");

            entity.Property(e => e.Materno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Paterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.Rut).HasColumnName("RUT");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<FuncionariosDomicilio>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.PerFunDomNro }).HasName("PK__Funciona__3D5368117CEF6059");

            entity.ToTable("Funcionarios_Domicilios");

            entity.HasIndex(e => e.PerFunDomVilCod, "IFUNCIONARIOS_DOMICILIOS2");

            entity.HasIndex(e => e.PerFunDomPrvCod, "IFUNCIONARIOS_DOMICILIOS3");

            entity.HasIndex(e => e.PerFunDomRegCod, "IFUNCIONARIOS_DOMICILIOS4");

            entity.HasIndex(e => new { e.PerFunDomComCod, e.PerFunDomCalleCod, e.PerFunDomCalleTipo }, "IFUNCIONARIOS_DOMICILIOS8");

            entity.Property(e => e.PerFunDomCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomCalleDes)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomCalleNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunDomDptoNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomFecIns).HasColumnType("datetime");
            entity.Property(e => e.PerFunDomFecUpd).HasColumnType("datetime");
            entity.Property(e => e.PerFunDomPrvCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunDomRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunDomUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomVilCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PerFunDomWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FuncionariosFoto>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.PerFunFotoHisNro }).HasName("PK__Funciona__3E1A4C574BCD0611");

            entity.ToTable("Funcionarios_Fotos");

            entity.HasIndex(e => e.PerFunFotoHisInv, "IFUN_FOTO_INV").IsDescending();

            entity.Property(e => e.PerFunFotoHisExt)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.PerFunFotoHisFec).HasColumnType("datetime");
        });

        modelBuilder.Entity<GesAdministracion>(entity =>
        {
            entity.HasKey(e => e.GesAdmCod).HasName("PK__Ges_Admi__1F8C556C75D84E76");

            entity.ToTable("Ges_Administracion");

            entity.Property(e => e.GesAdmCod).ValueGeneratedNever();
            entity.Property(e => e.GesAdmTxt).IsUnicode(false);
        });

        modelBuilder.Entity<GesAgrupacionDescriptor>(entity =>
        {
            entity.HasKey(e => e.GesAgrCod).HasName("PK__Ges_Agru__BE3625E7678A2F1F");

            entity.ToTable("Ges_Agrupacion_Descriptor");

            entity.Property(e => e.GesAgrCod).ValueGeneratedNever();
            entity.Property(e => e.GesAgrDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GesArea>(entity =>
        {
            entity.HasKey(e => e.GesAreaCod).HasName("PK__Ges_Area__A288708A63B99E3B");

            entity.ToTable("Ges_Areas");

            entity.Property(e => e.GesAreaCod).ValueGeneratedNever();
            entity.Property(e => e.GesAreaDes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesAreasPonderacion>(entity =>
        {
            entity.HasKey(e => new { e.GesAreaCod, e.GesAreaAno, e.GesAreaUnidad }).HasName("PK__Ges_Area__6481838879A8DF5A");

            entity.ToTable("Ges_Areas_Ponderacion");

            entity.Property(e => e.GesAreaUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesAreaPond).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesAreasPonderacionMeta>(entity =>
        {
            entity.HasKey(e => new { e.GesAreaCod, e.GesAreaAno, e.GesAreaUnidad, e.GesAreaMeta }).HasName("PK__Ges_Area__4695460777C096E8");

            entity.ToTable("Ges_Areas_Ponderacion_Metas");

            entity.Property(e => e.GesAreaUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesAreaMetaPond).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesAuditoriaConsultum>(entity =>
        {
            entity.HasKey(e => new { e.GesAudiFunRut, e.GesAudiConCorr }).HasName("PK__Ges_Audi__F5B96F6C6B5AC003");

            entity.ToTable("Ges_Auditoria_Consulta");

            entity.HasIndex(e => e.GesAudiConUniCod, "IGES_AUDITORIA_CONSULTA1");

            entity.HasIndex(e => e.GesAudiConFecCon, "IGES_AUDI_FECCON");

            entity.HasIndex(e => e.GesAudiConInvCorr, "IGES_AUDI_INV_FOLIO").IsDescending();

            entity.HasIndex(e => e.GesAudiConUniObj, "IGES_AUDI_UNICON");

            entity.Property(e => e.GesAudiConCorr).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.GesAudiConFecCon).HasColumnType("datetime");
            entity.Property(e => e.GesAudiConFecha).HasColumnType("datetime");
            entity.Property(e => e.GesAudiConInvCorr).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.GesAudiConIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GesAudiConIP");
            entity.Property(e => e.GesAudiConTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesAudiConUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesAudiConUniObj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesAuditoriaUnidade>(entity =>
        {
            entity.HasKey(e => e.IdmovGesaud).HasName("PK__ges_Audi__969D12DD554B8353");

            entity.ToTable("ges_Auditoria_Unidades");

            entity.Property(e => e.IdmovGesaud).HasColumnName("idmov_gesaud");
            entity.Property(e => e.FechaGesaud)
                .HasColumnType("datetime")
                .HasColumnName("fecha_gesaud");
            entity.Property(e => e.GesunicodGesaud)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("gesunicod_gesaud");
            entity.Property(e => e.Gesunicodcompleto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gesunicodcompleto");
            entity.Property(e => e.GesunidesGesaud)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("gesunides_gesaud");
            entity.Property(e => e.MovnewGesaud)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("movnew_gesaud");
            entity.Property(e => e.MovoldGesaud)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("movold_gesaud");
            entity.Property(e => e.UserGesaud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_gesaud");
        });

        modelBuilder.Entity<GesCalculoIndicador>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesMedCod }).HasName("PK__Ges_Calc__CFF73CC65EF4E91E");

            entity.ToTable("Ges_CalculoIndicador");

            entity.HasIndex(e => e.GesMedCod, "IGES_CALCULOINDICADOR1");

            entity.HasIndex(e => e.GesIndMedCal, "IGES_OPERACIONINDICADOR");

            entity.Property(e => e.GesIndMedCal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesCategoria>(entity =>
        {
            entity.HasKey(e => e.GesCtgCod).HasName("PK__Ges_Cate__DCB14BAD528F1239");

            entity.ToTable("Ges_Categorias");

            entity.Property(e => e.GesCtgCod).ValueGeneratedNever();
            entity.Property(e => e.GesCtgDes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesCtgPond).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesCategoriasInforme>(entity =>
        {
            entity.HasKey(e => new { e.GesCtgCod, e.GesCtgInfCod }).HasName("PK__Ges_Cate__9F23EDF94BE214AA");

            entity.ToTable("Ges_Categorias_Informes");

            entity.Property(e => e.GesCtgInfPond).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesDescriptorAgrupado>(entity =>
        {
            entity.HasKey(e => new { e.GesMedCod, e.GesAgrCod }).HasName("PK__Ges_Desc__C17C58A5481183C6");

            entity.ToTable("Ges_Descriptor_Agrupado");

            entity.HasIndex(e => e.GesAgrCod, "IGES_DESCRIPTOR_AGRUPADO1");
        });

        modelBuilder.Entity<GesDescriptorGrupo>(entity =>
        {
            entity.HasKey(e => new { e.GesMedCod, e.GesGrupDesCod }).HasName("PK__Ges_Desc__07C9B25350A6C9C7");

            entity.ToTable("Ges_Descriptor_Grupo");

            entity.HasIndex(e => e.GesGrupDesCod, "IGES_DESCRIPTOR_GRUPO1");
        });

        modelBuilder.Entity<GesDireccion>(entity =>
        {
            entity.HasKey(e => e.GesDirCod).HasName("PK__Ges_Dire__6985A2B34A83DC1D");

            entity.ToTable("Ges_Direccion");

            entity.Property(e => e.GesDirCod).ValueGeneratedNever();
            entity.Property(e => e.GesDirCodJer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesDirDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesGrupoDescriptor>(entity =>
        {
            entity.HasKey(e => e.GesGrupDesCod).HasName("PK__Ges_Grup__D5688A8B34FEAF52");

            entity.ToTable("Ges_Grupo_Descriptor");

            entity.Property(e => e.GesGrupDesCod).ValueGeneratedNever();
            entity.Property(e => e.GesGrupDesNom)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesIndicadorAuxiliar>(entity =>
        {
            entity.HasKey(e => new { e.GesAuxIndCod, e.GesAuxForNro }).HasName("PK__Ges_Indi__AB236BA03BABACE1");

            entity.ToTable("Ges_Indicador_Auxiliar");

            entity.HasIndex(e => e.GesAuxDesCod, "IGES_INDICADOR_AUXILIAR3");

            entity.Property(e => e.GesAuxForCons).HasColumnType("money");
        });

        modelBuilder.Entity<GesIndicadorAuxiliar1>(entity =>
        {
            entity.HasKey(e => e.GesAuxIndCod).HasName("PK__Ges_Indi__27A10A924440F2E2");

            entity.ToTable("Ges_Indicador_Auxiliar1");

            entity.Property(e => e.GesAuxIndCod).ValueGeneratedNever();
            entity.Property(e => e.GesAuxIndFor)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GesIndicadorCategorium>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesCtgCod }).HasName("PK__Ges_Indi__A895DBD323D42350");

            entity.ToTable("Ges_IndicadorCategoria");

            entity.HasIndex(e => e.GesCtgCod, "IGES_INDICADORCATEGORIA1");
        });

        modelBuilder.Entity<GesIndicadorStandarPromedi1>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesStaIndAno, e.GesStaIndNro }).HasName("PK__Ges_Indi__D671DA6936E6F7C4");

            entity.ToTable("Ges_Indicador_Standar_Promedi1");

            entity.Property(e => e.GesStaCondZero).HasColumnType("smallmoney");
            entity.Property(e => e.GesStaIndValInf).HasColumnType("smallmoney");
            entity.Property(e => e.GesStaIndValSup).HasColumnType("smallmoney");
            entity.Property(e => e.GesStaIndValor).HasColumnType("smallmoney");
            entity.Property(e => e.GesStaLimite).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesIndicadorStandarPromedi2>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesStaIndAno, e.GesStaIndNro, e.GesStaProNro }).HasName("PK__Ges_Indi__A0EDEB9E3039FA35");

            entity.ToTable("Ges_Indicador_Standar_Promedi2");
        });

        modelBuilder.Entity<GesIndicadorTemplate>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniTempAno, e.GesUniTempIndCod }).HasName("PK__Ges_Indi__3DE794352C696951");

            entity.ToTable("Ges_Indicador_Template");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesIndicadore>(entity =>
        {
            entity.HasKey(e => e.GesIndCod).HasName("PK__Ges_Indi__655ECF695C187C73");

            entity.ToTable("Ges_Indicadores");

            entity.Property(e => e.GesIndCod).ValueGeneratedNever();
            entity.Property(e => e.GesIndDes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesIndPond).HasColumnType("smallmoney");
            entity.Property(e => e.GesIndRmtodas).HasColumnName("GesIndRMTodas");
            entity.Property(e => e.GesIndTxtExpl).IsUnicode(false);
            entity.Property(e => e.GesValSta1).HasColumnType("smallmoney");
            entity.Property(e => e.GesValSta2).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesIndicadoresArea>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesIndAreaCod }).HasName("PK__Ges_Indi__2A533CDF1D2725C1");

            entity.ToTable("Ges_Indicadores_Areas");

            entity.HasIndex(e => e.GesIndAreaCod, "IGES_INDICADORES_AREAS12");
        });

        modelBuilder.Entity<GesIndicadoresClasificacion>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesTipoIndCod }).HasName("PK__Ges_Indi__ED0422BA186270A4");

            entity.ToTable("Ges_Indicadores_Clasificacion");

            entity.HasIndex(e => e.GesTipoIndCod, "IGES_INDICADORES_CLASIFICACIO1");
        });

        modelBuilder.Entity<GesIndicadoresEspecialidad>(entity =>
        {
            entity.HasKey(e => new { e.GesIndCod, e.GesGrupIndCod }).HasName("PK__Ges_Indi__AC9D8FDC1F0F6E33");

            entity.ToTable("Ges_Indicadores_Especialidad");

            entity.HasIndex(e => e.GesGrupIndCod, "IGES_INDICADORES_ESPECIALIDAD2");
        });

        modelBuilder.Entity<GesIndicadoresExcepcion>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesExcepIndCod, e.GesExcepIndAno, e.GesExcepMesUno, e.GesExcepMesDos }).HasName("PK__Ges_Indi__19C6840B1491DFC0");

            entity.ToTable("Ges_Indicadores_Excepcion");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesExcepFecIns).HasColumnType("datetime");
            entity.Property(e => e.GesExcepFecUpd).HasColumnType("datetime");
            entity.Property(e => e.GesExcepValor).HasColumnType("money");
        });

        modelBuilder.Entity<GesJefaturaDireccion>(entity =>
        {
            entity.HasKey(e => new { e.GesDirCod, e.GesJefCod }).HasName("PK__Ges_Jefa__108CA0740BFC99BF");

            entity.ToTable("Ges_JefaturaDireccion");

            entity.HasIndex(e => e.GesJefCod, "IGES_JEFATURADIRECCION1");

            entity.Property(e => e.GesJefCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesJefaturaPolicial>(entity =>
        {
            entity.HasKey(e => e.GesJefCod).HasName("PK__Ges_Jefa__90902C765EDFDA85");

            entity.ToTable("Ges_Jefatura_Policial");

            entity.Property(e => e.GesJefCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesJefDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesJefJerCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesJefaturaUnidad>(entity =>
        {
            entity.HasKey(e => new { e.GesJefCod, e.GesUniDepCod }).HasName("PK__Ges_Jefa__B8A40410082C08DB");

            entity.ToTable("Ges_JefaturaUnidad");

            entity.HasIndex(e => e.GesUniDepCod, "IGES_JEFATURAUNIDAD1");

            entity.Property(e => e.GesJefCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesMedida>(entity =>
        {
            entity.HasKey(e => e.GesMedCod).HasName("PK__Ges_Medi__AA9F3AFB53F837BE");

            entity.ToTable("Ges_Medidas");

            entity.Property(e => e.GesMedCod).ValueGeneratedNever();
            entity.Property(e => e.GesMedDes).IsUnicode(false);
            entity.Property(e => e.GesMedTxtExp)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GesMetasArea>(entity =>
        {
            entity.HasKey(e => new { e.MetasCod, e.MetasAreasCod }).HasName("PK__Ges_Meta__63745794045B77F7");

            entity.ToTable("Ges_Metas_Areas");

            entity.HasIndex(e => e.MetasAreasCod, "IGES_METAS_AREAS");
        });

        modelBuilder.Entity<GesMetasDetalle>(entity =>
        {
            entity.HasKey(e => new { e.MetasCod, e.GesIndCod }).HasName("PK__Ges_Meta__C628B445276FAA0A");

            entity.ToTable("Ges_Metas_Detalle");

            entity.HasIndex(e => e.GesIndCod, "IGES_METAS_UPD1");

            entity.Property(e => e.MetasGesIndPor).HasColumnType("smallmoney");
            entity.Property(e => e.MetasGesIndVal).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesMetasMaestro>(entity =>
        {
            entity.HasKey(e => e.MetasCod).HasName("PK__Ges_Meta__407D58B332E15CB6");

            entity.ToTable("Ges_Metas_Maestro");

            entity.Property(e => e.MetasCod).ValueGeneratedNever();
            entity.Property(e => e.MetasDes).IsUnicode(false);
            entity.Property(e => e.MetasPond).HasColumnType("smallmoney");
            entity.Property(e => e.MetasTxtExpl).IsUnicode(false);
        });

        modelBuilder.Entity<GesMetasPonderacione>(entity =>
        {
            entity.HasKey(e => new { e.GesMetaCod, e.GesMetaAno, e.GesMetaUnidad }).HasName("PK__Ges_Meta__EE86FEC37D79703E");

            entity.ToTable("Ges_Metas_Ponderaciones");

            entity.Property(e => e.GesMetaUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesMetaPond).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesMetasPonderacionesInd>(entity =>
        {
            entity.HasKey(e => new { e.GesMetaCod, e.GesMetaAno, e.GesMetaUnidad, e.GesMetaIndCod }).HasName("PK__Ges_Meta__2A66211F03324994");

            entity.ToTable("Ges_Metas_Ponderaciones_Ind");

            entity.Property(e => e.GesMetaUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesMetaIndPond).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesPeriodo>(entity =>
        {
            entity.HasKey(e => new { e.GesUniAno, e.GesUniMes }).HasName("PK__Ges_Peri__562183C75319221E");

            entity.ToTable("Ges_Periodo");

            entity.Property(e => e.GesPerFecActivacion).HasColumnType("datetime");
            entity.Property(e => e.GesPerFecCierre).HasColumnType("datetime");
            entity.Property(e => e.GesPerFecProceso).HasColumnType("datetime");
        });

        modelBuilder.Entity<GesPeriodoUnidad>(entity =>
        {
            entity.HasKey(e => new { e.GesUniAno, e.GesUniMes, e.GesUnidadPeriodo }).HasName("PK__Ges_Peri__A84E5FAC41EE961C");

            entity.ToTable("Ges_Periodo_Unidad");

            entity.Property(e => e.GesUnidadPeriodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesPrefecturaPolicial>(entity =>
        {
            entity.HasKey(e => e.GesPrefCod).HasName("PK__Ges_Pref__38649FBC0BC78F95");

            entity.ToTable("Ges_Prefectura_Policial");

            entity.Property(e => e.GesPrefCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesPrefDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesPrefJerCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesPrefRegion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesPrefecturaRegion>(entity =>
        {
            entity.HasKey(e => new { e.GesPrefCod, e.GesRegPolCod }).HasName("PK__Ges_Pref__E3D96EAD7CBA562F");

            entity.ToTable("Ges_PrefecturaRegion");

            entity.HasIndex(e => e.GesRegPolCod, "IGES_PREFECTURAREGION1");

            entity.Property(e => e.GesPrefCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesRegPolCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesPrefecturaUnidad>(entity =>
        {
            entity.HasKey(e => new { e.GesPrefCod, e.GesUniDepCod }).HasName("PK__Ges_Pref__1050B7DA008AE713");

            entity.ToTable("Ges_PrefecturaUnidad");

            entity.HasIndex(e => e.GesUniDepCod, "IGES_PREFECTURAUNIDAD1");

            entity.Property(e => e.GesPrefCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesRegionDireccion>(entity =>
        {
            entity.HasKey(e => new { e.GesDirCod, e.GesRegPolCod }).HasName("PK__Ges_Regi__B23853A27425102E");

            entity.ToTable("Ges_RegionDireccion");

            entity.HasIndex(e => e.GesRegPolCod, "IGES_REGIONDIRECCION1");

            entity.Property(e => e.GesRegPolCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesRegionPolicial>(entity =>
        {
            entity.HasKey(e => e.GesRegPolCod).HasName("PK__Ges_Regi__BBDF111C6B45B16A");

            entity.ToTable("Ges_Region_Policial");

            entity.Property(e => e.GesRegPolCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesRegPolDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesRegPolJer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesSeccionPolicial>(entity =>
        {
            entity.HasKey(e => e.GesSeccCod).HasName("PK__Ges_Secc__1115234F70547F4A");

            entity.ToTable("Ges_Seccion_Policial");

            entity.Property(e => e.GesSeccCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesSeccDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesSeccJerCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesTipoIndicador>(entity =>
        {
            entity.HasKey(e => e.GesTipoIndCod).HasName("PK__Ges_Tipo__85AEDD396B8FCA2D");

            entity.ToTable("Ges_Tipo_Indicador");

            entity.Property(e => e.GesTipoIndCod).ValueGeneratedNever();
            entity.Property(e => e.GesTipoIndDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GesUniAuditorium>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesUniIngFec, e.GesUniIngCorr }).HasName("PK__Ges_Uni___7C4C5D0B69A781BB");

            entity.ToTable("Ges_Uni_Auditoria");

            entity.HasIndex(e => new { e.GesUniAno, e.GesUniMes }, "IGES_UNI_AUDITORIA1");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniIngFec).HasColumnType("datetime");
            entity.Property(e => e.GesUniIngDateTime).HasColumnType("datetime");
            entity.Property(e => e.GesUniIngIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GesUniIngIP");
        });

        modelBuilder.Entity<GesUniCalculoIndicadoresDe>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.MetasCod, e.GesIndCod, e.GesUniDesCod }).HasName("PK__Ges_Uni___92F46DD964E2CC9E");

            entity.ToTable("Ges_Uni_Calculo_IndicadoresDes");

            entity.HasIndex(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.MetasCod, e.GesIndCod, e.GesUniDesCod, e.GesUniDesCalc }, "GES_UNI_CALCULOACENDENTE");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDesCalc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDesValor).HasColumnType("money");
        });

        modelBuilder.Entity<GesUniDescriptore>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesMedCod }).HasName("PK__Ges_Uni___9EE2560A3E1E0538");

            entity.ToTable("Ges_Uni_Descriptores");

            entity.HasIndex(e => new { e.GesUniAno, e.GesUniMes }, "IGES_UNI_DESCRIPTORES2");

            entity.HasIndex(e => e.GesMedCod, "IGES_UNI_DESCRIPTORES3");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesFunHrsModDatos).HasColumnType("datetime");
            entity.Property(e => e.GesUniValMed).HasColumnType("money");
        });

        modelBuilder.Entity<GesUniDescriptoresAuditorium>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesMedCod, e.GesMedFchUni, e.GesMedFchCorr }).HasName("PK__Ges_Uni___A988F65738652BE2");

            entity.ToTable("Ges_Uni_Descriptores_Auditoria");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesMedFchUni).HasColumnType("datetime");
            entity.Property(e => e.GesMedFchAudDate).HasColumnType("datetime");
            entity.Property(e => e.GesMedFchAudIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GesMedFchAudIP");
            entity.Property(e => e.GesMedFchAudVal).HasColumnType("money");
        });

        modelBuilder.Entity<GesUniDescriptoresDiario>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesMedCod, e.GesMedFchUni }).HasName("PK__Ges_Uni___F258692C33A076C5");

            entity.ToTable("Ges_Uni_Descriptores_Diario");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesMedFchUni).HasColumnType("datetime");
            entity.Property(e => e.GesMedFchDateIns).HasColumnType("datetime");
            entity.Property(e => e.GesMedFchDateUpd).HasColumnType("datetime");
            entity.Property(e => e.GesMedFchVal).HasColumnType("money");
        });

        modelBuilder.Entity<GesUniGenericaMeta>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.MetasCod }).HasName("PK__Ges_Uni___BA6CF82C587CF5B9");

            entity.ToTable("Ges_Uni_Generica_Metas");

            entity.HasIndex(e => e.MetasCod, "IGES_UNI_GENERICA_METAS1");

            entity.HasIndex(e => new { e.GesUniAno, e.GesUniMes }, "IGES_UNI_GENERICA_METAS2");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniMetaFecIns).HasColumnType("datetime");
        });

        modelBuilder.Entity<GesUniIndCalculoDe>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesUniIndCod, e.GesUniDesCod }).HasName("PK__Ges_Uni___39CBEFB5145CD596");

            entity.ToTable("Ges_Uni_Ind_CalculoDes");

            entity.HasIndex(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesUniIndCod, e.GesUniDesIndCalc }, "GES_UNICALC_INDICADOR");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDesIndCalc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDesIndValor).HasColumnType("money");
        });

        modelBuilder.Entity<GesUniIndicadore>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.GesUniIndCod }).HasName("PK__Ges_Uni___46C4E50B1B09D325");

            entity.ToTable("Ges_Uni_Indicadores");

            entity.HasIndex(e => new { e.GesUniAno, e.GesUniMes }, "IGES_UNI_INDICADORES1");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniIndFchHoraIns).HasColumnType("datetime");
            entity.Property(e => e.GesUniIndFchIndIns).HasColumnType("datetime");
            entity.Property(e => e.GesUniIndPerResultado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniIndPorPerAnt).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniIndStaInf).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniIndStaSup).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniIndStaValor).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniIndValComp).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniIndValor).HasColumnType("money");
        });

        modelBuilder.Entity<GesUniMetasIndicadore>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.GesUniAno, e.GesUniMes, e.MetasCod, e.GesIndCod }).HasName("PK__Ges_Uni___75049D7216451E08");

            entity.ToTable("Ges_Uni_Metas_Indicadores");

            entity.HasIndex(e => new { e.MetasCod, e.GesIndCod }, "IGES_UNI_METAS_INDICADORES1");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesIndMetaPond).HasColumnType("smallmoney");
            entity.Property(e => e.GesIndNota).HasColumnType("smallmoney");
            entity.Property(e => e.GesIndRanStaInf).HasColumnType("smallmoney");
            entity.Property(e => e.GesIndRanStaSup).HasColumnType("smallmoney");
            entity.Property(e => e.GesIndStanVal).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniIndFecIns).HasColumnType("datetime");
            entity.Property(e => e.GesUniIndFecValIns).HasColumnType("datetime");
            entity.Property(e => e.GesUniIndResultado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniPorRes).HasColumnType("smallmoney");
            entity.Property(e => e.GesUniValInd).HasColumnType("money");
            entity.Property(e => e.GesUniValPerComp).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<GesUnidadDepartamento>(entity =>
        {
            entity.HasKey(e => e.GesUniDepCod).HasName("PK__Ges_Unid__834286630F982079");

            entity.ToTable("Ges_Unidad_Departamento");

            entity.HasIndex(e => e.GesUniDepJerCod, "IGES_UNI_JERARQUIA");

            entity.Property(e => e.GesUniDepCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepJef)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepJerCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepPref)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesUniDepReg)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesUnidadDescripcion>(entity =>
        {
            entity.HasKey(e => e.GesUnidadDescripcionId).HasName("PK__Ges_Unid__7841D5346A11960F");

            entity.ToTable("Ges_Unidad_Descripcion");

            entity.Property(e => e.GesUnidadDescripcionId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Ges_Unidad_DescripcionID");
            entity.Property(e => e.GesUnidadDescripcionDes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Ges_Unidad_DescripcionDES");
        });

        modelBuilder.Entity<GesUnidadFusionadum>(entity =>
        {
            entity.HasKey(e => new { e.GesFusUniId, e.GesFusUniNro }).HasName("PK__Ges_Unid__8A3BC2994B22FA9B");

            entity.ToTable("Ges_Unidad_Fusionada");

            entity.Property(e => e.GesFusUniId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GesFusUniID");
            entity.Property(e => e.GesFusFec).HasColumnType("datetime");
            entity.Property(e => e.GesFusUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesUnidadGenerica>(entity =>
        {
            entity.HasKey(e => e.GesGenUniCod).HasName("PK__Ges_Unid__542AE7C57BD11EEE");

            entity.ToTable("Ges_Unidad_Generica");

            entity.HasIndex(e => e.UniTipoCod, "IGES_UNIDAD_GENERICA1");

            entity.HasIndex(e => e.TipEspPolCod, "IGES_UNIDAD_GENERICA2");

            entity.HasIndex(e => e.GesGenRegCod, "IGES_UNIDAD_REGCOD");

            entity.HasIndex(e => new { e.GesGenActivo, e.GesGenUniDes }, "IUGES_UNIDAD_GENERICA01");

            entity.HasIndex(e => new { e.GesGenActivo, e.UniTipoCod, e.GesGenUniDes }, "IUGES_UNIDAD_GENERICA02");

            entity.HasIndex(e => new { e.GesGenActivo, e.GesGenRegCod, e.GesGenUniDes }, "IUGES_UNIDAD_GENERICA03");

            entity.HasIndex(e => new { e.GesGenActivo, e.GesGenRegCod, e.UniTipoCod, e.GesGenUniDes }, "IUGES_UNIDAD_GENERICA04");

            entity.HasIndex(e => new { e.GesGenActivo, e.GesGenUniCod }, "IUGES_UNIDAD_GENERICA05");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesCodGepol)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.GesCodSia).HasColumnName("GesCodSIA");
            entity.Property(e => e.GesGenCodArea)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.GesGenComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesGenDirNom)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GesGenDirNro)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GesGenEmail)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.GesGenRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GesGenRmges).HasColumnName("GesGenRMGes");
            entity.Property(e => e.GesGenUniAbv)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GesGenUniDes)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Gescodalma).HasColumnName("GESCODALMA");
            entity.Property(e => e.Gesgensegdec).HasColumnName("GESGENSEGDEC");
            entity.Property(e => e.UniTipoCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GesUnidadGenerica1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GES_UNIDAD_GENERICA", "SISTEMAS_GENEXUS");

            entity.Property(e => e.Gescodalma)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("GESCODALMA");
            entity.Property(e => e.Gescodgepol)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("GESCODGEPOL");
            entity.Property(e => e.Gescodsia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("GESCODSIA");
            entity.Property(e => e.Gesgenactivo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("GESGENACTIVO");
            entity.Property(e => e.Gesgenciucod)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("GESGENCIUCOD");
            entity.Property(e => e.Gesgencodarea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("GESGENCODAREA");
            entity.Property(e => e.Gesgencomcod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GESGENCOMCOD");
            entity.Property(e => e.Gesgendirnom)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("GESGENDIRNOM");
            entity.Property(e => e.Gesgendirnro)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GESGENDIRNRO");
            entity.Property(e => e.Gesgenemail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GESGENEMAIL");
            entity.Property(e => e.Gesgenfusflg)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("GESGENFUSFLG");
            entity.Property(e => e.Gesgenjefges)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("GESGENJEFGES");
            entity.Property(e => e.Gesgenregcod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GESGENREGCOD");
            entity.Property(e => e.Gesgenrgnges)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("GESGENRGNGES");
            entity.Property(e => e.Gesgenrmges)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("GESGENRMGES");
            entity.Property(e => e.Gesgenuniabv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GESGENUNIABV");
            entity.Property(e => e.Gesgenunicod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GESGENUNICOD");
            entity.Property(e => e.Gesgenunides)
                .HasMaxLength(208)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GESGENUNIDES");
            entity.Property(e => e.Tipesppolcod)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIPESPPOLCOD");
            entity.Property(e => e.Unitipocod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNITIPOCOD");
        });

        modelBuilder.Entity<GrupoCriminalMaestro>(entity =>
        {
            entity.HasKey(e => new { e.GrupoCrimCodMa, e.GrupoCrimAsoCodM }).HasName("PK__Grupo_Cr__BFC94F5E4F9D96F5");

            entity.ToTable("Grupo_Criminal_Maestro");

            entity.HasIndex(e => new { e.GrupoCrimCodMa, e.GrupoCrimVig, e.GrupoCrimDscCod, e.GrupoCrimAsoCodM }, "IGRUPO_CRIMINAL_MAESTROI");

            entity.Property(e => e.GrupoCrimDsc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrupoCrimDscCod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrupoCrimIngSis).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gxa0024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GXA0024");

            entity.Property(e => e.AudiWsDeCod)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(15, 0)");
            entity.Property(e => e.AudiWsDeFecha).HasColumnType("datetime");
            entity.Property(e => e.AudiWsDeHh).HasColumnName("AudiWsDeHH");
            entity.Property(e => e.AudiWsDeInst)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsDeMm).HasColumnName("AudiWsDeMM");
            entity.Property(e => e.AudiWsDeRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AudiWsDeRUC");
            entity.Property(e => e.AudiWsDeRut)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsDeRutC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsDeSs).HasColumnName("AudiWsDeSS");
            entity.Property(e => e.AudiWsDeXml)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("AudiWsDeXML");
            entity.Property(e => e.AudiWsDesFault)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AudiWsSexo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HechosGeo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hechos_geo");

            entity.Property(e => e.AgrupacionDelito).HasColumnName("AGRUPACION_DELITO");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido2");
            entity.Property(e => e.CalleDiligencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle_diligencia");
            entity.Property(e => e.ComunaDiligencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_diligencia");
            entity.Property(e => e.CondicionImplicado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("condicion_implicado");
            entity.Property(e => e.DatetimeHecho)
                .HasMaxLength(81)
                .IsUnicode(false)
                .HasColumnName("datetime_hecho");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DV");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.FechNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fech_nacimiento");
            entity.Property(e => e.FechaDecreto)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DECRETO");
            entity.Property(e => e.FechaRecepcionDecreto)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_RECEPCION_DECRETO");
            entity.Property(e => e.GrupoCriminal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo_criminal");
            entity.Property(e => e.IdKey).HasColumnName("ID_KEY");
            entity.Property(e => e.Inpfolio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("inpfolio");
            entity.Property(e => e.LatDiligencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lat_diligencia");
            entity.Property(e => e.LongDiligencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("long_diligencia");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NrodirDiligencia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nrodir_diligencia");
            entity.Property(e => e.RegionDiligencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_diligencia");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("resultado");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad");
        });

        modelBuilder.Entity<Herramienta>(entity =>
        {
            entity.HasKey(e => e.HerrCod).HasName("PK__Herramie__35656ABD17AE438D");

            entity.HasIndex(e => e.HerrMarCod, "IHERRAMIENTAS1");

            entity.Property(e => e.HerrCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HerTipoDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.HerrDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.HerrModelo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisEnvioDec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HIS_ENVIO_DEC");

            entity.Property(e => e.CorrEnvDev).HasColumnName("CORR. ENV/DEV");
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaHoraEnvDev)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA ENV/DEV");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.MaternoEjecuta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO EJECUTA");
            entity.Property(e => e.NombreEjecuta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE EJECUTA");
            entity.Property(e => e.PaternoEjecuta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO EJECUTA");
            entity.Property(e => e.RutEjecuta).HasColumnName("RUT EJECUTA");
        });

        modelBuilder.Entity<Hoja1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hoja1$");

            entity.Property(e => e.ComDes).HasMaxLength(255);
        });

        modelBuilder.Entity<HomCaso>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio }).HasName("PK__Hom_Caso__033BCA9D5C4D869D");

            entity.ToTable("Hom_Caso");

            entity.HasIndex(e => new { e.HomUniCod, e.HomGruCod }, "IHOM_CASO10");

            entity.HasIndex(e => e.HomPerFisId, "IHOM_CASO2");

            entity.HasIndex(e => e.HomCasoFunIns, "IHOM_CASO3");

            entity.HasIndex(e => new { e.HomOrgCod, e.HomOrgDetCod }, "IHOM_CASO4");

            entity.HasIndex(e => e.HomTipHomCod, "IHOM_CASO5");

            entity.HasIndex(e => e.HomCasoComCod, "IHOM_CASO6");

            entity.HasIndex(e => e.HomCasoRegCod, "IHOM_CASO8");

            entity.HasIndex(e => e.HomCasoPrvCod, "IHOM_CASO9");

            entity.Property(e => e.HomCasoCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoCalleDes)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HomCasoDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoFec).HasColumnType("datetime");
            entity.Property(e => e.HomCasoFecCon).HasColumnType("datetime");
            entity.Property(e => e.HomCasoHrsCall).HasColumnType("datetime");
            entity.Property(e => e.HomCasoHrsIns).HasColumnType("datetime");
            entity.Property(e => e.HomCasoHrsUpd).HasColumnType("datetime");
            entity.Property(e => e.HomCasoInsOcu).IsUnicode(false);
            entity.Property(e => e.HomCasoNroDom)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoObs)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoPrvCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HomCasoRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HomCasoUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HomCasoWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HomPerFisId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HomUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<HomCasoEvidencia>(entity =>
        {
            entity.HasKey(e => new { e.HomFolio, e.HomAno, e.HomEviNro }).HasName("PK__Hom_Caso__E4DE634154AC64D5");

            entity.ToTable("Hom_Caso_Evidencias");

            entity.HasIndex(e => new { e.HomAno, e.HomFolio }, "IHOM_CASO_EVIDENCIAS1");

            entity.HasIndex(e => e.HomEviArmCod, "IHOM_CASO_EVIDENCIAS2");

            entity.Property(e => e.HomEviArmCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HomEviArmSerie)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HomEviDesc)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.HomEviFecIns).HasColumnType("datetime");
            entity.Property(e => e.HomEviFecUpd).HasColumnType("datetime");
            entity.Property(e => e.HomEviNue)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HomEviUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomEviUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomEviWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HomEviWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomCasoFiscale>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomFisNro }).HasName("PK__Hom_Caso__644B324E50DBD3F1");

            entity.ToTable("Hom_Caso_Fiscales");

            entity.HasIndex(e => e.HomFisCasoId, "IHOM_CASO_FISCALES2");

            entity.Property(e => e.HomFisCasoFecIni).HasColumnType("datetime");
            entity.Property(e => e.HomFisCasoFecTer).HasColumnType("datetime");
            entity.Property(e => e.HomFisCasoId)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomCasoFoto>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomFotoNro }).HasName("PK__Hom_Caso__8A85B9773DC8FF7D");

            entity.ToTable("Hom_Caso_Fotos");

            entity.Property(e => e.HomFotoDesc)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.HomFotoFchIns).HasColumnType("datetime");
            entity.Property(e => e.HomFotoFchUpd).HasColumnType("datetime");
            entity.Property(e => e.HomFotoFec).HasColumnType("datetime");
            entity.Property(e => e.HomFotoUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomFotoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomFotoWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HomFotoWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomCasoFuncionario>(entity =>
        {
            entity.HasKey(e => new { e.HomFolio, e.HomAno, e.HomFunIdCaso }).HasName("PK__Hom_Caso__078F544314C6E9EA");

            entity.ToTable("Hom_Caso_Funcionarios");

            entity.HasIndex(e => new { e.HomAno, e.HomFolio }, "IHOM_CASO_FUNCIONARIOS1");

            entity.HasIndex(e => e.HomFunIdCaso, "IHOM_CASO_FUNCIONARIOS2");

            entity.HasIndex(e => e.HomFunOrder, "IHOM_FUN_ORDER");
        });

        modelBuilder.Entity<HomCasoImputado>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomImpNro }).HasName("PK__Hom_Caso__144B4BB04475FD0C");

            entity.ToTable("Hom_Caso_Imputados");

            entity.HasIndex(e => e.HomImpFunRut, "IHOM_CASO_IMPUTADOS2");

            entity.HasIndex(e => e.HomImpId, "IHOM_CASO_IMPUTADOS3");

            entity.Property(e => e.HomImpDec).IsUnicode(false);
            entity.Property(e => e.HomImpFecEmp).HasColumnType("datetime");
            entity.Property(e => e.HomImpHrsFin).HasColumnType("datetime");
            entity.Property(e => e.HomImpHrsIni).HasColumnType("datetime");
            entity.Property(e => e.HomImpId)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomCasoMemo>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomMemoFolio }).HasName("PK__Hom_Caso__392F45253FB147EF");

            entity.ToTable("Hom_Caso_Memo");

            entity.HasIndex(e => e.HomMemoFunFirRut, "IHOM_CASO_MEMO1");

            entity.Property(e => e.HomMemoDil).IsUnicode(false);
            entity.Property(e => e.HomMemoFec).HasColumnType("datetime");
            entity.Property(e => e.HomMemoFecIns).HasColumnType("datetime");
            entity.Property(e => e.HomMemoFecUpd).HasColumnType("datetime");
            entity.Property(e => e.HomMemoMat).IsUnicode(false);
            entity.Property(e => e.HomMemoNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomMemoRes).IsUnicode(false);
            entity.Property(e => e.HomMemoUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomMemoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomMemoWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HomMemoWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomCasoMemoDist>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomMemoFolio, e.HomMemoUniDis }).HasName("PK__Hom_Caso__13386F673627DDB5");

            entity.ToTable("Hom_Caso_Memo_Dist");

            entity.HasIndex(e => e.HomMemoUniDis, "IHOM_CASO_MEMO_COMLEVEL11");

            entity.Property(e => e.HomMemoUniDis)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<HomCasoTestigo>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomTesNro }).HasName("PK__Hom_Caso__CF9D38B338102627");

            entity.ToTable("Hom_Caso_Testigos");

            entity.HasIndex(e => e.HomTesId, "IHOM_CASO_TESTIGOS2");

            entity.HasIndex(e => e.HomTesFunRut, "IHOM_CASO_TESTIGOS3");

            entity.Property(e => e.HomTesDec).IsUnicode(false);
            entity.Property(e => e.HomTesFecEmp).HasColumnType("datetime");
            entity.Property(e => e.HomTesHrsFin).HasColumnType("datetime");
            entity.Property(e => e.HomTesHrsIni).HasColumnType("datetime");
            entity.Property(e => e.HomTesId)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomCasoVictima>(entity =>
        {
            entity.HasKey(e => new { e.HomAno, e.HomFolio, e.HomVicNro }).HasName("PK__Hom_Caso__54CC79732C9E737B");

            entity.ToTable("Hom_Caso_Victimas");

            entity.HasIndex(e => e.HomVicId, "IHOM_CASO_VICTIMAS2");

            entity.HasIndex(e => e.HomMovTipCod, "IHOM_CASO_VICTIMAS3");

            entity.HasIndex(e => e.HomModCod, "IHOM_CASO_VICTIMAS4");

            entity.Property(e => e.HomVicAntPol)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.HomVicCausa)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.HomVicDataHom)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.HomVicFecDef).HasColumnType("datetime");
            entity.Property(e => e.HomVicId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HomVicIdenPor)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.HomVicMedInf).IsUnicode(false);
            entity.Property(e => e.HomVicNn)
                .IsUnicode(false)
                .HasColumnName("HomVicNN");
            entity.Property(e => e.HomVicObs).IsUnicode(false);
            entity.Property(e => e.HomVicUbi).IsUnicode(false);
        });

        modelBuilder.Entity<HomFiscale>(entity =>
        {
            entity.HasKey(e => e.HomFisId).HasName("PK__Hom_Fisc__A110180928CDE297");

            entity.ToTable("Hom_Fiscales");

            entity.Property(e => e.HomFisId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HomFisConcat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.HomFisFono1)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HomFisFono2)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HomFisFono3)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HomFisMaterno)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HomFisNombres)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HomFisPaterno)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomGrupoFuncionario>(entity =>
        {
            entity.HasKey(e => new { e.HomUniCod, e.HomGruCod, e.HomGruFunCod }).HasName("PK__Hom_Grup__C92A906524FD51B3");

            entity.ToTable("Hom_Grupo_Funcionarios");

            entity.HasIndex(e => e.HomGruFunCod, "IHOM_GRUPO_FUNCIONARIOS2");

            entity.Property(e => e.HomUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<HomGrupoTrabajo>(entity =>
        {
            entity.HasKey(e => new { e.HomUniCod, e.HomGruCod }).HasName("PK__Hom_Grup__02C8D39520389C96");

            entity.ToTable("Hom_Grupo_Trabajo");

            entity.HasIndex(e => e.HomGruFunJefe, "IHOM_GRUPO_TRABAJO2");

            entity.Property(e => e.HomUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HomGruDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.HomGruFecIns).HasColumnType("datetime");
            entity.Property(e => e.HomGruFecUpd).HasColumnType("datetime");
            entity.Property(e => e.HomGruUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HomGruUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomModalidadHomicidio>(entity =>
        {
            entity.HasKey(e => e.HomModCod).HasName("PK__Hom_Moda__8CDBDC7F10F65906");

            entity.ToTable("Hom_Modalidad_Homicidio");

            entity.Property(e => e.HomModCod).ValueGeneratedNever();
            entity.Property(e => e.HomModDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomMovilHomicidio>(entity =>
        {
            entity.HasKey(e => e.HomMovTipCod).HasName("PK__Hom_Movi__76DF67CD0D25C822");

            entity.ToTable("Hom_Movil_Homicidio");

            entity.Property(e => e.HomMovTipCod).ValueGeneratedNever();
            entity.Property(e => e.HomMovTipDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomTipoHomicidio>(entity =>
        {
            entity.HasKey(e => e.HomTipHomCod).HasName("PK__Hom_Tipo__AF26FA110584A65A");

            entity.ToTable("Hom_Tipo_Homicidio");

            entity.Property(e => e.HomTipHomCod).ValueGeneratedNever();
            entity.Property(e => e.HomTipHomDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HomUnidade>(entity =>
        {
            entity.HasKey(e => e.HomUniCod).HasName("PK__Hom_Unid__2A8CF4271C680BB2");

            entity.ToTable("Hom_Unidades");

            entity.Property(e => e.HomUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasKey(e => e.IdiomaCod).HasName("PK__Idiomas__2454461A1590F0F1");

            entity.HasIndex(e => e.IdiomaNom, "IIDIOMANOM");

            entity.Property(e => e.IdiomaCod).ValueGeneratedNever();
            entity.Property(e => e.IdiomaNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Infraccione>(entity =>
        {
            entity.HasKey(e => e.Infracod).HasName("PK__INFRACCI__F7BBA6E2BE3570A4");

            entity.ToTable("INFRACCIONES");

            entity.Property(e => e.Infracod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("INFRACOD");
            entity.Property(e => e.Infrades)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("INFRADES");
        });

        modelBuilder.Entity<InfractoresBrain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INFRACTORES_BRAIN");

            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NACIMIENTO");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.IdPer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID. PER");
            entity.Property(e => e.Infraccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INFRACCION");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO DECRETO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
        });

        modelBuilder.Entity<InpAmpliacionPlazo>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpAmpFolio }).HasName("PK__INP_Ampl__6E01A4114A39C35A");

            entity.ToTable("INP_Ampliacion_Plazo");

            entity.HasIndex(e => e.InpAmpFisId, "IINP_AMPLIACION_PLAZO2");

            entity.HasIndex(e => e.InpAmpFunRut, "IINP_AMPLIACION_PLAZO3");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpAmpFecFin).HasColumnType("datetime");
            entity.Property(e => e.InpAmpFecIns).HasColumnType("datetime");
            entity.Property(e => e.InpAmpFecUpd).HasColumnType("datetime");
            entity.Property(e => e.InpAmpFecha).HasColumnType("datetime");
            entity.Property(e => e.InpAmpFisId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpAmpFisID");
            entity.Property(e => e.InpAmpObs)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.InpAmpUniIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpAmpUniUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpAmpUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpAmpUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpAmpWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpAmpWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpAnalisisFoco>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpFolioAnalisis }).HasName("PK__InpAnali__BFADCCF1FEB330FB");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpFolioAnalisis)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpAnalisisDate).HasColumnType("datetime");
            entity.Property(e => e.InpAnalisisDateSistema).HasColumnType("datetime");
            entity.Property(e => e.InpAnalisisEscrito).IsUnicode(false);
            entity.Property(e => e.InpAnalisisTitu)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpAnalisisYear).HasColumnName("inpAnalisisYear");
        });

        modelBuilder.Entity<InpCarpetaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.InpCarpNro, e.InpFolio }).HasName("PK__INP_Carp__850BDD4E123F82FA");

            entity.ToTable("INP_Carpeta_Detalle");

            entity.HasIndex(e => e.InpFolio, "IINP_CARPETA_DETALLE1");

            entity.Property(e => e.InpCarpNro).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCarpetaInvestigacion>(entity =>
        {
            entity.HasKey(e => e.InpCarpNro).HasName("PK__INP_Carp__BC78FCFB3EC810AE");

            entity.ToTable("INP_Carpeta_Investigacion");

            entity.HasIndex(e => e.InpCarpUniIns, "IINP_CARPETA_INVESTIGACION1");

            entity.HasIndex(e => new { e.InpCarpFunIns, e.InpCarpUniIns, e.InpCarpFecReaIns }, "IINP_CARPETA_INVESTIGACION3").IsDescending(false, false, true);

            entity.HasIndex(e => e.InpCarpInvFolio, "IINP_CARP_INVERSO")
                .IsUnique()
                .IsDescending();

            entity.HasIndex(e => e.InpCarpRuc, "IINP_CARP_RUC");

            entity.Property(e => e.InpCarpNro).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpCarpDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpCarpDetalle)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.InpCarpFecHch).HasColumnType("datetime");
            entity.Property(e => e.InpCarpFecIns).HasColumnType("datetime");
            entity.Property(e => e.InpCarpFecReaIns).HasColumnType("datetime");
            entity.Property(e => e.InpCarpFecUpd).HasColumnType("datetime");
            entity.Property(e => e.InpCarpFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpCarpInvFolio).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpCarpRuc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpCarpRUC");
            entity.Property(e => e.InpCarpUniAlma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpCarpUniIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCarpUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpCarpWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpCarpWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCaso>(entity =>
        {
            entity.HasKey(e => e.InpFolio).HasName("PK__Inp_Caso__97321B524298A192");

            entity.ToTable("Inp_Caso");

            entity.HasIndex(e => new { e.InpOrgCausaVer, e.TipoOrdenCod, e.InpUniIngCod }, "IINPRUCVER");

            entity.HasIndex(e => new { e.InpFunEndAct, e.InpResEndoso, e.TipoOrdenCod }, "IINP_CASO31");

            entity.HasIndex(e => new { e.InpResFunParte, e.InpUniIngCod, e.InpInvFolio }, "IINP_CASO34").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.InpFunEndAct, e.InpUniIngCod, e.TipoOrdenCod, e.InpInvFolio }, "IINP_CASO35").IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.InpUniIngCod, e.InpResEndoso, e.TipoOrdenCod, e.InpFecReaIng }, "IINP_CASO36").IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.InpUniIngCod, e.InpResEndoso, e.InpFecReaIng, e.TipoOrdenCod }, "IINP_CASO37").IsDescending(false, false, true, false);

            entity.HasIndex(e => new { e.InpFchInforme, e.InpUniIngCod }, "IINP_CASO38");

            entity.HasIndex(e => new { e.InpUniIngCod, e.InpResFecVen }, "IINP_CASO39");

            entity.HasIndex(e => new { e.TipoOrdenCod, e.InpResFecVen }, "IINP_CASO40");

            entity.HasIndex(e => e.InpInvFolio, "IINP_FOLIO_INV").IsDescending();

            entity.HasIndex(e => new { e.InpDenNro, e.TipoOrdenCod }, "IINP_FOLIO_NRODEN").IsDescending(true, false);

            entity.HasIndex(e => new { e.InpOrgCausa, e.TipoOrdenCod, e.InpUniIngCod }, "IINP_RUC");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ApoyoEstatal).HasColumnName("Apoyo_Estatal");
            entity.Property(e => e.CargoGub)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Cargo_Gub");
            entity.Property(e => e.FchIngInstGub).HasColumnType("datetime");
            entity.Property(e => e.InpApmDenun)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InpAppDenun)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InpAutOtDenunExt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCodInstrucVer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpComFis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpConFecHraDel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDebHacDil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDecRelDdhh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpDecRelDDHH");
            entity.Property(e => e.InpDenAlaSeg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InpDenCalleDesAux)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpDenCamSeg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenCerPer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenConFlujPea)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpDenConTranVeh)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpDenDenAno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenDirExa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenDirLat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenDirLong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenDirNpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpDenDirNPD");
            entity.Property(e => e.InpDenDirNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenExtCseg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpDenExtCSeg");
            entity.Property(e => e.InpDenId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpDenID");
            entity.Property(e => e.InpDenIdver)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpDenIDVer");
            entity.Property(e => e.InpDenLetDen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenLugDel).IsUnicode(false);
            entity.Property(e => e.InpDenNro).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.InpDenNroAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenNroDen).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpDenOtrMedSeg)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpDenPaiRecTuri).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.InpDenPerSeg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenSw)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenTieAnt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenTuri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenUniPri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenVillaPob)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpDenun21057)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenunAsoc)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDenunAusencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenunTipoOtr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDenunVif)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpDenunVIF");
            entity.Property(e => e.InpDepCondIlu)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpDetalle).IsUnicode(false);
            entity.Property(e => e.InpDetalleVer).IsUnicode(false);
            entity.Property(e => e.InpDivDenun)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDocDecretoExt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDocDecretoNom)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InpEndFecDoc).HasColumnType("datetime");
            entity.Property(e => e.InpEsEiv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpEsEIV");
            entity.Property(e => e.InpEspTotAva).HasColumnType("money");
            entity.Property(e => e.InpEvalResulcaso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpFacExt)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpFchInforme).HasColumnType("datetime");
            entity.Property(e => e.InpFchUltEndo).HasColumnType("datetime");
            entity.Property(e => e.InpFecCita).HasColumnType("datetime");
            entity.Property(e => e.InpFecCom).HasColumnType("datetime");
            entity.Property(e => e.InpFecFirEle).HasColumnType("datetime");
            entity.Property(e => e.InpFecHecho1).HasColumnType("datetime");
            entity.Property(e => e.InpFecHecho2).HasColumnType("datetime");
            entity.Property(e => e.InpFecReaIng).HasColumnType("datetime");
            entity.Property(e => e.InpFecReaUpd).HasColumnType("datetime");
            entity.Property(e => e.InpFecRecep).HasColumnType("datetime");
            entity.Property(e => e.InpFecRecepVer).HasColumnType("datetime");
            entity.Property(e => e.InpFecha).HasColumnType("datetime");
            entity.Property(e => e.InpFoco).HasColumnType("numeric(8, 0)");
            entity.Property(e => e.InpFolMinPub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InpFolSisPjud)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpFolSisPJud");
            entity.Property(e => e.InpFolUniNac)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpFormDecExtInf).IsUnicode(false);
            entity.Property(e => e.InpFunIng)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpHashDoc).IsUnicode(false);
            entity.Property(e => e.InpHorHecho1).HasColumnType("datetime");
            entity.Property(e => e.InpHorHecho2)
                .HasColumnType("datetime")
                .HasColumnName("INpHorHecho2");
            entity.Property(e => e.InpHoraCom).HasColumnType("datetime");
            entity.Property(e => e.InpHoraRecep).HasColumnType("datetime");
            entity.Property(e => e.InpHoraRecepVer).HasColumnType("datetime");
            entity.Property(e => e.InpIdFolMp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InpIdFolMP");
            entity.Property(e => e.InpIncDatGubInf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpInfIntercep).IsUnicode(false);
            entity.Property(e => e.InpInfoF3nna)
                .IsUnicode(false)
                .HasColumnName("InpInfoF3NNA");
            entity.Property(e => e.InpInfoF4nna)
                .IsUnicode(false)
                .HasColumnName("InpInfoF4NNA");
            entity.Property(e => e.InpInvFolio).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpMedDenunExt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpModInfra)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpModOpeGen).IsUnicode(false);
            entity.Property(e => e.InpMonAdeu).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.InpMonCan).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.InpMotSinEndo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpNoComObs).IsUnicode(false);
            entity.Property(e => e.InpNomDenun)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InpNroDoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpObs).IsUnicode(false);
            entity.Property(e => e.InpObsPerPro).IsUnicode(false);
            entity.Property(e => e.InpObsVer).IsUnicode(false);
            entity.Property(e => e.InpOrdInvCierreDef)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpOrgCausa)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpOrgCausaVer)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpOrgRit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpOrgRitVer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpOrgRol)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpOtrLugCon)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpPideCtaFecFin).HasColumnType("datetime");
            entity.Property(e => e.InpPrcSanExp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpProAdoUni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpRelatoHecho).IsUnicode(false);
            entity.Property(e => e.InpRepreCorreo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InpRepreDenPdi)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InpRepreDomUn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpRepreDomi)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InpRepreNomPdi)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InpRepreTelf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpResAmpliacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpResDecAsoc)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpResExhorto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpResFecCancel).HasColumnType("datetime");
            entity.Property(e => e.InpResFecVen).HasColumnType("datetime");
            entity.Property(e => e.InpResParteLet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpResParteNro).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpResPideCta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpResPlasasoc).HasColumnName("InpResPLASAsoc");
            entity.Property(e => e.InpResulVif)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.InpRutDenun)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpSafito)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpSugVif).IsUnicode(false);
            entity.Property(e => e.InpTieneFacul)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipDelFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipDocDenun)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipDocIng)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipDocIngVer)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipOrdExtena)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipReso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTipoAso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpTpDenunExt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpUniAlmaIngCod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpUniCreaDoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpUniIngCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpWrkIng)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Inpdenlugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NomAcomNna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NomAcomNNA");
            entity.Property(e => e.NomProtecNna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NomProtecNNA");
            entity.Property(e => e.UniIdtem)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UniIDTem");
            entity.Property(e => e.UniLdeCod).HasColumnName("UniLDeCod");
        });

        modelBuilder.Entity<InpCasoAbandono>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.AbanCod }).HasName("PK__INP_Caso__A4071D7B6EE13824");

            entity.ToTable("INP_Caso_Abandonos");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.AbanDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpAbanFchIns).HasColumnType("datetime");
            entity.Property(e => e.InpAbanFchUpd).HasColumnType("datetime");
            entity.Property(e => e.InpAbanFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpAbanFunIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpAbanFunIP");
            entity.Property(e => e.InpAbanFunIpupd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpAbanFunIPUpd");
            entity.Property(e => e.InpAbanFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpAbanObs)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoArma>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpArmFolio }).HasName("PK__INP_Caso__5D123C506ADB9D16");

            entity.ToTable("INP_Caso_Armas");

            entity.HasIndex(e => e.TipArmCod, "IINP_CASO_ARMAS2");

            entity.HasIndex(e => e.MarArmCod, "IINP_CASO_ARMAS3");

            entity.HasIndex(e => e.InpArmMonCod, "IINP_CASO_ARMAS4");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpArmEnc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmFecInc).HasColumnType("datetime");
            entity.Property(e => e.InpArmFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpArmFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpArmHrsIns).HasColumnType("datetime");
            entity.Property(e => e.InpArmHrsUpd).HasColumnType("datetime");
            entity.Property(e => e.InpArmIpins)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpArmIPIns");
            entity.Property(e => e.InpArmIpupd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpArmIPUpd");
            entity.Property(e => e.InpArmModelo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InpArmMonCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmNroSer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmNue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("InpArmNUE");
            entity.Property(e => e.InpArmObs)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpArmUniIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmUniUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaIns)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<InpCasoConclusione>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpClcFolio }).HasName("PK__INP_Caso__EF3FEA035B995986");

            entity.ToTable("INP_Caso_Conclusiones");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpClcCorrDel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpClcTexto).IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoDelitosAsociado>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpDelCod }).HasName("PK__Inp_Caso__1F1C911C0BA79404");

            entity.ToTable("Inp_Caso_Delitos_Asociados");

            entity.HasIndex(e => e.InpDelCod, "INP_CASO_DELITOS_ASOCIADOS3");

            entity.HasIndex(e => new { e.InpFolio, e.InpDelPrin }, "INP_CASO_DELITOS_ASOCIADOS4").IsDescending(false, true);

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDelPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpModOpeCirDet).IsUnicode(false);
            entity.Property(e => e.InpModOpeDelAso).IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoDiligencia>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpDilNro }).HasName("PK__Inp_Caso__9F0FF4CF3726EEE6");

            entity.ToTable("Inp_Caso_Diligencias");

            entity.HasIndex(e => new { e.InpDiliOrgCod, e.InpDiliOrgDetNro }, "IINP_CASO_DILIGENCIAS3");

            entity.HasIndex(e => e.InpDiliTipDoc, "IINP_CASO_DILIGENCIAS4");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDiliFec).HasColumnType("datetime");
            entity.Property(e => e.InpDiliHora).HasColumnType("datetime");
            entity.Property(e => e.InpDiliNroDoc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpDiliNumInf).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.InpDiliRes).IsUnicode(false);
            entity.Property(e => e.InpDiliTipDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDiliTxt).IsUnicode(false);
            entity.Property(e => e.InpDiliUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Inpdilifunjef).HasColumnName("INPDILIFUNJEF");
        });

        modelBuilder.Entity<InpCasoDroga>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.DrogCod, e.InpDrogFolio }).HasName("PK__Inp_Caso__FA7DB75E5BF880E2");

            entity.ToTable("Inp_Caso_Drogas");

            entity.HasIndex(e => e.InpDrogComCodOri, "IINP_CASO_DROGAS");

            entity.HasIndex(e => e.InpDrogComCodDes, "IINP_CASO_DROGAS1");

            entity.HasIndex(e => e.InpDrogPaisOri, "IINP_CASO_DROGAS2");

            entity.HasIndex(e => e.InpDrogPaisDes, "IINP_CASO_DROGAS3");

            entity.HasIndex(e => e.OculDrogCod, "IINP_CASO_DROGAS4");

            entity.HasIndex(e => e.MedUniCod, "IINP_CASO_DROGAS5");

            entity.HasIndex(e => e.DrogCod, "IINP_CASO_DROGAS6");

            entity.HasIndex(e => e.InpDroEntDes, "IINP_CASO_DROGAS8");

            entity.HasIndex(e => e.InpDroPasFronDet, "IINP_CASO_DROGAS9");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDrogFolio).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.InpDroCoor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDroPasFron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDroPasFronDet)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDrogCan).HasColumnType("money");
            entity.Property(e => e.InpDrogComCodDes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDrogComCodOri)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDrogFchIns).HasColumnType("datetime");
            entity.Property(e => e.InpDrogFchUpd).HasColumnType("datetime");
            entity.Property(e => e.InpDrogFec).HasColumnType("datetime");
            entity.Property(e => e.InpDrogFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpDrogFunIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpDrogFunIP");
            entity.Property(e => e.InpDrogFunIpupd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpDrogFunIPUpd");
            entity.Property(e => e.InpDrogFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpDrogNue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("InpDrogNUE");
            entity.Property(e => e.InpDrogObs).IsUnicode(false);
            entity.Property(e => e.InpDrogVal).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.MedUniCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<InpCasoDrogasDelAso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.DrogCod, e.InpDrogFolio, e.InpDroDelAso }).HasName("PK__Inp_Caso__E43A8F26517AF26F");

            entity.ToTable("Inp_Caso_Drogas_DelAso");

            entity.HasIndex(e => e.InpDroDelAso, "ITDINP_CASO_DROGASINP_CASO_DR1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDrogFolio).HasColumnType("decimal(12, 0)");
        });

        modelBuilder.Entity<InpCasoEndoso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpEndNro }).HasName("PK__INP_CASO__FBF9B2043AF77FCA");

            entity.ToTable("INP_CASO_ENDOSO");

            entity.HasIndex(e => e.InpFolio, "IINP_CASO_ENDOSO1");

            entity.HasIndex(e => e.InpEndFunAsg, "IINP_CASO_ENDOSO2");

            entity.HasIndex(e => e.InpEndFunRec, "IINP_CASO_ENDOSO3");

            entity.HasIndex(e => e.InpEndResDocTipo, "IINP_CASO_ENDOSO4");

            entity.HasIndex(e => e.InpEndUniEnd, "IINP_CASO_ENDOSO5");

            entity.HasIndex(e => new { e.InpEndFunRec, e.InpFolio, e.InpEndNro, e.InpEndAmplia }, "IINP_CASO_ENDOSO6").IsDescending(false, true, true, false);

            entity.HasIndex(e => e.InpFolio, "IINP_CASO_FOLIO_DES").IsDescending();

            entity.HasIndex(e => new { e.InpEndFec, e.InpEndFunIns }, "INP_CASO_ENDOSO7").IsDescending(true, false);

            entity.HasIndex(e => new { e.InpFolio, e.InpEndNro }, "INP_CASO_FUNEND").IsDescending(false, true);

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpEndAmplia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEndFec).HasColumnType("datetime");
            entity.Property(e => e.InpEndFecCan).HasColumnType("datetime");
            entity.Property(e => e.InpEndFecIns).HasColumnType("datetime");
            entity.Property(e => e.InpEndFecVen).HasColumnType("datetime");
            entity.Property(e => e.InpEndFunCan)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpEndFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpEndObsEnd)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.InpEndResDocAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEndResDocFec).HasColumnType("datetime");
            entity.Property(e => e.InpEndResDocLet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEndResDocNro).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpEndResDocTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEndResGenInf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEndUniAlmaEnd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpEndUniEnd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEndWrkCan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpEndWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpNumEndoso)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoEspeciesDelAso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpEspFolio, e.InpEspDelAso }).HasName("PK__Inp_caso__BFED5C010035E158");

            entity.ToTable("Inp_caso_especies_DelAso");

            entity.HasIndex(e => e.InpEspDelAso, "IINP_CASO_ESPECIESDELASO");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoEspeciesFotografia>(entity =>
        {
            entity.HasKey(e => new { e.Inpfolio, e.Inpespfolio, e.Inpespfotocorr }).HasName("PK__INP_CASO__82A84B4F017131E4");

            entity.ToTable("INP_CASO_ESPECIES_FOTOGRAFIAS");

            entity.Property(e => e.Inpfolio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("INPFOLIO");
            entity.Property(e => e.Inpespfolio)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("INPESPFOLIO");
            entity.Property(e => e.Inpespfotocorr)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("INPESPFOTOCORR");
            entity.Property(e => e.Inpespfoto)
                .HasColumnType("image")
                .HasColumnName("INPESPFOTO");
            entity.Property(e => e.Inpespfotofch)
                .HasColumnType("datetime")
                .HasColumnName("INPESPFOTOFCH");
            entity.Property(e => e.Inpespfotovig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INPESPFOTOVIG");
        });

        modelBuilder.Entity<InpCasoEspecy>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpEspFolio }).HasName("PK__Inp_Caso__2AFE3A262F85CD1E");

            entity.ToTable("Inp_Caso_Especies");

            entity.HasIndex(e => e.MedUniCod, "IINP_CASO_ESPECIES2");

            entity.HasIndex(e => new { e.InpEspTipo, e.InpEspCod }, "IINP_CASO_ESPECIES3");

            entity.HasIndex(e => e.InpEspMonCod, "IINP_CASO_ESPECIES4");

            entity.HasIndex(e => e.UniEstCod, "IINP_CASO_ESPECIES5");

            entity.HasIndex(e => new { e.InpEspTxt, e.InpEspStatus, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESIX").IsDescending(false, false, true, false);

            entity.HasIndex(e => new { e.InpFolio, e.UniEspImeicel, e.InpEspStatus }, "IINP_CASO_ESPECIESVI").IsDescending(true, false, false);

            entity.HasIndex(e => new { e.InpEspStatus, e.InpEspTipo, e.InpEspCod, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESVII").IsDescending(false, false, false, true, false);

            entity.HasIndex(e => new { e.InpEspDes, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESVIII").IsDescending(false, true, false);

            entity.HasIndex(e => new { e.InpEspVal, e.InpEspCant, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESX").IsDescending(true, false, true, false);

            entity.HasIndex(e => new { e.UniEspNroCha, e.UniEspNroMot, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESXI").IsDescending(false, false, true, false);

            entity.HasIndex(e => new { e.InpEspSerie, e.InpEspGrab, e.InpEspVal, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESXII").IsDescending(false, false, false, true, false);

            entity.HasIndex(e => new { e.InpFolio, e.InpEspFolio, e.InpEspTipo, e.UniEstCod, e.InpEspStatus, e.InpEspCant, e.InpEspVal, e.InpEspCod }, "IINP_CASO_ESPECIESXIII").IsDescending(true, false, false, false, false, false, false, false);

            entity.HasIndex(e => new { e.InpTipOrDenCod, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESXIV").IsDescending(false, true, false);

            entity.HasIndex(e => new { e.InpRegCod, e.InpUnidadCod, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESXV").IsDescending(false, false, true, false);

            entity.HasIndex(e => new { e.InpUnidadCod, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESXVI").IsDescending(false, true, false);

            entity.HasIndex(e => new { e.InpEspStatus, e.InpEspTipo, e.InpRegCod, e.InpUnidadCod, e.InpEspTxt, e.InpFolio, e.InpEspFolio }, "IINP_CASO_ESPECIESXVII").IsDescending(false, false, false, false, false, true, false);

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpEspCant).HasColumnType("money");
            entity.Property(e => e.InpEspCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEspDes)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.InpEspDsc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpEspEnc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEspFecInc).HasColumnType("datetime");
            entity.Property(e => e.InpEspGrab)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpEspHraInc).HasColumnType("datetime");
            entity.Property(e => e.InpEspMonCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEspNue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("InpEspNUE");
            entity.Property(e => e.InpEspObs).IsUnicode(false);
            entity.Property(e => e.InpEspRecu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEspSerie)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.InpEspTxt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpEspVal).HasColumnType("money");
            entity.Property(e => e.InpRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpUnidadCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MedUniCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniEspEntPor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniEspImeicel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UniEspIMEICel");
            entity.Property(e => e.UniEspLevPor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniEspMacAddress)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UniEspNroCha)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UniEspNroMot)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UniEspRemitida)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniEspSdtcanEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTCanEnc");
            entity.Property(e => e.UniEspSdtestEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTEstEnc");
            entity.Property(e => e.UniEspSdtingEnc)
                .IsUnicode(false)
                .HasColumnName("UniEspSDTIngEnc");
        });

        modelBuilder.Entity<InpCasoEval>(entity =>
        {
            entity.HasKey(e => e.InpCodigo).HasName("PK__INP_Caso__B9C0A6BE5B2F4532");

            entity.ToTable("INP_Caso_Eval");

            entity.HasIndex(e => new { e.InpFolio, e.InpCodigo }, "IINP_CASO_EVAL2").IsDescending(false, true);

            entity.HasIndex(e => new { e.InpFolio, e.InpEval }, "IINP_CASO_EVAL3");

            entity.HasIndex(e => new { e.InpFolio, e.InpFechaEval, e.InpEval }, "IINP_CASO_EVAL4").IsDescending(false, true, false);

            entity.Property(e => e.InpComentario)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioBud)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InpEvalResul)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpFecReaEval).HasColumnType("datetime");
            entity.Property(e => e.InpFechaDenuncia).HasColumnType("datetime");
            entity.Property(e => e.InpFechaEval).HasColumnType("datetime");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpTipoResOrDa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpTipoResOrDA");
            entity.Property(e => e.InpUniIngCodEval)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<InpCasoFuncionario>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpCasoFun }).HasName("PK__Inp_Caso__35BECA645F9EF494");

            entity.ToTable("Inp_Caso_Funcionarios");

            entity.HasIndex(e => e.InpCasoFun, "IINP_CASO_FUNCIONARIOS2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoOrdRelacion>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpFolOrdRel }).HasName("PK__Inp_caso__F6369C9C3A6282ED");

            entity.ToTable("Inp_caso_ord_relacion");

            entity.HasIndex(e => e.InpFolOrdRel, "IINP_CASO_ORD_RELACION2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpFolOrdRel)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoSecuestro>(entity =>
        {
            entity.HasKey(e => new { e.InpSecNro, e.InpFolio }).HasName("PK__inp_Caso__A7D6C047432CD318");

            entity.ToTable("inp_Caso_Secuestro");

            entity.HasIndex(e => e.InpFolio, "ITINP_CASO_SECUESTRO1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSecuContenido).HasMaxLength(4000);
            entity.Property(e => e.InpSecuDenNro).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.InpSecuFecha).HasColumnType("datetime");
            entity.Property(e => e.InpSecuFono).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.InpSecuHora).HasColumnType("datetime");
            entity.Property(e => e.InpSecuMedio)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoSecuestroExigencium>(entity =>
        {
            entity.HasKey(e => new { e.InpSecNro, e.InpFolio, e.InpSecuExigenId }).HasName("PK__inp_Caso__C81BFF9B3A978D17");

            entity.ToTable("inp_Caso_SecuestroExigencia");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSecuExigenCant).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.InpSecuExigenDetalle)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.InpSecuExigenTipo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCasoSs>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSsfolio, e.InpSucfolio }).HasName("PK__INP_CASO__2805695F5F008534");

            entity.ToTable("INP_CASO_SS");

            entity.HasIndex(e => e.InpSsfisId, "IINP_CASO_SS1");

            entity.HasIndex(e => new { e.InpFolio, e.InpSucfolio }, "IINP_CASO_SS13");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSsfolio).HasColumnName("InpSSFolio");
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.InpEspDest)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpEspSsnue)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpEspSSNue");
            entity.Property(e => e.InpRsscaryGrad)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpRSSCaryGrad");
            entity.Property(e => e.InpRssinstitucion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("InpRSSInstitucion");
            entity.Property(e => e.InpRssnomb)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("InpRSSNomb");
            entity.Property(e => e.InpSsaisCer).HasColumnName("InpSSAisCer");
            entity.Property(e => e.InpSsaltTxt)
                .IsUnicode(false)
                .HasColumnName("InpSSAltTxt");
            entity.Property(e => e.InpSsalterado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSAlterado");
            entity.Property(e => e.InpSscantEsp).HasColumnName("InpSSCantEsp");
            entity.Property(e => e.InpSsconAdm)
                .IsUnicode(false)
                .HasColumnName("InpSSConAdm");
            entity.Property(e => e.InpSsconAdmHmAct)
                .HasColumnType("money")
                .HasColumnName("InpSSConAdmHmAct");
            entity.Property(e => e.InpSsconAdmTmAct)
                .HasColumnType("money")
                .HasColumnName("InpSSConAdmTmAct");
            entity.Property(e => e.InpSsconTraPea)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSConTraPea");
            entity.Property(e => e.InpSsconTraVeh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSConTraVeh");
            entity.Property(e => e.InpSscondIlum)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSCondIlum");
            entity.Property(e => e.InpSsdepEsp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSDepEsp");
            entity.Property(e => e.InpSsdesEsp).HasColumnName("InpSSDesEsp");
            entity.Property(e => e.InpSsdesEspDet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSDesEspDet");
            entity.Property(e => e.InpSsdesGen)
                .IsUnicode(false)
                .HasColumnName("InpSSDesGen");
            entity.Property(e => e.InpSseleIntCri)
                .IsUnicode(false)
                .HasColumnName("InpSSEleIntCri");
            entity.Property(e => e.InpSsempTesOid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSEmpTesOid");
            entity.Property(e => e.InpSsempTesPre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSEmpTesPre");
            entity.Property(e => e.InpSsespLev)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSEspLev");
            entity.Property(e => e.InpSseviLev)
                .IsUnicode(false)
                .HasColumnName("InpSSEviLev");
            entity.Property(e => e.InpSseviRelInv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSEviRelInv");
            entity.Property(e => e.InpSsexisAso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSExisASO");
            entity.Property(e => e.InpSsexisCerPer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSExisCerPer");
            entity.Property(e => e.InpSsexisGcs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSExisGCS");
            entity.Property(e => e.InpSsexisPseg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSExisPSeg");
            entity.Property(e => e.InpSsfecConCurr)
                .HasColumnType("datetime")
                .HasColumnName("InpSSFecConCurr");
            entity.Property(e => e.InpSsfecIns)
                .HasColumnType("datetime")
                .HasColumnName("InpSSFecIns");
            entity.Property(e => e.InpSsfecUpd)
                .HasColumnType("datetime")
                .HasColumnName("InpSSFecUpd");
            entity.Property(e => e.InpSsfijFot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSFijFot");
            entity.Property(e => e.InpSsfisId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpSSFisID");
            entity.Property(e => e.InpSsfunIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpSSFunIns");
            entity.Property(e => e.InpSsfunUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpSSFunUpd");
            entity.Property(e => e.InpSshrsFinConCurr)
                .HasColumnType("datetime")
                .HasColumnName("InpSSHrsFinConCurr");
            entity.Property(e => e.InpSshrsIniConCurr)
                .HasColumnType("datetime")
                .HasColumnName("InpSSHrsIniConCurr");
            entity.Property(e => e.InpSsintPol)
                .IsUnicode(false)
                .HasColumnName("InpSSIntPol");
            entity.Property(e => e.InpSslevArmas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLevArmas");
            entity.Property(e => e.InpSslevEspSus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLevEspSus");
            entity.Property(e => e.InpSslevGrabSeg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLevGrabSeg");
            entity.Property(e => e.InpSslevHueDac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLevHueDac");
            entity.Property(e => e.InpSslevHuePla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLevHuePla");
            entity.Property(e => e.InpSslevInsEmpCd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLevInsEmpCD");
            entity.Property(e => e.InpSsminFinConCurr).HasColumnName("InpSSMinFinConCurr");
            entity.Property(e => e.InpSsminIniConCurr).HasColumnName("InpSSMinIniConCurr");
            entity.Property(e => e.InpSsmodus)
                .IsUnicode(false)
                .HasColumnName("InpSSModus");
            entity.Property(e => e.InpSsnroAnexoPeri)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("InpSSNroAnexoPeri");
            entity.Property(e => e.InpSsobs)
                .IsUnicode(false)
                .HasColumnName("InpSSObs");
            entity.Property(e => e.InpSsotraMedSeg)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSOtraMedSeg");
            entity.Property(e => e.InpSspatProxSs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSPatProxSS");
            entity.Property(e => e.InpSsperSol)
                .IsUnicode(false)
                .HasColumnName("InpSSPerSol");
            entity.Property(e => e.InpSspericias)
                .IsUnicode(false)
                .HasColumnName("InpSSPericias");
            entity.Property(e => e.InpSsproAlt)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSProAlt");
            entity.Property(e => e.InpSsproAltMot)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSProAltMot");
            entity.Property(e => e.InpSsproteDet)
                .IsUnicode(false)
                .HasColumnName("InpSSProteDet");
            entity.Property(e => e.InpSsprotegido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSProtegido");
            entity.Property(e => e.InpSsresguardo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSResguardo");
            entity.Property(e => e.InpSssolPerEsp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSSolPerEsp");
            entity.Property(e => e.InpSstipo).HasColumnName("InpSSTipo");
            entity.Property(e => e.InpSstomDecFun)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSTomDecFun");
            entity.Property(e => e.InpSswrkIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpSSWrkIns");
            entity.Property(e => e.InpSswrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpSSWrkUpd");
        });

        modelBuilder.Entity<InpCasoSsDetalle>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSsfolio, e.InpSucfolio, e.InpSsperFunRut }).HasName("PK__INP_Caso__6CA6CD90B7573689");

            entity.ToTable("INP_Caso_SS_Detalles");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSsfolio).HasColumnName("InpSSFolio");
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.InpSsperFunRut).HasColumnName("InpSSPerFunRut");
            entity.Property(e => e.InpSsperFunCargo).HasColumnName("InpSSPerFunCargo");
            entity.Property(e => e.InpSsperFunFinTrab)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSPerFunFinTrab");
            entity.Property(e => e.InpSsperFunFinTrabMot)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSPerFunFinTrabMot");
            entity.Property(e => e.InpSsperFunFinTrabMotDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSPerFunFinTrabMotDes");
            entity.Property(e => e.InpSsperFunTipo).HasColumnName("InpSSPerFunTipo");
            entity.Property(e => e.InpSsperFunUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSPerFunUniCod");
        });

        modelBuilder.Entity<InpCasoVehiculo>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpVehFolio }).HasName("PK__Inp_Caso__5BCB9EC0087B4945");

            entity.ToTable("Inp_Caso_Vehiculos");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpVehActEnt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehClonado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehEnc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehFec).HasColumnType("datetime");
            entity.Property(e => e.InpVehFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpVehFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpVehHrsIns).HasColumnType("datetime");
            entity.Property(e => e.InpVehHrsUpd).HasColumnType("datetime");
            entity.Property(e => e.InpVehIpins)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpVehIPIns");
            entity.Property(e => e.InpVehIpupd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpVehIPUpd");
            entity.Property(e => e.InpVehModelo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InpVehMonCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehNroCha)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehNroMot)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehNue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("InpVehNUE");
            entity.Property(e => e.InpVehObs)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.InpVehPatente)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InpVehUsDel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVehValor).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.TvhCod).HasColumnName("tvhCod");
        });

        modelBuilder.Entity<InpCausa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("inp_Causas");

            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Identificador)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("identificador");
            entity.Property(e => e.OrganismoDetalleId).HasColumnName("organismoDetalleId");
            entity.Property(e => e.OrganismoId).HasColumnName("organismoId");
            entity.Property(e => e.Vigente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vigente");
        });

        modelBuilder.Entity<InpCharla>(entity =>
        {
            entity.HasKey(e => e.InpCharFolio).HasName("PK__INP_Char__E253BD8227E4AB56");

            entity.ToTable("INP_Charlas");

            entity.HasIndex(e => e.InpCharFunCargo, "IINP_CHARLAS1");

            entity.HasIndex(e => new { e.InpCharOrgCod, e.InpCharOrgDetCod }, "IINP_CHARLAS2");

            entity.HasIndex(e => e.InpCharUniCod, "IINP_CHARLAS3");

            entity.HasIndex(e => new { e.InpCharAnio, e.InpCharMes }, "IINP_CHARLA_ANIO");

            entity.HasIndex(e => e.InpCharInvFolio, "IINP_CHARLA_INV")
                .IsUnique()
                .IsDescending();

            entity.Property(e => e.InpCharFolio).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpCharDetalle)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.InpCharFecIns).HasColumnType("datetime");
            entity.Property(e => e.InpCharFecUpd).HasColumnType("datetime");
            entity.Property(e => e.InpCharFecha).HasColumnType("datetime");
            entity.Property(e => e.InpCharFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpCharFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpCharInvFolio).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.InpCharUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCharWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpCharWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpCondicionPersona>(entity =>
        {
            entity.HasKey(e => e.UperCondCod).HasName("PK__INP_Cond__38959BD75ADA3F77");

            entity.ToTable("INP_Condicion_Persona");

            entity.Property(e => e.UperCondCod)
                .ValueGeneratedNever()
                .HasColumnName("UPerCondCod");
            entity.Property(e => e.UperConDenImp).HasColumnName("UPerConDenImp");
            entity.Property(e => e.UperConDenTestigo).HasColumnName("UPerConDenTestigo");
            entity.Property(e => e.UperConEmpadrona).HasColumnName("UPerConEmpadrona");
            entity.Property(e => e.UperCondDenuncia).HasColumnName("UPerCondDenuncia");
            entity.Property(e => e.UperCondDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPerCondDes");
            entity.Property(e => e.UperCondVictima).HasColumnName("UPerCondVictima");
            entity.Property(e => e.UperCondVig).HasColumnName("UPerCondVig");
        });

        modelBuilder.Entity<InpControlIdentidad>(entity =>
        {
            entity.HasKey(e => e.InpCtrlFolio).HasName("PK__INP_Cont__5AF0745961873D06");

            entity.ToTable("INP_Control_Identidad");

            entity.HasIndex(e => new { e.InpCtrlAnio, e.InpCtrlMes }, "IINP_CONTROL_ANIO");

            entity.HasIndex(e => e.InpCtrlComCod, "IINP_CONTROL_IDENTIDAD1");

            entity.HasIndex(e => e.InpCtrlFunRut, "IINP_CONTROL_IDENTIDAD2");

            entity.HasIndex(e => e.InpCtrlUniCod, "IINP_CONTROL_IDENTIDAD3");

            entity.HasIndex(e => e.InpCtrlInvFolio, "IINP_CONTROL_INV_FOLIO")
                .IsUnique()
                .IsDescending();

            entity.Property(e => e.InpCtrlFolio).ValueGeneratedNever();
            entity.Property(e => e.InpCtrlComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCtrlDetalles)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.InpCtrlFecha).HasColumnType("datetime");
            entity.Property(e => e.InpCtrlFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpCtrlFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpCtrlHora).HasColumnType("datetime");
            entity.Property(e => e.InpCtrlHrsIns).HasColumnType("datetime");
            entity.Property(e => e.InpCtrlHrsUpd).HasColumnType("datetime");
            entity.Property(e => e.InpCtrlUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCtrlUniIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCtrlUniUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpCtrlWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpCtrlWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpGrupoDelito>(entity =>
        {
            entity.HasKey(e => new { e.DelCod, e.DelcodGrupo }).HasName("PK__inpGrupo__43044610904F5633");

            entity.ToTable("inpGrupoDelito");

            entity.HasIndex(e => new { e.DelGrupoDesc, e.DelcodGrupo, e.DelCod }, "idx_Nonclustered_desc_cod").HasFillFactor(100);

            entity.Property(e => e.DelCod).HasColumnName("delCod");
            entity.Property(e => e.DelcodGrupo).HasColumnName("delcodGrupo");
            entity.Property(e => e.DelGrupoActivo).HasColumnName("delGrupoActivo");
            entity.Property(e => e.DelGrupoDesc)
                .HasMaxLength(255)
                .HasColumnName("delGrupoDesc");
        });

        modelBuilder.Entity<InpMarcaEnvioBud>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpEnvioTry }).HasName("PK__InpMarca__09F7E2397E6BD98D");

            entity.ToTable("InpMarcaEnvioBud");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioBud)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioError)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioMsg)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioResp).IsUnicode(false);
            entity.Property(e => e.InpEnvioSis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEnvioXml).IsUnicode(false);
            entity.Property(e => e.InpMarcaFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<InpMarcaEnvioBudPaso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InpMarcaEnvioBudPaso");

            entity.Property(e => e.InpEnvioBud)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioError)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioMsg)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpEnvioResp).IsUnicode(false);
            entity.Property(e => e.InpEnvioXml).IsUnicode(false);
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpMarcaFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<InpModusOperandi>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpModFolio }).HasName("PK__INP_Modu__DAF7DDBEC1577658");

            entity.ToTable("INP_Modus_Operandi");

            entity.HasIndex(e => new { e.ModOpCod, e.ModOpDetCod }, "IINP_MODUS_OPERANDI2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpModObs)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.InpModOpeMarPer)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpNumeradorDocumento>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.InpNumAnio }).HasName("PK__INP_Nume__CD415BA184CC8F76");

            entity.ToTable("INP_Numerador_Documentos");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<InpOcularSitioSuceso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InsOcuCor }).HasName("PK__Inp_ocul__26F769CE1CDB8018");

            entity.ToTable("Inp_ocular_sitio_suceso");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InsOcuDet).IsUnicode(false);
        });

        modelBuilder.Entity<InpOficialesDetencion>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpPerFolio, e.InpOfiDetRut }).HasName("PK__INP_Ofic__122BB4B799609058");

            entity.ToTable("INP_Oficiales_Detencion");

            entity.HasIndex(e => e.InpOfiDetRut, "IINP_OFICIALES_DETENCION2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpOfiUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerDetId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPerDetID");
        });

        modelBuilder.Entity<InpPeritajeProTecDelAso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InsperiPcor, e.InsperiPddelaso }).HasName("PK__Inp_Peri__C8C1A77175B852E5");

            entity.ToTable("Inp_Peritaje_Pro_TecDelAso");

            entity.HasIndex(e => e.InsperiPddelaso, "IINP_PERITAJE_PRO_TECDELASO3");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InsperiPcor).HasColumnName("InsperiPCor");
            entity.Property(e => e.InsperiPddelaso).HasColumnName("InsperiPDDelaso");
        });

        modelBuilder.Entity<InpPeritajeProcTec>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InsperiPcor }).HasName("PK__Inp_peri__9BBBE58798F730F3");

            entity.ToTable("Inp_peritaje_proc_tec");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InsperiPcor).HasColumnName("InsperiPCor");
            entity.Property(e => e.InsperiPdet)
                .IsUnicode(false)
                .HasColumnName("InsperiPDet");
        });

        modelBuilder.Entity<InpPersonasDelito>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpDelCod, e.InpDelPerId }).HasName("PK__Inp_Pers__09CD29D506E2DEE7");

            entity.ToTable("Inp_Personas_Delitos");

            entity.HasIndex(e => e.InpDelPerId, "INP_PERSONAS_DELITOS1");

            entity.HasIndex(e => e.InpDelCond, "INP_PERSONAS_DELITOS3");

            entity.HasIndex(e => new { e.InpFolio, e.InpDelPerId }, "INP_PERSONAS_DELITOS4");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDelPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpDelPerID");
        });

        modelBuilder.Entity<InpPersonasImplicada>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpPerFolio }).HasName("PK__Inp_Pers__DEBC863B8EF08010");

            entity.ToTable("Inp_Personas_Implicadas");

            entity.HasIndex(e => e.InpPerNroDoc, "IINP_DOC_IMPLICADA");

            entity.HasIndex(e => e.InpPerInvConCat, "IINP_INV_IMPLICADA").IsDescending();

            entity.HasIndex(e => e.InpPerNomConCat, "IINP_NOM_IMPLICADA");

            entity.HasIndex(e => e.ConTexCod, "IINP_PERSONAS_IMPLICADAS10");

            entity.HasIndex(e => e.ColOjoCod, "IINP_PERSONAS_IMPLICADAS11");

            entity.HasIndex(e => e.TipCabelCod, "IINP_PERSONAS_IMPLICADAS12");

            entity.HasIndex(e => e.TipCarCod, "IINP_PERSONAS_IMPLICADAS13");

            entity.HasIndex(e => e.TipFreCod, "IINP_PERSONAS_IMPLICADAS14");

            entity.HasIndex(e => e.InpPerNnprof1, "IINP_PERSONAS_IMPLICADAS15");

            entity.HasIndex(e => e.InpPerNnapo1, "IINP_PERSONAS_IMPLICADAS16");

            entity.HasIndex(e => e.InpPerNnprof2, "IINP_PERSONAS_IMPLICADAS17");

            entity.HasIndex(e => e.InpPerNnapo2, "IINP_PERSONAS_IMPLICADAS18");

            entity.HasIndex(e => e.TipNarizCod, "IINP_PERSONAS_IMPLICADAS19");

            entity.HasIndex(e => e.InpPerId, "IINP_PERSONAS_IMPLICADAS2");

            entity.HasIndex(e => e.InpPerPaiDoc, "IINP_PERSONAS_IMPLICADAS20");

            entity.HasIndex(e => e.TipOrecCod, "IINP_PERSONAS_IMPLICADAS21");

            entity.HasIndex(e => e.TipoVozCod, "IINP_PERSONAS_IMPLICADAS23");

            entity.HasIndex(e => e.TipoBocCod, "IINP_PERSONAS_IMPLICADAS24");

            entity.HasIndex(e => e.InpPerDetRegCod, "IINP_PERSONAS_IMPLICADAS25");

            entity.HasIndex(e => e.InpPerDetComCod, "IINP_PERSONAS_IMPLICADAS26");

            entity.HasIndex(e => e.InpPerVillaCod, "IINP_PERSONAS_IMPLICADAS27");

            entity.HasIndex(e => e.TipPielCod, "IINP_PERSONAS_IMPLICADAS28");

            entity.HasIndex(e => e.MotDetCod, "IINP_PERSONAS_IMPLICADAS29");

            entity.HasIndex(e => new { e.InpPerComCod, e.InpPerCalleCod, e.InpPerCalleTipo }, "IINP_PERSONAS_IMPLICADAS3");

            entity.HasIndex(e => new { e.InpFolio, e.InpPerId }, "IINP_PERSONAS_IMPLICADAS30");

            entity.HasIndex(e => new { e.InpFolio, e.UperCondCod, e.InpPerRec, e.InpPerTestAporDenun }, "IINP_PERSONAS_IMPLICADAS31").IsDescending(false, false, false, true);

            entity.HasIndex(e => e.TipAmpCod, "IINP_PERSONAS_IMPLICADAS32");

            entity.HasIndex(e => e.TipCicaCod, "IINP_PERSONAS_IMPLICADAS33");

            entity.HasIndex(e => e.TipTatuCod, "IINP_PERSONAS_IMPLICADAS34");

            entity.HasIndex(e => new { e.OrgCodGubCasoP, e.OrgDetNroGubCasoP }, "IINP_PERSONAS_IMPLICADAS35");

            entity.HasIndex(e => e.RangoEdadP, "IINP_PERSONAS_IMPLICADAS36");

            entity.HasIndex(e => e.InpPerNnnac, "IINP_PERSONAS_IMPLICADAS37");

            entity.HasIndex(e => e.InpPerConFalCod, "IINP_PERSONAS_IMPLICADAS38");

            entity.HasIndex(e => new { e.UperCondCod, e.InpPerId }, "IINP_PERSONAS_IMPLICADAS39");

            entity.HasIndex(e => e.TipoMenCod, "IINP_PERSONAS_IMPLICADAS4");

            entity.HasIndex(e => e.InpPerTipoDoc, "IINP_PERSONAS_IMPLICADAS5");

            entity.HasIndex(e => e.InpPerIdRetDet, "IINP_PERSONAS_IMPLICADAS6");

            entity.HasIndex(e => e.InpNacPerImp, "IINP_PERSONAS_IMPLICADAS7");

            entity.HasIndex(e => e.TipCabCod, "IINP_PERSONAS_IMPLICADAS8");

            entity.HasIndex(e => e.ColCabCod, "IINP_PERSONAS_IMPLICADAS9");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ApoyoEstatalP).HasColumnName("Apoyo_EstatalP");
            entity.Property(e => e.CargoGubP)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Cargo_GubP");
            entity.Property(e => e.FchIngInstGubP).HasColumnType("datetime");
            entity.Property(e => e.InpAdulRespRecMen)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpConCel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpConNom)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpConRecImp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpConTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpDirContacto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpIncDatGubInfP)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpLugMedProtec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpMaternoNn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpMaternoNN");
            entity.Property(e => e.InpNomSup)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpNombreNn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("InpNombreNN");
            entity.Property(e => e.InpPaternoNn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPaternoNN");
            entity.Property(e => e.InpPerAntDet).IsUnicode(false);
            entity.Property(e => e.InpPerAntGep)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerAntInt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerApo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpPerAyudaCons)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InpPerCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InpPerCalleDpto)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpPerCalleNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpPerCel)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InpPerComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerComSitDet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerCopLecDer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerDatFis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerDesLesio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpPerDetComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerDetComPad)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpPerDetFecFin).HasColumnType("datetime");
            entity.Property(e => e.InpPerDetFecIni).HasColumnType("datetime");
            entity.Property(e => e.InpPerDetGep).IsUnicode(false);
            entity.Property(e => e.InpPerDetHoraFin).HasColumnType("datetime");
            entity.Property(e => e.InpPerDetHoraIni).HasColumnType("datetime");
            entity.Property(e => e.InpPerDetInt).IsUnicode(false);
            entity.Property(e => e.InpPerDetPlas).HasColumnName("InpPerDetPLAS");
            entity.Property(e => e.InpPerDetRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerDirExa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerDirLab)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpPerFecDet).HasColumnType("datetime");
            entity.Property(e => e.InpPerFecIns).HasColumnType("datetime");
            entity.Property(e => e.InpPerFecUpd).HasColumnType("datetime");
            entity.Property(e => e.InpPerFono)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InpPerFormAne3).IsUnicode(false);
            entity.Property(e => e.InpPerFormAne4).IsUnicode(false);
            entity.Property(e => e.InpPerFunPdi).HasColumnName("InpPerFunPDI");
            entity.Property(e => e.InpPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPerID");
            entity.Property(e => e.InpPerIdRetDet)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.InpPerIdioLecD)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpPerIndLesio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerIndPerExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerInfAlcohol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerInfDrogas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerInvConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.InpPerLatDet)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpPerLecDer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerLongDet)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpPerLugDel).IsUnicode(false);
            entity.Property(e => e.InpPerLugLaboral)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.InpPerMail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpPerMotNenc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpPerMotNEnc");
            entity.Property(e => e.InpPerNnalt).HasColumnName("InpPerNNAlt");
            entity.Property(e => e.InpPerNnaltFin).HasColumnName("InpPerNNAltFin");
            entity.Property(e => e.InpPerNnapo1).HasColumnName("InpPerNNApo1");
            entity.Property(e => e.InpPerNnapo2).HasColumnName("InpPerNNApo2");
            entity.Property(e => e.InpPerNnnac).HasColumnName("InpPerNNNac");
            entity.Property(e => e.InpPerNnprof1).HasColumnName("InpPerNNProf1");
            entity.Property(e => e.InpPerNnprof2).HasColumnName("InpPerNNProf2");
            entity.Property(e => e.InpPerNnsex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPerNNSex");
            entity.Property(e => e.InpPerNomConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.InpPerNomConvi)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.InpPerNomConyu)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.InpPerNomMadre)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.InpPerNomPadre)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.InpPerNroDoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpPerNroOa).HasColumnName("InpPerNroOA");
            entity.Property(e => e.InpPerNumTelConPerDet)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpPerObs)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.InpPerProf1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InpPerProf2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InpPerResIden)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerSsalt).HasColumnName("InpPerSSAlt");
            entity.Property(e => e.InpPerSsemp).HasColumnName("InpPerSSEmp");
            entity.Property(e => e.InpPerTemxVid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerTesDec)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.InpPerTesDecNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpPerTestAporDenun)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerTipoDoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpPerUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpPerUtilInv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPerVilla)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpPerVillaCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.InpPerWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpPerWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpTxtTestResIden).IsUnicode(false);
            entity.Property(e => e.RangoEdadP).HasColumnName("Rango_EdadP");
            entity.Property(e => e.UperCondCod).HasColumnName("UPerCondCod");
        });

        modelBuilder.Entity<InpPersonasModu>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpModFolio, e.InpModPerFolio }).HasName("PK__INP_PERS__6916B36B45D43599");

            entity.ToTable("INP_PERSONAS_MODUS");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpPersonasVestimenta>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpPerFolio, e.InpPerVestNro }).HasName("PK__Inp_Pers__C0FC94831472254D");

            entity.ToTable("Inp_Personas_Vestimentas");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpPerVestObs)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpPideCuentum>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpPideFolio }).HasName("PK__Inp_Pide__E2D736D0AA18E4D7");

            entity.ToTable("Inp_Pide_Cuenta");

            entity.HasIndex(e => new { e.InpFolio, e.InpPideFolio }, "IINP_PIDE_CUENTA6").IsDescending(false, true);

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpPideCtaFecFing).HasColumnType("datetime");
            entity.Property(e => e.InpPideDetalles)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.InpPideDocFec).HasColumnType("datetime");
            entity.Property(e => e.InpPideDocNro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpPideDocTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPideFecIns).HasColumnType("datetime");
            entity.Property(e => e.InpPideFisId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPideFisID");
            entity.Property(e => e.InpPideObs)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.InpPideUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPideUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpPideVenFec).HasColumnType("datetime");
            entity.Property(e => e.InpPideWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpPla>(entity =>
        {
            entity.HasKey(e => e.InpPlasfolio).HasName("PK__INP_PLAS__770C6BC96FF0E617");

            entity.ToTable("INP_PLAS");

            entity.Property(e => e.InpPlasfolio)
                .ValueGeneratedNever()
                .HasColumnName("InpPLASFolio");
            entity.Property(e => e.InpPlasComuNorte)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPlasComuOcc)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPlasComuOri)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPlasComuSur)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPlasanio).HasColumnName("InpPLASAnio");
            entity.Property(e => e.InpPlascalleNor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InpPLASCalleNor");
            entity.Property(e => e.InpPlascalleOcc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InpPLASCalleOcc");
            entity.Property(e => e.InpPlascalleOri)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InpPLASCalleOri");
            entity.Property(e => e.InpPlascalleSur)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InpPLASCalleSur");
            entity.Property(e => e.InpPlascontrol).HasColumnName("InpPLASControl");
            entity.Property(e => e.InpPlasdetalle)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("InpPLASDetalle");
            entity.Property(e => e.InpPlasdocAttach).HasColumnName("InpPLASDocAttach");
            entity.Property(e => e.InpPlasdocExt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("InpPLASDocExt");
            entity.Property(e => e.InpPlasdocFec)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASDocFec");
            entity.Property(e => e.InpPlasdocIni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASDocIni");
            entity.Property(e => e.InpPlasfecFin)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASFecFin");
            entity.Property(e => e.InpPlasfecIni)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASFecIni");
            entity.Property(e => e.InpPlasfecIns)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASFecIns");
            entity.Property(e => e.InpPlasfecUpd)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASFecUpd");
            entity.Property(e => e.InpPlasfunCar).HasColumnName("InpPLASFunCar");
            entity.Property(e => e.InpPlashoraFin)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASHoraFin");
            entity.Property(e => e.InpPlashoraIni)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASHoraIni");
            entity.Property(e => e.InpPlasinvFolio).HasColumnName("InpPLASInvFolio");
            entity.Property(e => e.InpPlasmes).HasColumnName("InpPLASMes");
            entity.Property(e => e.InpPlasregCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASRegCod");
            entity.Property(e => e.InpPlastipDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASTipDoc");
            entity.Property(e => e.InpPlastipo).HasColumnName("InpPLASTipo");
            entity.Property(e => e.InpPlasuniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASUniCod");
            entity.Property(e => e.InpPlasuniIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASUniIns");
            entity.Property(e => e.InpPlasuniOrd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASUniOrd");
            entity.Property(e => e.InpPlasuniUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASUniUpd");
            entity.Property(e => e.InpPlasusuIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpPLASUsuIns");
            entity.Property(e => e.InpPlasusuUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASUsuUpd");
            entity.Property(e => e.InpPlaswrkIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASWrkIns");
            entity.Property(e => e.InpPlaswrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASWrkUpd");
        });

        modelBuilder.Entity<InpPlasCarro>(entity =>
        {
            entity.HasKey(e => new { e.InpPlasfolio, e.CarrPolId }).HasName("PK__INP_PLAS__21478D2F30BA68A4");

            entity.ToTable("INP_PLAS_Carros");

            entity.Property(e => e.InpPlasfolio).HasColumnName("InpPLASFolio");
            entity.Property(e => e.CarrPolId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CarrPolID");
            entity.Property(e => e.InpPlascarrKmFin).HasColumnName("InpPLASCarrKmFin");
            entity.Property(e => e.InpPlascarrKmIni).HasColumnName("InpPLASCarrKmIni");
            entity.Property(e => e.InpPlascarrLts)
                .HasColumnType("money")
                .HasColumnName("InpPLASCarrLts");
            entity.Property(e => e.InpPlascarrNroFun).HasColumnName("InpPLASCarrNroFun");
            entity.Property(e => e.InpPlascarrUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASCarrUni");
        });

        modelBuilder.Entity<InpPlasComuna>(entity =>
        {
            entity.HasKey(e => new { e.InpPlasfolio, e.InpPlascomCod }).HasName("PK__INP_PLAS__7A3357A1AAD8B498");

            entity.ToTable("INP_PLAS_COMUNAS");

            entity.Property(e => e.InpPlasfolio).HasColumnName("InpPLASFolio");
            entity.Property(e => e.InpPlascomCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASComCod");
        });

        modelBuilder.Entity<InpPlasConsultado>(entity =>
        {
            entity.HasKey(e => new { e.InpPlasfolio, e.InpPlasconNro }).HasName("PK__INP_PLAS__50FA1E2E3E27B182");

            entity.ToTable("INP_PLAS_Consultados");

            entity.Property(e => e.InpPlasfolio).HasColumnName("InpPLASFolio");
            entity.Property(e => e.InpPlasconNro).HasColumnName("InpPLASConNro");
            entity.Property(e => e.InpPlasVillaPoblaTxt)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpPlasconAntec).HasColumnName("InpPLASConAntec");
            entity.Property(e => e.InpPlasconCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InpPLASConCalleCod");
            entity.Property(e => e.InpPlasconCalleInt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InpPLASConCalleInt");
            entity.Property(e => e.InpPlasconCauPen).HasColumnName("InpPLASConCauPen");
            entity.Property(e => e.InpPlasconComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASConComCod");
            entity.Property(e => e.InpPlasconDet).HasColumnName("InpPLASConDet");
            entity.Property(e => e.InpPlasconDetCua).HasColumnName("InpPLASConDetCua");
            entity.Property(e => e.InpPlasconDetEstado).HasColumnName("InpPLASConDetEstado");
            entity.Property(e => e.InpPlasconDetFecFin)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConDetFecFin");
            entity.Property(e => e.InpPlasconDetFecIni)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConDetFecIni");
            entity.Property(e => e.InpPlasconDetHoraFin)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConDetHoraFin");
            entity.Property(e => e.InpPlasconDetHoraIni)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConDetHoraIni");
            entity.Property(e => e.InpPlasconDetHrsFin).HasColumnName("InpPLASConDetHrsFin");
            entity.Property(e => e.InpPlasconDetHrsIni).HasColumnName("InpPLASConDetHrsIni");
            entity.Property(e => e.InpPlasconDetMinFin).HasColumnName("InpPLASConDetMinFin");
            entity.Property(e => e.InpPlasconDetMinIni).HasColumnName("InpPLASConDetMinIni");
            entity.Property(e => e.InpPlasconDetParteNro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASConDetParteNro");
            entity.Property(e => e.InpPlasconDocNro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASConDocNro");
            entity.Property(e => e.InpPlasconDocPai).HasColumnName("InpPLASConDocPai");
            entity.Property(e => e.InpPlasconDocTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASConDocTipo");
            entity.Property(e => e.InpPlasconFch)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConFch");
            entity.Property(e => e.InpPlasconFecIns)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConFecIns");
            entity.Property(e => e.InpPlasconFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConFecUpd");
            entity.Property(e => e.InpPlasconFunIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpPLASConFunIns");
            entity.Property(e => e.InpPlasconFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpPLASConFunUpd");
            entity.Property(e => e.InpPlasconHora)
                .HasColumnType("datetime")
                .HasColumnName("InpPLASConHora");
            entity.Property(e => e.InpPlasconLin).HasColumnName("InpPLASConLin");
            entity.Property(e => e.InpPlasconNroCalle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpPLASConNroCalle");
            entity.Property(e => e.InpPlasconNroDpto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InpPLASConNroDpto");
            entity.Property(e => e.InpPlasconPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPLASConPerID");
            entity.Property(e => e.InpPlasconRel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASConRel");
            entity.Property(e => e.InpPlasconRelev).HasColumnName("InpPLASConRelev");
            entity.Property(e => e.InpPlasconTipoCalle).HasColumnName("InpPLASConTipoCalle");
            entity.Property(e => e.InpPlasconVillaCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("InpPLASConVillaCod");
            entity.Property(e => e.InpPlasconWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASConWrkIns");
            entity.Property(e => e.InpPlasconWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpPLASConWrkUpd");
            entity.Property(e => e.InpPlasdetHrs).HasColumnName("InpPLASDetHrs");
            entity.Property(e => e.InpPlasdetMin).HasColumnName("InpPLASDetMin");
        });

        modelBuilder.Entity<InpPlasFuncionario>(entity =>
        {
            entity.HasKey(e => new { e.InpPlasfolio, e.InpPlasparFunRut }).HasName("PK__INP_PLAS__F036417D7C3FBEE0");

            entity.ToTable("INP_PLAS_Funcionarios");

            entity.Property(e => e.InpPlasfolio).HasColumnName("InpPLASFolio");
            entity.Property(e => e.InpPlasparFunRut).HasColumnName("InpPLASParFunRut");
            entity.Property(e => e.InpIdCarroPol)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.InpPlasparFunUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpPLASParFunUni");
        });

        modelBuilder.Entity<InpReconocimientoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpRecFolio, e.InpRecPerId }).HasName("PK__Inp_Reco__DB51B317DEB7CD0B");

            entity.ToTable("Inp_Reconocimiento_Detalle");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpRecPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpRecPerID");
        });

        modelBuilder.Entity<InpReconocimientoFotografico>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpRecFolio }).HasName("PK__Inp_Reco__64FE85B70934F422");

            entity.ToTable("Inp_Reconocimiento_Fotografico");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpRecFchHoraIns).HasColumnType("datetime");
            entity.Property(e => e.InpRecFchHoraUpd).HasColumnType("datetime");
            entity.Property(e => e.InpRecFec).HasColumnType("datetime");
            entity.Property(e => e.InpRecFunIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpRecFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpRecId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpRecID");
            entity.Property(e => e.InpRecInvConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.InpRecIpins)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpRecIPIns");
            entity.Property(e => e.InpRecIpupd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InpRecIPUpd");
            entity.Property(e => e.InpRecNomConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.InpRecUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpRecUpdUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<InpReportespbi>(entity =>
        {
            entity.HasKey(e => e.IdPbi).HasName("PK__InpRepor__2ACCCE24ECE41CD5");

            entity.ToTable("InpReportespbi");

            entity.Property(e => e.IdPbi)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("IdPBI");
            entity.Property(e => e.ApliPerfilPbi).HasColumnName("ApliPerfilPBI");
            entity.Property(e => e.DatePbi)
                .HasColumnType("datetime")
                .HasColumnName("DatePBI");
            entity.Property(e => e.KeyEmbPbi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("KeyEmbPBI");
            entity.Property(e => e.SourceHttpPbi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SourceHttpPBI");
        });

        modelBuilder.Entity<InpSs>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSucfolio }).HasName("PK__INP_SS__E9EAD51E72FAE8E3");

            entity.ToTable("INP_SS");

            entity.HasIndex(e => new { e.InpSucRegCod, e.InpSucComCod, e.InpSucCalleCod }, "IINP_S10");

            entity.HasIndex(e => new { e.InpSucComCod, e.InpSucCalleCod }, "IINP_S11");

            entity.HasIndex(e => e.InpFolio, "IINP_SS1").HasFillFactor(100);

            entity.HasIndex(e => e.InpSucVillaCod, "IINP_SS3");

            entity.HasIndex(e => e.InpSucIntCalleCod, "IINP_SS4");

            entity.HasIndex(e => e.InpSucTipCalleCod, "IINP_SS5");

            entity.HasIndex(e => e.LugSucCod, "IINP_SS6");

            entity.HasIndex(e => new { e.InpSslugCod, e.InpSsldetCod }, "IINP_SS7");

            entity.HasIndex(e => e.InpSucCalleCod, "IINP_SS8");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.InpAsisteCarab)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpSitioSuceso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpSsdetInsPdi)
                .IsUnicode(false)
                .HasColumnName("InpSSDetInsPDI");
            entity.Property(e => e.InpSsdirAlt)
                .IsUnicode(false)
                .HasColumnName("InpSSDirAlt");
            entity.Property(e => e.InpSsdirLat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSDirLat");
            entity.Property(e => e.InpSsdirLong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSDirLong");
            entity.Property(e => e.InpSsdirRec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSDirRec");
            entity.Property(e => e.InpSsinsPdi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSInsPDI");
            entity.Property(e => e.InpSsldetCod).HasColumnName("InpSSLDetCod");
            entity.Property(e => e.InpSslugCod).HasColumnName("InpSSLugCod");
            entity.Property(e => e.InpSslugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSLugar");
            entity.Property(e => e.InpSucCalleAlt)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InpSucCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InpSucComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpSucConcurre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpSucEstado).HasColumnName("Inp_SucEstado");
            entity.Property(e => e.InpSucFecha).HasColumnType("datetime");
            entity.Property(e => e.InpSucHora).HasColumnType("datetime");
            entity.Property(e => e.InpSucIntCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InpSucNroDir)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpSucNroDpto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InpSucRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpSucRelato).IsUnicode(false);
            entity.Property(e => e.InpSucVilla)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpSucVillaCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.InpTipoSitiosuc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LugSucCod)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InpSsFoto>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSucfolio, e.InpSsfotoId }).HasName("PK__INP_SS_F__898F653F26EB6514");

            entity.ToTable("INP_SS_FOTOS");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.InpSsfotoId).HasColumnName("InpSSFotoId");
            entity.Property(e => e.InpSsfotos).HasColumnName("InpSSFotos");
        });

        modelBuilder.Entity<InpSsdelAso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSucfolio, e.InpSsdelAso1 }).HasName("PK__InpSSDel__E71C97720D508985");

            entity.ToTable("InpSSDelAso");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.InpSsdelAso1).HasColumnName("InpSSDelAso");
        });

        modelBuilder.Entity<InstrumentosMusicale>(entity =>
        {
            entity.HasKey(e => e.MusInscod).HasName("PK__Instrume__3AE5917B0D30B51A");

            entity.ToTable("Instrumentos_Musicales");

            entity.Property(e => e.MusInscod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FamInsDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MatTipDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MusInsDes)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.MusInsModelo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MusMarDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipMusDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InsumoComputacionale>(entity =>
        {
            entity.HasKey(e => e.InsComCod).HasName("PK__Insumo_C__B06FB2E424141A72");

            entity.ToTable("Insumo_Computacionales");

            entity.HasIndex(e => e.ColCod, "IINSUMO_COMPUTACIONALES1");

            entity.Property(e => e.InsComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InsComDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.InsComModelo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InsComNroSerie)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InsComObs)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MarComDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipInsDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IpPai>(entity =>
        {
            entity.HasKey(e => e.IpIntCod).HasName("PK__IP_Pais__CEBAECCD00AAE2A4");

            entity.ToTable("IP_Pais");

            entity.HasIndex(e => e.IpIntPai, "IIP_PAIS2");

            entity.Property(e => e.IpIntCod).ValueGeneratedNever();
            entity.Property(e => e.IpIntDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JerarquiaCriminal>(entity =>
        {
            entity.HasKey(e => e.CodJerarquico).HasName("PK__jerarqui__2E51CD885E55CAA0");

            entity.ToTable("jerarquia_criminal");

            entity.Property(e => e.CodJerarquico)
                .ValueGeneratedNever()
                .HasColumnName("cod_Jerarquico");
            entity.Property(e => e.DescJerarquico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_jerarquico");
        });

        modelBuilder.Entity<JoyPiedra>(entity =>
        {
            entity.HasKey(e => e.JoyPieCod).HasName("PK__Joy_Pied__816AAFC24A4ED1F3");

            entity.ToTable("Joy_Piedras");

            entity.Property(e => e.JoyPieCod).ValueGeneratedNever();
            entity.Property(e => e.JoyPieDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Joya>(entity =>
        {
            entity.HasKey(e => e.JoyCod).HasName("PK__Joyas__89022013110145FE");

            entity.HasIndex(e => e.JoyMaePieCod, "IJOYAS1");

            entity.Property(e => e.JoyCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JoyDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.JoyFamDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.JoyForDes)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JoyMatDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.JoyObs)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JoyPeso).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<LogEnvDatMp>(entity =>
        {
            entity.HasKey(e => e.UniIdLogEnvMp).HasName("PK__LogEnvDa__D4A1C4254BC990A7");

            entity.ToTable("LogEnvDatMP");

            entity.Property(e => e.UniIdLogEnvMp)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("UniIdLogEnvMP");
            entity.Property(e => e.UniFchHraEnvMp)
                .HasColumnType("datetime")
                .HasColumnName("UniFchHraEnvMP");
            entity.Property(e => e.UniInpFolioBrain)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniPgmEnvMp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UniPgmEnvMP");
            entity.Property(e => e.UniServMp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UniServMP");
            entity.Property(e => e.UniValEnv).IsUnicode(false);
            entity.Property(e => e.UniValRec).IsUnicode(false);
        });

        modelBuilder.Entity<LugarSuceso>(entity =>
        {
            entity.HasKey(e => e.LugSucCod).HasName("PK__Lugar_Su__7B53B5C35E9FE363");

            entity.ToTable("Lugar_Suceso");

            entity.Property(e => e.LugSucCod)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LugSucDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MarcaArma>(entity =>
        {
            entity.HasKey(e => e.MarArmCod).HasName("PK__Marca_Ar__87BFDE2238EF3BC7");

            entity.ToTable("Marca_Arma");

            entity.Property(e => e.MarArmCod).ValueGeneratedNever();
            entity.Property(e => e.MarArmDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MarcaElectronica>(entity =>
        {
            entity.HasKey(e => e.MarcElecCod).HasName("PK__Marca_El__CC0DE1AF4460EE73");

            entity.ToTable("Marca_Electronica");

            entity.Property(e => e.MarcElecCod).ValueGeneratedNever();
            entity.Property(e => e.MarcElecDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MarcaHerramientum>(entity =>
        {
            entity.HasKey(e => e.MarHerCod).HasName("PK__Marca_He__48266D0341B98BF2");

            entity.ToTable("Marca_Herramienta");

            entity.Property(e => e.MarHerCod).ValueGeneratedNever();
            entity.Property(e => e.MarHerDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MarcaVehiculo>(entity =>
        {
            entity.HasKey(e => e.MarVehCod).HasName("PK__Marca_Ve__D97D51C9600908E8");

            entity.ToTable("Marca_Vehiculos");

            entity.HasIndex(e => e.MarVehCod, "IMARCA_VEHICULOS5").IsDescending();

            entity.HasIndex(e => e.MarVehDes, "MARVEHDES");

            entity.Property(e => e.MarVehCod).ValueGeneratedNever();
            entity.Property(e => e.MarVehDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MarVehSis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MarcasVestimenta>(entity =>
        {
            entity.HasKey(e => e.MarVestCod).HasName("PK__Marcas_V__396D414F4E697B9A");

            entity.ToTable("Marcas_Vestimentas");

            entity.Property(e => e.MarVestCod).ValueGeneratedNever();
            entity.Property(e => e.MarVestDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MarcosAux>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("marcos_aux");

            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido2");
            entity.Property(e => e.CodPais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_pais");
            entity.Property(e => e.FechaNac)
                .HasColumnType("date")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombresCompuesto)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nombres_compuesto");
            entity.Property(e => e.Uperid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uperid");
        });

        modelBuilder.Entity<MaterialesConstruccion>(entity =>
        {
            entity.HasKey(e => e.MatConCod).HasName("PK__Material__1D94F6502B403AEE");

            entity.ToTable("Materiales_Construccion");

            entity.HasIndex(e => e.MatConTipoMed, "IMATERIALES_CONSTRUCCION1");

            entity.Property(e => e.MatConCod).ValueGeneratedNever();
            entity.Property(e => e.MatConDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MatConTipoMed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Mese>(entity =>
        {
            entity.HasKey(e => e.MesesCod).HasName("PK__Meses__81530F81662BF692");

            entity.Property(e => e.MesesCod).ValueGeneratedNever();
            entity.Property(e => e.MesesDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Metale>(entity =>
        {
            entity.HasKey(e => e.MetalCod).HasName("PK__Metales__ABFCAAFD01BF026E");

            entity.Property(e => e.MetalCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MetalDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModusDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MODUS_DESTAPOL");

            entity.Property(e => e.AccionesPrevias).HasColumnName("ACCIONES PREVIAS");
            entity.Property(e => e.CantidadImputados)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CANTIDAD IMPUTADOS");
            entity.Property(e => e.CodCantImputados).HasColumnName("COD_CANT_IMPUTADOS");
            entity.Property(e => e.CodFormContacto).HasColumnName("COD_FORM_CONTACTO");
            entity.Property(e => e.CodGenero).HasColumnName("COD_GENERO");
            entity.Property(e => e.CodMedHerramientas).HasColumnName("COD_MED_HERRAMIENTAS");
            entity.Property(e => e.CodModalidad).HasColumnName("COD_MODALIDAD");
            entity.Property(e => e.CodPuntoAcceso).HasColumnName("COD_PUNTO_ACCESO");
            entity.Property(e => e.CodRangoEtario).HasColumnName("COD_RANGO_ETARIO");
            entity.Property(e => e.CodTransporte).HasColumnName("COD_TRANSPORTE");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FormaDeContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FORMA DE CONTACTO");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.MediosOHerramientas)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEDIOS O HERRAMIENTAS");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODALIDAD");
            entity.Property(e => e.PuntoAcceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PUNTO ACCESO");
            entity.Property(e => e.RangoEtario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RANGO ETARIO");
            entity.Property(e => e.SelloPersonal)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SELLO PERSONAL");
            entity.Property(e => e.TransporteUsado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TRANSPORTE USADO");
        });

        modelBuilder.Entity<ModusOperandi>(entity =>
        {
            entity.HasKey(e => e.ModOpCod).HasName("PK__Modus_Op__E4FCE8B505B9B084");

            entity.ToTable("Modus_Operandi");

            entity.Property(e => e.ModOpCod).ValueGeneratedNever();
            entity.Property(e => e.ModOpDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModusOperandiDetalle>(entity =>
        {
            entity.HasKey(e => new { e.ModOpCod, e.ModOpDetCod }).HasName("PK__Modus_Op__054539667A47FDD8");

            entity.ToTable("Modus_Operandi_Detalle");

            entity.Property(e => e.ModOpDetDes)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.HasKey(e => e.Moncod).HasName("PK__Monedas__C01A05511AF4C48C");

            entity.HasIndex(e => e.MonDes, "IMONDES").IsUnique();

            entity.Property(e => e.Moncod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonDes)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MonSim)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MorfologiaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.MorfCod, e.MorfDetCod }).HasName("PK__Morfolog__30002A4A1F997E18");

            entity.ToTable("Morfologia_Detalle");

            entity.Property(e => e.MorfDetDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Morfologium>(entity =>
        {
            entity.HasKey(e => e.MorfCod).HasName("PK__Morfolog__06A8537C3588BF37");

            entity.Property(e => e.MorfCod).ValueGeneratedNever();
            entity.Property(e => e.MorfDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MotivoDetencion>(entity =>
        {
            entity.HasKey(e => e.MotDetCod).HasName("PK__Motivo_D__E3083EDB50C6C558");

            entity.ToTable("Motivo_Detencion");

            entity.Property(e => e.MotDetCod).ValueGeneratedNever();
            entity.Property(e => e.MotDetDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MotDetOa).HasColumnName("MotDetOA");
            entity.Property(e => e.MotDetVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<NominaDefinitivaInhabilitadosEnChile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nomina_Definitiva_Inhabilitados_en_Chile");

            entity.Property(e => e.Circunscripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSCRIPCION");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.DomicilioElectoral)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO_ELECTORAL");
            entity.Property(e => e.Dv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DV");
            entity.Property(e => e.Nombre)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Run)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RUN");
            entity.Property(e => e.Sexo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEXO");
        });

        modelBuilder.Entity<NominaDefinitivaInhabilitadosEnElExtranjero>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nomina_Definitiva_Inhabilitados_en_el_Extranjero");

            entity.Property(e => e.Circunscripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSCRIPCION");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.DomicilioElectoral)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO_ELECTORAL");
            entity.Property(e => e.Dv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DV");
            entity.Property(e => e.Nombre)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAIS");
            entity.Property(e => e.Run)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RUN");
            entity.Property(e => e.Sexo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEXO");
        });

        modelBuilder.Entity<Nue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("nues");

            entity.Property(e => e.AvalúoArma)
                .HasColumnType("money")
                .HasColumnName("AVALÚO ARMA");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CantidadArma).HasColumnName("CANTIDAD ARMA");
            entity.Property(e => e.CantidadDroga)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD DROGA");
            entity.Property(e => e.DescEspecie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESC. ESPECIE");
            entity.Property(e => e.DescTipoArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESC. TIPO ARMA");
            entity.Property(e => e.DetEspecie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DET. ESPECIE");
            entity.Property(e => e.DondeFueLevantada)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DONDE FUE LEVANTADA");
            entity.Property(e => e.EstadoArma)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO ARMA");
            entity.Property(e => e.EstadoDroga)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("ESTADO DROGA");
            entity.Property(e => e.FamEspecie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FAM. ESPECIE");
            entity.Property(e => e.FamiliaArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FAMILIA ARMA");
            entity.Property(e => e.FechaAccionDroga)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ACCION DROGA");
            entity.Property(e => e.FechaEvidencia)
                .HasColumnType("datetime")
                .HasColumnName("FECHA EVIDENCIA");
            entity.Property(e => e.FolioArma).HasColumnName("FOLIO ARMA");
            entity.Property(e => e.FolioDroga)
                .HasColumnType("decimal(12, 0)")
                .HasColumnName("FOLIO DROGA");
            entity.Property(e => e.FolioEspecie).HasColumnName("FOLIO ESPECIE");
            entity.Property(e => e.FolioEvidencia).HasColumnName("FOLIO EVIDENCIA");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Modelo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.NSerie)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("N° SERIE");
            entity.Property(e => e.NUE1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("N.U.E.");
            entity.Property(e => e.SerieArma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIE ARMA");
            entity.Property(e => e.TipoDrogra)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO DROGRA");
            entity.Property(e => e.Valor)
                .HasColumnType("money")
                .HasColumnName("VALOR");
            entity.Property(e => e.ValorDroga)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("VALOR DROGA");
        });

        modelBuilder.Entity<OaVigentesGepol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OA_VigentesGepol");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(255)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Comuna)
                .HasMaxLength(255)
                .HasColumnName("COMUNA");
            entity.Property(e => e.Delito)
                .HasMaxLength(255)
                .HasColumnName("DELITO");
            entity.Property(e => e.DocIdentidad)
                .HasMaxLength(255)
                .HasColumnName("DOC-IDENTIDAD");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(255)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.Dv)
                .HasMaxLength(255)
                .HasColumnName("DV");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .HasColumnName("ESTADO");
            entity.Property(e => e.F20).HasMaxLength(255);
            entity.Property(e => e.FechaCausa)
                .HasMaxLength(255)
                .HasColumnName("FECHA-CAUSA");
            entity.Property(e => e.FechaIngGepol)
                .HasMaxLength(255)
                .HasColumnName("FECHA-ING-GEPOL");
            entity.Property(e => e.IdGepol)
                .HasMaxLength(255)
                .HasColumnName("ID-GEPOL");
            entity.Property(e => e.Materno)
                .HasMaxLength(255)
                .HasColumnName("MATERNO");
            entity.Property(e => e.NCausa)
                .HasMaxLength(255)
                .HasColumnName("N° CAUSA");
            entity.Property(e => e.NFolio)
                .HasMaxLength(255)
                .HasColumnName("N° FOLIO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(255)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.OrganismoExterno)
                .HasMaxLength(255)
                .HasColumnName("ORGANISMO EXTERNO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(255)
                .HasColumnName("PATERNO");
            entity.Property(e => e.ProfJusticia)
                .HasMaxLength(255)
                .HasColumnName("PROF-JUSTICIA");
            entity.Property(e => e.Reg)
                .HasMaxLength(255)
                .HasColumnName("REG");
            entity.Property(e => e.TipoDeOrden)
                .HasMaxLength(255)
                .HasColumnName("TIPO DE ORDEN");
        });

        modelBuilder.Entity<OcultamientoDroga>(entity =>
        {
            entity.HasKey(e => e.OculDrogCod).HasName("PK__Ocultami__17DE95A1420E91AD");

            entity.ToTable("Ocultamiento_Droga");

            entity.Property(e => e.OculDrogCod).ValueGeneratedNever();
            entity.Property(e => e.OculDrogDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Odontograma>(entity =>
        {
            entity.HasKey(e => e.OdonCod).HasName("PK__Odontogr__CCCA2A1859FB29D7");

            entity.ToTable("Odontograma");

            entity.Property(e => e.OdonCod).ValueGeneratedNever();
            entity.Property(e => e.OdonDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenAlfa>(entity =>
        {
            entity.HasKey(e => e.AlfaCod).HasName("PK__Orden_Al__B043B9E476976885");

            entity.ToTable("Orden_Alfa");

            entity.Property(e => e.AlfaCod)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Organismo>(entity =>
        {
            entity.HasKey(e => e.OrgCod).HasName("PK__Organism__F06A3E257F4CAA17");

            entity.HasIndex(e => new { e.OrgCod, e.OrgDesFlgCar }, "IORGANISMOS1");

            entity.HasIndex(e => e.OrgDesFlgCar, "IORGANISMOS2");

            entity.HasIndex(e => e.OrgDes, "IORGDES");

            entity.Property(e => e.OrgCod).ValueGeneratedNever();
            entity.Property(e => e.OrgDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrganismoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.OrgCod, e.OrgDetNro }).HasName("PK__Organism__00F1A5896502C82F");

            entity.ToTable("Organismo_Detalle");

            entity.HasIndex(e => e.OrgDetDestad, "IORGANISMO_DESTAD");

            entity.HasIndex(e => e.Regcod, "IORGANISMO_DETALLE1");

            entity.HasIndex(e => e.OrgDetComCod, "IORGANISMO_DETALLE3");

            entity.HasIndex(e => new { e.OrgCod, e.OrgDetVig }, "IORGANISMO_DETALLE4");

            entity.Property(e => e.OrgDetCodArea)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrgDetDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetDesNum)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetDirCalle)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetDirNro)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetNumOrg)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Regcod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrganismoGuberDetalle>(entity =>
        {
            entity.HasKey(e => new { e.OrgCodGub, e.OrgDetNroGub }).HasName("PK__Organism__087A72362922E852");

            entity.ToTable("OrganismoGuber_Detalle");

            entity.HasIndex(e => e.OrgDetComCodGub, "IORGANISMOGUBER_DETALLE1");

            entity.HasIndex(e => new { e.OrgCodGub, e.OrgDetDirNroGub }, "IORGANISMOGUBER_DETALLE3").IsDescending(false, true);

            entity.HasIndex(e => new { e.OrgCodGub, e.OrgDetNroGub }, "IORGANISMOGUBER_DETALLE4").IsDescending(false, true);

            entity.Property(e => e.OrgDetCodAreaGub)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetComCodGub)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrgDetDesGub)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetDirCalleGub)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OrgDetDirCalleGUb");
            entity.Property(e => e.OrgDetDirNroGub)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.OrgDetEmailGub)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegcodGub)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RegcodGUB");
        });

        modelBuilder.Entity<OrganismosGuber>(entity =>
        {
            entity.HasKey(e => e.OrgCodGub).HasName("PK__Organism__AF0F3BFC603E1312");

            entity.ToTable("Organismos_Guber");

            entity.Property(e => e.OrgCodGub).ValueGeneratedNever();
            entity.Property(e => e.OrgDesGub)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<PadronElectoralDefinitivoEnChile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Padron_Electoral_Definitivo_en_Chile");

            entity.Property(e => e.Calidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CALIDAD");
            entity.Property(e => e.Circunscripcion)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSCRIPCION");
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMUNA");
            entity.Property(e => e.DireccionLocalVotacion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_LOCAL_VOTACION");
            entity.Property(e => e.Dv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DV");
            entity.Property(e => e.LocalVotacion)
                .IsUnicode(false)
                .HasColumnName("LOCAL_VOTACION");
            entity.Property(e => e.Mesa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESA");
            entity.Property(e => e.Nombre)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Run)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RUN");
        });

        modelBuilder.Entity<PadronElectoralDefinitivoEnExtranjero>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Padron_Electoral_Definitivo_en_Extranjero");

            entity.Property(e => e.Calidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CALIDAD");
            entity.Property(e => e.Circunscripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSCRIPCION");
            entity.Property(e => e.DireccionLocalVotacion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_LOCAL_VOTACION");
            entity.Property(e => e.Dv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DV");
            entity.Property(e => e.LocalVotacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCAL_VOTACION");
            entity.Property(e => e.Mesa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESA");
            entity.Property(e => e.Nombre)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.PaisCircunscripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAIS_CIRCUNSCRIPCION");
            entity.Property(e => e.Run)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RUN");
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.Paicod).HasName("PK__Paises__B12019632C8964E2");

            entity.Property(e => e.Paicod).ValueGeneratedNever();
            entity.Property(e => e.Contincod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaiAbr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaiGen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Painom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ParSinapro>(entity =>
        {
            entity.HasKey(e => e.SinParAno).HasName("PK__Par_Sina__28E54E7A6E022284");

            entity.ToTable("Par_Sinapro");

            entity.Property(e => e.SinParAno).ValueGeneratedNever();
        });

        modelBuilder.Entity<ParticipacionDelito>(entity =>
        {
            entity.HasKey(e => e.ParDelCod).HasName("PK__Particip__47ADB52C70A98505");

            entity.ToTable("Participacion_Delito");

            entity.Property(e => e.ParDelCod).ValueGeneratedNever();
            entity.Property(e => e.ParDelDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PasoEvidenciaacopiadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PASO_EVIDENCIAACOPIADA");

            entity.Property(e => e.Ruc)
                .HasMaxLength(255)
                .HasColumnName("ruc");
        });

        modelBuilder.Entity<PerFuncionario>(entity =>
        {
            entity.HasKey(e => e.PerFunRut).HasName("PK__Per_Func__205AAC99E3DBE014");

            entity.ToTable("Per_Funcionarios");

            entity.HasIndex(e => e.PerFunPatIni, "IPER_INIPAT").HasFillFactor(100);

            entity.HasIndex(e => e.PerFunEsp1, "IPer_Funcionarios1").HasFillFactor(100);

            entity.HasIndex(e => e.PerFunEsp2, "IPer_Funcionarios2").HasFillFactor(100);

            entity.HasIndex(e => new { e.PerFunCarCod, e.PerFunGraCod }, "IPer_Funcionarios3").HasFillFactor(100);

            entity.HasIndex(e => e.EspPeriCod, "IPer_Funcionarios4").HasFillFactor(100);

            entity.HasIndex(e => e.TenSexCod, "IPer_Funcionarios6").HasFillFactor(100);

            entity.HasIndex(e => e.PerFunIdPer, "IPer_FuncionariosPer").HasFillFactor(100);

            entity.HasIndex(e => new { e.PerFunApePat, e.PerFunApeMat, e.PerFunNombre }, "IPer_PATMATNOM").HasFillFactor(100);

            entity.Property(e => e.PerFunRut).ValueGeneratedNever();
            entity.Property(e => e.PerFunApeMat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunApePat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunCryptPass)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunCurExt)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunCurIns)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunDir)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunDv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunEdadHijos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunEstCiv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunFecIng).HasColumnType("datetime");
            entity.Property(e => e.PerFunFecNac).HasColumnType("datetime");
            entity.Property(e => e.PerFunFecUniIng).HasColumnType("datetime");
            entity.Property(e => e.PerFunIbm)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PerFunIBM");
            entity.Property(e => e.PerFunIdPer)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PerFunLugNac)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunPass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunPatIni)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PerFunRegDir)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunUniAct)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunUserGepol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerFunVisConCat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PerfunClave)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Perfunmultiuni).HasColumnName("PERFUNMULTIUNI");
        });

        modelBuilder.Entity<PerMovSolicitud>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.MovSolAno, e.MovSolFolio }).HasName("PK__Per_Mov___C64F4AEA6CB8F890");

            entity.ToTable("Per_Mov_Solicitud");

            entity.Property(e => e.MovSolFecha).HasColumnType("datetime");
            entity.Property(e => e.MovSolMotivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovSolRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovSolUni1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovSolUni2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovSolUni3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersoRelPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSO_REL_PBI");

            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA HECHO");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.DelitoDecreto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO DECRETO");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
        });

        modelBuilder.Entity<PersonaMorfologium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONA_MORFOLOGIA");

            entity.Property(e => e.Apodo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("APODO");
            entity.Property(e => e.Calle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CasaDepto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CASA/DEPTO");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Depto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("DEPTO");
            entity.Property(e => e.DiligenciaSobreLaPersona)
                .IsUnicode(false)
                .HasColumnName("DILIGENCIA SOBRE LA PERSONA");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(216)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADO CIVIL");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NACIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Genero)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.MarcaVehiculo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MARCA VEHICULO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.NombreFuncionario)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE FUNCIONARIO");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.NumeroTel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUMERO TEL.");
            entity.Property(e => e.ObsDiligencia)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("OBS. DILIGENCIA");
            entity.Property(e => e.OtraRedSocial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OTRA RED SOCIAL");
            entity.Property(e => e.PatenteVehiculo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATENTE VEHICULO");
            entity.Property(e => e.Persona)
                .HasMaxLength(92)
                .IsUnicode(false)
                .HasColumnName("PERSONA");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.Provincia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.RutFuncionario).HasColumnName("RUT FUNCIONARIO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
            entity.Property(e => e.Tatuaje)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TATUAJE");
            entity.Property(e => e.TipoAlteración)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ALTERACIÓN");
            entity.Property(e => e.TipoCicatriz)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO CICATRIZ");
            entity.Property(e => e.TipoDiligencia)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("TIPO DILIGENCIA");
            entity.Property(e => e.TipoDomicilio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO DOMICILIO");
            entity.Property(e => e.TipoRedSoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO RED SOC.");
            entity.Property(e => e.TipoVehiculo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("TIPO VEHICULO");
            entity.Property(e => e.UbicacionTatuaje)
                .HasMaxLength(60)
                .HasColumnName("UBICACION TATUAJE");
            entity.Property(e => e.UbucacionCicatriz)
                .HasMaxLength(60)
                .HasColumnName("UBUCACION CICATRIZ");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.UsuarioNick)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USUARIO/NICK");
        });

        modelBuilder.Entity<PersonasAsoDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("personas_aso_destapol");

            entity.Property(e => e.AsoInvDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.AsoTipDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperAsoAplIns).HasColumnName("UPerAsoAplIns");
            entity.Property(e => e.UperAsoAplUpd).HasColumnName("UPerAsoAplUpd");
            entity.Property(e => e.UperAsoFecIni)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIni");
            entity.Property(e => e.UperAsoFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIns");
            entity.Property(e => e.UperAsoFecTer)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecTer");
            entity.Property(e => e.UperAsoFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecUpd");
            entity.Property(e => e.UperAsoObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UPerAsoObs");
            entity.Property(e => e.UperAsoPri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoPri");
            entity.Property(e => e.UperAsoSec)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoSec");
            entity.Property(e => e.UperAsoUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAsoUsuIns");
            entity.Property(e => e.UperAsoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAsoUsuUpd");
            entity.Property(e => e.UperAsoVigencia).HasColumnName("UPerAsoVigencia");
            entity.Property(e => e.UperAsoWrkStIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAsoWrkStIns");
            entity.Property(e => e.UperAsoWrkStUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAsoWrkStUpd");
        });

        modelBuilder.Entity<PersonasBrainSimple>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONAS_BRAIN_SIMPLE");

            entity.Property(e => e.ComunaDetencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA DETENCION");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA HECHO");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.CondicionFallecido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONDICION FALLECIDO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DET. ORGANISMO");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DV");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.EstadoDecreto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO DECRETO");
            entity.Property(e => e.EstadoDetenido)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ESTADO DETENIDO");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DETENCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOCUMENTO");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NACIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA DETENCION");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nomrbe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMRBE");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM.  DOC.");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<PersonasDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONAS_DESTAPOL");

            entity.Property(e => e.AntecedentesDentencion)
                .IsUnicode(false)
                .HasColumnName("ANTECEDENTES_DENTENCION");
            entity.Property(e => e.ApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.ApellMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apell_mat");
            entity.Property(e => e.AsistenciaConsular)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ASISTENCIA_CONSULAR");
            entity.Property(e => e.Calle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.CalleDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_DETENCION");
            entity.Property(e => e.CalleNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("calle_Nro");
            entity.Property(e => e.CircunstanciaDetencion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSTANCIA_DETENCION");
            entity.Property(e => e.CodCalleDet)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_DET");
            entity.Property(e => e.CodComuDet)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMU_DET");
            entity.Property(e => e.CodCondicion).HasColumnName("COD_CONDICION");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodEstCivil)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_EST_CIVIL");
            entity.Property(e => e.CodMotDetencion).HasColumnName("COD_MOT_DETENCION");
            entity.Property(e => e.CodPaisNac).HasColumnName("COD_PAIS_NAC");
            entity.Property(e => e.ComunaDetencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_DETENCION");
            entity.Property(e => e.ComunaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_persona");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.CondicionFallecido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONDICION FALLECIDO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DirContactoMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DIR_CONTACTO_MENOR");
            entity.Property(e => e.DirExactaDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DIR_EXACTA_DETENCION");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EST_CIVIL");
            entity.Property(e => e.EstadoDetencion)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ESTADO_DETENCION");
            entity.Property(e => e.EstudiosTerminados)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DETENCION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EVALUACION");
            entity.Property(e => e.FechaEvaluacionreal)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EVALUACIONREAL");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO_SISTEMA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("folio_interno_decreto");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA_DETENCION");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID_UNIDAD");
            entity.Property(e => e.IdiomaLecturaDederecho)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IDIOMA_LECTURA_DEDERECHO");
            entity.Property(e => e.InpPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InpPerID");
            entity.Property(e => e.LatitudDetencion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("latitudDetencion");
            entity.Property(e => e.LatitudDomicilio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("latitudDomicilio");
            entity.Property(e => e.LecturaDeDerechos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LECTURA_DE_DERECHOS");
            entity.Property(e => e.LesionesDetencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LESIONES_DETENCION");
            entity.Property(e => e.LongitudDetencion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("longitudDetencion");
            entity.Property(e => e.LongitudDomicilio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("longitudDomicilio");
            entity.Property(e => e.LugarDetencion)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DETENCION");
            entity.Property(e => e.MedProtecMenor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MED_PROTEC_MENOR");
            entity.Property(e => e.MenorDirigidoA)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("MENOR_DIRIGIDO_A");
            entity.Property(e => e.MinDetencion).HasColumnName("MIN_DETENCION");
            entity.Property(e => e.MotDetencion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MOT_DETENCION");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombrePersonaRetiraMenor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE_PERSONA_RETIRA_MENOR");
            entity.Property(e => e.NroDireccionDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION_DET");
            entity.Property(e => e.NroDpto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("nro_DPTO");
            entity.Property(e => e.NroParcelaDeptoDet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO_DET");
            entity.Property(e => e.Orden)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ORDEN");
            entity.Property(e => e.PaisDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("paisDocumento");
            entity.Property(e => e.PresentaLesionesDetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRESENTA_LESIONES_DETENCION");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.ProvinciaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROVINCIA_PERSONA");
            entity.Property(e => e.RegionDetencion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_detencion");
            entity.Property(e => e.RegionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_persona");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.RelacionConMenor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RELACION_CON_MENOR");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RESULTADO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TiempoDetencion)
                .HasColumnType("datetime")
                .HasColumnName("tiempo_detencion");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("villa/pob");
        });

        modelBuilder.Entity<PersonasDetalle11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONAS_DETALLE_11");

            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleOrganisgoGuber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORGANISGO GUBER");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DETENCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.HoraMinutoDetencion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("HORA/MINUTO DETENCION");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.OrganismoGuber)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO GUBER");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<PersonasDetalleMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONAS_DETALLE_MES");

            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleOrganisgoGuber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORGANISGO GUBER");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DETENCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.HoraMinutoDetencion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("HORA/MINUTO DETENCION");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.OrganismoGuber)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO GUBER");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<PersonasPmJenage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONAS_PM_JENAGES");

            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleOrganisgoGuber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORGANISGO GUBER");
            entity.Property(e => e.EstadoDetencion)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("ESTADO DETENCION");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DETENCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.HoraMinutoDetencion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("HORA/MINUTO DETENCION");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.NumeroDocumentoPersona)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO PERSONA");
            entity.Property(e => e.OrganismoGuber)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO GUBER");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<PersonasSimplificadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONAS_SIMPLIFICADA");

            entity.Property(e => e.CondicionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION PERSONA");
            entity.Property(e => e.DvDocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DV. DOCUMENTO");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADO CIVIL");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NACIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.FolioPersona).HasColumnName("FOLIO PERSONA");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Naci0nalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACI0NALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO DOCUMENTO");
        });

        modelBuilder.Entity<Pla>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PLAS");

            entity.Property(e => e.CarroPlas)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARRO PLAS");
            entity.Property(e => e.ComunaPlas)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA PLAS");
            entity.Property(e => e.EstadoPlas)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("ESTADO PLAS");
            entity.Property(e => e.FechaPlas)
                .HasColumnType("datetime")
                .HasColumnName("FECHA PLAS");
            entity.Property(e => e.HoraPlas)
                .HasColumnType("datetime")
                .HasColumnName("HORA PLAS");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.MaternoFun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO FUN");
            entity.Property(e => e.MaternoPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO PERSONA");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.NombreFun)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE FUN");
            entity.Property(e => e.NombrePersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE PERSONA");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO DOCUMENTO");
            entity.Property(e => e.PaisDoc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAIS DOC.");
            entity.Property(e => e.PaternoFun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO FUN");
            entity.Property(e => e.PaternoPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO PERSONA");
            entity.Property(e => e.RegPlas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REG. PLAS");
            entity.Property(e => e.RutFun).HasColumnName("RUT FUN");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO DOC.");
            entity.Property(e => e.TipoServicioPlas)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("TIPO SERVICIO PLAS");
        });

        modelBuilder.Entity<Plebicito2022Decreto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PLEBICITO_2022_DECRETOS");

            entity.Property(e => e.ConSinResultado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CON / SIN RESULTADO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.EstadoDecreto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO DECRETO");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA EVALUACION");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA / HORA INGRESO SISTEMA");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.HoraRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("HORA RECEPCION");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VerbalEscrita)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VERBAL / ESCRITA");
        });

        modelBuilder.Entity<Plebicito2022Persona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PLEBICITO_2022_PERSONAS");

            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA HECHO");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DET. ORGANISMO");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DV");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.EstadoDecreto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO DECRETO");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaDetencion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DETENCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOCUMENTO");
            entity.Property(e => e.FechaIngresoPersona)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO PERSONA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NACIMIENTO");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.HoraDetencion).HasColumnName("HORA DETENCION");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nomrbe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMRBE");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM.  DOC.");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION UNIDAD");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<PresuntaDesgracium>(entity =>
        {
            entity.HasKey(e => new { e.PreDesAno, e.PreDesFolio }).HasName("PK__Presunta__AE4A5D48560A9D62");

            entity.ToTable("Presunta_Desgracia");

            entity.HasIndex(e => e.PreDesUperId, "IPRESUNTA_DESGRACIA1");

            entity.HasIndex(e => e.PreDesReg, "IPRESUNTA_DESGRACIA2");

            entity.HasIndex(e => e.PreDesUni, "IPRESUNTA_DESGRACIA3");

            entity.HasIndex(e => new { e.PreDesProvCod, e.PreDesComCod }, "IPRESUNTA_DESGRACIA4");

            entity.HasIndex(e => e.PreDesUperDenId, "IPRESUNTA_DESGRACIA5");

            entity.Property(e => e.PreDesCalle1)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PreDesCalle2)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PreDesComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PreDesDir)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PreDesFec).HasColumnType("datetime");
            entity.Property(e => e.PreDesFecTer).HasColumnType("datetime");
            entity.Property(e => e.PreDesFecUpd).HasColumnType("datetime");
            entity.Property(e => e.PreDesFun)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreDesFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreDesObs)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PreDesProvCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PreDesReg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PreDesUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PreDesUperDenId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PreDesUPerDenId");
            entity.Property(e => e.PreDesUperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PreDesUPerId");
            entity.Property(e => e.PreFecHoraIng).HasColumnType("datetime");
        });

        modelBuilder.Entity<PresuntasDesgracia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PRESUNTAS_DESGRACIAS");

            entity.Property(e => e.CodPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD. PERSONA");
            entity.Property(e => e.ConRSinR)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CON R/ SIN R");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE ORGANISMO");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FecNac)
                .HasColumnType("datetime")
                .HasColumnName("FEC. NAC.");
            entity.Property(e => e.FechaDoc)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DOC.");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumImpli).HasColumnName("NUM IMPLI");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.Tag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
        });

        modelBuilder.Entity<Profesione>(entity =>
        {
            entity.HasKey(e => e.PrfCod).HasName("PK__Profesio__F0F0C31F0B13627E");

            entity.HasIndex(e => e.PrfDes, "IPROFESIONES2");

            entity.Property(e => e.PrfCod).ValueGeneratedNever();
            entity.Property(e => e.PrfDes)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.HasKey(e => e.ProviCod).HasName("PK__Provinci__3581293A125F7E8B");

            entity.HasIndex(e => e.Regcod, "IPROVINCIAS1");

            entity.HasIndex(e => new { e.ProviCod, e.Regcod }, "IPROVINCIAS2");

            entity.Property(e => e.ProviCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProviDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Regcod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProvinciaComuna>(entity =>
        {
            entity.HasKey(e => new { e.ProviCod, e.ComCod }).HasName("PK__Provinci__2D9826940E8EEDA7");

            entity.ToTable("ProvinciaComuna");

            entity.HasIndex(e => e.ComCod, "IPROVINCIACOMUNA1");

            entity.Property(e => e.ProviCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ReconocimientoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.RecVisFolio, e.RecVisUperId }).HasName("PK__Reconoci__2A6CA50471D2B368");

            entity.ToTable("Reconocimiento_Detalle");

            entity.Property(e => e.RecVisFolio).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.RecVisUperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecVisFotoPor).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<ReconocimientoFoto>(entity =>
        {
            entity.HasKey(e => e.RecVisFolio).HasName("PK__Reconoci__50B326567A67F969");

            entity.ToTable("Reconocimiento_Foto");

            entity.HasIndex(e => e.RecVisUniEnv, "IRECONOCIMIENTO_FOTO1");

            entity.HasIndex(e => e.RecVisDelCod, "IRECONOCIMIENTO_FOTO2");

            entity.HasIndex(e => e.RecComCod, "IRECONOCIMIENTO_FOTO3");

            entity.HasIndex(e => e.RecVisId, "IRECONOCIMIENTO_FOTO4");

            entity.HasIndex(e => new { e.RecOrgCod, e.RecDetOrgNro }, "IRECONOCIMIENTO_FOTO5");

            entity.HasIndex(e => e.RecProCod, "IRECONOCIMIENTO_FOTO6");

            entity.Property(e => e.RecVisFolio).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.RecCallePrin)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecCalleRef1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecCalleRef2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecFunDateIns).HasColumnType("datetime");
            entity.Property(e => e.RecFunDateUpd).HasColumnType("datetime");
            entity.Property(e => e.RecFunRutIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecFunRutUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecProCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecVisFec).HasColumnType("datetime");
            entity.Property(e => e.RecVisId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RecVisModus).IsUnicode(false);
            entity.Property(e => e.RecVisUniEnv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<RedesSocialesPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REDES_SOCIALES_PERSONAS");

            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("FECHA NAC.");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID Persona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM. DOC");
            entity.Property(e => e.OtraRedSocial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OTRA RED SOCIAL");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoRedSoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO RED SOC.");
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.UsarioNick)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USARIO/NICK");
            entity.Property(e => e._1Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO");
            entity.Property(e => e._2Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO");
        });

        modelBuilder.Entity<Regione>(entity =>
        {
            entity.HasKey(e => e.Regcod).HasName("PK__Regiones__D373881B027E1C7D");

            entity.Property(e => e.Regcod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RegNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RegNomFor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ResumenEstadistico>(entity =>
        {
            entity.HasKey(e => e.EstadisId).HasName("PK__RESUMEN___2305AC9D265B8A40");

            entity.ToTable("RESUMEN_ESTADISTICO");

            entity.HasIndex(e => new { e.EstadisInpfecrecep, e.EstadisRegcod, e.EstadisPrefcod, e.EstadisUnicod, e.EstadisTipdelcod }, "ESTADIS_BUSQUEDA_INDEX");

            entity.HasIndex(e => e.EstadisJefcod, "ESTADIS_JEFCOD_INDEX");

            entity.HasIndex(e => e.EstadisPrefcod, "ESTADIS_PREFCOD_INDEX");

            entity.HasIndex(e => e.EstadisRegcod, "ESTADIS_REGCOD_INDEX");

            entity.HasIndex(e => e.EstadisTipdelcod, "ESTADIS_TIPDELCOD_INDEX");

            entity.HasIndex(e => e.EstadisTipoordencod, "ESTADIS_TIPOORDENCOD_INDEX");

            entity.HasIndex(e => e.EstadisUnicod, "ESTADIS_UNICOD_INDEX");

            entity.Property(e => e.EstadisId)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("ESTADIS_ID");
            entity.Property(e => e.EstadisCantidad).HasColumnName("ESTADIS_CANTIDAD");
            entity.Property(e => e.EstadisInpfecrecep)
                .HasColumnType("datetime")
                .HasColumnName("ESTADIS_INPFECRECEP");
            entity.Property(e => e.EstadisJefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADIS_JEFCOD");
            entity.Property(e => e.EstadisPrefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADIS_PREFCOD");
            entity.Property(e => e.EstadisRegcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADIS_REGCOD");
            entity.Property(e => e.EstadisTipdelcod).HasColumnName("ESTADIS_TIPDELCOD");
            entity.Property(e => e.EstadisTipoordencod).HasColumnName("ESTADIS_TIPOORDENCOD");
            entity.Property(e => e.EstadisUnicod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADIS_UNICOD");
        });

        modelBuilder.Entity<ResumenEstadisticoDelito>(entity =>
        {
            entity.HasKey(e => e.EstadisdelitoId).HasName("PK__RESUMEN___BFD2AD070E8400AF");

            entity.ToTable("RESUMEN_ESTADISTICO_DELITO");

            entity.HasIndex(e => e.EstadisdelitoDelcod, "ESTADISDELITO_DELCOD_INDEX");

            entity.HasIndex(e => e.EstadisdelitoInpfecrecep, "ESTADISDELITO_FEC_INDEX");

            entity.HasIndex(e => e.EstadisdelitoInpuniingcod, "ESTADISDELITO_INPUNI_INDEX");

            entity.HasIndex(e => e.EstadisdelitoPrefcod, "ESTADISDELITO_PREFCOD_INDEX");

            entity.HasIndex(e => e.EstadisdelitoRegcod, "ESTADISDELITO_REGCOD_INDEX");

            entity.Property(e => e.EstadisdelitoId)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("ESTADISDELITO_ID");
            entity.Property(e => e.EstadisdelitoCalledes)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_CALLEDES");
            entity.Property(e => e.EstadisdelitoComdes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_COMDES");
            entity.Property(e => e.EstadisdelitoDelcod).HasColumnName("ESTADISDELITO_DELCOD");
            entity.Property(e => e.EstadisdelitoDeldes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_DELDES");
            entity.Property(e => e.EstadisdelitoGesgenunides)
                .HasMaxLength(208)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_GESGENUNIDES");
            entity.Property(e => e.EstadisdelitoInpdendirlat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPDENDIRLAT");
            entity.Property(e => e.EstadisdelitoInpdendirlong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPDENDIRLONG");
            entity.Property(e => e.EstadisdelitoInpdendirnpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPDENDIRNPD");
            entity.Property(e => e.EstadisdelitoInpdendirnro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPDENDIRNRO");
            entity.Property(e => e.EstadisdelitoInpdenlugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPDENLUGAR");
            entity.Property(e => e.EstadisdelitoInpdenlugdel)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_INPDENLUGDEL");
            entity.Property(e => e.EstadisdelitoInpdennro)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("ESTADISDELITO_INPDENNRO");
            entity.Property(e => e.EstadisdelitoInpdenvillapob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_INPDENVILLAPOB");
            entity.Property(e => e.EstadisdelitoInpendfecdoc)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPENDFECDOC");
            entity.Property(e => e.EstadisdelitoInpfechecho1)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPFECHECHO1");
            entity.Property(e => e.EstadisdelitoInpfechecho2)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPFECHECHO2");
            entity.Property(e => e.EstadisdelitoInpfecreaing)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPFECREAING");
            entity.Property(e => e.EstadisdelitoInpfecrecep)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPFECRECEP");
            entity.Property(e => e.EstadisdelitoInpfolio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_INPFOLIO");
            entity.Property(e => e.EstadisdelitoInphorarecep)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPHORARECEP");
            entity.Property(e => e.EstadisdelitoInphorhecho1)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPHORHECHO1");
            entity.Property(e => e.EstadisdelitoInphorhecho2)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPHORHECHO2");
            entity.Property(e => e.EstadisdelitoInpobs)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_INPOBS");
            entity.Property(e => e.EstadisdelitoInpperutilinv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPPERUTILINV");
            entity.Property(e => e.EstadisdelitoInpresfeccancel)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_INPRESFECCANCEL");
            entity.Property(e => e.EstadisdelitoInpresfunparte).HasColumnName("ESTADISDELITO_INPRESFUNPARTE");
            entity.Property(e => e.EstadisdelitoInpuniingcod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDELITO_INPUNIINGCOD");
            entity.Property(e => e.EstadisdelitoJefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_JEFCOD");
            entity.Property(e => e.EstadisdelitoNombre)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_NOMBRE");
            entity.Property(e => e.EstadisdelitoPerfunvisconcat)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_PERFUNVISCONCAT");
            entity.Property(e => e.EstadisdelitoPrefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_PREFCOD");
            entity.Property(e => e.EstadisdelitoRegcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_REGCOD");
            entity.Property(e => e.EstadisdelitoTipdelcod).HasColumnName("ESTADISDELITO_TIPDELCOD");
            entity.Property(e => e.EstadisdelitoTipdeldes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_TIPDELDES");
            entity.Property(e => e.EstadisdelitoUnildedes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_UNILDEDES");
            entity.Property(e => e.EstadisdelitoUnilugnom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_UNILUGNOM");
            entity.Property(e => e.EstadisdelitoUperconddes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_UPERCONDDES");
            entity.Property(e => e.EstadisdelitoUperdocnro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADISDELITO_UPERDOCNRO");
            entity.Property(e => e.EstadisdelitoUperedad).HasColumnName("ESTADISDELITO_UPEREDAD");
            entity.Property(e => e.EstadisdelitoUperfchnac)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDELITO_UPERFCHNAC");
        });

        modelBuilder.Entity<ResumenEstadisticoDroga>(entity =>
        {
            entity.HasKey(e => e.EstadisdrogaId).HasName("PK__RESUMEN___AE9356651AE9D794");

            entity.ToTable("RESUMEN_ESTADISTICO_DROGA");

            entity.HasIndex(e => e.EstadisdrogaDrogcod, "ESTADIS_DROGA_DROGCOD");

            entity.HasIndex(e => e.EstadisdrogaInpfecrecep, "ESTADIS_DROGA_INPFECRECEP");

            entity.HasIndex(e => e.EstadisdrogaJefcod, "ESTADIS_DROGA_JEFCOD");

            entity.HasIndex(e => e.EstadisdrogaPrefcod, "ESTADIS_DROGA_PREFCOD");

            entity.HasIndex(e => e.EstadisdrogaRegcod, "ESTADIS_DROGA_REGCOD");

            entity.HasIndex(e => e.EstadisdrogaTipoordencod, "ESTADIS_DROGA_TIPOORDENCOD");

            entity.HasIndex(e => e.EstadisdrogaUnicod, "ESTADIS_DROGA_UNICOD");

            entity.Property(e => e.EstadisdrogaId)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("ESTADISDROGA_ID");
            entity.Property(e => e.EstadisdrogaCantidad).HasColumnName("ESTADISDROGA_CANTIDAD");
            entity.Property(e => e.EstadisdrogaDrogcod).HasColumnName("ESTADISDROGA_DROGCOD");
            entity.Property(e => e.EstadisdrogaInpfecrecep)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISDROGA_INPFECRECEP");
            entity.Property(e => e.EstadisdrogaJefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISDROGA_JEFCOD");
            entity.Property(e => e.EstadisdrogaPrefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISDROGA_PREFCOD");
            entity.Property(e => e.EstadisdrogaRegcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISDROGA_REGCOD");
            entity.Property(e => e.EstadisdrogaTipoordencod).HasColumnName("ESTADISDROGA_TIPOORDENCOD");
            entity.Property(e => e.EstadisdrogaUnicod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISDROGA_UNICOD");
        });

        modelBuilder.Entity<ResumenEstadisticoEspecie>(entity =>
        {
            entity.HasKey(e => e.EstadisespecieId).HasName("PK__RESUMEN___6B6718D81EBA6878");

            entity.ToTable("RESUMEN_ESTADISTICO_ESPECIE");

            entity.HasIndex(e => e.EstadisespecieInpesptipo, "ESTADIS_ESPECIE_INPESPTIPO");

            entity.HasIndex(e => e.EstadisespecieInpfecrecep, "ESTADIS_ESPECIE_INPFECRECEP");

            entity.HasIndex(e => e.EstadisespecieJefcod, "ESTADIS_ESPECIE_JEFCOD");

            entity.HasIndex(e => e.EstadisespeciePrefcod, "ESTADIS_ESPECIE_PREFCOD");

            entity.HasIndex(e => e.EstadisespecieRegcod, "ESTADIS_ESPECIE_REGCOD");

            entity.HasIndex(e => e.EstadisespecieTipoordencod, "ESTADIS_ESPECIE_TIPOORDENCOD");

            entity.HasIndex(e => e.EstadisespecieUnicod, "ESTADIS_ESPECIE_UNICOD");

            entity.Property(e => e.EstadisespecieId)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("ESTADISESPECIE_ID");
            entity.Property(e => e.EstadisespecieCantidad).HasColumnName("ESTADISESPECIE_CANTIDAD");
            entity.Property(e => e.EstadisespecieInpesptipo).HasColumnName("ESTADISESPECIE_INPESPTIPO");
            entity.Property(e => e.EstadisespecieInpfecrecep)
                .HasColumnType("datetime")
                .HasColumnName("ESTADISESPECIE_INPFECRECEP");
            entity.Property(e => e.EstadisespecieJefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISESPECIE_JEFCOD");
            entity.Property(e => e.EstadisespeciePrefcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISESPECIE_PREFCOD");
            entity.Property(e => e.EstadisespecieRegcod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ESTADISESPECIE_REGCOD");
            entity.Property(e => e.EstadisespecieTipoordencod).HasColumnName("ESTADISESPECIE_TIPOORDENCOD");
            entity.Property(e => e.EstadisespecieUnicod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADISESPECIE_UNICOD");
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.RubCod).HasName("PK__Rubros__208C80335D76B500");

            entity.Property(e => e.RubCod).ValueGeneratedNever();
            entity.Property(e => e.RubDes)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RucPalasqlo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ruc_palasqlo");

            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.F8).HasMaxLength(255);
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(255)
                .HasColumnName("folio_interno_decreto");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(255)
                .HasColumnName("ID_UNIDAD");
            entity.Property(e => e.InpPerId)
                .HasMaxLength(255)
                .HasColumnName("InpPerID");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(255)
                .HasColumnName("REGION_UNIDAD");
            entity.Property(e => e.Unidad)
                .HasMaxLength(255)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<RutIndultado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rut_indultados");

            entity.Property(e => e.Dv)
                .HasMaxLength(255)
                .HasColumnName("dv");
            entity.Property(e => e.Identificador).HasMaxLength(255);
        });

        modelBuilder.Entity<SebaAux01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SEBA_AUX01");

            entity.Property(e => e.Folio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("folio");
        });

        modelBuilder.Entity<SebaAux05>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("seba_aux05");

            entity.Property(e => e.TotUniInpCaso).HasColumnName("tot_uni_inp_caso");
            entity.Property(e => e.UnidadInpCaso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("unidad_inp_caso");
        });

        modelBuilder.Entity<Siglo>(entity =>
        {
            entity.HasKey(e => e.SigCod).HasName("PK__Siglos__2251F1994F138710");

            entity.Property(e => e.SigCod).ValueGeneratedNever();
            entity.Property(e => e.SigDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Ss11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SS_11");

            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAlternativa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTERNATIVA");
            entity.Property(e => e.CalleIntersecta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_INTERSECTA");
            entity.Property(e => e.CodCalle)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE");
            entity.Property(e => e.CodCalleIntersecta)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_INTERSECTA");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodLugar).HasColumnName("COD_LUGAR");
            entity.Property(e => e.CodLugarDet).HasColumnName("COD_LUGAR_DET");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_REGION");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LUGAR");
            entity.Property(e => e.LugarDet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DET");
            entity.Property(e => e.LugarNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_NOMBRE");
            entity.Property(e => e.NroDireccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION");
            entity.Property(e => e.NroParcelaDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Sector)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.SitioDelSuceso)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SITIO_DEL_SUCESO");
            entity.Property(e => e.SsFolio).HasColumnName("SS_FOLIO");
            entity.Property(e => e.TipoLugar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_LUGAR");
        });

        modelBuilder.Entity<Ss11Me>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SS_11_MES");

            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAlternativa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTERNATIVA");
            entity.Property(e => e.CalleIntersecta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_INTERSECTA");
            entity.Property(e => e.CodCalle)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE");
            entity.Property(e => e.CodCalleIntersecta)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_INTERSECTA");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodLugar).HasColumnName("COD_LUGAR");
            entity.Property(e => e.CodLugarDet).HasColumnName("COD_LUGAR_DET");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_REGION");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LUGAR");
            entity.Property(e => e.LugarDet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DET");
            entity.Property(e => e.LugarNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_NOMBRE");
            entity.Property(e => e.NroDireccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION");
            entity.Property(e => e.NroParcelaDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Sector)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.SitioDelSuceso)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SITIO_DEL_SUCESO");
            entity.Property(e => e.SsFolio).HasColumnName("SS_FOLIO");
            entity.Property(e => e.TipoLugar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_LUGAR");
        });

        modelBuilder.Entity<SsDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SS_DESTAPOL");

            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.CalleAlternativa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CALLE_ALTERNATIVA");
            entity.Property(e => e.CalleIntersecta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_INTERSECTA");
            entity.Property(e => e.CodCalle)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE");
            entity.Property(e => e.CodCalleIntersecta)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("COD_CALLE_INTERSECTA");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodLugar).HasColumnName("COD_LUGAR");
            entity.Property(e => e.CodLugarDet).HasColumnName("COD_LUGAR_DET");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_REGION");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DELITO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LUGAR");
            entity.Property(e => e.LugarDet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_DET");
            entity.Property(e => e.LugarNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_NOMBRE");
            entity.Property(e => e.NroDireccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_DIRECCION");
            entity.Property(e => e.NroParcelaDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NRO_PARCELA_DEPTO");
            entity.Property(e => e.Provincia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Sector)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.SitioDelSuceso)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SITIO_DEL_SUCESO");
            entity.Property(e => e.SsFolio).HasColumnName("SS_FOLIO");
            entity.Property(e => e.TipoLugar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_LUGAR");
        });

        modelBuilder.Entity<SsOfan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SS_OFAN");

            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.Comuna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR");
            entity.Property(e => e.NSs).HasColumnName("N° SS");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
        });

        modelBuilder.Entity<StatusVigencium>(entity =>
        {
            entity.HasKey(e => e.TipoVigencia).HasName("PK__STATUS_V__BC7F0E1568D35913");

            entity.ToTable("STATUS_VIGENCIA");

            entity.Property(e => e.TipoVigencia)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_VIGENCIA");
            entity.Property(e => e.DesVigencia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DES_VIGENCIA");
        });

        modelBuilder.Entity<SujetosDesconocido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SUJETOS_DESCONOCIDOS");

            entity.Property(e => e.AlturaFinal).HasColumnName("ALTURA FINAL");
            entity.Property(e => e.AlturaInicial).HasColumnName("ALTURA INICIAL");
            entity.Property(e => e.Apodo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("APODO");
            entity.Property(e => e.Cabello)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CABELLO");
            entity.Property(e => e.Cicatriz)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CICATRIZ");
            entity.Property(e => e.ColorCabello)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("COLOR CABELLO");
            entity.Property(e => e.ColorOjos)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("COLOR OJOS");
            entity.Property(e => e.ComunaDelito)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA DELITO");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION");
            entity.Property(e => e.Contextura)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CONTEXTURA");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DetalleVestimenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE VESTIMENTA");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID PERSONA");
            entity.Property(e => e.MaternoSupuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MATERNO SUPUESTO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.NombreSupuesto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE SUPUESTO");
            entity.Property(e => e.ObsVestimenta)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS. VESTIMENTA");
            entity.Property(e => e.PaternoSupuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PATERNO SUPUESTO");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.RangoEdad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RANGO EDAD");
            entity.Property(e => e.Ruc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RUC");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoBoca)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO BOCA");
            entity.Property(e => e.TipoCabeza)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO CABEZA");
            entity.Property(e => e.TipoCara)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO CARA");
            entity.Property(e => e.TipoFrente)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO FRENTE");
            entity.Property(e => e.TipoMenton)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO MENTON");
            entity.Property(e => e.TipoNariz)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO NARIZ");
            entity.Property(e => e.TipoOrdeja)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO ORDEJA");
            entity.Property(e => e.TipoPiel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO PIEL");
            entity.Property(e => e.TipoTatuaje)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TIPO TATUAJE");
            entity.Property(e => e.TipoVoz)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPO VOZ");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.Vestimenta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("VESTIMENTA");
        });

        modelBuilder.Entity<TagOfan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TAG_OFAN");

            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Tag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<Telefonium>(entity =>
        {
            entity.HasKey(e => e.TelCod).HasName("PK__Telefoni__B3ED45E1670B0C32");

            entity.HasIndex(e => e.ColCod, "ITELEFONIA1");

            entity.HasIndex(e => e.MarcElecCod, "ITELEFONIA2");

            entity.Property(e => e.TelCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TelDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TelModelo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TelNroSerie)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TempIdFoto>(entity =>
        {
            entity.HasKey(e => new { e.TempFunCod, e.TempFecCon, e.TempFotoUperId }).HasName("PK__Temp_IdF__B72740D502091B31");

            entity.ToTable("Temp_IdFoto");

            entity.Property(e => e.TempFecCon).HasColumnType("datetime");
            entity.Property(e => e.TempFotoUperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TempFotoUperID");
        });

        modelBuilder.Entity<TendenciasSexuale>(entity =>
        {
            entity.HasKey(e => e.TenSexCod).HasName("PK__Tendenci__8AF4183940905D8F");

            entity.ToTable("Tendencias_Sexuales");

            entity.Property(e => e.TenSexCod).ValueGeneratedNever();
            entity.Property(e => e.TenSexDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TinpActa>(entity =>
        {
            entity.HasKey(e => e.IdActa).HasName("PK__TINP_Act__4EE6FB6866984441");

            entity.ToTable("TINP_Actas");

            entity.Property(e => e.IdActa).HasColumnName("ID_Acta");
            entity.Property(e => e.DetalleActa)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("Detalle_Acta");
            entity.Property(e => e.NombreActa)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Nombre_Acta");
            entity.Property(e => e.VigActa).HasColumnName("Vig_Acta");
        });

        modelBuilder.Entity<TipoAlteracionFisica>(entity =>
        {
            entity.HasKey(e => e.TipAltFisCod).HasName("PK__Tipo_Alt__43FF992419C0A931");

            entity.ToTable("Tipo_Alteracion_Fisica");

            entity.Property(e => e.TipAltFisCod).ValueGeneratedNever();
            entity.Property(e => e.TipAltFisDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoAmputacion>(entity =>
        {
            entity.HasKey(e => e.TipAmpCod).HasName("PK__Tipo_Amp__B184907C5EBFDEF4");

            entity.ToTable("Tipo_Amputacion");

            entity.Property(e => e.TipAmpCod).ValueGeneratedNever();
            entity.Property(e => e.TipAmpDes)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoArma>(entity =>
        {
            entity.HasKey(e => e.TipArmCod).HasName("PK__Tipo_Arm__74765EE65497563C");

            entity.ToTable("Tipo_Arma");

            entity.Property(e => e.TipArmCod).ValueGeneratedNever();
            entity.Property(e => e.TipArmDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoBoca>(entity =>
        {
            entity.HasKey(e => e.TipoBocCod).HasName("PK__Tipo_Boc__18E2213204B07DB2");

            entity.ToTable("Tipo_Boca");

            entity.Property(e => e.TipoBocCod).ValueGeneratedNever();
            entity.Property(e => e.TipoBocDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCabello1>(entity =>
        {
            entity.HasKey(e => e.TipCabelCod).HasName("PK__Tipo_Cab__C8E0B3B032774862");

            entity.ToTable("Tipo_Cabello1");

            entity.Property(e => e.TipCabelCod).ValueGeneratedNever();
            entity.Property(e => e.TipCabelDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCabeza>(entity =>
        {
            entity.HasKey(e => e.TipCabCod).HasName("PK__Tipo_Cab__FCA4C8F4458A1CD6");

            entity.ToTable("Tipo_Cabeza");

            entity.Property(e => e.TipCabCod).ValueGeneratedNever();
            entity.Property(e => e.TipCabDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCalle>(entity =>
        {
            entity.HasKey(e => e.TipCalleCod).HasName("PK__Tipo_Cal__AA16653B0E4EF685");

            entity.ToTable("Tipo_Calle");

            entity.Property(e => e.TipCalleCod).ValueGeneratedNever();
            entity.Property(e => e.TipCalleDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCara>(entity =>
        {
            entity.HasKey(e => e.TipCarCod).HasName("PK__Tipo_Car__7945DFFE2AD6269A");

            entity.ToTable("Tipo_Cara");

            entity.Property(e => e.TipCarCod).ValueGeneratedNever();
            entity.Property(e => e.TipCarDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCicatriz>(entity =>
        {
            entity.HasKey(e => e.TipCicaCod).HasName("PK__Tipo_Cic__FAB2BA131BA8F1A3");

            entity.ToTable("Tipo_Cicatriz");

            entity.Property(e => e.TipCicaCod).ValueGeneratedNever();
            entity.Property(e => e.TipCicaDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCliente>(entity =>
        {
            entity.HasKey(e => e.TipoClienteId).HasName("PK__TipoClie__68CB036F7A87F4FA");

            entity.ToTable("TipoCliente");

            entity.Property(e => e.TipoClienteId).ValueGeneratedNever();
            entity.Property(e => e.TipoClienteDescripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoDelincuente>(entity =>
        {
            entity.HasKey(e => e.Deltipocod).HasName("PK__TIPO_DEL__DFE1C70CE2383122");

            entity.ToTable("TIPO_DELINCUENTE");

            entity.Property(e => e.Deltipocod)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("DELTIPOCOD");
            entity.Property(e => e.Deltipodes)
                .HasMaxLength(40)
                .HasColumnName("DELTIPODES");
        });

        modelBuilder.Entity<TipoDelito>(entity =>
        {
            entity.HasKey(e => e.TipDelCod).HasName("PK__Tipo_Del__426169D348317F57");

            entity.ToTable("Tipo_Delito");

            entity.HasIndex(e => e.TipDelCod, "ITIPO_DELITO1").IsDescending();

            entity.Property(e => e.TipDelCod).ValueGeneratedNever();
            entity.Property(e => e.TipDelDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.TipDocCod).HasName("PK__Tipo_Doc__8CAE58A73059F5C6");

            entity.ToTable("Tipo_Documento");

            entity.Property(e => e.TipDocCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipDocDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipDocDve)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoDroga>(entity =>
        {
            entity.HasKey(e => e.DrogCod).HasName("PK__Tipo_Dro__5D556D943E3E00C9");

            entity.ToTable("Tipo_Droga");

            entity.Property(e => e.DrogCod).ValueGeneratedNever();
            entity.Property(e => e.DrogDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoElectrodomestico>(entity =>
        {
            entity.HasKey(e => e.Tipeleccod).HasName("PK__TIPO_ELE__E06F21B7C2E32866");

            entity.ToTable("TIPO_ELECTRODOMESTICO");

            entity.Property(e => e.Tipeleccod)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIPELECCOD");
            entity.Property(e => e.Tipelecdes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPELECDES");
        });

        modelBuilder.Entity<TipoEncargo>(entity =>
        {
            entity.HasKey(e => e.TipEncCod).HasName("PK__Tipo_Enc__4F8DDA1A75392FF8");

            entity.ToTable("Tipo_Encargo");

            entity.Property(e => e.TipEncCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipEncDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEspecialidadPolicial>(entity =>
        {
            entity.HasKey(e => e.TipEspPolCod).HasName("PK__Tipo_Esp__F16BA19D7FA1AFD2");

            entity.ToTable("Tipo_Especialidad_Policial");

            entity.Property(e => e.TipEspPolCod).ValueGeneratedNever();
            entity.Property(e => e.TipEspPolDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEspeciesDetalle>(entity =>
        {
            entity.HasKey(e => new { e.TipoEspCod, e.TipoEspDetCod }).HasName("PK__Tipo_Esp__B0005B564D2B3E9E");

            entity.ToTable("Tipo_Especies_Detalle");

            entity.HasIndex(e => e.TipoEspDetDes, "IDESCRIPCION_ESPECIES");

            entity.Property(e => e.TipoEspDetCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoEspDetCodMp).HasColumnName("TipoEspDetCodMP");
            entity.Property(e => e.TipoEspDetDes)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEspecy>(entity =>
        {
            entity.HasKey(e => e.TipoEspCod).HasName("PK__Tipo_Esp__4EF4DA967D0F5BEA");

            entity.ToTable("Tipo_Especies");

            entity.Property(e => e.TipoEspCod).ValueGeneratedNever();
            entity.Property(e => e.TipoEspCodMp).HasColumnName("TipoEspCodMP");
            entity.Property(e => e.TipoEspDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoFrente>(entity =>
        {
            entity.HasKey(e => e.TipFreCod).HasName("PK__Tipo_Fre__4345ED8E214CBC60");

            entity.ToTable("Tipo_Frente");

            entity.Property(e => e.TipFreCod).ValueGeneratedNever();
            entity.Property(e => e.TipFreDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoHerramientum>(entity =>
        {
            entity.HasKey(e => e.Hertipocod).HasName("PK__TIPO_HER__7E8B619D1F96B992");

            entity.ToTable("TIPO_HERRAMIENTA");

            entity.Property(e => e.Hertipocod)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("HERTIPOCOD");
            entity.Property(e => e.Hertipodes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("HERTIPODES");
        });

        modelBuilder.Entity<TipoInstrumento>(entity =>
        {
            entity.HasKey(e => e.Tipmuscod).HasName("PK__TIPO_INS__95BDE04D9B903A8F");

            entity.ToTable("TIPO_INSTRUMENTO");

            entity.Property(e => e.Tipmuscod)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIPMUSCOD");
            entity.Property(e => e.Tipmusdes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPMUSDES");
        });

        modelBuilder.Entity<TipoInsumo>(entity =>
        {
            entity.HasKey(e => e.Tipinscod).HasName("PK__TIPO_INS__5CB3AD6F721F982B");

            entity.ToTable("TIPO_INSUMO");

            entity.Property(e => e.Tipinscod)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIPINSCOD");
            entity.Property(e => e.Tipinsdes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TIPINSDES");
        });

        modelBuilder.Entity<TipoMaterial>(entity =>
        {
            entity.HasKey(e => e.Mattipcod).HasName("PK__TIPO_MAT__0A2380F22C7025B4");

            entity.ToTable("TIPO_MATERIAL");

            entity.Property(e => e.Mattipcod)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("MATTIPCOD");
            entity.Property(e => e.Mattipdes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MATTIPDES");
        });

        modelBuilder.Entity<TipoMenton>(entity =>
        {
            entity.HasKey(e => e.TipoMenCod).HasName("PK__Tipo_Men__5A0D5593097532CF");

            entity.ToTable("Tipo_Menton");

            entity.Property(e => e.TipoMenCod).ValueGeneratedNever();
            entity.Property(e => e.TipoMenDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoNariz>(entity =>
        {
            entity.HasKey(e => e.TipNarizCod).HasName("PK__Tipo_Nar__CD85031719AB9A98");

            entity.ToTable("Tipo_Nariz");

            entity.Property(e => e.TipNarizCod).ValueGeneratedNever();
            entity.Property(e => e.TipNarizDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoOrden>(entity =>
        {
            entity.HasKey(e => e.TipoOrdenCod).HasName("PK__Tipo_Ord__C12BCC324AA3D7AE");

            entity.ToTable("Tipo_Orden");

            entity.HasIndex(e => e.TipoOrdenDes, "ITIPO_ORDEN2");

            entity.HasIndex(e => new { e.TipoOrdenVig, e.TipoOrdenDes }, "ITIPO_ORDEN3");

            entity.HasIndex(e => e.TipoOrdenMinCod, "ITIPO_ORDMINCOD");

            entity.Property(e => e.TipoOrdenCod).ValueGeneratedNever();
            entity.Property(e => e.TipoOrdenDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoOrdenTab>(entity =>
        {
            entity.HasKey(e => new { e.TipoOrdenCod, e.TipoOrdenTabId }).HasName("PK__Tipo_Ord__5B2362DE6B3AC472");

            entity.ToTable("Tipo_Orden_Tabs");

            entity.HasIndex(e => new { e.TipoOrdenCod, e.TipoOrdenTabOrd }, "ITIPO_ORDEN_TABS2");

            entity.HasIndex(e => new { e.TipoOrdenCod, e.TipoOrdenTabVig, e.TipoOrdenTabOrd }, "ITIPO_ORDEN_TABS3");

            entity.Property(e => e.TipoOrdenTabId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoOrdenTabDes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoOrdenTabVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoOreja>(entity =>
        {
            entity.HasKey(e => e.TipOrecCod).HasName("PK__Tipo_Ore__2BACB5F215DB09B4");

            entity.ToTable("Tipo_Oreja");

            entity.Property(e => e.TipOrecCod).ValueGeneratedNever();
            entity.Property(e => e.TipOreDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoOrganismoDelictual>(entity =>
        {
            entity.HasKey(e => e.Tiporgcrimcod).HasName("PK__Tipo_Org__2CA8F42571689F14");

            entity.ToTable("Tipo_Organismo_Delictual");

            entity.Property(e => e.Tiporgcrimcod)
                .ValueGeneratedNever()
                .HasColumnName("TIPORGCRIMCOD");
            entity.Property(e => e.Tiporgcrimdsc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPORGCRIMDSC");
            entity.Property(e => e.Tiporgcrimvig).HasColumnName("TIPORGCRIMVIG");
        });

        modelBuilder.Entity<TipoPiel>(entity =>
        {
            entity.HasKey(e => e.TipPielCod).HasName("PK__Tipo_Pie__DDAE810E1C880743");

            entity.ToTable("Tipo_Piel");

            entity.Property(e => e.TipPielCod).ValueGeneratedNever();
            entity.Property(e => e.TipPielDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoResistencium>(entity =>
        {
            entity.HasKey(e => e.Encredcod).HasName("PK__TIPO_RES__490487E3A04C88A3");

            entity.ToTable("TIPO_RESISTENCIA");

            entity.Property(e => e.Encredcod)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ENCREDCOD");
            entity.Property(e => e.Encreddes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ENCREDDES");
        });

        modelBuilder.Entity<TipoTatuaje>(entity =>
        {
            entity.HasKey(e => e.TipTatuCod).HasName("PK__Tipo_Tat__074E1EAF4E546D01");

            entity.ToTable("Tipo_Tatuajes");

            entity.Property(e => e.TipTatuCod).ValueGeneratedNever();
            entity.Property(e => e.TipTatuDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoUnidadPolicial>(entity =>
        {
            entity.HasKey(e => e.UniTipoCod).HasName("PK__Tipo_Uni__BF8D537655D59338");

            entity.ToTable("Tipo_Unidad_Policial");

            entity.Property(e => e.UniTipoCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniTipoDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoVillaPobla>(entity =>
        {
            entity.HasKey(e => e.VillaPoblaCod).HasName("PK__Tipo_Vil__2082F21159911583");

            entity.ToTable("Tipo_Villa_Pobla");

            entity.Property(e => e.VillaPoblaCod)
                .ValueGeneratedNever()
                .HasColumnName("VillaPobla_cod");
            entity.Property(e => e.VillaPoblaDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VillaPobla_desc");
        });

        modelBuilder.Entity<TipoVisa>(entity =>
        {
            entity.HasKey(e => e.VisaTipo).HasName("PK__TIPO_VIS__CB93F36C37F02A96");

            entity.ToTable("TIPO_VISAS");

            entity.Property(e => e.VisaTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VISA_TIPO");
            entity.Property(e => e.VisaDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VISA_DES");
        });

        modelBuilder.Entity<TipoVoz>(entity =>
        {
            entity.HasKey(e => e.TipoVozCod).HasName("PK__Tipo_Voz__CFC2B7E7120A78D0");

            entity.ToTable("Tipo_Voz");

            entity.Property(e => e.TipoVozCod).ValueGeneratedNever();
            entity.Property(e => e.TipoVozDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposVehiculo>(entity =>
        {
            entity.HasKey(e => e.TvhCod).HasName("PK__TiposVeh__2E0C0B6D45DF2291");

            entity.ToTable("TiposVehiculo");

            entity.HasIndex(e => e.TvhDes, "NOMBRE");

            entity.Property(e => e.TvhCod)
                .ValueGeneratedNever()
                .HasColumnName("tvhCod");
            entity.Property(e => e.TvhDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tvhDes");
        });

        modelBuilder.Entity<TotalSsConcu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TOTAL_SS_CONCU");

            entity.Property(e => e.Delito).HasColumnName("delito");
            entity.Property(e => e.EstadoSs)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Estado_SS");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tipo_decreto");
            entity.Property(e => e.TipoLugar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_LUGAR");
            entity.Property(e => e.TotalConcu).HasColumnName("TOTAL CONCU");
            entity.Property(e => e.TotalSs).HasColumnName("TOTAL SS");
        });

        modelBuilder.Entity<UniAbrirDocumento>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpEndNro, e.UniAbrNro }).HasName("PK__UNI_Abri__D4528465AAFAFA0C");

            entity.ToTable("UNI_Abrir_Documento");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniAbrFec).HasColumnType("datetime");
            entity.Property(e => e.UniAbrHor).HasColumnType("datetime");
            entity.Property(e => e.UniAbrObs).IsUnicode(false);
            entity.Property(e => e.UniAbrRfa).HasColumnName("UniAbrRFA");
        });

        modelBuilder.Entity<UniAno>(entity =>
        {
            entity.HasKey(e => e.UniAnosCod).HasName("PK__UNI_ANOS__976EBECF121F8769");

            entity.ToTable("UNI_ANOS");

            entity.HasIndex(e => e.UniAnosCod, "IUNI_ANOS2").IsDescending();

            entity.Property(e => e.UniAnosCod)
                .ValueGeneratedNever()
                .HasColumnName("UNI_ANOS_Cod");
            entity.Property(e => e.UniAnosDesc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UNI_ANOS_Desc");
        });

        modelBuilder.Entity<UniAntecedente>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UniantCorr }).HasName("PK__UNI_Ante__4F2994CF6343158A");

            entity.ToTable("UNI_Antecedentes");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UniantCorr).HasColumnName("UNIAntCorr");
        });

        modelBuilder.Entity<UniAtnMigPaiAnte>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCorrAntM, e.UperAnMgCrPai }).HasName("PK__UniAtnMi__8CF8402BCFC83001");

            entity.ToTable("UniAtnMigPaiAnte");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperAntMigFecFin).HasColumnType("datetime");
            entity.Property(e => e.UperAntMigFecIni).HasColumnType("datetime");
            entity.Property(e => e.UperAntMigForma)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniAudiGepol>(entity =>
        {
            entity.HasKey(e => new { e.UniAudiGplRutFun, e.UperId, e.UniAudiGplFecha }).HasName("PK__UniAudiG__88E834134C4C28FE");

            entity.ToTable("UniAudiGepol");

            entity.HasIndex(e => e.UperId, "IUNIAUDIGEPOL1");

            entity.HasIndex(e => new { e.UniAudiGplFecha, e.UniAudiGplRutFun, e.UperId }, "IUNIAUDIGEPOL2").IsDescending(true, false, false);

            entity.HasIndex(e => new { e.UniAudiGplFecha, e.UperId, e.UniAudiGplRutFun }, "IUNIAUDIGEPOL3").IsDescending(true, false, false);

            entity.HasIndex(e => new { e.UniAudiGplTpoIng, e.UniAudiGplFecha }, "IUNIAUDIGEPOL4").IsDescending(false, true);

            entity.HasIndex(e => new { e.UniAudiGepolUni, e.UniAudiGplFecha }, "IUNIAUDIGEPOL5").IsDescending(false, true);

            entity.Property(e => e.UniAudiGplRutFun).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UniAudiGplFecha).HasColumnType("datetime");
            entity.Property(e => e.UniAudiGepolUni)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UniAudiGplHh).HasColumnName("UniAudiGplHH");
            entity.Property(e => e.UniAudiGplInfo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniAudiGplMm).HasColumnName("UniAudiGplMM");
            entity.Property(e => e.UniAudiGplSs).HasColumnName("UniAudiGplSS");
            entity.Property(e => e.UniAudiGplWrkIng)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniAudiInterpol>(entity =>
        {
            entity.HasKey(e => new { e.UniAudiIplRutFun, e.UperId, e.UniAudiIplFecha }).HasName("PK__UniAudiI__C34E84826423B28F");

            entity.ToTable("UniAudiInterpol");

            entity.HasIndex(e => e.UperId, "IUNIAUDIINTERPOL1");

            entity.HasIndex(e => new { e.UniAudiIplFecha, e.UniAudiIplRutFun, e.UperId }, "IUNIAUDIINTERPOL2").IsDescending(true, false, false);

            entity.HasIndex(e => new { e.UniAudiIplFecha, e.UperId, e.UniAudiIplRutFun }, "IUNIAUDIINTERPOL3").IsDescending(true, false, false);

            entity.HasIndex(e => new { e.UniAudiIplTpoIng, e.UniAudiIplFecha }, "IUNIAUDIINTERPOL4").IsDescending(false, true);

            entity.HasIndex(e => new { e.UniAudiIplUni, e.UniAudiIplFecha }, "IUNIAUDIINTERPOL5").IsDescending(false, true);

            entity.Property(e => e.UniAudiIplRutFun).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UniAudiIplFecha).HasColumnType("datetime");
            entity.Property(e => e.UniAudiIplHh).HasColumnName("UniAudiIplHH");
            entity.Property(e => e.UniAudiIplInfo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniAudiIplMm).HasColumnName("UniAudiIplMM");
            entity.Property(e => e.UniAudiIplSs).HasColumnName("UniAudiIplSS");
            entity.Property(e => e.UniAudiIplUni)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UniAudiIplWrkIng)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniAudiWsDen>(entity =>
        {
            entity.HasKey(e => e.UniAudiWsDenFolio).HasName("PK__UniAudiW__E607EF5C46FD63FC");

            entity.ToTable("UniAudiWsDen");

            entity.HasIndex(e => new { e.UniAudiWsDenDate, e.UniAudiWsDenFolio }, "IUNIAUDIWSDENI").IsDescending(true, false);

            entity.HasIndex(e => new { e.UniAudiWsDenAa, e.UniAudiWsDenMm, e.UniAudiWsDenDd, e.UniAudiWsDenFolio }, "IUNIAUDIWSDENII").IsDescending(true, true, true, false);

            entity.HasIndex(e => e.UniAudiWsDenRa, "IUNIAUDIWSDENIII").IsDescending();

            entity.HasIndex(e => e.UniAudiWsDenRo, "IUNIAUDIWSDENIV").IsDescending();

            entity.HasIndex(e => new { e.UniAudiWsDenEst, e.UniAudiWsDenFolio }, "IUNIAUDIWSDENV").IsDescending(false, true);

            entity.Property(e => e.UniAudiWsDenFolio).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.UniAudiWsDenAa).HasColumnName("UniAudiWsDenAA");
            entity.Property(e => e.UniAudiWsDenDate)
                .HasColumnType("datetime")
                .HasColumnName("UniAudiWsDenDATE");
            entity.Property(e => e.UniAudiWsDenDd).HasColumnName("UniAudiWsDenDD");
            entity.Property(e => e.UniAudiWsDenEst).HasColumnName("UniAudiWsDenEST");
            entity.Property(e => e.UniAudiWsDenHh).HasColumnName("UniAudiWsDenHH");
            entity.Property(e => e.UniAudiWsDenMin).HasColumnName("UniAudiWsDenMIN");
            entity.Property(e => e.UniAudiWsDenMm).HasColumnName("UniAudiWsDenMM");
            entity.Property(e => e.UniAudiWsDenRa)
                .HasColumnType("decimal(11, 0)")
                .HasColumnName("UniAudiWsDenRA");
            entity.Property(e => e.UniAudiWsDenRo)
                .HasColumnType("decimal(11, 0)")
                .HasColumnName("UniAudiWsDenRO");
            entity.Property(e => e.UniAudiWsDenSs).HasColumnName("UniAudiWsDenSS");
            entity.Property(e => e.UniAudiWsDenXml)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("UniAudiWsDenXML");
        });

        modelBuilder.Entity<UniAudiWsEstado>(entity =>
        {
            entity.HasKey(e => e.UniAudiWsEstadoId).HasName("PK__UniAudiW__1D56BEB27F6CA5A8");

            entity.ToTable("UniAudiWsEstado");

            entity.Property(e => e.UniAudiWsEstadoId)
                .ValueGeneratedNever()
                .HasColumnName("UniAudiWsEstadoID");
            entity.Property(e => e.UniAudiWsEstadoDsc)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniAuditaMovimiento>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.AudMovNro }).HasName("PK__UNI_Audi__8D0A7258FD395F79");

            entity.ToTable("UNI_Audita_Movimientos");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.AudMovFec).HasColumnType("datetime");
            entity.Property(e => e.AudMovFre).HasColumnName("AudMovFRe");
            entity.Property(e => e.AudMovFso).HasColumnName("AudMovFSo");
            entity.Property(e => e.AudMovHor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudMovIp)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AudMovObs).IsUnicode(false);
            entity.Property(e => e.AudMovTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudUniDes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniAuditoria2>(entity =>
        {
            entity.HasKey(e => e.UniAudFolio).HasName("PK__Uni_Audi__6500B60D847F98A4");

            entity.ToTable("Uni_Auditoria2");

            entity.HasIndex(e => new { e.UniAudFecha, e.UniAudHora, e.UniAudMin, e.UniAudSeg }, "IUNI_AUDITORIA2").IsDescending();

            entity.Property(e => e.UniAudFolio)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UniAudAtrMod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniAudConcepto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniAudFecha).HasColumnType("datetime");
            entity.Property(e => e.UniAudIpHost)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniAudPgm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniAudTipMov)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniAudValAnt).IsUnicode(false);
            entity.Property(e => e.UniAudValKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniAudValNue).IsUnicode(false);
        });

        modelBuilder.Entity<UniAuditoriaFicha>(entity =>
        {
            entity.HasKey(e => new { e.AudFicIdp, e.AudFicFun, e.AudFicFec, e.AudFicHor }).HasName("PK__UNI_Audi__A81F1B8764EDB996");

            entity.ToTable("UNI_Auditoria_Ficha");

            entity.Property(e => e.AudFicIdp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AudFicIDP");
            entity.Property(e => e.AudFicFec).HasColumnType("datetime");
            entity.Property(e => e.AudFicHor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudFicIp)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniAuditoriaGepol>(entity =>
        {
            entity.HasKey(e => e.AudGepidp).HasName("PK__UNI_AUDI__6938EAAB26268016");

            entity.ToTable("UNI_AUDITORIA_GEPOL");

            entity.Property(e => e.AudGepidp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AudGEPIDP");
            entity.Property(e => e.AudGepfec)
                .HasColumnType("datetime")
                .HasColumnName("AudGEPFec");
            entity.Property(e => e.AudGepfun).HasColumnName("AudGEPFun");
            entity.Property(e => e.AudGephor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AudGEPHor");
            entity.Property(e => e.AudGepip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AudGEPIp");
        });

        modelBuilder.Entity<UniAuditorium>(entity =>
        {
            entity.HasKey(e => new { e.UniAudFecha, e.UniAudHora, e.UniAudMin, e.UniAudSeg, e.UniAudSec }).HasName("PK__Uni_Audi__23795D901D6F8315");

            entity.ToTable("Uni_Auditoria");

            entity.Property(e => e.UniAudFecha).HasColumnType("datetime");
            entity.Property(e => e.UniAudAtrMod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniAudConcepto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniAudIpHost)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniAudPgm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniAudTipMov)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniAudValAnt).IsUnicode(false);
            entity.Property(e => e.UniAudValKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniAudValNue).IsUnicode(false);
        });

        modelBuilder.Entity<UniBarrioPrioritario>(entity =>
        {
            entity.HasKey(e => new { e.UniBarrioNombre, e.UniBarrioCodComuna }).HasName("PK__Uni_Barr__DD2A06DC1E6AB201");

            entity.ToTable("Uni_BarrioPrioritario");

            entity.Property(e => e.UniBarrioNombre).HasMaxLength(100);
            entity.Property(e => e.UniBarrioComuna).HasMaxLength(50);
            entity.Property(e => e.UniBarrioPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniBarrioPK");
            entity.Property(e => e.UniBarrioRegion).HasMaxLength(100);
        });

        modelBuilder.Entity<UniCalibreArma>(entity =>
        {
            entity.HasKey(e => e.UniCodCalArma).HasName("PK__Uni_Cali__14988C753E930684");

            entity.ToTable("Uni_Calibre_Arma");

            entity.Property(e => e.UniNomCalArma)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniCalle>(entity =>
        {
            entity.HasKey(e => new { e.Nombrevial, e.Tipocalle, e.Nroregion }).HasName("PK__UNI_CALL__88E6A86662906FD8");

            entity.ToTable("UNI_CALLES");

            entity.Property(e => e.Nombrevial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBREVIAL");
            entity.Property(e => e.Tipocalle).HasColumnName("TIPOCALLE");
            entity.Property(e => e.Nroregion).HasColumnName("NROREGION");
            entity.Property(e => e.Comider)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMIDER");
            entity.Property(e => e.Comizq)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMIZQ");
            entity.Property(e => e.Desctipocalle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESCTIPOCALLE");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
        });

        modelBuilder.Entity<UniCalxTpArma>(entity =>
        {
            entity.HasKey(e => new { e.Unicodmodarma, e.UniCodTipoArma, e.UniCodCalArma }).HasName("PK__Uni_Calx__C17A7E8E92159D68");

            entity.ToTable("Uni_CalxTpArma");

            entity.HasIndex(e => e.UniCodCalArma, "ITUNI_CALXTIPARMA1");

            entity.Property(e => e.Unicodmodarma).HasColumnName("UNICODMODARMA");
        });

        modelBuilder.Entity<UniCargaApp>(entity =>
        {
            entity.HasKey(e => e.UniPathApp).HasName("PK__Uni_Carg__2248B70F7C8C57C1");

            entity.ToTable("Uni_CargaAPP");

            entity.Property(e => e.UniPathApp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UniPathAPP");
        });

        modelBuilder.Entity<UniCausasAsociada>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UnicauNro }).HasName("PK__UNI_Caus__A7A8CE112943CD87");

            entity.ToTable("UNI_Causas_Asociadas");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnicauNro).HasColumnName("UNICauNro");
            entity.Property(e => e.UniTipOrdPen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnicauDel).HasColumnName("UNICauDel");
            entity.Property(e => e.UnicauFec)
                .HasColumnType("datetime")
                .HasColumnName("UNICauFec");
            entity.Property(e => e.UnicauRuc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UNICauRUC");
        });

        modelBuilder.Entity<UniConFall>(entity =>
        {
            entity.HasKey(e => e.UniConFalCod).HasName("PK__Uni_ConF__46035DCF7A791FB1");

            entity.ToTable("Uni_ConFall");

            entity.Property(e => e.UniConFalCod).ValueGeneratedNever();
            entity.Property(e => e.UniConFalDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniConFalVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniConPai>(entity =>
        {
            entity.HasKey(e => e.UniCodContPai).HasName("PK__UniConPa__7E5DC788715D36D6");

            entity.Property(e => e.UniDesConPai)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniVigConPai)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniContadorVisita>(entity =>
        {
            entity.HasKey(e => e.IdVisita).HasName("PK__Uni_Cont__020AC827D1F7E6E3");

            entity.ToTable("Uni_ContadorVisitas");

            entity.Property(e => e.IdVisita).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.PerFunDateVisita).HasColumnType("datetime");
            entity.Property(e => e.PerFunUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PerWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniDelConclu>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpClcFolio, e.InpClcDelCod }).HasName("PK__UNI_DelC__896F53136BF99E43");

            entity.ToTable("UNI_DelConclu");

            entity.HasIndex(e => e.InpClcDelCod, "IUNIDELCONCLU2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniDelGruopCrim>(entity =>
        {
            entity.HasKey(e => new { e.GrupoCrimCodMa, e.GrupoCrimAsoCodM, e.GrupoCrimDelCod }).HasName("PK__UniDelGr__3B60C71EDEB81283");

            entity.ToTable("UniDelGruopCrim");

            entity.HasIndex(e => e.GrupoCrimDelCod, "IUNIDELGRUOPCRIM2");
        });

        modelBuilder.Entity<UniDelResev>(entity =>
        {
            entity.HasKey(e => e.UniCodDelRes).HasName("PK__UniDelRe__4972B7AF2196D523");

            entity.ToTable("UniDelResev");

            entity.Property(e => e.UniCodDelRes).ValueGeneratedNever();
        });

        modelBuilder.Entity<UniDelitosAsociado>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniDasnro }).HasName("PK__UNI_Deli__46A56BFAF745D29D");

            entity.ToTable("UNI_Delitos_Asociados");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniDasnro).HasColumnName("UniDASNro");
            entity.Property(e => e.UniDasobs)
                .IsUnicode(false)
                .HasColumnName("UniDASObs");
            entity.Property(e => e.Unidasdel).HasColumnName("UNIDASDel");
        });

        modelBuilder.Entity<UniDescriptorDelito>(entity =>
        {
            entity.HasKey(e => new { e.GesMedCod, e.GesDelCod }).HasName("PK__UNI_Desc__3069201957C8C8A2");

            entity.ToTable("UNI_Descriptor_Delitos");

            entity.HasIndex(e => e.GesDelCod, "IUNI_DESCRIPTOR_DELITOS2");
        });

        modelBuilder.Entity<UniDetConPai>(entity =>
        {
            entity.HasKey(e => new { e.UniCodContPai, e.UniDetCodConPai }).HasName("PK__UniDetCo__FBC36EABBA2AE968");

            entity.ToTable("UniDetConPai");

            entity.HasIndex(e => new { e.UniCodContPai, e.UnivigDetConPai, e.UniDetCodConPai }, "IUNIDETCONPAI2");

            entity.Property(e => e.UniDetDesConPai)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnivigDetConPai)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniDiligenciaPersona>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpPerFolio, e.UniDilCod }).HasName("PK__UNI_Dili__EF7ADDCC4F411B2F");

            entity.ToTable("UNI_Diligencia_Persona");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniDilDil).IsUnicode(false);
            entity.Property(e => e.UniDilFec).HasColumnType("datetime");
            entity.Property(e => e.UniDilHor).HasColumnType("datetime");
            entity.Property(e => e.UniDilRel).IsUnicode(false);
            entity.Property(e => e.UniDiliMot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniDiliObs)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniDiligenciasDocumento>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpDilNro, e.InpCorrDilDoc }).HasName("PK__Uni_Dili__050BA1498D0084B3");

            entity.ToTable("Uni_Diligencias_Documentos");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpDscDocDil)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniDiligenciasDocumentosDelA>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpDilNro, e.InpDilDelAso }).HasName("PK__Uni_Dili__5B138D9273D00A73");

            entity.ToTable("Uni_Diligencias_DocumentosDelA");

            entity.HasIndex(e => e.InpDilDelAso, "IUNI_DILIGENCIAS_DOCUMENTOSDEL");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniDocumentosVisado>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.DocVisNro }).HasName("PK__UNI_Docu__B5C6728E79B808D0");

            entity.ToTable("UNI_Documentos_Visados");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.DocVisCom).IsUnicode(false);
            entity.Property(e => e.DocVisFec).HasColumnType("datetime");
            entity.Property(e => e.DocVisFho)
                .HasColumnType("datetime")
                .HasColumnName("DocVisFHo");
            entity.Property(e => e.DocVisHor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniEntDesDro>(entity =>
        {
            entity.HasKey(e => e.UniEntDesDroCod).HasName("PK__Uni_EntD__1B5C85D66B3178ED");

            entity.ToTable("Uni_EntDesDro");

            entity.Property(e => e.UniEntDesDroCod).ValueGeneratedNever();
            entity.Property(e => e.UniEntDesDroDes)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniEntDesDroVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniEstadosEspecie>(entity =>
        {
            entity.HasKey(e => e.UniEstCod).HasName("PK__UNI_Esta__A0FDAFBF4A94872A");

            entity.ToTable("UNI_Estados_Especie");

            entity.Property(e => e.UniEstCod).ValueGeneratedNever();
            entity.Property(e => e.UniEstDes)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniFenDel>(entity =>
        {
            entity.HasKey(e => e.UniIdfenDel).HasName("PK__UniFenDe__C8BD6F5C18E2D0A4");

            entity.ToTable("UniFenDel");

            entity.HasIndex(e => e.UniDesFenDel, "IUNIFENDEL1");

            entity.Property(e => e.UniIdfenDel)
                .ValueGeneratedNever()
                .HasColumnName("UniIDFenDel");
            entity.Property(e => e.UniDesComFenDel)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UniDesFenDel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UniVigFenDel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniFolUniNac>(entity =>
        {
            entity.HasKey(e => new { e.UniParAnnoFol, e.GesGenUniCod }).HasName("PK__UniFolUn__2BFDEC2C26C59E94");

            entity.ToTable("UniFolUniNac");

            entity.HasIndex(e => e.GesGenUniCod, "IUNIFOLUNINAC2");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniParFol).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<UniFolioDenuncium>(entity =>
        {
            entity.HasKey(e => e.UniDenAno).HasName("PK__UNI_Foli__4BC5D0FAA793B563");

            entity.ToTable("UNI_Folio_Denuncia");

            entity.Property(e => e.UniDenAno).ValueGeneratedNever();
        });

        modelBuilder.Entity<UniFunOtrDili>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpDilNro, e.InpDiliFunJef }).HasName("PK__UNI_FunO__8033A3FF494FED5E");

            entity.ToTable("UNI_FunOtrDili");

            entity.HasIndex(e => e.InpDiliFunJef, "IUNI_FUNOTRDILI2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniFuncionarioUnidad>(entity =>
        {
            entity.HasKey(e => new { e.UniFunUniFechaNum, e.UniFunUniId }).HasName("PK__UNI_FUNC__2B99A5340E4852D2");

            entity.ToTable("UNI_FUNCIONARIO_UNIDAD");

            entity.Property(e => e.UniFunUniFechaNum).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniFunUniId)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("UniFunUniID");
            entity.Property(e => e.UniFunUniActDes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniFunUniActual)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniFunUniDestDes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniFunUniDestino)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniFunUniFchHr).HasColumnType("datetime");
            entity.Property(e => e.UniFunUniFecha).HasColumnType("datetime");
            entity.Property(e => e.UniFunUniRemWrk)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniFunUniRespon).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<UniGooglemap>(entity =>
        {
            entity.HasKey(e => e.UniGoogleKey).HasName("PK__UNI_GOOG__B55A068ECED79C0D");

            entity.ToTable("UNI_GOOGLEMAPS");

            entity.Property(e => e.UniGoogleKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniGoogleCount).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.UniGoogleUpdate).HasColumnType("date");
        });

        modelBuilder.Entity<UniHisEnvDev>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniFolHisEnvDev }).HasName("PK__UniHisEn__F8ED04BD0DBAC4FF");

            entity.ToTable("UniHisEnvDev");

            entity.HasIndex(e => e.UniFunEnvDev, "IUNIHISENVDEV");

            entity.HasIndex(e => new { e.InpFolio, e.UniFolHisEnvDev }, "IUNIHISENVDEV3").IsDescending(false, true);

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniEstEnvDev)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniFecEnvDev).HasColumnType("datetime");
        });

        modelBuilder.Entity<UniImgAsoc>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniImgFol }).HasName("PK__Uni_ImgA__26C62E621D3FF782");

            entity.ToTable("Uni_ImgAsoc");

            entity.HasIndex(e => new { e.InpFolio, e.UniImgFol }, "IUNI_IMGASOC3").IsDescending(false, true);

            entity.HasIndex(e => new { e.InpFolio, e.UniImgEti }, "IUNI_IMGASOC4");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniImgDsc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniImgEti)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniImgOri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniInfExt>(entity =>
        {
            entity.HasKey(e => e.InpCodInfExt).HasName("PK__UniInfEx__D092A3F53F914C5E");

            entity.ToTable("UniInfExt");

            entity.Property(e => e.InpCodInfExt).ValueGeneratedNever();
            entity.Property(e => e.InpDesInfExt)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InpSolDelInfExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpVigInfExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniInfxDec>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpCodInfExt }).HasName("PK__UniInfxD__DA3B316D2E66C05C");

            entity.ToTable("UniInfxDec");

            entity.HasIndex(e => e.InpCodDelInfExt, "IUNIINFXDEC");

            entity.HasIndex(e => e.InpCodInfExt, "UNIINFXDEC1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniIngresoArmasNew>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpArmaFolio }).HasName("PK__Uni_Ingr__A9C9065593ED513F");

            entity.ToTable("Uni_Ingreso_Armas_new");

            entity.HasIndex(e => e.InpEspStatus, "ITUNI_INGRESO_ARMAS_NEW1");

            entity.HasIndex(e => e.InpEspMonCod, "IUNI_INGRESO_ARMAS_NEW");

            entity.HasIndex(e => e.InpArmaInstitucion, "IUNI_INGRESO_ARMAS_NEW1");

            entity.HasIndex(e => new { e.Unicodmodarma, e.UniCodTipoArma, e.UniCodMarArma }, "IUNI_INGRESO_ARMAS_NEW2");

            entity.HasIndex(e => new { e.Unicodmodarma, e.UniCodTipoArma, e.UniCodCalArma }, "IUNI_INGRESO_ARMAS_NEW3");

            entity.HasIndex(e => e.InpArmaComuna, "IUNI_INGRESO_ARMAS_NEW4");

            entity.HasIndex(e => e.OculArmasCod, "IUNI_INGRESO_ARMAS_NEW5");

            entity.HasIndex(e => new { e.InpArmaSerie, e.InpFolio }, "IUNI_INGRESO_ARMAS_NEW6");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaConsultaDgmn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpArmaConsultaDGMN");
            entity.Property(e => e.InpArmaCunia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaDgmn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpArmaDGMN");
            entity.Property(e => e.InpArmaDuenio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaDuenioNom)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaFiscal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaHraInc).HasColumnType("datetime");
            entity.Property(e => e.InpArmaLatitud)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaLongitud)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaModQue)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaModify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaPorte)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaRecup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpArmaSerie)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaTxt)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaUperid)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.InpArmaVal).HasColumnType("money");
            entity.Property(e => e.InpEspMonCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Inparmafecinc)
                .HasColumnType("datetime")
                .HasColumnName("INPARMAFECINC");
            entity.Property(e => e.UniFchIngArma).HasColumnType("datetime");
            entity.Property(e => e.Unicodmodarma).HasColumnName("UNICODMODARMA");
        });

        modelBuilder.Entity<UniIngresoUrl>(entity =>
        {
            entity.HasKey(e => new { e.PerFunRut, e.Uniurlhora }).HasName("PK__UNI_ingr__7A2656725746A719");

            entity.ToTable("UNI_ingreso_url");

            entity.Property(e => e.Uniurlhora).HasColumnType("datetime");
            entity.Property(e => e.ApeMatInicio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ApeMat_inicio");
            entity.Property(e => e.ApePatInicio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ApePat_inicio");
            entity.Property(e => e.DvInicio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DV_inicio");
            entity.Property(e => e.GradoInicio).HasColumnName("Grado_inicio");
            entity.Property(e => e.NombreInicio)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Nombre_inicio");
            entity.Property(e => e.UniRemoteWrk)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnidadInicio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Unidad_inicio");
            entity.Property(e => e.Uniurl)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VariableNumerica).HasColumnName("variable_numerica");
        });

        modelBuilder.Entity<UniInstFiscal>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniInstCor }).HasName("PK__UNI_Inst__FFD4025009C2C9EC");

            entity.ToTable("UNI_Inst_Fiscal");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniConFis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniInsFol)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniInstFec).HasColumnType("datetime");
            entity.Property(e => e.UniInstFfi).HasColumnName("UniInstFFi");
            entity.Property(e => e.UniInstHor).HasColumnType("datetime");
            entity.Property(e => e.UniInstIdf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UniInstIDF");
            entity.Property(e => e.UniInstIns).IsUnicode(false);
        });

        modelBuilder.Entity<UniInstruccionVerbal>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniInsVerFol }).HasName("PK__UNI_Inst__48CC6E9632DDF46F");

            entity.ToTable("UNI_Instruccion_Verbal");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniInsVerCde).HasColumnName("UniInsVerCDe");
            entity.Property(e => e.UniInsVerCor).HasColumnName("UniInsVerCOr");
            entity.Property(e => e.UniInsVerDet)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UniInsVerFre)
                .HasColumnType("datetime")
                .HasColumnName("UniInsVerFRe");
            entity.Property(e => e.UniInsVerHre)
                .HasColumnType("datetime")
                .HasColumnName("UniInsVerHRe");
            entity.Property(e => e.UniInsVerIdF)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UniInsVerObs)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UniInsVerRit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UniInsVerRIT");
            entity.Property(e => e.UniInsVerRuc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UniInsVerRUC");
            entity.Property(e => e.UniInsVerTde).HasColumnName("UniInsVerTDe");
            entity.Property(e => e.UniInsVerTdo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniInsVerTDo");
            entity.Property(e => e.UniInsVerTor).HasColumnName("UniInsVerTOr");
        });

        modelBuilder.Entity<UniJ>(entity =>
        {
            entity.HasKey(e => e.UniJscod).HasName("PK__UNI_JS__DE51175F3024EB9C");

            entity.ToTable("UNI_JS");

            entity.Property(e => e.UniJscod)
                .ValueGeneratedNever()
                .HasColumnName("UniJSCod");
            entity.Property(e => e.UniJsdes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UniJSDes");
            entity.Property(e => e.UniJsdet)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("UniJSDet");
            entity.Property(e => e.UniJsfec)
                .HasColumnType("datetime")
                .HasColumnName("UniJSFec");
        });

        modelBuilder.Entity<UniJefaturasPeritaje>(entity =>
        {
            entity.HasKey(e => e.UniIdJefPer).HasName("PK__Uni_Jefa__D917B99D20D7BB14");

            entity.ToTable("Uni_Jefaturas_Peritajes");

            entity.Property(e => e.UniIdJefPer).ValueGeneratedNever();
            entity.Property(e => e.UniNomJefPer)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniLetrasTilde>(entity =>
        {
            entity.HasKey(e => e.UniLetrasTildeId).HasName("PK__UniLetra__92DCD0563DFE09A7");

            entity.ToTable("UniLetrasTilde");

            entity.HasIndex(e => new { e.UniLetrasTildeId, e.UniLetrasTildeVig }, "IUNILETRASTILDEII");

            entity.Property(e => e.UniLetrasTildeId)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UniLetrasTildeSt)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniLib6a>(entity =>
        {
            entity.HasKey(e => e.UniLib6aCorr).HasName("PK__Uni_Lib6__396AE2487947629E");

            entity.ToTable("Uni_Lib6a");

            entity.HasIndex(e => e.UniLib6aRutFunIng, "IUNI_LIB6A1");

            entity.HasIndex(e => e.UniLib6aRutFunSal, "IUNI_LIB6A2");

            entity.HasIndex(e => e.UniLib6aCorr, "IUNI_LIB6A3").IsDescending();

            entity.HasIndex(e => e.UniLib6aIdPerVis, "IUNI_LIB6A4");

            entity.HasIndex(e => new { e.UniLib6aIdPer, e.UniLib6aIdCuartel, e.IniLib6aFecIngDig, e.UniLib6aFecSalDig }, "IUNI_LIB6A5");

            entity.HasIndex(e => new { e.UniLib6aIdCuartel, e.UniLib6aCorr, e.UniLib6aElimLog, e.UniLib6aFecIng, e.UniLib6aFecSal }, "IUNI_LIB6A6").IsDescending(false, true, false, false, false);

            entity.Property(e => e.UniLib6aCorr).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IniLib6aFecIngDig).HasColumnType("datetime");
            entity.Property(e => e.UniLib6aElimLog)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniLib6aFecIng).HasColumnType("datetime");
            entity.Property(e => e.UniLib6aFecSal).HasColumnType("datetime");
            entity.Property(e => e.UniLib6aFecSalDig).HasColumnType("datetime");
            entity.Property(e => e.UniLib6aIdCuartel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniLib6aIdPer)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UniLib6aIdPerVis)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UniLib6aMotVis).IsUnicode(false);
            entity.Property(e => e.UniLib6aObs).IsUnicode(false);
            entity.Property(e => e.UniLib6aPerDisca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniLib6aVisDh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniLib6aVisDH");
        });

        modelBuilder.Entity<UniLogOrdPjud>(entity =>
        {
            entity.HasKey(e => e.FolPjud).HasName("PK__UniLogOr__6475867877CB83E0");

            entity.ToTable("UniLogOrdPjud");

            entity.HasIndex(e => e.FolPjud, "IUNILOGORGPJUD2").IsDescending();

            entity.Property(e => e.FolPjud)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("FolPJud");
            entity.Property(e => e.FolPjudWs)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FolPJudWS");
            entity.Property(e => e.PjudFchHra)
                .HasColumnType("datetime")
                .HasColumnName("PJudFchHra");
            entity.Property(e => e.PjudSdtIn)
                .IsUnicode(false)
                .HasColumnName("PJudSdtIn");
            entity.Property(e => e.PjudSdtOut)
                .IsUnicode(false)
                .HasColumnName("PJudSdtOut");
        });

        modelBuilder.Entity<UniLugar>(entity =>
        {
            entity.HasKey(e => e.UniLugCod).HasName("PK__UNI_Luga__FD61D54420238DFD");

            entity.ToTable("UNI_Lugar");

            entity.Property(e => e.UniLugCod).ValueGeneratedNever();
            entity.Property(e => e.UniLugFisVir)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniLugNom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniLugUltLdet).HasColumnName("UniLugUltLDet");
            entity.Property(e => e.UniLugVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniLugarDetalle>(entity =>
        {
            entity.HasKey(e => new { e.UniLugCod, e.UniLdeCod }).HasName("PK__UNI_Luga__B77EDE102B554987");

            entity.ToTable("UNI_Lugar_Detalle");

            entity.HasIndex(e => new { e.UniLugCod, e.UniLdeCod }, "IUNI_LUGAR_DETALLE2").IsDescending(true, false);

            entity.HasIndex(e => new { e.UniLugCod, e.UniLdeCod }, "IUNI_LUGAR_DETALLE4").IsDescending(false, true);

            entity.Property(e => e.UniLdeCod).HasColumnName("UniLDeCod");
            entity.Property(e => e.UniLdeDes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UniLDeDes");
            entity.Property(e => e.UniLdeVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniLDeVig");
        });

        modelBuilder.Entity<UniMarcaArma>(entity =>
        {
            entity.HasKey(e => e.UniCodMarArma).HasName("PK__Uni_Marc__35ACCD8F165A2CA1");

            entity.ToTable("Uni_Marca_Arma");

            entity.HasIndex(e => e.UniPaiMarArma, "IUNI_MARCA_ARMA");

            entity.Property(e => e.UniCodMarArma).ValueGeneratedNever();
            entity.Property(e => e.UniNomMarArma)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniMarxTpArma>(entity =>
        {
            entity.HasKey(e => new { e.Unicodmodarma, e.UniCodTipoArma, e.UniCodMarArma }).HasName("PK__Uni_Marx__3B5B4ACF0FAD2F12");

            entity.ToTable("Uni_MarxTpArma");

            entity.HasIndex(e => e.UniCodMarArma, "ITUNI_MODELO_ARMASTIPOUNI_MAR1");

            entity.Property(e => e.Unicodmodarma).HasColumnName("UNICODMODARMA");
        });

        modelBuilder.Entity<UniMedDrog>(entity =>
        {
            entity.HasKey(e => new { e.UniDrogCodMed, e.UniCodMedMed }).HasName("PK__UniMedDr__AB16B1D98CFC7371");

            entity.ToTable("UniMedDrog");

            entity.HasIndex(e => e.UniCodMedMed, "IUNIMEDDROG");

            entity.Property(e => e.UniCodMedMed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniMedxTipoEsp>(entity =>
        {
            entity.HasKey(e => new { e.TipoEspCod, e.TipoEspUniMed }).HasName("PK__UniMedxT__412D4A282784B8A3");

            entity.ToTable("UniMedxTipoEsp");

            entity.HasIndex(e => e.TipoEspUniMed, "IUNIMEDXTIPOESP2");

            entity.Property(e => e.TipoEspUniMed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniMensaje>(entity =>
        {
            entity.HasKey(e => e.UniMsjCod).HasName("PK__UNI_Mens__EB76E2596C8EDB5E");

            entity.ToTable("UNI_Mensajes");

            entity.Property(e => e.UniMsjCod).ValueGeneratedNever();
            entity.Property(e => e.UniMsjTxt).IsUnicode(false);
        });

        modelBuilder.Entity<UniMenu>(entity =>
        {
            entity.HasKey(e => new { e.ApliFunPerfil, e.UniCodMenu }).HasName("PK__Uni_Menu__9F73BC7D2181C68A");

            entity.ToTable("Uni_Menu");

            entity.HasIndex(e => new { e.ApliFunPerfil, e.UniCodSubMenu, e.UniVigMenu, e.UniCodMenu }, "IUNI_MENU2");

            entity.HasIndex(e => new { e.ApliFunPerfil, e.UniVigMenu, e.UniPgmMenu }, "IUNI_MENU3");

            entity.HasIndex(e => new { e.ApliFunPerfil, e.UniCodSubMenu, e.UniVigMenu, e.UniUltLinPar }, "IUNI_MENU4");

            entity.Property(e => e.UniNomMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniPgmMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniVigMenu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniModeloArma>(entity =>
        {
            entity.HasKey(e => e.Unicodmodarma).HasName("PK__Uni_Mode__5A088C3636F1E4BC");

            entity.ToTable("Uni_Modelo_Armas");

            entity.Property(e => e.Unicodmodarma).HasColumnName("UNICODMODARMA");
            entity.Property(e => e.Uninommodarma)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UNINOMMODARMA");
        });

        modelBuilder.Entity<UniModusOperandiCondSuj>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpModFolio, e.InpModConSuj }).HasName("PK__Uni_Modu__A7D4808036C6FC33");

            entity.ToTable("Uni_Modus_Operandi_CondSuj");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniModusOperandiDelAso>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpModFolio, e.InpModOpDelAso }).HasName("PK__Uni_Modu__3E910FCC6F0B5556");

            entity.ToTable("Uni_Modus_Operandi_DelAso");

            entity.HasIndex(e => e.InpModOpDelAso, "IUNI_MODUS_OPERANDI_DELASO3");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniModusOperandiLenSuj>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpModFolio, e.InpModLenSuj }).HasName("PK__Uni_Modu__99F0C50C3E681DFB");

            entity.ToTable("Uni_Modus_Operandi_LenSuj");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniMotivounidad>(entity =>
        {
            entity.HasKey(e => e.UniMotUnidadNro).HasName("PK__UNI_MOTI__B4D1299816B7083E");

            entity.ToTable("UNI_MOTIVOUNIDAD");

            entity.Property(e => e.UniMotUnidadNro).ValueGeneratedNever();
            entity.Property(e => e.UniMotUnidadDes)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniNoticia>(entity =>
        {
            entity.HasKey(e => e.UniNotCod).HasName("PK__UNI_Noti__409C861947FC752D");

            entity.ToTable("UNI_Noticias");

            entity.HasIndex(e => new { e.UniNotVig, e.UniNotFec }, "IUNI_NOTICIAS1");

            entity.Property(e => e.UniNotCod).ValueGeneratedNever();
            entity.Property(e => e.UniNotCom).IsUnicode(false);
            entity.Property(e => e.UniNotFec).HasColumnType("datetime");
            entity.Property(e => e.UniNotLink)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UniNotNoL)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UniNotNot)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniNotVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniNumeroCorrelativo>(entity =>
        {
            entity.HasKey(e => new { e.UninroCorrUni, e.UninroCorrAno, e.UninroCorrNro, e.UninroCorrLet }).HasName("PK__UNI_Nume__52F135317F0CB2F5");

            entity.ToTable("UNI_Numero_Correlativos");

            entity.HasIndex(e => new { e.UninroCorrUni, e.UninroCorrAno, e.UninroCorrLet, e.UninroCorrNro }, "IUNI_NUMERO_CORRELATIVOS1").IsDescending(false, false, false, true);

            entity.Property(e => e.UninroCorrUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNINroCorrUni");
            entity.Property(e => e.UninroCorrAno).HasColumnName("UNINroCorrAno");
            entity.Property(e => e.UninroCorrNro)
                .HasColumnType("decimal(11, 0)")
                .HasColumnName("UNINroCorrNro");
            entity.Property(e => e.UninroCorrLet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNINroCorrLet");
            entity.Property(e => e.UniNroCorrFol)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniOcultamientoArma>(entity =>
        {
            entity.HasKey(e => e.OculArmaCod).HasName("PK__Uni_Ocul__97292165B4193FBD");

            entity.ToTable("Uni_Ocultamiento_Arma");

            entity.Property(e => e.OculArmaCod).ValueGeneratedNever();
            entity.Property(e => e.OculArmaDes)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniOtrosAntecedente>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniOanCor }).HasName("PK__UNI_Otro__74676FC584E3D519");

            entity.ToTable("UNI_Otros_Antecedentes");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniOanCor).HasColumnName("UniOAnCor");
            entity.Property(e => e.UniOanDet)
                .IsUnicode(false)
                .HasColumnName("UniOAnDet");
        });

        modelBuilder.Entity<UniOtrosDocumento>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniOtDnro }).HasName("PK__UNI_Otro__B469153003765E84");

            entity.ToTable("UNI_Otros_Documentos");

            entity.HasIndex(e => e.InpFolio, "IUNI_Otros_Documentos1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniOtDnro).HasColumnName("UniOtDNro");
            entity.Property(e => e.UniOtDdes)
                .IsUnicode(false)
                .HasColumnName("UniOtDDes");
        });

        modelBuilder.Entity<UniOtrosDocumentosAdjunto>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniOtDnro, e.UniOtDcorr }).HasName("PK__Uni_Otro__96F9B1C273419AF4");

            entity.ToTable("Uni_Otros_Documentos_Adjuntos");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniOtDnro).HasColumnName("UniOtDNro");
            entity.Property(e => e.UniOtDcorr).HasColumnName("UniOtDCorr");
            entity.Property(e => e.UniOtDext)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UniOtDExt");
            entity.Property(e => e.UniOtDnom)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UniOtDNom");
        });

        modelBuilder.Entity<UniPargen>(entity =>
        {
            entity.HasKey(e => e.UniCodParGen).HasName("PK__UNI_PARG__3DE8D3D75C06D3AF");

            entity.ToTable("UNI_PARGEN");

            entity.Property(e => e.UniCodParGen).ValueGeneratedNever();
            entity.Property(e => e.UniAvisoV2).IsUnicode(false);
            entity.Property(e => e.UniBrainAct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniBrainFechProc).HasColumnType("datetime");
            entity.Property(e => e.UniClaveGoogle)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UniCodParAmbiente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniContador).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniCorrIndoc).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniEleConDenun).IsUnicode(false);
            entity.Property(e => e.UniEleConPriDil).IsUnicode(false);
            entity.Property(e => e.UniEncVifact)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniEncVIFAct");
            entity.Property(e => e.UniEncVifburl)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UniEncVIFBUrl");
            entity.Property(e => e.UniEncVifburlTout).HasColumnName("UniEncVIFBUrlTOut");
            entity.Property(e => e.UniEncVifpuerto).HasColumnName("UniEncVIFPuerto");
            entity.Property(e => e.UniEncVifrname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UniEncVIFRName");
            entity.Property(e => e.UniEncVifserv)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UniEncVIFServ");
            entity.Property(e => e.UniFecCorInf).HasColumnType("datetime");
            entity.Property(e => e.UniFechaActualizaEstadis).HasColumnType("datetime");
            entity.Property(e => e.UniFolUniAct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniFolUniCorr).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniIpConRegCiv)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniPassConRgCiv)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniPredes).IsUnicode(false);
            entity.Property(e => e.UniTelConBrain).IsUnicode(false);
            entity.Property(e => e.UniUltLinCod).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.UniUltUperid).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UniUrlChatBot)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UniUrlPaso)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UniUserServRegc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniUserServREGC");
            entity.Property(e => e.UniUserServRegctc)
                .HasColumnType("datetime")
                .HasColumnName("UniUserServREGCTC");
            entity.Property(e => e.UniUsuConRegCiv)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UniVersionNav).IsUnicode(false);
        });

        modelBuilder.Entity<UniPeinHd>(entity =>
        {
            entity.HasKey(e => new { e.Peinhdid, e.Peinhdcde, e.Peinhdfol }).HasName("PK__UNI_PEIN__1440468B23BF14B7");

            entity.ToTable("UNI_PEIN_HD");

            entity.HasIndex(e => new { e.Peinhdcde, e.Peinhdid }, "IUNI_PEIN_HD1");

            entity.Property(e => e.Peinhdid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PEINHDID");
            entity.Property(e => e.Peinhdcde).HasColumnName("PEINHDCDe");
            entity.Property(e => e.Peinhdfol)
                .HasColumnType("decimal(11, 0)")
                .HasColumnName("PEINHDFol");
            entity.Property(e => e.Peinhddde)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PEINHDDDe");
            entity.Property(e => e.Peinpercond).HasColumnName("PEINPERCOND");
            entity.Property(e => e.PeintotalDenun).HasColumnName("PEINTOTAL_DENUN");
            entity.Property(e => e.PeintotalDenunYVict).HasColumnName("PEINTOTAL_DENUN_Y_VICT");
            entity.Property(e => e.PeintotalDete).HasColumnName("PEINTOTAL_DETE");
            entity.Property(e => e.PeintotalEmpa).HasColumnName("PEINTOTAL_EMPA");
            entity.Property(e => e.PeintotalFalle).HasColumnName("PEINTOTAL_FALLE");
            entity.Property(e => e.PeintotalImpu).HasColumnName("PEINTOTAL_IMPU");
            entity.Property(e => e.PeintotalMenor).HasColumnName("PEINTOTAL_MENOR");
            entity.Property(e => e.PeintotalTesti).HasColumnName("PEINTOTAL_TESTI");
            entity.Property(e => e.PeintotalVict).HasColumnName("PEINTOTAL_VICT");
        });

        modelBuilder.Entity<UniPeinMo>(entity =>
        {
            entity.HasKey(e => new { e.Peinmoid, e.Peinmocmo, e.Peinmocdm }).HasName("PK__UNI_PEIN__625557427F81B441");

            entity.ToTable("UNI_PEIN_MO");

            entity.HasIndex(e => new { e.Peinmocmo, e.Peinmocdm }, "IUNI_PEIN_MO1");

            entity.Property(e => e.Peinmoid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PEINMOID");
            entity.Property(e => e.Peinmocmo).HasColumnName("PEINMOCMO");
            entity.Property(e => e.Peinmocdm).HasColumnName("PEINMOCDM");
            entity.Property(e => e.Peinmoddm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PEINMODDM");
            entity.Property(e => e.Peinmodmo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PEINMODMO");
        });

        modelBuilder.Entity<UniPeinRp>(entity =>
        {
            entity.HasKey(e => new { e.Peinrpid, e.PeinconCod }).HasName("PK__UNI_PEIN__355A799A564A9484");

            entity.ToTable("UNI_PEIN_RP");

            entity.HasIndex(e => e.Peinrpnro, "IUNI_PEIN_RP1").IsDescending();

            entity.HasIndex(e => new { e.Peinrpsex, e.PeinconCod, e.PeintieFot, e.PeinapePat, e.PeinapeMat, e.PeinnomCom }, "IUNI_PEIN_RP2");

            entity.HasIndex(e => new { e.PeinconCod, e.Peinrpnro }, "IUNI_PEIN_RP3").IsDescending(false, true);

            entity.Property(e => e.Peinrpid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PEINRPID");
            entity.Property(e => e.PeinconCod).HasColumnName("PEINConCod");
            entity.Property(e => e.PeinapeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PEINApeMat");
            entity.Property(e => e.PeinapePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PEINApePat");
            entity.Property(e => e.Peincodprov)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PEINCODPROV");
            entity.Property(e => e.Peincodreg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PEINCODREG");
            entity.Property(e => e.PeinconDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PEINConDes");
            entity.Property(e => e.PeindigVer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PEINDigVer");
            entity.Property(e => e.PeinfecNac)
                .HasColumnType("datetime")
                .HasColumnName("PEINFecNac");
            entity.Property(e => e.PeinnomCom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PEINNomCom");
            entity.Property(e => e.PeinpaiNac)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PEINPaiNac");
            entity.Property(e => e.Peinrpdoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PEINRPDoc");
            entity.Property(e => e.Peinrpnro).HasColumnName("PEINRPNro");
            entity.Property(e => e.Peinrpsex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PEINRPSex");
            entity.Property(e => e.PeintieFot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PEINTieFot");
        });

        modelBuilder.Entity<UniPgmParametro>(entity =>
        {
            entity.HasKey(e => new { e.ApliFunPerfil, e.UniCodMenu, e.UniNroLinPar }).HasName("PK__Uni_Pgm___BE51C6CC1AD4C8FB");

            entity.ToTable("Uni_Pgm_Parametro");

            entity.Property(e => e.UniPgmPar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniPlasBrain>(entity =>
        {
            entity.HasKey(e => new { e.UniPlasUperId, e.UniPlasAno, e.UniPlasCorre }).HasName("PK__UNI_PLAS__2991A2123568C3A6");

            entity.ToTable("UNI_PLAS_BRAIN");

            entity.HasIndex(e => new { e.UniPlasUperId, e.UniPlasFecha, e.UniPlasHora }, "IUNI_PLAS_BRAIN4").IsDescending(false, true, true);

            entity.Property(e => e.UniPlasUperId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasCorre).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniPlasCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasCarro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniPlasConCalleInt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasFecha).HasColumnType("datetime");
            entity.Property(e => e.UniPlasFrenteNro).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniPlasHora).HasColumnType("datetime");
            entity.Property(e => e.UniPlasInsFec).HasColumnType("datetime");
            entity.Property(e => e.UniPlasLat)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasLong)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasNroArteria)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasObs).IsUnicode(false);
            entity.Property(e => e.UniPlasProvincias)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniPlasRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniPlasUestado).HasColumnName("UniPlasUEstado");
            entity.Property(e => e.UniPlasUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniPlasWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniPortalNoticia>(entity =>
        {
            entity.HasKey(e => e.PncodIng).HasName("PK__UNI_Port__8837F05E1C1DF2EF");

            entity.ToTable("UNI_Portal_Noticias");

            entity.HasIndex(e => e.PnfecHor, "IUNI_PORTAL_NOTICIAS1").IsDescending();

            entity.Property(e => e.PncodIng)
                .ValueGeneratedNever()
                .HasColumnName("PNCodIng");
            entity.Property(e => e.PncargaWebs)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PNCargaWebs");
            entity.Property(e => e.PnfecHor)
                .HasColumnType("datetime")
                .HasColumnName("PNFecHor");
            entity.Property(e => e.PnfecIng)
                .HasColumnType("datetime")
                .HasColumnName("PNFecIng");
            entity.Property(e => e.PnfotNot).HasColumnName("PNFotNot");
            entity.Property(e => e.PntxtCom)
                .IsUnicode(false)
                .HasColumnName("PNTxtCom");
            entity.Property(e => e.PntxtCor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PNTxtCor");
            entity.Property(e => e.PnvigNot).HasColumnName("PNVigNot");
        });

        modelBuilder.Entity<UniRangoEdad>(entity =>
        {
            entity.HasKey(e => e.UniRanCod).HasName("PK__UNI_Rang__52C65887184D620B");

            entity.ToTable("UNI_Rango_Edad");

            entity.Property(e => e.UniRanCod).ValueGeneratedNever();
            entity.Property(e => e.UniRanDes)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniRegPerNinv>(entity =>
        {
            entity.HasKey(e => e.UperCorrNind).HasName("PK__Uni_RegP__51F5BEB39B54053F");

            entity.ToTable("Uni_RegPerNInv");

            entity.HasIndex(e => e.UperNacSupPnind, "UNI_REGPERNINV1");

            entity.HasIndex(e => e.UperTpeloSupPnind, "UNI_REGPERNINV2");

            entity.HasIndex(e => e.UperFchReg, "UNI_REGPERNINV3").IsDescending();

            entity.Property(e => e.UperCorrNind)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("UperCorrNInd");
            entity.Property(e => e.UpeContexDesSupPnind)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UpeContexDesSupPNInd");
            entity.Property(e => e.UpeContexSupPnind).HasColumnName("UpeContexSupPNInd");
            entity.Property(e => e.UperAlturaSupPnind)
                .HasColumnType("smallmoney")
                .HasColumnName("UperAlturaSupPNInd");
            entity.Property(e => e.UperFchReg).HasColumnType("datetime");
            entity.Property(e => e.UperFotoPnind).HasColumnName("UperFotoPNInd");
            entity.Property(e => e.UperFotoPnindGxi)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("UperFotoPNInd_GXI");
            entity.Property(e => e.UperFunIngpPnind).HasColumnName("UperFunIngpPNInd");
            entity.Property(e => e.UperLatSupPnind)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UperLatSupPNInd");
            entity.Property(e => e.UperLongitudSupPnind)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UperLongitudSupPNInd");
            entity.Property(e => e.UperMatupPnind)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UperMatupPNInd");
            entity.Property(e => e.UperNacSupPnind).HasColumnName("UperNacSupPNInd");
            entity.Property(e => e.UperNomSupPnind)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UperNomSupPNInd");
            entity.Property(e => e.UperPatSupPnind)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UperPatSupPNInd");
            entity.Property(e => e.UperRedadSupPnind).HasColumnName("UperREdadSupPNInd");
            entity.Property(e => e.UperSexoSupPnind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UperSexoSupPNInd");
            entity.Property(e => e.UperTpeloSupPnind).HasColumnName("UperTPeloSupPNInd");
        });

        modelBuilder.Entity<UniRegTel>(entity =>
        {
            entity.HasKey(e => e.UniIdTegTel).HasName("PK__Uni_RegT__36FF49A109775354");

            entity.ToTable("Uni_RegTel");

            entity.HasIndex(e => e.UniCodPaiRegTel, "IUNI_REGTEL1");

            entity.HasIndex(e => new { e.UniFunSol, e.UniEstNumTel }, "IUNI_REGTEL2");

            entity.Property(e => e.UniIdTegTel)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniFchResTel).HasColumnType("datetime");
            entity.Property(e => e.UniNumTel).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<UniRegTelUniDetReg>(entity =>
        {
            entity.HasKey(e => new { e.UniIdTegTel, e.UniDetRegTel }).HasName("PK__Uni_RegT__FBD65B43F6E06F52");

            entity.ToTable("Uni_RegTelUniDetReg");

            entity.Property(e => e.UniIdTegTel).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UniFchSolTelDet).HasColumnType("datetime");
        });

        modelBuilder.Entity<UniRegistroSeguridad>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.RsnroCorr }).HasName("PK__UNI_Regi__54F0AA9F68BE4A7A");

            entity.ToTable("UNI_Registro_Seguridad");

            entity.HasIndex(e => new { e.RsrutFun, e.RsregVig }, "IUNI_RESGISTRO_SEGURIDAD2").IsDescending(false, true);

            entity.HasIndex(e => new { e.InpFolio, e.RsregVig }, "IUNI_RESGISTRO_SEGURIDAD3");

            entity.HasIndex(e => e.InpFolio, "IUNI_Registro_Seguridad1").HasFillFactor(100);

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.RsnroCorr).HasColumnName("RSNroCorr");
            entity.Property(e => e.RscodUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RSCodUni");
            entity.Property(e => e.RsfecSeg)
                .HasColumnType("datetime")
                .HasColumnName("RSFecSeg");
            entity.Property(e => e.RsfinSeg)
                .HasColumnType("datetime")
                .HasColumnName("RSFinSeg");
            entity.Property(e => e.RsfunDoc).HasColumnName("RSFunDoc");
            entity.Property(e => e.RshorSeg)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RSHorSeg");
            entity.Property(e => e.RsnivSeg).HasColumnName("RSNivSeg");
            entity.Property(e => e.RsobsSeg)
                .IsUnicode(false)
                .HasColumnName("RSObsSeg");
            entity.Property(e => e.RsregVig).HasColumnName("RSRegVig");
            entity.Property(e => e.RsrutFun).HasColumnName("RSRutFun");
        });

        modelBuilder.Entity<UniRelConPai>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniCodContPai, e.UniDetCodConPai }).HasName("PK__UniRelCo__388E2DB8B22FDDD9");

            entity.HasIndex(e => new { e.UniCodContPai, e.UniDetCodConPai }, "ITUNIRELCONPAIS1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniRelFenDel>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniIdfenDel }).HasName("PK__UniRelFe__4BB9CDA727C5A654");

            entity.ToTable("UniRelFenDel");

            entity.HasIndex(e => e.UniIdfenDel, "IUNIRELFENDEL1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniIdfenDel).HasColumnName("UniIDFenDel");
        });

        modelBuilder.Entity<UniRelPlasConPai>(entity =>
        {
            entity.HasKey(e => new { e.UniPlasUperId, e.UniPlasAno, e.UniPlasCorre, e.UniCodContPai, e.UniDetCodConPai }).HasName("PK__UniRelPl__C33E1E240E0AE935");

            entity.ToTable("UniRelPlasConPai");

            entity.HasIndex(e => new { e.UniCodContPai, e.UniDetCodConPai }, "ITUNIRELPLASCONPAI1");

            entity.Property(e => e.UniPlasUperId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UniPlasCorre).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<UniRuta>(entity =>
        {
            entity.HasKey(e => e.UniRutaCod).HasName("PK__Uni_Ruta__00C7F4036680FC4D");

            entity.ToTable("Uni_Rutas");

            entity.Property(e => e.UniRutaCod).ValueGeneratedNever();
            entity.Property(e => e.UniRutaDes).IsUnicode(false);
            entity.Property(e => e.UniRutaRuta)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniSeguridadAuditoriaFolio>(entity =>
        {
            entity.HasKey(e => new { e.SarutFun, e.SaperId, e.SafecCon, e.SahorCon, e.SafolDoc, e.SanroCor }).HasName("PK__UNI_Segu__AB2E02AB597C06EA");

            entity.ToTable("UNI_Seguridad_AuditoriaFolio");

            entity.Property(e => e.SarutFun).HasColumnName("SARutFun");
            entity.Property(e => e.SaperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPerId");
            entity.Property(e => e.SafecCon)
                .HasColumnType("datetime")
                .HasColumnName("SAFecCon");
            entity.Property(e => e.SahorCon)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAHorCon");
            entity.Property(e => e.SafolDoc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SAFolDoc");
            entity.Property(e => e.SanroCor).HasColumnName("SANroCor");
        });

        modelBuilder.Entity<UniSeguridadAuditorium>(entity =>
        {
            entity.HasKey(e => new { e.SarutFun, e.SaperId, e.SafecCon, e.SahorCon }).HasName("PK__UNI_Segu__0F3D34B75D4C97CE");

            entity.ToTable("UNI_Seguridad_Auditoria");

            entity.HasIndex(e => e.SafecHor, "IUNI_SEGURIDAD_AUDITORIA1");

            entity.Property(e => e.SarutFun).HasColumnName("SARutFun");
            entity.Property(e => e.SaperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPerId");
            entity.Property(e => e.SafecCon)
                .HasColumnType("datetime")
                .HasColumnName("SAFecCon");
            entity.Property(e => e.SahorCon)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAHorCon");
            entity.Property(e => e.SaestLec).HasColumnName("SAEstLec");
            entity.Property(e => e.SafecHor)
                .HasColumnType("datetime")
                .HasColumnName("SAFecHor");
        });

        modelBuilder.Entity<UniSeguridadPersona>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.SpperId }).HasName("PK__UNI_Segu__D3BEAED7611D28B2");

            entity.ToTable("UNI_Seguridad_Personas");

            entity.HasIndex(e => e.SpperId, "IUNI_SEGURIDAD_PERSONAS2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.SpperId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SPPerID");
            entity.Property(e => e.SpapeMat)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SPApeMat");
            entity.Property(e => e.SpapePat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SPApePat");
            entity.Property(e => e.SpconPer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPConPer");
            entity.Property(e => e.SpnomPer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SPNomPer");
            entity.Property(e => e.SptipSeg).HasColumnName("SPTipSeg");
        });

        modelBuilder.Entity<UniSelInfInt>(entity =>
        {
            entity.HasKey(e => new { e.InfIntCodUni, e.InfIntCodDel, e.InfIntCodComu }).HasName("PK__UniSelIn__F142197B0F5AB7B0");

            entity.ToTable("UniSelInfInt");

            entity.HasIndex(e => e.InfIntCodDel, "UNISELINFINT2");

            entity.HasIndex(e => e.InfIntCodComu, "UNISELINFINT3");

            entity.Property(e => e.InfIntCodUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InfIntCodComu)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniSsEvidencium>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSucfolio, e.InpSsfolio, e.InpEspFolio }).HasName("PK__Uni_SS_E__0ADAB6D17F76C749");

            entity.ToTable("Uni_SS_Evidencia");

            entity.HasIndex(e => new { e.InpFolio, e.InpEspFolio }, "ITD_SS_EVIDENCIA1");

            entity.HasIndex(e => new { e.InpFolio, e.InpSsfolio, e.InpSucfolio }, "ITD_SS_EVIDENCIA2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.InpSsfolio).HasColumnName("InpSSFolio");
            entity.Property(e => e.InpEspCant).HasColumnType("money");
            entity.Property(e => e.InpEspCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InpEspTxt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InpSsevidFecha)
                .HasColumnType("datetime")
                .HasColumnName("InpSSEvidFecha");
            entity.Property(e => e.InpSsevidLevantada)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InpSSEvidLevantada");
            entity.Property(e => e.InpSsevidNue)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("InpSSEvidNUE");
            entity.Property(e => e.InpSsevidSolPeritaje)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InpSSEvidSolPeritaje");
            entity.Property(e => e.InpSsevidencias)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("InpSSEvidencias");
        });

        modelBuilder.Entity<UniSsPeritaje>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpSsfolio, e.UniPeriCod, e.Inpunicodperitaje }).HasName("PK__Uni_SS_P__DA1B981978C9C9BA");

            entity.ToTable("Uni_SS_Peritajes");

            entity.HasIndex(e => new { e.UniIdJefPer, e.UniIdUniPer, e.UniPeriCod }, "ITD_SS_PERITAJES1");

            entity.HasIndex(e => new { e.InpFolio, e.InpSsfolio, e.InpSucfolio }, "ITD_SS_PERITAJES2");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.InpSsfolio).HasColumnName("InpSSFolio");
            entity.Property(e => e.Inpunicodperitaje)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("inpunicodperitaje");
            entity.Property(e => e.InpSucfolio).HasColumnName("InpSUCFolio");
            entity.Property(e => e.Inpssnue)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("inpssnue");
            entity.Property(e => e.UniPeriTipoOtro)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniTag>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniTag1 }).HasName("PK__UniTags__81F19209C5557218");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UniTag1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UniTag");
        });

        modelBuilder.Entity<UniTipoArma>(entity =>
        {
            entity.HasKey(e => new { e.Unicodmodarma, e.UniCodTipoArma }).HasName("PK__Uni_Tipo__B56EE6020623C4D8");

            entity.ToTable("Uni_Tipo_Armas");

            entity.Property(e => e.Unicodmodarma).HasColumnName("UNICODMODARMA");
            entity.Property(e => e.UniCodNomTipoArma)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniTipoDip>(entity =>
        {
            entity.HasKey(e => e.Unidipcod).HasName("PK__UNI_Tipo__762C3D1656E9B302");

            entity.ToTable("UNI_Tipo_DIP");

            entity.Property(e => e.Unidipcod)
                .ValueGeneratedNever()
                .HasColumnName("UNIDIPCod");
            entity.Property(e => e.UniDipdes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UniDIPDes");
        });

        modelBuilder.Entity<UniTipoInsParticular>(entity =>
        {
            entity.HasKey(e => e.UniInsParcod).HasName("PK__UNI_Tipo__C451DB1214B1DB51");

            entity.ToTable("UNI_Tipo_InsParticular");

            entity.Property(e => e.UniInsParcod).ValueGeneratedNever();
            entity.Property(e => e.UniInsParDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniInsParVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UniTipoParticipacion>(entity =>
        {
            entity.HasKey(e => e.Unitippartcod).HasName("SYS_C00205320");

            entity.ToTable("UNI_TIPO_PARTICIPACION");

            entity.Property(e => e.Unitippartcod)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("UNITIPPARTCOD");
            entity.Property(e => e.Unitippartdesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UNITIPPARTDESC");
            entity.Property(e => e.Unitippartvig)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("UNITIPPARTVIG");
        });

        modelBuilder.Entity<UniTipoResidencium>(entity =>
        {
            entity.HasKey(e => e.UniTpResidenciaCod).HasName("PK__UNI_TIPO__D717D5956EC13C93");

            entity.ToTable("UNI_TIPO_RESIDENCIA");

            entity.HasIndex(e => e.UniTpResidenciaCod, "UNI_TIPO_RESIDENCIAI").IsDescending();

            entity.Property(e => e.UniTpResidenciaCod).ValueGeneratedNever();
            entity.Property(e => e.UniTpResidenciaDes)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniTpoCambioUnidadFun>(entity =>
        {
            entity.HasKey(e => e.UniTipCmbUniFunNro).HasName("PK__Uni_TpoC__7C26AA1910E14A6D");

            entity.ToTable("Uni_TpoCambioUnidadFun");

            entity.Property(e => e.UniTipCmbUniFunNro).ValueGeneratedNever();
            entity.Property(e => e.UniTipCmbUniFun)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniTrabCom>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.UniFunAsoTrab, e.TipoOrdenTabId }).HasName("PK__Uni_Trab__A4139C5A2AB512EE");

            entity.ToTable("Uni_Trab_com");

            entity.HasIndex(e => new { e.UniFunAsoTrab, e.InpFolio }, "IUNI_TRAB_COM4");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.TipoOrdenTabId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniUnidadPeritaje>(entity =>
        {
            entity.HasKey(e => new { e.UniIdJefPer, e.UniIdUniPer, e.UniPeriCod }).HasName("PK__Uni_Unid__8959A3B122C00386");

            entity.ToTable("Uni_Unidad_Peritajes");

            entity.Property(e => e.UniNomUniPer)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UniPeriDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UniPeriTipo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UniReqNueUniPer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UnidadCarroPolicial>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.UniCarrPolId }).HasName("PK__Unidad_C__0F649015633A7B4E");

            entity.ToTable("Unidad_Carro_Policial");

            entity.HasIndex(e => e.UniCarrPolId, "IUNIDAD_CARRO_POLICIAL1");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniCarrPolId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UniCarrPolID");
        });

        modelBuilder.Entity<UnidadDotacionMensual>(entity =>
        {
            entity.HasKey(e => new { e.GesGenUniCod, e.UniDotAnio, e.UniDotMes }).HasName("PK__Unidad_D__B29251A92EC6B30F");

            entity.ToTable("Unidad_Dotacion_Mensual");

            entity.Property(e => e.GesGenUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniDotAdmcant).HasColumnName("UniDotADMCant");
            entity.Property(e => e.UniDotAgcant).HasColumnName("UniDotAGCant");
            entity.Property(e => e.UniDotApadmCant).HasColumnName("UniDotAPAdmCant");
            entity.Property(e => e.UniDotApcant).HasColumnName("UniDotAPCant");
            entity.Property(e => e.UniDotFecIns).HasColumnType("datetime");
            entity.Property(e => e.UniDotFecUpd).HasColumnType("datetime");
            entity.Property(e => e.UniDotOpadmCant).HasColumnName("UniDotOPAdmCant");
            entity.Property(e => e.UniDotOpcant).HasColumnName("UniDotOPCant");
            entity.Property(e => e.UniDotUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UniDotUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UniDotWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniDotWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.MedUniCod).HasName("PK__Unidad_M__17BA58C93CBFCCAB");

            entity.ToTable("Unidad_Medida");

            entity.Property(e => e.MedUniCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MedUniDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Unidade>(entity =>
        {
            entity.HasKey(e => e.UnidadCod).HasName("PK__Unidades__69604B07717DADAD");

            entity.HasIndex(e => e.Regcod, "IUNIDADES1");

            entity.Property(e => e.UnidadCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Regcod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnidadDes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UnivPersona>(entity =>
        {
            entity.HasKey(e => e.UperId).HasName("PK__UnivPers__6571A1CC653643E4");

            entity.HasIndex(e => e.UperId, "IDX_UNIVPERS_ID");

            entity.HasIndex(e => new { e.UperFlgFis, e.UperApePat, e.UperApeMat, e.UperNbrCom }, "IUPer_Fiscales").HasFillFactor(100);

            entity.HasIndex(e => e.UperNomIngreso, "IUPer_Nom_Ingreso").HasFillFactor(100);

            entity.HasIndex(e => e.EscoCod, "IUnivPersonas1");

            entity.HasIndex(e => e.EstCivCod, "IUnivPersonas13").HasFillFactor(100);

            entity.HasIndex(e => e.UperPaiCodPar, "IUnivPersonas18");

            entity.HasIndex(e => e.UperNacPaiCod, "IUnivPersonas19");

            entity.HasIndex(e => new { e.UperSexo, e.UperApePat, e.UperApeMat, e.UperNomBus }, "IUnivPersonas20");

            entity.HasIndex(e => new { e.UperNbrCom, e.UperApeMat }, "IUnivPersonas4").HasFillFactor(100);

            entity.HasIndex(e => new { e.UperNbrCom, e.UperApeMat }, "IUnivPersonas5").HasFillFactor(100);

            entity.HasIndex(e => new { e.UperPatBus, e.UperMatBus }, "IUnivPersonas6");

            entity.HasIndex(e => e.UperFchNac, "IUnivPersonas7");

            entity.HasIndex(e => e.UperEdad, "IUnivPersonas8");

            entity.HasIndex(e => e.UperConPatMat, "IUperConPatMat").HasFillFactor(100);

            entity.HasIndex(e => e.UperInvConPatMat, "IUperInvCon").HasFillFactor(100);

            entity.HasIndex(e => new { e.UperApePat, e.UperApeMat, e.UperNbrCom }, "IUperPat_Mat_Nom").HasFillFactor(100);

            entity.HasIndex(e => e.UperSexo, "inp_idx1");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.EscoCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EstCivCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperAntPol).HasColumnName("UPerAntPol");
            entity.Property(e => e.UperApeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerApeMat");
            entity.Property(e => e.UperApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerApePat");
            entity.Property(e => e.UperCargGub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UperClaTipDel).HasColumnName("UPerClaTipDel");
            entity.Property(e => e.UperConPatMat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UperDepFolio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("UPerDepFolio");
            entity.Property(e => e.UperEdad).HasColumnName("UPerEdad");
            entity.Property(e => e.UperEstCom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperEstFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerEstFlg");
            entity.Property(e => e.UperEtniaPer)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperFchNac)
                .HasColumnType("datetime")
                .HasColumnName("UPerFchNac");
            entity.Property(e => e.UperFecDef)
                .HasColumnType("datetime")
                .HasColumnName("UPerFecDef");
            entity.Property(e => e.UperFlgDen).HasColumnName("UPerFlgDen");
            entity.Property(e => e.UperFlgDep).HasColumnName("UPerFlgDep");
            entity.Property(e => e.UperFlgEnc).HasColumnName("UPerFlgEnc");
            entity.Property(e => e.UperFlgEva).HasColumnName("UPerFlgEva");
            entity.Property(e => e.UperFlgFil).HasColumnName("UPerFlgFil");
            entity.Property(e => e.UperFlgFis).HasColumnName("UPerFlgFis");
            entity.Property(e => e.UperFlgFun).HasColumnName("UPerFlgFun");
            entity.Property(e => e.UperFlgHom).HasColumnName("UPerFlgHom");
            entity.Property(e => e.UperFlgInf).HasColumnName("UPerFlgInf");
            entity.Property(e => e.UperFlgIng).HasColumnName("UPerFlgIng");
            entity.Property(e => e.UperFlgInt).HasColumnName("UPerFlgInt");
            entity.Property(e => e.UperFlgNar).HasColumnName("UPerFlgNar");
            entity.Property(e => e.UperFlgRecFoto).HasColumnName("UPerFlgRecFoto");
            entity.Property(e => e.UperFlgRes).HasColumnName("UPerFlgRes");
            entity.Property(e => e.UperFlgSin).HasColumnName("UPerFlgSin");
            entity.Property(e => e.UperFlgTad).HasColumnName("UPerFlgTad");
            entity.Property(e => e.UperFlgUpd).HasColumnName("UPerFlgUpd");
            entity.Property(e => e.UperFlgVia).HasColumnName("UPerFlgVia");
            entity.Property(e => e.UperFonoDos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerFonoDos");
            entity.Property(e => e.UperFonoUno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerFonoUno");
            entity.Property(e => e.UperFot01).HasColumnName("UPerFot01");
            entity.Property(e => e.UperFunIns).HasColumnName("UPerFunIns");
            entity.Property(e => e.UperFunInsFch)
                .HasColumnType("datetime")
                .HasColumnName("UPerFunInsFch");
            entity.Property(e => e.UperFunUpd).HasColumnName("UPerFunUpd");
            entity.Property(e => e.UperFunUpdFch)
                .HasColumnType("datetime")
                .HasColumnName("UPerFunUpdFch");
            entity.Property(e => e.UperGenPer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperHisUltLinDir)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("UPerHisUltLinDir");
            entity.Property(e => e.UperHisUltLinDpe)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("UPerHisUltLinDpe");
            entity.Property(e => e.UperHisUltLinMor)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("UPerHisUltLinMor");
            entity.Property(e => e.UperInvConPatMat)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("UPerInvConPatMat");
            entity.Property(e => e.UperLugNac)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerLugNac");
            entity.Property(e => e.UperMatBus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerMatBus");
            entity.Property(e => e.UperNacCiuDes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UPerNacCiuDes");
            entity.Property(e => e.UperNacPaiCod).HasColumnName("UPerNacPaiCod");
            entity.Property(e => e.UperNbrCom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerNbrCom");
            entity.Property(e => e.UperNomBus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerNomBus");
            entity.Property(e => e.UperNomIngreso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPerNomIngreso");
            entity.Property(e => e.UperNomMatSup)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperNomPatSup)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperPaiCodPar).HasColumnName("UPerPaiCodPar");
            entity.Property(e => e.UperPatBus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerPatBus");
            entity.Property(e => e.UperPrefPer)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperReinci)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerReinci");
            entity.Property(e => e.UperSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerSexo");
            entity.Property(e => e.UperTarCtrl).HasColumnName("UPerTarCtrl");
        });

        modelBuilder.Entity<UperAmputacione>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperAmpNro }).HasName("PK__UPer_Amp__6E4CB9430856E012");

            entity.ToTable("UPer_Amputaciones");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperAmpNro).HasColumnName("UPerAmpNro");
        });

        modelBuilder.Entity<UperApodo>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperApoCod }).HasName("PK__UPer_Apo__B550D1B0A89FF69B");

            entity.ToTable("UPer_Apodos");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperApoCod).HasColumnName("UPerApoCod");
            entity.Property(e => e.UperApoPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperApoVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UperAuditoria>(entity =>
        {
            entity.HasKey(e => e.UperAudFolio).HasName("PK__UPer_Aud__E022A0AB1AAD4887");

            entity.ToTable("UPer_Auditorias");

            entity.Property(e => e.UperAudFolio)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("UPerAudFolio");
            entity.Property(e => e.UperAudFecHora)
                .HasColumnType("datetime")
                .HasColumnName("UPerAudFecHora");
            entity.Property(e => e.UperAudFun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAudFun");
            entity.Property(e => e.UperAudInvCorr)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("UPerAudInvCorr");
            entity.Property(e => e.UperAudIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAudIP");
            entity.Property(e => e.UperAudNomConcat)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("UPerAudNomConcat");
            entity.Property(e => e.UperAudObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UPerAudObs");
            entity.Property(e => e.UperAudPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAudPerId");
            entity.Property(e => e.UperAudTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerAudTipo");
            entity.Property(e => e.UperAudUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerAudUni");
        });

        modelBuilder.Entity<UperCicatrice>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCicNro }).HasName("PK__UPer_Cic__632656C1670A11EA");

            entity.ToTable("UPer_Cicatrices");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperCicNro).HasColumnName("UPerCicNro");
            entity.Property(e => e.UperCicExtImg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperCicNomImg)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UperCicTipo).HasColumnName("UPerCicTipo");
        });

        modelBuilder.Entity<UperDanCor>(entity =>
        {
            entity.HasKey(e => new { e.InpFolio, e.InpPerFolio, e.InpIdDanCor }).HasName("PK__UperDanC__B542130B5A3E02F8");

            entity.ToTable("UperDanCor");

            entity.HasIndex(e => e.InpFisUbiCod, "ITUPERDANCOR1");

            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UperDetencionesDetalleLevel1>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperUniDet, e.UperUniParte, e.UperNroDel }).HasName("PK__Uper_Det__F673C5105933150A");

            entity.ToTable("Uper_Detenciones_DetalleLevel1");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperUniDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperUniParte).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UperDelFecCau).HasColumnType("datetime");
            entity.Property(e => e.UperDelObs)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.UperDelOrgCod).HasColumnName("UPerDelOrgCod");
            entity.Property(e => e.UperDelOrgDetCod).HasColumnName("UPerDelOrgDetCod");
            entity.Property(e => e.UperDelRit)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UperDelRuc)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UperDetencionesLevel1>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperUniDet, e.UperUniParte }).HasName("PK__Uper_Det__EC998A550784869A");

            entity.ToTable("Uper_DetencionesLevel1");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperUniDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperUniParte).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.ReaDelDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UperDetAseNro)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UperDetComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDetComCod");
            entity.Property(e => e.UperDetFecIng).HasColumnType("datetime");
            entity.Property(e => e.UperDetFecPar).HasColumnType("datetime");
            entity.Property(e => e.UperDetFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerDetFecUpd");
            entity.Property(e => e.UperDetFunIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDetFunIns");
            entity.Property(e => e.UperDetFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDetFunUpd");
            entity.Property(e => e.UperDetHora)
                .HasColumnType("datetime")
                .HasColumnName("UPerDetHora");
            entity.Property(e => e.UperDetRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDetRegCod");
            entity.Property(e => e.UperDetVig).HasColumnName("UPerDetVig");
            entity.Property(e => e.UperFilUniCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerFilUniCod");
        });

        modelBuilder.Entity<UperDocIdenArch>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperDocIdenNro }).HasName("PK__Uper_Doc__90FE6F096F87D0AC");

            entity.ToTable("Uper_DocIdenArch");

            entity.HasIndex(e => new { e.UperId, e.UperDocIdenNro }, "UPER_DOCIDENARCH2").IsDescending(false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperDocIdenArch1).HasColumnName("UperDocIdenArch");
            entity.Property(e => e.UperDocIdenExt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDocIdenNom)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UperEspecialidad>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.EspDelCod }).HasName("PK__Uper_Esp__EC3F6F9A93E584A9");

            entity.ToTable("Uper_Especialidad");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperEspePrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UperHisMorfologico>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.HtrMrfNroLin }).HasName("PK__UPer_His__EF118262155C6EA4");

            entity.ToTable("UPer_HisMorfologico");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.HtrMrfFunInsFch).HasColumnType("datetime");
            entity.Property(e => e.HtrMrfFunUpdFch).HasColumnType("datetime");
            entity.Property(e => e.HtrMrfMasObs)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.HtrMrfPesoKgr).HasColumnType("money");
            entity.Property(e => e.HtrMrfSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UperNombreSupuesto>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperSupNomId }).HasName("PK__UPer_Nom__C4D4A9F70227D30E");

            entity.ToTable("UPer_Nombre_Supuestos");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperSupNomId).HasColumnName("UPerSupNomId");
            entity.Property(e => e.UperNomSupPrim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperNomSupVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsupApeMat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("USupApeMat");
            entity.Property(e => e.UsupApePat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("USupApePat");
            entity.Property(e => e.UsupNomCom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("USupNomCom");
        });

        modelBuilder.Entity<UperRedSoc>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperIdRedSoc }).HasName("PK__Uper_Red__57D10CDBBD532915");

            entity.ToTable("Uper_RedSoc");

            entity.HasIndex(e => new { e.UperId, e.UperIdRedSoc }, "IUPER_REDSOC2").IsDescending(false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperOtrRdSoc)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperRedSocVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperTpRedSoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperUrlredSoc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UperURLRedSoc");
            entity.Property(e => e.UperUsuNck)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UperSolApeFic>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperFolSol }).HasName("PK__UperSolA__1DE73785FDD042AF");

            entity.ToTable("UperSolApeFic");

            entity.HasIndex(e => new { e.UperId, e.UperFolSol }, "IUPERSOLAPEFIC3").IsDescending(false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperFchCie).HasColumnType("datetime");
            entity.Property(e => e.UperFchSol).HasColumnType("datetime");
            entity.Property(e => e.UperMotApe)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UperSolicitude>(entity =>
        {
            entity.HasKey(e => e.NroSolicitud).HasName("PK__UperSoli__EAD5CE476E262244");

            entity.Property(e => e.NroSolicitud).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UperFePregunta).HasColumnType("datetime");
            entity.Property(e => e.UperFeRespuesta).HasColumnType("datetime");
            entity.Property(e => e.UperFpregunta).HasColumnName("UperFPregunta");
            entity.Property(e => e.UperFrespuesta).HasColumnName("UperFRespuesta");
            entity.Property(e => e.UperFuncionS).IsUnicode(false);
            entity.Property(e => e.UperfuncionR).IsUnicode(false);
        });

        modelBuilder.Entity<UperTatuaje>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperTatNro }).HasName("PK__UPer_Tat__0B28321DA7424347");

            entity.ToTable("UPer_Tatuajes");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperTatNro).HasColumnName("UPerTatNro");
            entity.Property(e => e.UperTatImgExt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpertatImgNom)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UperVendedore>(entity =>
        {
            entity.HasKey(e => e.UperVenId).HasName("PK__Uper_Ven__7061161C719B5703");

            entity.ToTable("Uper_Vendedores");

            entity.Property(e => e.UperVenId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UperVenApeMat)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UperVenApePat)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UperVenCom)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperVenDir)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UperVenDv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperVenIdEnc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerVenIdEnc");
            entity.Property(e => e.UperVenNombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UperVenRut).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.UperVenTipDoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerVenTipDoc");
        });

        modelBuilder.Entity<UpersonasAntMig>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCorrAntM }).HasName("PK__UPersona__99707410AF935A85");

            entity.ToTable("UPersonas_AntMig");

            entity.HasIndex(e => e.UperAcomEst, "IUPERSONAS_ANTMIG");

            entity.HasIndex(e => e.UperLigIngAntM, "IUPERSONAS_ANTMIG1");

            entity.HasIndex(e => e.UperDivPag, "IUPERSONAS_ANTMIG2");

            entity.HasIndex(e => e.UperCondIngAntM, "UPER_UNIANTMIG1");

            entity.HasIndex(e => e.UperTipVisAntM, "UPER_UNIANTMIG3");

            entity.HasIndex(e => new { e.UperId, e.UperCorrAntM }, "UPER_UNIANTMIG4").IsDescending(false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UpeAntMigVictima)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UperAntIngDocu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperAntMigAcomPar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperAntMigVinculoPais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UperAntmigFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperAntmigFlagDet)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UperAutoOrtor)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperCondIngAntM)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperCondResAntM)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UperDinPagEst).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.UperDivPag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperFecIngAntM).HasColumnType("datetime");
            entity.Property(e => e.UperFecIngAntM2).HasColumnType("datetime");
            entity.Property(e => e.UperFecIngEst).HasColumnType("datetime");
            entity.Property(e => e.UperFecIngEst2).HasColumnType("datetime");
            entity.Property(e => e.UperFecResDoc).HasColumnType("datetime");
            entity.Property(e => e.UperFecVenDoc).HasColumnType("datetime");
            entity.Property(e => e.UperForIngEst)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperLigIngAntM)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperMedTransEst)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperNomAcomAntMig)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperNomDueResAnt)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperNumResDoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UperNumTimMigEst)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UperPerPagEst)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperRunEmpAntM)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UperTipIngPai)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperTipVisAntM)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasAsetecInfo>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperAsetecFolio }).HasName("PK__UPersona__A60F353F156D334A");

            entity.ToTable("UPersonas_Asetec_Info");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperAsetecFolio).HasColumnName("UPerAsetecFolio");
            entity.Property(e => e.UperAsetecFec)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsetecFec");
            entity.Property(e => e.UperAsetecInfVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperAsetecInfo)
                .IsUnicode(false)
                .HasColumnName("UPerAsetecInfo");
        });

        modelBuilder.Entity<UpersonasAsociacione>(entity =>
        {
            entity.HasKey(e => new { e.UperAsoPri, e.UperAsoSec, e.AsoTipCod }).HasName("PK__UPersona__14527D3E96933DE7");

            entity.ToTable("UPersonas_Asociaciones");

            entity.HasIndex(e => e.AsoTipCod, "IUPERSONAS_ASOCIACIONES1");

            entity.HasIndex(e => e.UperAsoSec, "IUPERSONAS_ASOCIACIONES3");

            entity.Property(e => e.UperAsoPri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoPri");
            entity.Property(e => e.UperAsoSec)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerAsoSec");
            entity.Property(e => e.UperAsoAplIns).HasColumnName("UPerAsoAplIns");
            entity.Property(e => e.UperAsoAplUpd).HasColumnName("UPerAsoAplUpd");
            entity.Property(e => e.UperAsoFecIni)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIni");
            entity.Property(e => e.UperAsoFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecIns");
            entity.Property(e => e.UperAsoFecTer)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecTer");
            entity.Property(e => e.UperAsoFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerAsoFecUpd");
            entity.Property(e => e.UperAsoObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UPerAsoObs");
            entity.Property(e => e.UperAsoUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAsoUsuIns");
            entity.Property(e => e.UperAsoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerAsoUsuUpd");
            entity.Property(e => e.UperAsoVigencia).HasColumnName("UPerAsoVigencia");
            entity.Property(e => e.UperAsoWrkStIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAsoWrkStIns");
            entity.Property(e => e.UperAsoWrkStUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerAsoWrkStUpd");
        });

        modelBuilder.Entity<UpersonasCancelacion>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCanAntNro }).HasName("PK__UPersona__97C811FCB5D5A551");

            entity.ToTable("UPersonas_Cancelacion");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperCanAntNro).HasColumnName("UPerCanAntNro");
            entity.Property(e => e.EncTipDocCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperCanAntFec)
                .HasColumnType("datetime")
                .HasColumnName("UPerCanAntFec");
            entity.Property(e => e.UperCanAntTipo).HasColumnName("UPerCanAntTipo");
            entity.Property(e => e.UperCanFecDoc)
                .HasColumnType("datetime")
                .HasColumnName("UPerCanFecDoc");
            entity.Property(e => e.UperCanFun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerCanFun");
            entity.Property(e => e.UperCanFunEmiDoc).HasColumnName("UPerCanFunEmiDoc");
            entity.Property(e => e.UperCanFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerCanFunUpd");
            entity.Property(e => e.UperCanInsFec)
                .HasColumnType("datetime")
                .HasColumnName("UPerCanInsFec");
            entity.Property(e => e.UperCanInsWrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerCanInsWrk");
            entity.Property(e => e.UperCanNiv).HasColumnName("UPerCanNiv");
            entity.Property(e => e.UperCanNroDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerCanNroDoc");
            entity.Property(e => e.UperCanObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UPerCanObs");
            entity.Property(e => e.UperCanResolex)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerCanResolex");
            entity.Property(e => e.UperCanRevNiv).HasColumnName("UPerCanRevNiv");
            entity.Property(e => e.UperCanRevObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("UPerCanRevObs");
            entity.Property(e => e.UperCanStatus).HasColumnName("UPerCanStatus");
            entity.Property(e => e.UperCanUni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerCanUni");
            entity.Property(e => e.UperCanUniEmiDoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerCanUniEmiDoc");
            entity.Property(e => e.UperCanUniUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerCanUniUpd");
            entity.Property(e => e.UperCanUpdFec)
                .HasColumnType("datetime")
                .HasColumnName("UPerCanUpdFec");
            entity.Property(e => e.UperCanUpdWrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerCanUpdWrk");
        });

        modelBuilder.Entity<UpersonasCancelacionDetalle>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCanAntNro, e.UperCanAntDetNro }).HasName("PK__UPersona__94D59F3EEB1098A3");

            entity.ToTable("UPersonas_Cancelacion_Detalle");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperCanAntNro).HasColumnName("UPerCanAntNro");
            entity.Property(e => e.UperCanAntDetNro).HasColumnName("UPerCanAntDetNro");
            entity.Property(e => e.UperCanAntCla).HasColumnName("UPerCanAntCla");
            entity.Property(e => e.UperCanAntEncFol).HasColumnName("UPerCanAntEncFol");
            entity.Property(e => e.UperCanAntParDet)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("UPerCanAntParDet");
            entity.Property(e => e.UperCanAntRevFec)
                .HasColumnType("datetime")
                .HasColumnName("UPerCanAntRevFec");
            entity.Property(e => e.UperCanAntStatus).HasColumnName("UPerCanAntStatus");
            entity.Property(e => e.UperCanAntUniDet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerCanAntUniDet");
        });

        modelBuilder.Entity<UpersonasDocumento>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperDocTipo, e.UperDocNro, e.UperDocPaiEmi }).HasName("PK__UPersona__AF3D54C0B79FCEC1");

            entity.ToTable("UPersonas_Documentos");

            entity.HasIndex(e => new { e.UperDocTipo, e.UperDocPaiEmi, e.UperDocNro }, "IUPERSONAS_DOCUMENTOS7");

            entity.HasIndex(e => e.UperId, "IUPersonas_Documentos1").HasFillFactor(100);

            entity.HasIndex(e => e.UperDocPaiEmi, "IUPersonas_Documentos2").HasFillFactor(100);

            entity.HasIndex(e => new { e.UperId, e.UperDocTipo, e.UperDocPaiEmi }, "IUPersonas_Documentos4").HasFillFactor(100);

            entity.HasIndex(e => new { e.UperId, e.UperDocVig, e.UperDocPrin }, "IUPersonas_Documentos5")
                .IsDescending(false, false, true)
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.UperDocSexo, e.UperDocAplIns }, "IUPersonas_Documentos6").HasFillFactor(100);

            entity.HasIndex(e => new { e.UperDocNro, e.UperDocPrin, e.UperDocVig }, "UPerDocNumero").HasFillFactor(100);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperDocTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDocTipo");
            entity.Property(e => e.UperDocNro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerDocNro");
            entity.Property(e => e.UperDocPaiEmi).HasColumnName("UPerDocPaiEmi");
            entity.Property(e => e.UperDocAnt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDocAplIns).HasColumnName("UPerDocAplIns");
            entity.Property(e => e.UperDocAplUpd).HasColumnName("UPerDocAplUpd");
            entity.Property(e => e.UperDocDv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDocDV");
            entity.Property(e => e.UperDocFecEmi)
                .HasColumnType("datetime")
                .HasColumnName("UPerDocFecEmi");
            entity.Property(e => e.UperDocFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerDocFecIns");
            entity.Property(e => e.UperDocFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerDocFecUpd");
            entity.Property(e => e.UperDocFecVen)
                .HasColumnType("datetime")
                .HasColumnName("UPerDocFecVen");
            entity.Property(e => e.UperDocPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDocSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDocUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDocUsuIns");
            entity.Property(e => e.UperDocUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDocUsuUpd");
            entity.Property(e => e.UperDocVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDocWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerDocWrkIns");
            entity.Property(e => e.UperDocWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerDocWrkUpd");
        });

        modelBuilder.Entity<UpersonasDomicilio>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperDomNro }).HasName("PK__UPersona__EA4A32830EF83141");

            entity.ToTable("UPersonas_Domicilios");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperDomNro).HasColumnName("UPerDomNro");
            entity.Property(e => e.UperBlockDep)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDesVillPob)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UperDomAplIns).HasColumnName("UPerDomAplIns");
            entity.Property(e => e.UperDomAplUpd).HasColumnName("UPerDomAplUpd");
            entity.Property(e => e.UperDomCalleCod)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("UPerDomCalleCod");
            entity.Property(e => e.UperDomCalleDes)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("UPerDomCalleDes");
            entity.Property(e => e.UperDomCalleNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDomCalleNro");
            entity.Property(e => e.UperDomCalleTipo).HasColumnName("UPerDomCalleTipo");
            entity.Property(e => e.UperDomComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDomComCod");
            entity.Property(e => e.UperDomCompPer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UperDomDptoNro)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UPerDomDptoNro");
            entity.Property(e => e.UperDomExt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDomFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerDomFecIns");
            entity.Property(e => e.UperDomFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerDomFecUpd");
            entity.Property(e => e.UperDomPerLat)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UperDomPerLong)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UperDomPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDomPrvCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDomPrvCod");
            entity.Property(e => e.UperDomRegCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerDomRegCod");
            entity.Property(e => e.UperDomTipo).HasColumnName("UPerDomTipo");
            entity.Property(e => e.UperDomUsuIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDomUsuIns");
            entity.Property(e => e.UperDomUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerDomUsuUpd");
            entity.Property(e => e.UperDomVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperDomVilCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UPerDomVilCod");
            entity.Property(e => e.UperDomWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerDomWrkIns");
            entity.Property(e => e.UperDomWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerDomWrkUpd");
            entity.Property(e => e.UperLugTrab)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerLugTrab");
            entity.Property(e => e.UperNroBcd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerNroBCD");
            entity.Property(e => e.UperTipBcd).HasColumnName("UPerTipBCD");
        });

        modelBuilder.Entity<UpersonasEmail>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperEmail }).HasName("PK__UPersona__BB11A84D269BFA2E");

            entity.ToTable("UPersonas_Emails");

            entity.HasIndex(e => new { e.UperId, e.UperEmailVig, e.UperEmailPrin }, "IUPERSONAS_EMAILSUPD2").IsDescending(false, false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperEmail)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UperEmailPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperEmailVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasEnfermedade>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.EnfCod }).HasName("PK__UPersona__3CE7AA72AD211EE6");

            entity.ToTable("UPersonas_Enfermedades");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.EnfVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasEstablecimiento>(entity =>
        {
            entity.HasKey(e => new { e.Uperid, e.Upersinestnro }).HasName("PK__UPERSONA__CBEDD7F3BBB28BFA");

            entity.ToTable("UPERSONAS_ESTABLECIMIENTOS");

            entity.Property(e => e.Uperid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPERID");
            entity.Property(e => e.Upersinestnro)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("UPERSINESTNRO");
            entity.Property(e => e.Upersinestfec)
                .HasColumnType("datetime")
                .HasColumnName("UPERSINESTFEC");
            entity.Property(e => e.Upersinestrol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPERSINESTROL");
            entity.Property(e => e.Upersinestrut)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("UPERSINESTRUT");
            entity.Property(e => e.Upersinestsuc)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("UPERSINESTSUC");
            entity.Property(e => e.Upersinestusu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPERSINESTUSU");
            entity.Property(e => e.Upersinestwrk)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPERSINESTWRK");
        });

        modelBuilder.Entity<UpersonasFoto>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperFotoId }).HasName("PK__UPersona__4BD3A1C9A3F822FD");

            entity.ToTable("UPersonas_Fotos");

            entity.HasIndex(e => e.FisUbiCod, "IUPERSONAS_FOTOS2");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperFotoId).HasColumnName("UPerFotoId");
            entity.Property(e => e.UperFotoFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerFotoFecIns");
            entity.Property(e => e.UperFotoFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerFotoFecUpd");
            entity.Property(e => e.UperFotoFront).HasColumnName("UPerFotoFront");
            entity.Property(e => e.UperFotoImg).HasColumnName("UPerFotoImg");
            entity.Property(e => e.UperFotoPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperFotoUsuCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerFotoUsuCod");
            entity.Property(e => e.UperFotoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerFotoUsuUpd");
            entity.Property(e => e.UperFotoVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperFotoWrkIns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerFotoWrkIns");
            entity.Property(e => e.UperFotoWrkUpd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerFotoWrkUpd");
        });

        modelBuilder.Entity<UpersonasGrupoCriminal>(entity =>
        {
            entity.HasKey(e => new { e.GrupoCrimAsoId, e.GrupoCrimCod, e.GrupoCrimAsoCod, e.GrupoCrimReg, e.GrupoCrimProv, e.GrupoCrimCom }).HasName("PK__Upersona__D799456AA8ABEE99");

            entity.ToTable("Upersonas_Grupo_Criminal");

            entity.Property(e => e.GrupoCrimAsoId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.GrupoCrimReg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoCrimProv)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoCrimCom)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupCriAsoFecIni).HasColumnType("datetime");
            entity.Property(e => e.GrupCriAsoFecIns).HasColumnType("datetime");
            entity.Property(e => e.GrupCriAsoFecTer).HasColumnType("datetime");
            entity.Property(e => e.GrupCriAsoFechUpd).HasColumnType("datetime");
            entity.Property(e => e.GrupCriAsoObs)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.GrupCriAsoUserIn)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GrupCriAsoUsuUpd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GrupCriAsoWrkStUpd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GrupCriAsoWrksIns)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GrupoCrimCiuExt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrupoCrimVilla)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.GrupoPaiOpe).HasColumnType("numeric(3, 0)");
        });

        modelBuilder.Entity<UpersonasHuella>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UhueCod }).HasName("PK__UPersona__46763530F58F8AAB");

            entity.ToTable("UPersonas_Huellas");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UhueCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UHueCod");
            entity.Property(e => e.UhueClaCin)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaCin");
            entity.Property(e => e.UhueClaCua)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaCua");
            entity.Property(e => e.UhueClaDiez)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaDiez");
            entity.Property(e => e.UhueClaDos)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaDos");
            entity.Property(e => e.UhueClaNue)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaNue");
            entity.Property(e => e.UhueClaOcho)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaOcho");
            entity.Property(e => e.UhueClaSeis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaSeis");
            entity.Property(e => e.UhueClaSie)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaSie");
            entity.Property(e => e.UhueClaTres)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaTres");
            entity.Property(e => e.UhueClaUno)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UHueClaUno");
            entity.Property(e => e.UhueConCat)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UHueConCat");
        });

        modelBuilder.Entity<UpersonasInfBioMetrico>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCorrBio }).HasName("PK__UPersona__93EE31284108E6C8");

            entity.ToTable("UPersonas_InfBioMetrico");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperCorrBio).HasColumnName("UPerCorrBio");
            entity.Property(e => e.UinfBiometrico)
                .IsUnicode(false)
                .HasColumnName("UInfBiometrico");
            entity.Property(e => e.UperInfBioVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasInfDatBu>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCorrDatBus }).HasName("PK__UPersona__7F81DA8BFA906B1F");

            entity.ToTable("UPersonas_InfDatBus");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperCorrDatBus).HasColumnName("UPerCorrDatBus");
            entity.Property(e => e.UinfDatBus)
                .IsUnicode(false)
                .HasColumnName("UInfDatBus");
            entity.Property(e => e.UperInfDatBusVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasInfGepol>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UpercorrGepol }).HasName("PK__UPersona__D049958786A47DEF");

            entity.ToTable("UPersonas_InfGepol");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UinfGepol)
                .IsUnicode(false)
                .HasColumnName("UInfGepol");
            entity.Property(e => e.UnifGepolCant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UnifGepolCAnt");
            entity.Property(e => e.UperInfGepolPri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperInfGepolVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperIngGepolDel)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPerIngGepolDel");
            entity.Property(e => e.UperIngGepolDetMod).HasColumnName("UPerIngGepolDetMod");
            entity.Property(e => e.UperIngGepolDetoEnc).HasColumnName("UPerIngGepolDetoEnc");
            entity.Property(e => e.UperIngGepolDue).HasColumnName("UPerIngGepolDUE");
            entity.Property(e => e.UperIngGepolEinOre).HasColumnName("UPerIngGepolEIN_ORE");
            entity.Property(e => e.UperIngGepolEse)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UPerIngGepolESE");
            entity.Property(e => e.UperIngGepolFechaParte)
                .HasColumnType("datetime")
                .HasColumnName("UPerIngGepolFechaParte");
            entity.Property(e => e.UperIngGepolIdocore)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerIngGepolIDOCORE");
            entity.Property(e => e.UperIngGepolNroDete).HasColumnName("UPerIngGepolNroDete");
            entity.Property(e => e.UperIngGepolNroSecCor).HasColumnName("UPerIngGepolNroSecCor");
            entity.Property(e => e.UperIngGepolPerr)
                .HasColumnType("decimal(11, 0)")
                .HasColumnName("UPerIngGepolPerr");
            entity.Property(e => e.UperIngGepolTie)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UPerIngGepolTIE");
        });

        modelBuilder.Entity<UpersonasInfInterpol>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCorrInterpol }).HasName("PK__UPersona__5515F6A8FBA7D069");

            entity.ToTable("UPersonas_InfInterpol");

            entity.HasIndex(e => new { e.UperId, e.UperCorrInterpol }, "IUPERSONA_INFINTERPOL2").IsDescending(false, true);

            entity.HasIndex(e => new { e.UperId, e.UperInfInterPolVig }, "IUPERSONA_INFINTERPOL3").IsDescending(false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UinfInterpol)
                .IsUnicode(false)
                .HasColumnName("UInfInterpol");
            entity.Property(e => e.UperInfInterPolPri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerInfInterPolPri");
            entity.Property(e => e.UperInfInterPolVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasInfoB3000>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperCorrB3 }).HasName("PK__UPersona__DBE1DAD8B2881A0C");

            entity.ToTable("UPersonas_InfoB3000");

            entity.HasIndex(e => new { e.UperId, e.UperCorrB3 }, "UPER_INFOB3002").IsDescending(false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperInfVigB3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperInfoB3).IsUnicode(false);
        });

        modelBuilder.Entity<UpersonasObservacione>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperObsNro }).HasName("PK__UPersona__D06FCF6852822ADF");

            entity.ToTable("UPersonas_Observaciones");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperObsNro).HasColumnName("UPerObsNro");
            entity.Property(e => e.UperObsFecIns)
                .HasColumnType("datetime")
                .HasColumnName("UPerObsFecIns");
            entity.Property(e => e.UperObsFecUpd)
                .HasColumnType("datetime")
                .HasColumnName("UPerObsFecUpd");
            entity.Property(e => e.UperObsFunIns)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerObsFunIns");
            entity.Property(e => e.UperObsFunUpd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPerObsFunUpd");
            entity.Property(e => e.UperObsIpins)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerObsIPIns");
            entity.Property(e => e.UperObsIpupd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPerObsIPUpd");
            entity.Property(e => e.UperObsTxt)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("UPerObsTxt");
        });

        modelBuilder.Entity<UpersonasOdontograma>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.OdonCod }).HasName("PK__UPersona__F9BD036D3A63D9A7");

            entity.ToTable("UPersonas_Odontograma");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperOdonFlg).HasColumnName("UPerOdonFlg");
            entity.Property(e => e.UperOdonTxt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("UPerOdonTxt");
        });

        modelBuilder.Entity<UpersonasProfesione>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperProfCod }).HasName("PK__UPersona__08FB544D98ACE97B");

            entity.ToTable("UPersonas_Profesiones");

            entity.HasIndex(e => e.UperProfCod, "IUPERSONAS_PROFESIONES2");

            entity.HasIndex(e => new { e.UperId, e.UperProfVig, e.UperProfPrin }, "IUPERSONAS_PROFESIONES3").IsDescending(false, false, true);

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperProfCod).HasColumnName("UPerProfCod");
            entity.Property(e => e.UperProfPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperProfVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasProgReha>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UniCodProgReha }).HasName("PK__UPersona__B3BAB3E3B3C91AF5");

            entity.ToTable("UPersonas_ProgReha");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UniEstProgReha)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniNomProgReha)
                .HasMaxLength(500)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasTelefono>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperTipTel, e.UperCodAreaTel, e.UperNumTel }).HasName("PK__UPersona__587618FC70388DF4");

            entity.ToTable("UPersonas_Telefonos");

            entity.HasIndex(e => new { e.UperId, e.UperFonoVig, e.UperFonoPrin }, "IUPERSONAS_TELEFONOS2").IsDescending(false, false, true);

            entity.HasIndex(e => e.UperId, "IUPersonas_Telefonos1");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperTipTel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperCodAreaTel)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperNumTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperFonoPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperFonoVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasVehiculo>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.VehPaten, e.UperMarVehCod, e.UperVehCod }).HasName("PK__UPersona__BB03B35B928E1503");

            entity.ToTable("UPersonas_Vehiculos");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.VehPaten)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperMarVehCod).HasColumnName("UPerMarVehCod");
            entity.Property(e => e.UperVehCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperVehNomCom)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("UPerVehNomCom");
            entity.Property(e => e.UperVehObs)
                .IsUnicode(false)
                .HasColumnName("UPerVehObs");
            entity.Property(e => e.UperVehPrin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperVehVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UpersonasViaje>(entity =>
        {
            entity.HasKey(e => new { e.UperId, e.UperViaNro }).HasName("PK__Upersona__F5521298656B0BB4");

            entity.ToTable("Upersonas_Viajes");

            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperViaDes).IsUnicode(false);
            entity.Property(e => e.UperViaVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VDecretosDestapolSolo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_decretosDestapolSolos");

            entity.Property(e => e.CausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CAUSA_O_RUC");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("decreto");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("delito");
            entity.Property(e => e.FamiliaOrganismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("familiaOrganismo");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("fechaDocumento");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("fechaEndoso");
            entity.Property(e => e.FechaInformada)
                .HasColumnType("datetime")
                .HasColumnName("fechaInformada");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fechaIngreso");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("date")
                .HasColumnName("fechaRecepcion");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fechaVencimiento");
            entity.Property(e => e.HoraRecepcion).HasColumnName("horaRecepcion");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.Organismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("organismo");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("resultado");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad");
        });

        modelBuilder.Entity<VDestapolDatosPersonalesBrain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Destapol_DatosPersonalesBrain");

            entity.Property(e => e.ApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.ApellMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apell_mat");
            entity.Property(e => e.Calle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.CalleNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("calle_Nro");
            entity.Property(e => e.CodEstCivil)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_EST_CIVIL");
            entity.Property(e => e.CodPaisNac).HasColumnName("COD_PAIS_NAC");
            entity.Property(e => e.ComunaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_persona");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EST_CIVIL");
            entity.Property(e => e.EstudiosTerminados)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etnia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ETNIA");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Genero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.LatitudDomicilio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("latitudDomicilio");
            entity.Property(e => e.LongitudDomicilio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("longitudDomicilio");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NroInmueble)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.ProvinciaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROVINCIA_PERSONA");
            entity.Property(e => e.RegionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_persona");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoInmueble)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperTipBcd).HasColumnName("UPerTipBCD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("villa/pob");
        });

        modelBuilder.Entity<VDeteFoto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dete_fotos");

            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad)
                .HasColumnType("numeric(25, 6)")
                .HasColumnName("edad");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("escolaridad");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("materno");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nacionalidad");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_completo");
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("paterno");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_documento");
            entity.Property(e => e.UperCondDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPerCondDes");
            entity.Property(e => e.UperFchNac)
                .HasColumnType("datetime")
                .HasColumnName("UPerFchNac");
            entity.Property(e => e.Uperid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("uperid");
        });

        modelBuilder.Entity<VDrogas15Dia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DROGAS_15_DIAS");

            entity.Property(e => e.Avaluo)
                .HasColumnType("decimal(30, 4)")
                .HasColumnName("AVALUO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodJefatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD. JEFATURA");
            entity.Property(e => e.CodPrefectura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD. PREFECTURA");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD. REGION");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD. UNIDAD");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA HECHO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DELITO");
            entity.Property(e => e.Droga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DROGA");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaAccionDroga)
                .HasColumnType("datetime")
                .HasColumnName("FECHA ACCION DROGA");
            entity.Property(e => e.FechaHoraExtraccion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA EXTRACCION");
            entity.Property(e => e.FechaInforme)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INFORME");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA RECEPCION");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.FolioNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO NACIONAL");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("JEFATURA");
            entity.Property(e => e.Nue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("NUE");
            entity.Property(e => e.OcultamientoDroga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OCULTAMIENTO DROGA");
            entity.Property(e => e.Ovoide).HasColumnName("OVOIDE");
            entity.Property(e => e.PaisDestino)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAIS DESTINO");
            entity.Property(e => e.PaisOrigen)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAIS ORIGEN");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PREFECTURA");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UNIDAD MEDIDA");
            entity.Property(e => e.ValorUnitario)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("VALOR UNITARIO");
        });

        modelBuilder.Entity<VDrogasDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DROGAS_DESTAPOL");

            entity.Property(e => e.Avaluo)
                .HasColumnType("decimal(30, 4)")
                .HasColumnName("AVALUO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.Droga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DROGA");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaInformada).HasColumnType("datetime");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Medida)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MEDIDA");
            entity.Property(e => e.MesAño)
                .HasColumnType("datetime")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.Nue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("NUE");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<VEspacioBd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_espacio_BD");

            entity.Property(e => e.EspacioNoUtilizadoMb)
                .HasColumnType("numeric(36, 2)")
                .HasColumnName("EspacioNoUtilizado_MB");
            entity.Property(e => e.EspacioUtilizadoMb)
                .HasColumnType("numeric(36, 2)")
                .HasColumnName("EspacioUtilizado_MB");
            entity.Property(e => e.Esquema).HasMaxLength(128);
            entity.Property(e => e.Tabla).HasMaxLength(128);
            entity.Property(e => e.TotalEspacioMb)
                .HasColumnType("numeric(36, 2)")
                .HasColumnName("TotalEspacio_MB");
        });

        modelBuilder.Entity<VHechosGeo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_hechos_geo");

            entity.Property(e => e.AgrupacionDelito).HasColumnName("AGRUPACION_DELITO");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido2");
            entity.Property(e => e.CalleDiligencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle_diligencia");
            entity.Property(e => e.ComunaDiligencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_diligencia");
            entity.Property(e => e.CondicionImplicado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("condicion_implicado");
            entity.Property(e => e.DatetimeHecho)
                .HasMaxLength(81)
                .IsUnicode(false)
                .HasColumnName("datetime_hecho");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DV");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.FechNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fech_nacimiento");
            entity.Property(e => e.FechaDecreto)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DECRETO");
            entity.Property(e => e.FechaRecepcionDecreto)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_RECEPCION_DECRETO");
            entity.Property(e => e.GrupoCriminal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo_criminal");
            entity.Property(e => e.IdKey).HasColumnName("ID_KEY");
            entity.Property(e => e.Inpfolio)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("inpfolio");
            entity.Property(e => e.LatDiligencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lat_diligencia");
            entity.Property(e => e.LongDiligencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("long_diligencia");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NrodirDiligencia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nrodir_diligencia");
            entity.Property(e => e.RegionDiligencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_diligencia");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("resultado");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad");
        });

        modelBuilder.Entity<VInpModusoperandi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_inp_modusoperandi");

            entity.Property(e => e.CodDetalle).HasColumnName("cod_detalle");
            entity.Property(e => e.CodFamilia).HasColumnName("cod_familia");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Familia)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.VigDetalle).HasColumnName("vig_detalle");
            entity.Property(e => e.VigFamilia).HasColumnName("vig_familia");
        });

        modelBuilder.Entity<VLibro6a>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_libro6a");

            entity.Property(e => e.Correlativo)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("correlativo");
            entity.Property(e => e.Discapacidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("discapacidad");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.FechaEgreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_egreso");
            entity.Property(e => e.FechaEgresoReal)
                .HasColumnType("datetime")
                .HasColumnName("fecha_egreso_real");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaIngresoReal)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso_real");
            entity.Property(e => e.FuncionarioIngresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("funcionario_ingresa");
            entity.Property(e => e.FuncionarioSalida)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("funcionario_salida");
            entity.Property(e => e.FuniApe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("funi_ape1");
            entity.Property(e => e.FuniApe2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("funi_ape2");
            entity.Property(e => e.FuniRut).HasColumnName("funi_rut");
            entity.Property(e => e.FunsApe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("funs_ape1");
            entity.Property(e => e.FunsApe2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("funs_ape2");
            entity.Property(e => e.FusRut).HasColumnName("fus_rut");
            entity.Property(e => e.IdCuartel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_cuartel");
            entity.Property(e => e.Motivo)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.PApell1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("p_apell1");
            entity.Property(e => e.PApell2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("p_apell2");
            entity.Property(e => e.PDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("p_documento");
            entity.Property(e => e.PDv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("p_dv");
            entity.Property(e => e.PersonaVisitante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("persona_visitante");
            entity.Property(e => e.UperSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerSexo");
            entity.Property(e => e.Uperid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("uperid");
            entity.Property(e => e.VApell1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("v_apell1");
            entity.Property(e => e.VApell2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("v_apell2");
            entity.Property(e => e.VDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("v_documento");
            entity.Property(e => e.VDv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("v_dv");
            entity.Property(e => e.Visitado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("visitado");
        });

        modelBuilder.Entity<VLock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_lock");

            entity.Property(e => e.Dbid).HasColumnName("dbid");
            entity.Property(e => e.Objectname)
                .HasMaxLength(128)
                .HasColumnName("objectname");
            entity.Property(e => e.Rmode)
                .HasMaxLength(60)
                .HasColumnName("rmode");
            entity.Property(e => e.Rstatus)
                .HasMaxLength(60)
                .HasColumnName("rstatus");
            entity.Property(e => e.Sessionid).HasColumnName("sessionid");
            entity.Property(e => e.Type)
                .HasMaxLength(60)
                .HasColumnName("type");
        });

        modelBuilder.Entity<VMorfoPeinDestapol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_morfoPein_destapol");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Parte)
                .HasMaxLength(60)
                .HasColumnName("parte");
            entity.Property(e => e.Pein)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pein");
            entity.Property(e => e.Tipo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Uperid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("uperid");
        });

        modelBuilder.Entity<VPerGrupoCrim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_per_grupo_crim");

            entity.Property(e => e.ComunaOrganizacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_organizacion");
            entity.Property(e => e.Documento)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.FechaInscriPein)
                .HasColumnType("date")
                .HasColumnName("fecha_inscri_pein");
            entity.Property(e => e.FuncionarioInscribe)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("funcionario_inscribe");
            entity.Property(e => e.Jerarquia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jerarquia");
            entity.Property(e => e.NombreGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_grupo");
            entity.Property(e => e.NombreIntegrante)
                .HasMaxLength(92)
                .IsUnicode(false)
                .HasColumnName("nombre_integrante");
            entity.Property(e => e.ObsDelpein)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obs_delpein");
            entity.Property(e => e.ProvinciaOrganizacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("provincia_organizacion");
            entity.Property(e => e.RegionOrganizacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_organizacion");
            entity.Property(e => e.RutFunInscribe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rut_fun_inscribe");
            entity.Property(e => e.TipoOrg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_org");
            entity.Property(e => e.UnidadFuncionario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad_funcionario");
        });

        modelBuilder.Entity<VPersonasDestapolSola>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PersonasDestapolSolas");

            entity.Property(e => e.ApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.ApellMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apell_mat");
            entity.Property(e => e.Apodo)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Calle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.CalleNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("calle_Nro");
            entity.Property(e => e.CodArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodEstCivil)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_EST_CIVIL");
            entity.Property(e => e.CodPaisNac).HasColumnName("COD_PAIS_NAC");
            entity.Property(e => e.ComunaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comuna_persona");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dv");
            entity.Property(e => e.Edad).HasColumnName("EDAD");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.EstCivil)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EST_CIVIL");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.LatitudDom)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LongitudDom)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NroDpto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("nro_DPTO");
            entity.Property(e => e.Profesion)
                .HasMaxLength(65)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROFESION");
            entity.Property(e => e.ProvinciaPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROVINCIA_PERSONA");
            entity.Property(e => e.RegionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_persona");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEXO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("villa/pob");
        });

        modelBuilder.Entity<VReportserverConcurrencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORTSERVER_CONCURRENCIAS");

            entity.Property(e => e.Delito).HasColumnName("delito");
            entity.Property(e => e.EstadoSs)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Estado_SS");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tipo_decreto");
            entity.Property(e => e.TipoLugar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPO_LUGAR");
            entity.Property(e => e.TotalConcu).HasColumnName("TOTAL CONCU");
            entity.Property(e => e.TotalSs).HasColumnName("TOTAL SS");
        });

        modelBuilder.Entity<VReportserverContextoPai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORTSERVER_ContextoPais");

            entity.Property(e => e.CodContexto).HasColumnName("COD. CONTEXTO");
            entity.Property(e => e.CodDetContexto).HasColumnName("COD. DET. CONTEXTO");
            entity.Property(e => e.DetalleContexto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLE CONTEXTO");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.GrupoContexto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GRUPO CONTEXTO");
        });

        modelBuilder.Entity<VReportserverDroga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORTSERVER_DROGAS");

            entity.Property(e => e.Avaluo)
                .HasColumnType("decimal(30, 4)")
                .HasColumnName("avaluo");
            entity.Property(e => e.AvaluoUnitario)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("avaluoUnitario");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodJefatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("codJefatura");
            entity.Property(e => e.CodPrefectura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("codPrefectura");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codRegion");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codUnidad");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("delito");
            entity.Property(e => e.Droga)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("droga");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaInformada)
                .HasColumnType("datetime")
                .HasColumnName("fechaInformada");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fechaRecepcion");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("folioInterno");
            entity.Property(e => e.FolioNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("folioNacional");
            entity.Property(e => e.Jefatura)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Medida)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("medida");
            entity.Property(e => e.Nue)
                .HasColumnType("decimal(13, 0)")
                .HasColumnName("NUE");
            entity.Property(e => e.Prefectura)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unidad");
        });

        modelBuilder.Entity<VResumenInfoBrain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RESUMEN_INFO_BRAIN");

            entity.Property(e => e.CantAmpliaciones).HasColumnName("CANT. AMPLIACIONES");
            entity.Property(e => e.CantDecDiasVencidos).HasColumnName("CANT. DEC. DIAS VENCIDOS");
            entity.Property(e => e.CantDecInformados).HasColumnName("CANT. DEC. INFORMADOS");
            entity.Property(e => e.CantDecVencidos).HasColumnName("CANT DEC. VENCIDOS");
            entity.Property(e => e.CantDiligencias).HasColumnName("CANT. DILIGENCIAS");
            entity.Property(e => e.CantDiligenciasPersonales).HasColumnName("CANT. DILIGENCIAS PERSONALES");
            entity.Property(e => e.CantMinutosTrabajados).HasColumnName("CANT. MINUTOS TRABAJADOS");
            entity.Property(e => e.CantPideCuenta).HasColumnName("CANT. PIDE CUENTA");
            entity.Property(e => e.CantidadActas).HasColumnName("CANTIDAD ACTAS");
            entity.Property(e => e.CantidadInformes).HasColumnName("CANTIDAD INFORMES");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD. REGION");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.FechaIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA INGRESO SISTEMA");
            entity.Property(e => e.FuncionariosBrain).HasColumnName("FUNCIONARIOS BRAIN");
            entity.Property(e => e.PromDecDiasVencidos).HasColumnName("PROM. DEC. DIAS VENCIDOS");
            entity.Property(e => e.PromedioMinutosTrabajados).HasColumnName("PROMEDIO MINUTOS TRABAJADOS");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<VVehiculosReportserver>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VEHICULOS_REPORTSERVER");

            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("date")
                .HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.InpFolio)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Ppu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ppu");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehCod).HasName("PK__Vehiculo__59908A433F672F2C");

            entity.HasIndex(e => e.MarVehCod, "IVEHICULOS1");

            entity.HasIndex(e => e.VehColCod, "IVEHICULOS2");

            entity.HasIndex(e => e.TvhCod, "IVEHICULOS3");

            entity.HasIndex(e => new { e.VehCod, e.MarVehCod, e.VehAno }, "IVEHICULOS4").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.VehcodN, e.MarVehCod }, "IVEHICULOS5").IsDescending(true, false);

            entity.Property(e => e.VehCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TvhCod).HasColumnName("tvhCod");
            entity.Property(e => e.VehDes)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.VehMarModelo)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehiculosAltomando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VEHICULOS_ALTOMANDO");

            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodRegion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD-REGION");
            entity.Property(e => e.DetalleEspecie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE ESPECIE");
            entity.Property(e => e.Especie)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ESPECIE");
            entity.Property(e => e.Estado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.MesAño)
                .HasColumnType("date")
                .HasColumnName("MES-AÑO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<VehiculosPieza>(entity =>
        {
            entity.HasKey(e => e.VehPieCod).HasName("PK__Vehiculo__F058E0D97A1DE0A6");

            entity.ToTable("Vehiculos_Piezas");

            entity.HasIndex(e => e.VehPieMarCod, "IVEHICULOS_PIEZAS1");

            entity.HasIndex(e => e.ColCod, "IVEHICULOS_PIEZAS2");

            entity.Property(e => e.VehPieCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehPieDes)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.VehPieNroSerie)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vestimenta>(entity =>
        {
            entity.HasKey(e => e.VestCod).HasName("PK__Vestimen__101A7AD262707447");

            entity.Property(e => e.VestCod).ValueGeneratedNever();
            entity.Property(e => e.VestDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.VestVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VestimentaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.VestCod, e.VestCorr }).HasName("PK__Vestimen__2CA9628A6641052B");

            entity.ToTable("Vestimenta_Detalle");

            entity.Property(e => e.VestDetDes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VestDetVig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ViaTransporte>(entity =>
        {
            entity.HasKey(e => e.Viacod).HasName("PK__VIA_TRAN__661DD8E84FC7B427");

            entity.ToTable("VIA_TRANSPORTE");

            entity.Property(e => e.Viacod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIACOD");
            entity.Property(e => e.Viades)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIADES");
        });

        modelBuilder.Entity<Villa>(entity =>
        {
            entity.HasKey(e => e.VilCod).HasName("PK__Villas__3B4AFB8E6E57283F");

            entity.HasIndex(e => new { e.VillaPoblaCod, e.VilCod, e.VilDes }, "IVILLAS1_2");

            entity.HasIndex(e => e.VilCod, "IVILLAS1_3").IsDescending();

            entity.HasIndex(e => new { e.VilDes, e.VillaVig }, "IVILLAS1_4");

            entity.Property(e => e.VilCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.VilComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VilDes)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.VillaPoblaCod).HasColumnName("VillaPobla_cod");
        });

        modelBuilder.Entity<VillaPoblacion>(entity =>
        {
            entity.HasKey(e => new { e.ComCod, e.VilCod }).HasName("PK__Villa_po__722455580B287117");

            entity.ToTable("Villa_poblacion");

            entity.HasIndex(e => e.VilCod, "IVILLA_POBLACION");

            entity.Property(e => e.ComCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VilCod)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VisitasLibro6a>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VISITAS_LIBRO6A");

            entity.Property(e => e.ActivoEliminado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACTIVO/ELIMINADO");
            entity.Property(e => e.Asociacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ASOCIACION");
            entity.Property(e => e.ConDiscapacidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CON DISCAPACIDAD?");
            entity.Property(e => e.DocumentoIngresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO INGRESA");
            entity.Property(e => e.FechaHoraIngresoDigitado)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA INGRESO DIGITADO");
            entity.Property(e => e.FechaHoraIngresoSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA INGRESO SISTEMA");
            entity.Property(e => e.FechaHoraSalidaDigitada)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA SALIDA DIGITADA");
            entity.Property(e => e.FechaHoraSalidaSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA/HORA SALIDA SISTEMA");
            entity.Property(e => e.IdCuartel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ID CUARTEL");
            entity.Property(e => e.IdPersonaQueVisita)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MaternoFuncionario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERNO FUNCIONARIO");
            entity.Property(e => e.MaternoIngresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO INGRESA");
            entity.Property(e => e.MaternoPersonaQueVisita)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MATERNO PERSONA QUE VISITA");
            entity.Property(e => e.MotivoVisita)
                .IsUnicode(false)
                .HasColumnName("MOTIVO VISITA");
            entity.Property(e => e.NombreFuncionario)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE FUNCIONARIO");
            entity.Property(e => e.NombreIngresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE INGRESA");
            entity.Property(e => e.NombrePersonaQueVisita)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE PERSONA QUE VISITA");
            entity.Property(e => e.NumDocPersonaQueVisita)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM. DOC PERSONA QUE VISITA");
            entity.Property(e => e.Observación)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIÓN");
            entity.Property(e => e.PaternoFuncionario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PATERNO FUNCIONARIO");
            entity.Property(e => e.PaternoIngresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO INGRESA");
            entity.Property(e => e.PaternoPersonaQueVisita)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PATERNO PERSONA QUE VISITA");
            entity.Property(e => e.RutFunIngresa).HasColumnName("RUT FUN INGRESA");
            entity.Property(e => e.UniLib6aCorr).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<VistaNna>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VISTA_NNA");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CIUDAD");
            entity.Property(e => e.CodDelito).HasColumnName("COD. DELITO");
            entity.Property(e => e.CondicionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION PERSONA");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.FechaDenuncia)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DENUNCIA");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.FolioNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO NACIONAL");
            entity.Property(e => e.HoraDenuncia)
                .HasColumnType("datetime")
                .HasColumnName("HORA DENUNCIA");
            entity.Property(e => e.InpInfoF3nna)
                .IsUnicode(false)
                .HasColumnName("InpInfoF3NNA");
            entity.Property(e => e.InpInfoF4nna)
                .IsUnicode(false)
                .HasColumnName("InpInfoF4NNA");
            entity.Property(e => e.NomAcomNna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NomAcomNNA");
            entity.Property(e => e.NomProtecNna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NomProtecNNA");
            entity.Property(e => e.NombreDenunciante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE DENUNCIANTE");
            entity.Property(e => e.NumDocDenun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM. DOC. DENUN");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Relato)
                .IsUnicode(false)
                .HasColumnName("RELATO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e._1ApellidoDenunciante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO DENUNCIANTE");
            entity.Property(e => e._2ApellidoDenunciante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO DENUNCIANTE");
        });

        modelBuilder.Entity<VistaNnaSinFor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_nna_sin_for");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CIUDAD");
            entity.Property(e => e.CodDelito).HasColumnName("COD. DELITO");
            entity.Property(e => e.CondicionPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONDICION PERSONA");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.FechaDenuncia)
                .HasColumnType("datetime")
                .HasColumnName("FECHA DENUNCIA");
            entity.Property(e => e.FolioInterno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO INTERNO");
            entity.Property(e => e.FolioNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO NACIONAL");
            entity.Property(e => e.HoraDenuncia)
                .HasColumnType("datetime")
                .HasColumnName("HORA DENUNCIA");
            entity.Property(e => e.InpInfoF3nna)
                .IsUnicode(false)
                .HasColumnName("InpInfoF3NNA");
            entity.Property(e => e.InpInfoF4nna)
                .IsUnicode(false)
                .HasColumnName("InpInfoF4NNA");
            entity.Property(e => e.NomAcomNna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NomAcomNNA");
            entity.Property(e => e.NomProtecNna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NomProtecNNA");
            entity.Property(e => e.NombreDenunciante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE DENUNCIANTE");
            entity.Property(e => e.NumDocDenun)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM. DOC. DENUN");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REGION");
            entity.Property(e => e.Relato)
                .IsUnicode(false)
                .HasColumnName("RELATO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e._1ApellidoDenunciante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("1° APELLIDO DENUNCIANTE");
            entity.Property(e => e._2ApellidoDenunciante)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("2° APELLIDO DENUNCIANTE");
        });

        modelBuilder.Entity<VistaPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VISTA_PERSONA");

            entity.Property(e => e.EscoCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UperApeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerApeMat");
            entity.Property(e => e.UperApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerApePat");
            entity.Property(e => e.UperConPatMat)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UperFchNac)
                .HasColumnType("datetime")
                .HasColumnName("UPerFchNac");
            entity.Property(e => e.UperId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPerId");
            entity.Property(e => e.UperInvConPatMat)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("UPerInvConPatMat");
            entity.Property(e => e.UperMatBus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerMatBus");
            entity.Property(e => e.UperNacCiuDes)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UPerNacCiuDes");
            entity.Property(e => e.UperNacPaiCod).HasColumnName("UPerNacPaiCod");
            entity.Property(e => e.UperNbrCom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerNbrCom");
            entity.Property(e => e.UperNomBus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerNomBus");
            entity.Property(e => e.UperPatBus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPerPatBus");
            entity.Property(e => e.UperSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UPerSexo");
        });

        modelBuilder.Entity<VistaVif>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_vif");

            entity.Property(e => e.CalleHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CALLE_HECHO");
            entity.Property(e => e.CodComuna)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMUNA");
            entity.Property(e => e.CodComunaDestapol).HasColumnName("COD_COMUNA_DESTAPOL");
            entity.Property(e => e.CodDecreto).HasColumnName("COD_DECRETO");
            entity.Property(e => e.CodDelito).HasColumnName("COD_DELITO");
            entity.Property(e => e.CodDetalleOrganusmo).HasColumnName("COD_DETALLE_ORGANUSMO");
            entity.Property(e => e.CodOrganismo).HasColumnName("COD_ORGANISMO");
            entity.Property(e => e.CodTipoInsOTramite).HasColumnName("COD_TIPO_INS_O_TRAMITE");
            entity.Property(e => e.CodUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_UNIDAD");
            entity.Property(e => e.ComunaHecho)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMUNA_HECHO");
            entity.Property(e => e.Decreto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DECRETO");
            entity.Property(e => e.Delito)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELITO");
            entity.Property(e => e.DescripcionResultado)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_RESULTADO");
            entity.Property(e => e.DetalleLugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_LUGAR_HECHO");
            entity.Property(e => e.DetalleOrganismo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DETALLE_ORGANISMO");
            entity.Property(e => e.DireccionInexacta)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_INEXACTA");
            entity.Property(e => e.Evaluacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVALUACION");
            entity.Property(e => e.FecEval)
                .HasColumnType("datetime")
                .HasColumnName("FEC_EVAL");
            entity.Property(e => e.FecRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_RECEPCION");
            entity.Property(e => e.FechaDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DOCUMENTO");
            entity.Property(e => e.FechaEndoso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENDOSO");
            entity.Property(e => e.FechaHecho1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO1");
            entity.Property(e => e.FechaHecho2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HECHO2");
            entity.Property(e => e.FechaHoraIngSistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HORA_ING_SISTEMA");
            entity.Property(e => e.FechaRealEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REAL_EVALUACION");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.Fiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FISCAL");
            entity.Property(e => e.FolioInternoDecreto)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FOLIO_INTERNO_DECRETO");
            entity.Property(e => e.FolioUnicoNacional)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FOLIO_UNICO_NACIONAL");
            entity.Property(e => e.HoraHecho1).HasColumnName("HORA_HECHO1");
            entity.Property(e => e.HoraHecho2).HasColumnName("HORA_HECHO2");
            entity.Property(e => e.HoraRecepcion).HasColumnName("HORA_RECEPCION");
            entity.Property(e => e.Interoperatividad).HasColumnName("interoperatividad");
            entity.Property(e => e.LatitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATITUD_HECHO");
            entity.Property(e => e.LongitudHecho)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LONGITUD_HECHO");
            entity.Property(e => e.LugarHecho)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUGAR_HECHO");
            entity.Property(e => e.NombreFunACargo)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUN_A_CARGO");
            entity.Property(e => e.NumCausaORuc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NUM_CAUSA_O_RUC");
            entity.Property(e => e.NumDenuncia)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("NUM_DENUNCIA");
            entity.Property(e => e.NumDepto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_DEPTO");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_DOC");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroFoco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("numero_foco");
            entity.Property(e => e.Organismo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.RegionUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("region_unidad");
            entity.Property(e => e.Resultado)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.ResultadoVif)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("RESULTADO VIF");
            entity.Property(e => e.RutEvaluador).HasColumnName("RUT_EVALUADOR");
            entity.Property(e => e.RutFunACargo).HasColumnName("RUT_FUN_A_CARGO");
            entity.Property(e => e.TipoDecreto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TIPO_DECRETO");
            entity.Property(e => e.TipoInsOTramite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIPO_INS_O_TRAMITE");
            entity.Property(e => e.TipoInstruccionParticular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TIPO_INSTRUCCION_PARTICULAR");
            entity.Property(e => e.Unidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.VillaPob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VILLA_POB");
        });

        modelBuilder.Entity<Wscodigorechazobud>(entity =>
        {
            entity.HasKey(e => e.Wsrechazobudid).HasName("PK__WSCODIGO__854ABB96070DC770");

            entity.ToTable("WSCODIGORECHAZOBUD");

            entity.Property(e => e.Wsrechazobudid)
                .ValueGeneratedNever()
                .HasColumnName("WSRECHAZOBUDID");
            entity.Property(e => e.Wsrechazobuddes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WSRECHAZOBUDDES");
            entity.Property(e => e.Wsrechazobudvig).HasColumnName("WSRECHAZOBUDVIG");
        });

        modelBuilder.Entity<Wsinstitucionesbud>(entity =>
        {
            entity.HasKey(e => e.Wsinstitucionesbudid).HasName("PK__WSINSTIT__438F2105033D368C");

            entity.ToTable("WSINSTITUCIONESBUD");

            entity.Property(e => e.Wsinstitucionesbudid)
                .ValueGeneratedNever()
                .HasColumnName("WSINSTITUCIONESBUDID");
            entity.Property(e => e.Wsinstitucionesbuddes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WSINSTITUCIONESBUDDES");
            entity.Property(e => e.Wsinstitucionesbudvig).HasColumnName("WSINSTITUCIONESBUDVIG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
