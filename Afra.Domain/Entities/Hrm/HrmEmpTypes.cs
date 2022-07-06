using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmEmpTypes : BaseEntity
    {
          
 
		public Int32 EmpTypeId { get; set; }  
 
		public String EmpTypeTitle { get; set; }  
 
		public Nullable<Int32> EmpTypeCode { get; set; } 
    }
}


