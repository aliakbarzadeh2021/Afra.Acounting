using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsBankAccountsDto
    {
          
 
		public Int32 BankAccountId { get; set; }  
 
		public String BankAccountNo { get; set; }  
 
		public Int32 BABrnchRef { get; set; }  
 
		public String BankAccountType { get; set; }  
 
		public Nullable<Double> BAFirstQty { get; set; }  
 
		public DateTime BAOpenDate { get; set; }  
 
		public String BADLRef { get; set; }  
 
		public DateTime BAReconDate { get; set; }  
 
		public Nullable<Double> BAReconRem { get; set; }  
 
		public Nullable<Int32> BARemWithInst { get; set; } 
    }
}


