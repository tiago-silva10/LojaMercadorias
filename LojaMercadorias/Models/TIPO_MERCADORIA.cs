//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaMercadorias.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_MERCADORIA
    {
        public TIPO_MERCADORIA()
        {
            this.MERCADORIA = new HashSet<MERCADORIA>();
        }
    
        public int TipoID { get; set; }
        public string NOME { get; set; }
    
        public virtual ICollection<MERCADORIA> MERCADORIA { get; set; }
    }
}
