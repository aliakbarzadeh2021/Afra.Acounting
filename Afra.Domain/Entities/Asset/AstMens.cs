using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstMens : BaseEntity
    {
          
 
		public Int32 AstMenId { get; set; }  
 
		public Int32 AMCrsRef { get; set; }  
 
		public DateTime AMIDate { get; set; } 
    }
}


