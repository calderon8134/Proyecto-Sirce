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
    
    public partial class EmpresasSIRCE
    {
        public EmpresasSIRCE()
        {
            this.Cursos = new HashSet<Cursos>();
            this.EmpresaCentrosTrabajoSIRCE = new HashSet<EmpresaCentrosTrabajoSIRCE>();
        }
    
        public int EmpresaSIRCEID { get; set; }
        public int EmpresaID { get; set; }
        public int ConsecutivoLista { get; set; }
    
        public virtual ICollection<Cursos> Cursos { get; set; }
        public virtual ICollection<EmpresaCentrosTrabajoSIRCE> EmpresaCentrosTrabajoSIRCE { get; set; }
    }
}
