//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBDDEntity.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public int? edad { get; set; }
        public int idCurso { get; set; }
    
        public virtual Curso Curso { get; set; }
    }
}
