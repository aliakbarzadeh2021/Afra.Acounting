using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContRatio : BaseEntity
    {
          
 
		public Int32 CntContRatioId { get; set; }  
 
		public Int32 CCRContRef { get; set; }  
 
		public DateTime CCRDate { get; set; }  
 
		public Double CCRRatio { get; set; } 
    }
}


