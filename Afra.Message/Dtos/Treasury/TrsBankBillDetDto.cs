using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsBankBillDetDto
    {
          
 
		public Int32 TrsBankBillDetId { get; set; }  
 
		public Int32 TrsBankBillRef { get; set; }  
 
		public Int32 TBBDSeq { get; set; }  
 
		public String TBBDItemNo { get; set; }  
 
		public DateTime TBBDItmDate { get; set; }  
 
		public Double TBBDDebit { get; set; }  
 
		public Double TBBDCredit { get; set; }  
 
		public String TBBDDescr { get; set; } 
    }
}


