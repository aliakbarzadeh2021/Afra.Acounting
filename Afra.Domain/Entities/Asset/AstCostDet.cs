using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstCostDet : BaseEntity
    {
          
 
		public Int32 AstCostDetID { get; set; }  
 
		public Int32 ACDType { get; set; }  
 
		public Int32 ACDItmRef { get; set; }  
 
		public Nullable<Double> ACDInstall { get; set; }  
 
		public Nullable<Double> ACDOther { get; set; }  
 
		public Nullable<Double> ACDTax { get; set; }  
 
		public Nullable<Double> ACDDuty { get; set; } 
    }
}


