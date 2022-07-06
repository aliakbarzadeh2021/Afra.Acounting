using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrFormSetting : BaseEntity
    {
          
 
		public String GFSFormRef { get; set; }  
 
		public Int32 GFSType { get; set; }  
 
		public String GFSValue { get; set; } 
    }
}


