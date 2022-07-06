using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsFundItmDetDto
    {
          
 
		public Int32 TrsFundItmDetId { get; set; }  
 
		public Int32 TFIDItemRef { get; set; }  
 
		public Nullable<Double> TFIDTaxAmnt { get; set; }  
 
		public Nullable<Double> TFIDDutyAmnt { get; set; }  
 
		public Nullable<Double> TFIDOthAmnt { get; set; } 
    }
}


