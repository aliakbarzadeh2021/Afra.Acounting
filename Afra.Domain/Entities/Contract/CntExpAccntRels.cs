using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExpAccntRels : BaseEntity
    {
          
 
		public Int32 CExRMastExpAcnRef { get; set; }  
 
		public Int32 CExRDetExpAcnRef { get; set; } 
    }
}


