using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PartFormulaDet : BaseEntity
    {
          
 
		public Int32 PartFrmlDetId { get; set; }  
 
		public Int32 PFDHdrRef { get; set; }  
 
		public Int32 PFDPartRef { get; set; }  
 
		public Nullable<Double> PFDQtyRatio { get; set; }  
 
		public Nullable<Double> PFDWast { get; set; } 
    }
}


