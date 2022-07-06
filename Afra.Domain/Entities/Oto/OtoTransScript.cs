using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoTransScript : BaseEntity
    {
          
 
		public Int32 OtoTransScriptId { get; set; }  
 
		public Nullable<Int32> OTSUserRef { get; set; }  
 
		public Nullable<Int32> OTSOrder { get; set; }  
 
		public String OTSDescr { get; set; } 
    }
}


