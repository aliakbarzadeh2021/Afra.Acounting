using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstAssetCost : BaseEntity
    {
          
 
		public Int32 AstAssetCstId { get; set; }  
 
		public Nullable<Int32> AstDocCostRef { get; set; }  
 
		public Int32 AACAstRef { get; set; }  
 
		public String AACCstType { get; set; }  
 
		public DateTime AACDate { get; set; }  
 
		public Nullable<Double> AACCost { get; set; }  
 
		public Nullable<Int32> AACAstInfRef { get; set; }  
 
		public String AACSLRef { get; set; }  
 
		public String AACDLRef { get; set; }  
 
		public String AACDLFive { get; set; }  
 
		public String AACDLSix { get; set; } 
    }
}


