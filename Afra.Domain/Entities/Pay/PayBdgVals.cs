using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayBdgVals : BaseEntity
    {
          
 
		public Int32 PayBdgValId { get; set; }  
 
		public Int32 PBVPersRef { get; set; }  
 
		public Int32 PBVElmntRef { get; set; }  
 
		public Int32 PBVIssueYear { get; set; }  
 
		public Int32 PBVIssueMonth { get; set; }  
 
		public Int32 PBVEffectYear { get; set; }  
 
		public Int32 PBVEffectMonth { get; set; }  
 
		public Nullable<Double> PBVAmount { get; set; }  
 
		public Nullable<Int32> PBVIYearMonth { get; set; }  
 
		public Nullable<Int32> PBVEYearMonth { get; set; } 
    }
}


