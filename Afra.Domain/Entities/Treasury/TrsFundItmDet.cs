using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFundItmDet : BaseEntity
    {
          
 
		public Int32 TrsFundItmDetId { get; set; }  
 
		public Int32 TFIDItemRef { get; set; }  
 
		public Nullable<Double> TFIDTaxAmnt { get; set; }  
 
		public Nullable<Double> TFIDDutyAmnt { get; set; }  
 
		public Nullable<Double> TFIDOthAmnt { get; set; } 
    }
}


