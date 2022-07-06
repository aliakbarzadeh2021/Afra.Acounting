using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleCstmrLimit : BaseEntity
    {
          
 
		public Int32 SleCstmrLimitId { get; set; }  
 
		public Int32 SCLCstmrRef { get; set; }  
 
		public DateTime SCLDate { get; set; }  
 
		public Nullable<Double> SCLAmount { get; set; } 
    }
}


