//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STPS.SIRCE.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trabajadores
    {
        public Trabajadores()
        {
            this.Constancias = new HashSet<Constancias>();
            this.NormaTrabajador = new HashSet<NormaTrabajador>();
        }
    
        public int TrabajadorID { get; set; }
        public string CURP { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int OcupacionID { get; set; }
        public int EntidadFederativaID { get; set; }
        public int MunicipioID { get; set; }
        public Nullable<int> EscolaridadID { get; set; }
        public Nullable<int> InstitucionesEducativasID { get; set; }
        public Nullable<int> ComprobanteEstudioID { get; set; }
        public int CentroTrabajoSIRCEID { get; set; }
        public byte Genero { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public bool Eliminado { get; set; }
        public bool VerificaCURP { get; set; }

        public virtual CentrosTrabajoSIRCE CentrosTrabajoSIRCE { get; set; }
        public virtual ICollection<Constancias> Constancias { get; set; }
        public virtual DocumentosProbatorios DocumentosProbatorios { get; set; }
        public virtual Escolaridades Escolaridades { get; set; }
        public virtual ICollection<NormaTrabajador> NormaTrabajador { get; set; }
        public virtual Ocupaciones Ocupaciones { get; set; }
    }
}
