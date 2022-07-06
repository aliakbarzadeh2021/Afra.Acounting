using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayLoanPayment : BaseEntity
    {
          
 
		public Int32 PayLoanPaymentId { get; set; }  
 
		public Nullable<Int32> PLPLoanRef { get; set; }  
 
		public Nullable<Int32> PLPYearNum { get; set; }  
 
		public Nullable<Int32> PLPMonthNum { get; set; }  
 
		public Nullable<Double> PLPAmount { get; set; }  
 
		public Nullable<Int32> PLPYearMonth { get; set; }  
 
		public Nullable<Int32> PLPType { get; set; }  
 
		public String PLPDescr { get; set; } 
    }
}


