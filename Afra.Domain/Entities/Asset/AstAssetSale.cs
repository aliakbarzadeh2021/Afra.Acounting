using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstAssetSale : BaseEntity
    {
          
 
		public Int32 AASAstRef { get; set; }  
 
		public Nullable<Double> AASCost { get; set; }  
 
		public Nullable<Int32> AASAstCstRef { get; set; } 
    }
}


