//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereço
    {
        public int Id { get; set; }
        public string NomeRua { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
