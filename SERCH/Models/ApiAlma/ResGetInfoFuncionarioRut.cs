namespace SERCH.Models.ApiAlma
{
    public class ResGetInfoFuncionarioRut
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public List<GetInfoFuncionarioRut> Result { get; set; }
    }

    public class GetInfoFuncionarioRut
    {

        public int Id_Funcionario { get; set; }
        public string Nombre { get; set; }
        public int Rut_Fun { get; set; }
        public int Id_Unidad { get; set; }
        public string Usuario_Fun { get; set; }
        public string Nombre_Uni { get; set; }
        public int Antiguedad { get; set; }
        public int Id_Perfil_Fun { get; set; }
        public string Descripcion_Perfil { get; set; }
        public string Nombre_Cargo { get; set; }
        public int Pertenece_Uni { get; set; }
        public int Reporta_Uni { get; set; }
        public string Nombre_Fun { get; set; }
        public string Paterno_Fun { get; set; }
        public string Materno_Fun { get; set; }
        public int Id_Cargo_Fun { get; set; }
        public int Tipo_Cargo { get; set; }
        public string Iniciales_Fun { get; set; }
        public string Sigla_Cargo { get; set; }
        public int Grado_Fun { get; set; }
        public DateTime Fingreso_Fun { get; set; }
        public string FIngresoInstitucional { get; set; }

        public DateTime Fnacimiento_Fun { get; set; }
        public DateTime Fecha_Region { get; set; }
        public DateTime Fecha_Unidad { get; set; }
        public string Sexo_Fun { get; set; }
        public string Email_Fun { get; set; }
        public string Fono_Fun { get; set; }
        public string Especializacion_Fun { get; set; }
        public string Titulo_Prof { get; set; }
        public string Org_Extrainstitucional { get; set; }
        public string Ciudad_Nacimiento { get; set; }
        public string Region_Uni { get; set; }
        public string Provincia_Uni { get; set; }
        public string Comuna_Uni { get; set; }
        public string Region_Uni_Id { get; set; }
        public string Provincia_Uni_Id { get; set; }
        public string Comuna_Uni_Id { get; set; }
        public int Activo_Fun { get; set; }
        public string Pertenece_Nombre { get; set; }
        public string Reporta_Nombre { get; set; }
        public int Planta_Fun { get; set; }
        public string Bco_Num_Cuenta { get; set; }
        public string Bco_Nombre { get; set; }
        public string Bco_Tipo_Cuenta { get; set; }
        public string Bco_Modo_Pago { get; set; }
        public int Id_Tipo_Unidad { get; set; }
        public int Dif_Horaria { get; set; }
        public int Ibm_Funcionario { get; set; }
        public int Ibm_Profesor { get; set; }
        public string Direccion { get; set; }
        public int Estado_Laboral { get; set; }
        public string Direccion_Comuna { get; set; }
        public string Ctrl_Asistencia { get; set; }
        public int Tipo_Jornada { get; set; }
        public int Unidad_Operativa { get; set; }
        public int Id_Uni_Subrogante { get; set; }
        public string Nombre_Uni_Subrogante { get; set; }
    }
}

