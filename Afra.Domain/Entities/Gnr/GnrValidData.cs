using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrValidData : BaseEntity
    {
          
 
		public Int32 GnrValidDataId { get; set; }  
 
		public Int32 GVDUserRef { get; set; }  
 
		public String GVDSysRef { get; set; }  
 
		public Int32 GVDConfirmer { get; set; } 
    }
}


