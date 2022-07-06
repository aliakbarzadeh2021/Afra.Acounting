using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsVchItmRel : BaseEntity
    {
          
 
		public Int32 TrsVchItmRef { get; set; }  
 
		public String TVIRSysRef { get; set; }  
 
		public Int32 TVIRVchRef { get; set; }  
 
		public Nullable<Double> TVIRQty { get; set; }  
 
		public String TVIRDescr { get; set; } 
    }
}


