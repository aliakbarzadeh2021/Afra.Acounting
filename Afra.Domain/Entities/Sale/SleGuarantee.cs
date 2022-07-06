using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleGuarantee : BaseEntity
    {
          
 
		public Int32 SleGuaranteeId { get; set; }  
 
		public String SGTitle { get; set; }  
 
		public String SGSLRef { get; set; }  
 
		public Nullable<Int32> SGDL4Type { get; set; }  
 
		public Nullable<Int32> SGDL5Type { get; set; }  
 
		public Nullable<Int32> SGDL6Type { get; set; } 
    }
}


