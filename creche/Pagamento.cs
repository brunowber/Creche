//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace creche
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagamento
    {
        public long Uid_pagamento { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Valor_recebido { get; set; }
        public Nullable<System.DateTime> Dt_vencimento { get; set; }
        public Nullable<long> Uid_crianca { get; set; }
    
        public virtual Crianca Crianca { get; set; }
    }
}
