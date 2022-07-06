using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgCostAllocDetDto
    {
          
 
		public Int32 BCADHdrRef { get; set; }  
 
		public Int32 BCADCostCntrRef { get; set; }  
 
		public Nullable<Double> BCADAllocQty { get; set; } 
    }
}


