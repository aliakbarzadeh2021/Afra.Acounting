using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmBaseAmounts : BaseEntity
    {
          
 
		public Int32 HrmBaseAmountsId { get; set; }  
 
		public String HBAType { get; set; }  
 
		public Int32 HBABaseId { get; set; }  
 
		public DateTime HBADate { get; set; }  
 
		public Double HBAQty { get; set; } 
    }
}


