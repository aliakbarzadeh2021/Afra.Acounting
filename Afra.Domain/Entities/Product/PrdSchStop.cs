using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdSchStop : BaseEntity
    {
          
 
		public Int32 PrdSchStopId { get; set; }  
 
		public DateTime PSSFDate { get; set; }  
 
		public DateTime PSSTDate { get; set; }  
 
		public String PSSDescr { get; set; }  
 
		public Int32 PSSYear { get; set; } 
    }
}


