using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleCstmrGroups : BaseEntity
    {
          
 
		public Int32 SleCstmrGroupId { get; set; }  
 
		public Nullable<Int32> SCGParent { get; set; }  
 
		public String SCGTitle { get; set; }  
 
		public String SCGDLRef { get; set; }  
 
		public Nullable<Int32> SCGMainRoot { get; set; } 
    }
}


