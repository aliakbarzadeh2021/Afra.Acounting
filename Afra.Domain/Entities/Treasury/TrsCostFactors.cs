using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsCostFactors : BaseEntity
    {
          
 
		public Int32 TrsCostFactorId { get; set; }  
 
		public Int32 TCFCode { get; set; }  
 
		public Nullable<Int32> TCFParent { get; set; }  
 
		public String TCFTitle { get; set; }  
 
		public String TCFSLRef { get; set; }  
 
		public String TCFDLRef { get; set; }  
 
		public String TCFDLFive { get; set; }  
 
		public String TCFDLSix { get; set; } 
    }
}


