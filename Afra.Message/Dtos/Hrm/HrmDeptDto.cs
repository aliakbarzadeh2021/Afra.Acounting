using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmDeptDto
    {
          
 
		public Int32 HrmDeptID { get; set; }  
 
		public Nullable<Int32> HDParentRef { get; set; }  
 
		public String HrmDeptTitle { get; set; }  
 
		public String HrmDeptCode { get; set; }  
 
		public Nullable<Int32> HrmDeptBaseRef { get; set; }  
 
		public Nullable<Int32> HrmDeptCount { get; set; } 
    }
}


