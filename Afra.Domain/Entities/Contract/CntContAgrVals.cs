using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContAgrVals : BaseEntity
    {
          
 
		public Int32 CntContAgValId { get; set; }  
 
		public Int32 CCAVFldRef { get; set; }  
 
		public Int32 CCAVBaseItm { get; set; }  
 
		public Nullable<Double> CCAVAmount { get; set; } 
    }
}


