using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdFixStop : BaseEntity
    {
          
 
		public Int32 PrdFixStopId { get; set; }  
 
		public DateTime PFSFTime { get; set; }  
 
		public DateTime PFSTTime { get; set; }  
 
		public String PFSDescr { get; set; } 
    }
}


