using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstAssetRate : BaseEntity
    {
          
 
		public Int32 AstAssetRateId { get; set; }  
 
		public Int32 AARAstRef { get; set; }  
 
		public String AARType { get; set; }  
 
		public String AARDepType { get; set; }  
 
		public DateTime AARDate { get; set; }  
 
		public Nullable<Double> AARRatio { get; set; }  
 
		public Nullable<Int32> AstDocRatioRef { get; set; } 
    }
}


