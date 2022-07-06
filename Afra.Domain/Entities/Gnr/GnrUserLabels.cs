using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserLabels : BaseEntity
    {
          
 
		public Int32 GnrUserLabelId { get; set; }  
 
		public Int32 GULUserRef { get; set; }  
 
		public String GULTitle { get; set; }  
 
		public Nullable<Int32> GULParent { get; set; } 
    }
}


