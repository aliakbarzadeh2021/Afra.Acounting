using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleSrvGroups : BaseEntity
    {
          
 
		public Int32 SleSrvGroupsId { get; set; }  
 
		public Nullable<Int32> SSGParent { get; set; }  
 
		public String SSGCode { get; set; }  
 
		public String SSGTitle { get; set; }  
 
		public String SSGDLRef { get; set; }  
 
		public Nullable<Int32> SSGMainRoot { get; set; } 
    }
}


