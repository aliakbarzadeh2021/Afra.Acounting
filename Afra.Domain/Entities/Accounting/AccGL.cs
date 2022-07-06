using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccGL : BaseEntity
    {
          
 
		public String gl_Code { get; set; }  
 
		public String PlRef { get; set; }  
 
		public String gl_Title { get; set; }  
 
		public String gl_BalanceType { get; set; } 
    }
}


