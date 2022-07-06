using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrRef2FormLinksItm : BaseEntity
    {
          
 
		public Int32 LinkRefHdrRef { get; set; }  
 
		public Int32 LRSysFormObjRef { get; set; }  
 
		public String LRFieldName { get; set; }  
 
		public Nullable<Int32> LRForceBaseVal { get; set; } 
    }
}


