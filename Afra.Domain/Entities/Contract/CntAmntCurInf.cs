using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntAmntCurInf : BaseEntity
    {
          
 
		public Int32 CntAmntCurInfId { get; set; }  
 
		public Int32 CACIBaseType { get; set; }  
 
		public Int32 CACIBaseRef { get; set; }  
 
		public Int32 CACICurRef { get; set; }  
 
		public Double CACIAmount { get; set; } 
    }
}


