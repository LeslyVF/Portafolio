//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portafolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experiencia
    {
        public string id { get; set; }
        public string UsuarioID { get; set; }
        public string Tipo_ID { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string Descripcion { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Tipo Tipo { get; set; }
    }
}
