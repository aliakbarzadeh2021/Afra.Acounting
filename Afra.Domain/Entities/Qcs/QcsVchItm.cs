using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class QcsVchItm : BaseEntity
    {
          
 
		public Int32 QcsVchItmId { get; set; }  
 
		public Int32 QcsVchHdrRef { get; set; }  
 
		public Int32 QVITestItmRef { get; set; }  
 
		public String QVIRes { get; set; }  
 
		public String QVIResDescr { get; set; }  
 
		public Nullable<Int32> QVIOK { get; set; } 
    }
}


