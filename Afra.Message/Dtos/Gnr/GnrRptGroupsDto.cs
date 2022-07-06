using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrRptGroupsDto
    {
          
 
		public Int32 RptGroupId { get; set; }  
 
		public String RptGroupTitle { get; set; }  
 
		public String RptSysRef { get; set; }  
 
		public Nullable<Int32> RGParentRef { get; set; } 
    }
}


