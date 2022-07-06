using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleCtgryAcc : BaseEntity
    {
          
 
		public Int32 SCACtgryRef { get; set; }  
 
		public Int32 SCAVchType { get; set; }  
 
		public String SCASLRef { get; set; }  
 
		public Nullable<Int32> SCADL4Type { get; set; }  
 
		public Nullable<Int32> SCADL5Type { get; set; }  
 
		public Nullable<Int32> SCADL6Type { get; set; } 
    }
}


