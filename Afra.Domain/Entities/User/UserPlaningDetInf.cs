using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserPlaningDetInf : BaseEntity
    {
          
 
		public Int32 UPDIItmRef { get; set; }  
 
		public DateTime UPDIDate { get; set; }  
 
		public String UPDIDescr { get; set; } 
    }
}


