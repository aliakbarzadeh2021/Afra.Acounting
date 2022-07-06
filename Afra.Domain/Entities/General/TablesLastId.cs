using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TablesLastId : BaseEntity
    {
          
 
		public String tblName { get; set; }  
 
		public Nullable<Int32> LastId { get; set; } 
    }
}


