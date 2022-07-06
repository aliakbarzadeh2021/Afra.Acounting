using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsDepositDetDto
    {
          
 
		public Int32 TrsDepositDetId { get; set; }  
 
		public Nullable<Int32> TDDType { get; set; }  
 
		public Nullable<Int32> TDDDeptRef { get; set; }  
 
		public DateTime TDDDate { get; set; }  
 
		public Nullable<Double> TDDAmount { get; set; }  
 
		public String TDDDescr { get; set; } 
    }
}


