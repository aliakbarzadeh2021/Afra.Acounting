using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsBankBill : BaseEntity
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


