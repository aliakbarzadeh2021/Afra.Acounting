using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysMsgDet : BaseEntity
    {
          
 
		public Int32 GSMDHdrRef { get; set; }  
 
		public Int32 GSMDUserRef { get; set; }  
 
		public Nullable<Int32> GSMDSit { get; set; } 
    }
}


