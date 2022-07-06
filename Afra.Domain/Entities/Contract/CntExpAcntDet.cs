using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExpAcntDet : BaseEntity
    {
          
 
		public Int32 CntExpAcntDetId { get; set; }  
 
		public Int32 CEADItemRef { get; set; }  
 
		public Int32 CEADExpAcntRef { get; set; }  
 
		public Double CEADQty { get; set; }  
 
		public Nullable<Int32> CEADDur { get; set; } 
    }
}


