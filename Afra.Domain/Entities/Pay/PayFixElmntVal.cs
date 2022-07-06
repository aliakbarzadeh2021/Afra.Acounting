using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayFixElmntVal : BaseEntity
    {
          
 
		public Int32 PayFixElmntValId { get; set; }  
 
		public Int32 PFEVElmntRef { get; set; }  
 
		public Int32 PFEVYear { get; set; }  
 
		public Int32 PFEVMonth { get; set; }  
 
		public Double PFEVAmount { get; set; }  
 
		public Nullable<Int32> PFEVYearMonth { get; set; } 
    }
}


