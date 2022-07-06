using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartGroups : BaseEntity
    {
          
 
		public Int32 InvPartGroupsId { get; set; }  
 
		public Nullable<Int32> IPGParent { get; set; }  
 
		public String IPGCode { get; set; }  
 
		public String IPGTitle { get; set; }  
 
		public String IPGDLRef { get; set; }  
 
		public Nullable<Int32> IPGMainRoot { get; set; } 
    }
}


