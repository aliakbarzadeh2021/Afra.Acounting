using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsBankReconcileDet : BaseEntity
    {
          
 
		public Int32 TrsBankReconcileDetId { get; set; }  
 
		public Int32 TrsBankReconcileRef { get; set; }  
 
		public Int32 TBRDItmType { get; set; }  
 
		public Nullable<Int32> TBRDItmKind { get; set; }  
 
		public Int32 TBRDItmRef { get; set; }  
 
		public DateTime TBRDItmDate { get; set; }  
 
		public String TBRDItmNo { get; set; }  
 
		public Double TBRDDebit { get; set; }  
 
		public Double TBRDCredit { get; set; }  
 
		public String TBRDDescr { get; set; }  
 
		public Nullable<Int32> TBRDRelId { get; set; } 
    }
}


