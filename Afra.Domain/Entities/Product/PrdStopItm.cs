using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdStopItm : BaseEntity
    {
          
 
		public Int32 PrdStopItmId { get; set; }  
 
		public Int32 PrdStopRef { get; set; }  
 
		public Int32 PSISeq { get; set; }  
 
		public Int32 PSIWStation { get; set; }  
 
		public Int32 PSIMashRef { get; set; }  
 
		public DateTime PSIFTime { get; set; }  
 
		public DateTime PSITTime { get; set; }  
 
		public String PSIDescr { get; set; } 
    }
}


