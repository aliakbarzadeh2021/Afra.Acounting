using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacManCredit : BaseEntity
    {
          
 
		public Int32 TrsFacManCreditId { get; set; }  
 
		public Int32 TFMCCrspndRef { get; set; }  
 
		public Int32 TFMCType { get; set; }  
 
		public Double TFMCAmount { get; set; }  
 
		public String TFMCDescr { get; set; } 
    }
}


