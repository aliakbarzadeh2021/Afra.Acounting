using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsBankReconcileDto
    {
          
 
		public Int32 TrsBankReconcileId { get; set; }  
 
		public Int32 TBRBankBillRef { get; set; }  
 
		public String TBRNum { get; set; }  
 
		public DateTime TBRDate { get; set; } 
    }
}


