using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class QcsTests : BaseEntity
    {
          
 
		public Int32 QcsTestsId { get; set; }  
 
		public Int32 QTPartRef { get; set; }  
 
		public String QTStepName { get; set; }  
 
		public String QTName { get; set; }  
 
		public Int32 QTLabRef { get; set; }  
 
		public Int32 QTRepeat { get; set; } 
    }
}


