using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacTypeInf : BaseEntity
    {
          
 
		public Int32 TrsFacTypeInfId { get; set; }  
 
		public Int32 TFTIFacRef { get; set; }  
 
		public DateTime TFTIDate { get; set; }  
 
		public Double TFTIRate { get; set; }  
 
		public Int32 TFTIDur { get; set; } 
    }
}


