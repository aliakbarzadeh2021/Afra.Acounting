using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartCtgryAcc : BaseEntity
    {
          
 
		public Int32 InvPartCtgryAccId { get; set; }  
 
		public Nullable<Int32> IPCACtgryRef { get; set; }  
 
		public String IPCAType { get; set; }  
 
		public String IPCASLRef { get; set; } 
    }
}


