using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CostCenters : BaseEntity
    {
          
 
		public Int32 CostCenterID { get; set; }  
 
		public String CstCode { get; set; }  
 
		public String CstName { get; set; }  
 
		public String CstDLRef { get; set; }  
 
		public Nullable<Int32> CstType { get; set; } 
    }
}


