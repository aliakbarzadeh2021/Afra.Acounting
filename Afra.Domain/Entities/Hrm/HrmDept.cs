using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmDept : BaseEntity
    {
          
 
		public Int32 HrmDeptID { get; set; }  
 
		public Nullable<Int32> HDParentRef { get; set; }  
 
		public String HrmDeptTitle { get; set; }  
 
		public String HrmDeptCode { get; set; }  
 
		public Nullable<Int32> HrmDeptBaseRef { get; set; }  
 
		public Nullable<Int32> HrmDeptCount { get; set; } 
    }
}


