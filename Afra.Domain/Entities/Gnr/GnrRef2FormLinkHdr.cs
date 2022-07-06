using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrRef2FormLinkHdr : BaseEntity
    {
          
 
		public Int32 LinkRefHdrId { get; set; }  
 
		public String LRHTitle { get; set; }  
 
		public Int32 LRHSysFormRef { get; set; }  
 
		public Int32 LRHRefFormRef { get; set; }  
 
		public Nullable<Int32> LRHVchType { get; set; }  
 
		public String LRHRefQryCond { get; set; } 
    }
}


