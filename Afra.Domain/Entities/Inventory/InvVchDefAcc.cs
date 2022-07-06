using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvVchDefAcc : BaseEntity
    {
          
 
		public Int32 InvVchDefAccId { get; set; }  
 
		public Int32 IVDAAccPrd { get; set; }  
 
		public Int32 IVDAVchType { get; set; }  
 
		public Nullable<Int32> IVDAPartRef { get; set; }  
 
		public String IVDADLRef { get; set; }  
 
		public String IVDASLRef { get; set; } 
    }
}


