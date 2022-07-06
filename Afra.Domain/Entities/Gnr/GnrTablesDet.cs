using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrTablesDet : BaseEntity
    {
          
 
		public Int32 TableRef { get; set; }  
 
		public String ColName { get; set; }  
 
		public String ColTitle { get; set; } 
    }
}


