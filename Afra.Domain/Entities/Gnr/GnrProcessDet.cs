using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrProcessDet : BaseEntity
    {
          
 
		public Int32 GnrProcessDetId { get; set; }  
 
		public Int32 GPDProccessRef { get; set; }  
 
		public String GPDTitle { get; set; }  
 
		public Int32 GPDStep { get; set; }  
 
		public Int32 GPDType { get; set; }  
 
		public Int32 GPDRefId { get; set; }  
 
		public String GPDRefData { get; set; }  
 
		public Nullable<Int32> GPDDecField { get; set; }  
 
		public Nullable<Int32> GPDRelStep { get; set; } 
    }
}


