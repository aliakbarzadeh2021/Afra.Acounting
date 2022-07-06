using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsDeposit : BaseEntity
    {
          
 
		public Int32 TrsDepositId { get; set; }  
 
		public Int32 TDType { get; set; }  
 
		public Int32 TDNum { get; set; }  
 
		public DateTime TDDate { get; set; }  
 
		public Int32 TDSrcUseRef { get; set; }  
 
		public String TDDLRef { get; set; }  
 
		public String TDDescr { get; set; }  
 
		public Double TDAmount { get; set; }  
 
		public Double TDInstRate { get; set; }  
 
		public DateTime TDInstDate { get; set; }  
 
		public Int32 TDPayDur { get; set; }  
 
		public Int32 TDAccPrdRef { get; set; }  
 
		public Nullable<Int32> TDState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 
    }
}


