using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class sysdiagrams : BaseEntity
    {
          
 
		public String name { get; set; }  
 
		public Int32 principal_id { get; set; }  
 
		public Int32 diagram_id { get; set; }  
 
		public Nullable<Int32> version { get; set; }  
 
		public Byte[] definition { get; set; } 
    }
}


