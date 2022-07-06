using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserRefListDet : BaseEntity
    {
          
 
		public Int32 GURLListRef { get; set; }  
 
		public String GURLFieldName { get; set; }  
 
		public String GURLFieldTitle { get; set; }  
 
		public Nullable<Int32> GURLShowOnForm { get; set; }  
 
		public Nullable<Int32> GURLSize { get; set; } 
    }
}


