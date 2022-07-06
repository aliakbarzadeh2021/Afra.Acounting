using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsSourceUse : BaseEntity
    {
          
 
		public Int32 TrsSourceUseID { get; set; }  
 
		public Nullable<Int32> TSUCode { get; set; }  
 
		public String TSUTitle { get; set; }  
 
		public String TSUSLRef { get; set; }  
 
		public String TSUDLRef { get; set; }  
 
		public String TSUDLFive { get; set; }  
 
		public String TSUDLSix { get; set; }  
 
		public Nullable<Int32> TSUType { get; set; } 
    }
}


