using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserFormDesign : BaseEntity
    {
          
 
		public Int32 GUFDFormRef { get; set; }  
 
		public Int32 GUFDFieldRef { get; set; }  
 
		public Int32 GUFDPropRef { get; set; }  
 
		public Nullable<Int32> GUFDValue { get; set; }  
 
		public String GUFDFieldParent { get; set; } 
    }
}


