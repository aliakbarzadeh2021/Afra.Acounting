using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntFormVals : BaseEntity
    {
          
 
		public Int32 CntFormValsId { get; set; }  
 
		public Int32 CFVType { get; set; }  
 
		public Int32 CFVBaseId { get; set; }  
 
		public Int32 CFVFieldRef { get; set; }  
 
		public Nullable<Double> CFVAmount { get; set; } 
    }
}


