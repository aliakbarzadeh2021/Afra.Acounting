using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CurExChange : BaseEntity
    {
          
 
		public Int32 CurExchangeId { get; set; }  
 
		public Int32 CExMainCurRef { get; set; }  
 
		public Int32 CExRelCurRef { get; set; }  
 
		public DateTime CExDate { get; set; }  
 
		public Double CExRate { get; set; } 
    }
}


