using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysFormObjects : BaseEntity
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


