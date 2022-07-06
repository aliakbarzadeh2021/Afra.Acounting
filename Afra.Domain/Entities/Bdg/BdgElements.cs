using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgElements : BaseEntity
    {
          
 
		public Int32 BdgElmntId { get; set; }  
 
		public String BESLRef { get; set; }  
 
		public Int32 BERole { get; set; }  
 
		public Int32 BEType { get; set; }  
 
		public Nullable<Int32> BEWarPoint { get; set; }  
 
		public Nullable<Int32> BEWarNotOk { get; set; } 
    }
}


