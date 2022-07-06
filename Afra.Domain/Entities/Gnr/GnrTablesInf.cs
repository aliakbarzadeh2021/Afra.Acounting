using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrTablesInf : BaseEntity
    {
          
 
		public Int32 GnrTabesInfId { get; set; }  
 
		public String TableName { get; set; }  
 
		public String Title { get; set; } 
    }
}


