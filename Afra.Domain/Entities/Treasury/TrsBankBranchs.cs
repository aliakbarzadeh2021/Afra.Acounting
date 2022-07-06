using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsBankBranchs : BaseEntity
    {
          
 
		public Int32 BankBranchId { get; set; }  
 
		public String BankBranchName { get; set; }  
 
		public String BankBranchCode { get; set; }  
 
		public Int32 BBBankRef { get; set; }  
 
		public String BankBranchType { get; set; } 
    }
}


