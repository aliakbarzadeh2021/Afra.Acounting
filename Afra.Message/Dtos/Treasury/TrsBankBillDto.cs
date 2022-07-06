using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsBankBillDto
    {
          
 
		public Int32 TrsBankBillId { get; set; }  
 
		public String TBBNum { get; set; }  
 
		public DateTime TBBDate { get; set; }  
 
		public Int32 TBBBankAccRef { get; set; }  
 
		public String TBBDescr { get; set; }  
 
		public Nullable<Int32> TBBState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> TBBCreator { get; set; }  
 
		public Nullable<Int32> TBBSit { get; set; } 
    }
}


