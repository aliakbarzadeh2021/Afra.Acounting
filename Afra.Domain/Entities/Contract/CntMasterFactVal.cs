using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntMasterFactVal : BaseEntity
    {
          
 
		public Int32 CntMastFactValsId { get; set; }  
 
		public Int32 CMFVFldRef { get; set; }  
 
		public Int32 CMFVFactRef { get; set; }  
 
		public Nullable<Double> CMFVAmount { get; set; }  
 
		public Nullable<Int32> CMFVFormulRef { get; set; }  
 
		public Nullable<Double> CMFVCurVal { get; set; } 
    }
}


