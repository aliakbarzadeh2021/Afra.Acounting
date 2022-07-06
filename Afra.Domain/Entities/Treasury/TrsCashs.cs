using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsCashs : BaseEntity
    {
          
 
		public Int32 TrsCashId { get; set; }  
 
		public String TCName { get; set; }  
 
		public Int32 TCCashier { get; set; }  
 
		public Double TCFirstQty { get; set; }  
 
		public String TCDLRef { get; set; } 
    }
}


