using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgConts : BaseEntity
    {
          
 
		public Int32 BdgContsId { get; set; }  
 
		public Int32 BCNum { get; set; }  
 
		public DateTime BCDate { get; set; }  
 
		public String BCDescr { get; set; }  
 
		public Double BCAmount { get; set; }  
 
		public Int32 BCPeriodRef { get; set; }  
 
		public Nullable<Int32> BCCurRef { get; set; }  
 
		public String BCMainSLRef { get; set; } 
    }
}


