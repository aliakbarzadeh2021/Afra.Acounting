using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstAccRelInf : BaseEntity
    {
          
 
		public Int32 CARPeriodId { get; set; }  
 
		public String CARType { get; set; }  
 
		public String CARSLCode { get; set; }  
 
		public Nullable<Int32> CARDL4Type { get; set; }  
 
		public String CARDL4Code { get; set; }  
 
		public Nullable<Int32> CARDL5Type { get; set; }  
 
		public String CARDL5Code { get; set; }  
 
		public Nullable<Int32> CARDL6Type { get; set; }  
 
		public String CARDL6Code { get; set; } 
    }
}


