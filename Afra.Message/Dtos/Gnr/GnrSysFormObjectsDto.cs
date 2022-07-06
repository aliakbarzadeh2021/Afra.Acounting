using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrSysFormObjectsDto
    {
          
 
		public Int32 SysFormObjId { get; set; }  
 
		public Int32 SysFormRef { get; set; }  
 
		public String SFOName { get; set; }  
 
		public String SFOTitle { get; set; }  
 
		public String SFType { get; set; }  
 
		public Nullable<Boolean> SFIsMainField { get; set; }  
 
		public String SFOFldName { get; set; } 
    }
}


