using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExpAcntFlds : BaseEntity
    {
          
 
		public Int32 CntExpAcnFldId { get; set; }  
 
		public String CEAFTitle { get; set; }  
 
		public Int32 CEAType { get; set; }  
 
		public Nullable<Int32> CEAPrvty { get; set; } 
    }
}


