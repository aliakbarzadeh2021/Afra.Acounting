using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoSysLttr : BaseEntity
    {
          
 
		public Int32 OtoSysLtrId { get; set; }  
 
		public Int32 OSLUserRef { get; set; }  
 
		public DateTime OSLCreateDate { get; set; }  
 
		public Int32 OSLType { get; set; }  
 
		public Nullable<Int32> OSLRefId { get; set; }  
 
		public Byte[] OSLFileObj { get; set; }  
 
		public String OSLSignInf { get; set; }  
 
		public String OSLOthInf { get; set; } 
    }
}


