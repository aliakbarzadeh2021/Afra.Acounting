using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContAmntChng : BaseEntity
    {
          
 
		public Int32 CntContAmntChngId { get; set; }  
 
		public Int32 CCACContRef { get; set; }  
 
		public Int32 CCACType { get; set; }  
 
		public DateTime CCACDate { get; set; }  
 
		public String CCACDescr { get; set; }  
 
		public Double CCACVal { get; set; } 
    }
}


