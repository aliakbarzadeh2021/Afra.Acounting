using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstAssetDepr : BaseEntity
    {
          
 
		public Int32 AstAssetDeprId { get; set; }  
 
		public Int32 AADAstRef { get; set; }  
 
		public String AADDeprType { get; set; }  
 
		public Int32 AADYear { get; set; }  
 
		public Int32 AADMonth { get; set; }  
 
		public Nullable<Int32> AADAstInfRef { get; set; }  
 
		public Double AADAmount { get; set; }  
 
		public Nullable<Double> AADCstAmount { get; set; }  
 
		public Nullable<Int32> AADAccPrdRef { get; set; }  
 
		public Nullable<Int32> AADDeprVchRef { get; set; } 
    }
}


