using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgCurExchange : BaseEntity
    {
          
 
		public Int32 BdgCurExchangeId { get; set; }  
 
		public DateTime BCEDate { get; set; }  
 
		public Int32 BCECurRef { get; set; }  
 
		public Double BCERate { get; set; }  
 
		public Int32 BCEPeriodRef { get; set; } 
    }
}


