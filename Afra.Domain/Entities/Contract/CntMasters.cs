using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntMasters : BaseEntity
    {
          
 
		public Int32 CntMasterId { get; set; }  
 
		public Int32 CMCrsRef { get; set; }  
 
		public String CMSLRef { get; set; } 
    }
}


