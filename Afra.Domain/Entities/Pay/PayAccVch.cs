using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayAccVch : BaseEntity
    {
          
 
		public Int32 PayAccVchId { get; set; }  
 
		public Nullable<Int32> PAVTypeRef { get; set; }  
 
		public Nullable<Int32> PAVYear { get; set; }  
 
		public Nullable<Int32> PAVMonth { get; set; }  
 
		public Nullable<Int32> PAVPrdRef { get; set; } 
    }
}


