using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TaxDutyInf : BaseEntity
    {
          
 
		public Int32 TaxDutyId { get; set; }  
 
		public DateTime TDDate { get; set; }  
 
		public Nullable<Double> TDTaxPrc { get; set; }  
 
		public Nullable<Double> TDDutyPrc { get; set; }  
 
		public String TDRcvTaxSLRef { get; set; }  
 
		public String TDRcvDutySLRef { get; set; }  
 
		public String TDRcvTaxDLRef { get; set; }  
 
		public String TDRcvDutyDLRef { get; set; }  
 
		public String TDPayTaxSLRef { get; set; }  
 
		public String TDPayDutySLRef { get; set; }  
 
		public String TDPayTaxDLRef { get; set; }  
 
		public String TDPayDutyDLRef { get; set; } 
    }
}


